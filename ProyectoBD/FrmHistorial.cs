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
    public partial class FrmHistorial : Form
    {
        private int id_cliente;

        public FrmHistorial(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            getHistorial();
            lstHistorial.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void getHistorial()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Login.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT rental_date, return_date, payment_date, title, amount, address " +
                                         $"FROM customer FULL JOIN rental R USING (customer_id) FULL JOIN payment USING (rental_id) " +
                                         $"FULL JOIN inventory USING (inventory_id) FULL JOIN film USING (film_id) FULL JOIN store S ON " +
                                         $"(manager_staff_id = R.staff_id) FULL JOIN address A ON (S.address_id = A.address_id) WHERE " +
                                         $"R.customer_id = {this.id_cliente} ORDER BY rental_date DESC;";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    NpgsqlDataReader reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime fechaRenta = reader.GetDateTime(0);
                        String fechaDevolucion = reader.IsDBNull(1) ? "Sin registro" : reader.GetDateTime(1).ToString();
                        String fechaPago = reader.IsDBNull(2) ? "Sin registro" : reader.GetDateTime(2).ToString();
                        String precio = reader.IsDBNull(4) ? "Sin registro" : reader.GetDecimal(4).ToString();
                        String pelicula = reader.GetString(3);
                        String direccion = reader.GetString(5);

                        ListViewItem item = new ListViewItem(fechaRenta.ToString());
                        item.SubItems.Add(fechaDevolucion);
                        item.SubItems.Add(fechaPago);
                        item.SubItems.Add(pelicula);
                        item.SubItems.Add(precio);
                        item.SubItems.Add(direccion);
                        lstHistorial.Items.Add(item);
                    }
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close(); 
                }
            }
        }
    }
}
