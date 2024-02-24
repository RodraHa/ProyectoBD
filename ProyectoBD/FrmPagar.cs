using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class FrmPagar : Form
    {
        private int id_cliente;
        private NpgsqlConnection connection;

        public FrmPagar(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            connection = new NpgsqlConnection(Login.connectionString);
            OpenConnection();
            getPagosPendientes();
            lstPagos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void getPagosPendientes()
        {
            try
            {
                String commString = $"SELECT title, address, return_date, rental_id, R.staff_id, rental_rate FROM customer FULL JOIN rental R USING " +
                    $"(customer_id) FULL JOIN payment USING (rental_id) FULL JOIN inventory USING (inventory_id) FULL JOIN " +
                    $"film USING (film_id) FULL JOIN store S ON (manager_staff_id = R.staff_id) FULL JOIN address A ON " +
                    $"(S.address_id = A.address_id) WHERE R.customer_id = {this.id_cliente} AND return_date IS NOT NULL AND payment_date " +
                    $"IS NULL ORDER BY rental_date DESC;";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String pelicula = reader.GetString(0);
                        String tienda = reader.GetString(1);
                        String fechaRetorno = reader.GetDateTime(2).ToString();
                        String idRenta = reader.GetInt32(3).ToString();
                        String tiendaID = reader.GetInt32(4).ToString();
                        String pago = reader.GetDecimal(5).ToString();

                        ListViewItem item = new ListViewItem(pelicula);
                        item.SubItems.Add(tienda);
                        item.SubItems.Add(fechaRetorno);
                        item.SubItems.Add(idRenta);
                        item.SubItems.Add(tiendaID);
                        item.SubItems.Add(pago);
                        lstPagos.Items.Add(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmPagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }

        private void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (lstPagos.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Por favor seleccione un alquiler a pagar", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea pagar esta alquiler?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            String idRenta = lstPagos.SelectedItems[0].SubItems[3].Text;
            String tiendaID = lstPagos.SelectedItems[0].SubItems[4].Text;
            String pago = lstPagos.SelectedItems[0].SubItems[5].Text.Replace(',', '.');
            try
            {
                String commString = $"INSERT INTO payment VALUES(((SELECT payment_id FROM payment ORDER BY payment_id " +
                    $"DESC LIMIT 1) + 1), {this.id_cliente}, {tiendaID}, {idRenta}, {pago}, (SELECT now()::timestamp(0)))";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                int estado = comm.ExecuteNonQuery();
                if (estado == 1)
                {
                    MessageBox.Show("Pago exitoso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstPagos.Items.Clear();
                    labelPrecio.Text = "Cantidad a Pagar: ";
                    getPagosPendientes();
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void lstPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPagos.SelectedItems.Count > 0)
            {
                labelPrecio.Text = $"Cantidad a Pagar: $ {lstPagos.SelectedItems[0].SubItems[5].Text}";
            }
        }
    }
}
