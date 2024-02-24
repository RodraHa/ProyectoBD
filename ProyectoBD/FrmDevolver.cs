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
    public partial class FrmDevolver : Form
    {
        private int id_cliente;
        private NpgsqlConnection connection;

        public FrmDevolver(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            connection = new NpgsqlConnection(Login.connectionString);
            OpenConnection();
            getDevoluciones();
            lstDevoluciones.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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

        private void getDevoluciones()
        {
            try
            {
                String commString = $"SELECT title, address, rental_date, rental_id FROM customer FULL JOIN " +
                        $"rental R USING (customer_id) FULL JOIN inventory USING (inventory_id) FULL JOIN film USING (film_id) " +
                        $"FULL JOIN store S ON (manager_staff_id = R.staff_id) FULL JOIN address A ON (S.address_id = A.address_id) " +
                        $"WHERE R.customer_id = {this.id_cliente} AND return_date IS NULL ORDER BY rental_date DESC;";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String pelicula = reader.GetString(0);
                        String tienda = reader.GetString(1);
                        String fechaRenta = reader.GetDateTime(2).ToString();
                        String idRenta = reader.GetInt32(3).ToString();

                        ListViewItem item = new ListViewItem(pelicula);
                        item.SubItems.Add(tienda);
                        item.SubItems.Add(fechaRenta);
                        item.SubItems.Add(idRenta);
                        lstDevoluciones.Items.Add(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void FrmDevolver_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (lstDevoluciones.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Por favor seleccione una película para devolver", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea devolver esta película?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            String idRenta = lstDevoluciones.SelectedItems[0].SubItems[3].Text;
            try
            {
                String commString = $"UPDATE rental SET return_date = (SELECT now()::timestamp(0)) " +
                    $"WHERE rental_id = {idRenta}";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                int estado = comm.ExecuteNonQuery();
                if (estado == 1)
                {
                    MessageBox.Show("Devolución exitosa", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstDevoluciones.Items.Clear();
                    getDevoluciones();
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
