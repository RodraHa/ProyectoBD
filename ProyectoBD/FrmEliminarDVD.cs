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
    public partial class FrmEliminarDVD : Form
    {
        private NpgsqlConnection connection;

        public FrmEliminarDVD()
        {
            InitializeComponent();
            connection = new NpgsqlConnection(Login.connectionString);
            OpenConnection();
            getPeliculas();
            lstPeliculas.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lstPeliculas.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void getPeliculas()
        {
            try
            {
                String commString = $"SELECT title, COUNT(*), film_id FROM film F JOIN inventory USING (film_id) " +
                                       $"GROUP BY F.film_id ORDER BY title";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String tituloPelicula = reader.GetString(0);
                        String existencias = reader.GetInt32(1).ToString();
                        String id = reader.GetInt32(2).ToString();

                        ListViewItem item = new ListViewItem(tituloPelicula);
                        item.SubItems.Add(existencias);
                        item.SubItems.Add(id);
                        lstPeliculas.Items.Add(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
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

        private void lstPeliculas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstPeliculas.SelectedItems.Count > 0)
            {
                chckTienda1.Checked = false;
                chckTienda2.Checked = false;
                getInfoPelicula();
            }
        }

        private void getInfoPelicula()
        {
            String id = lstPeliculas.SelectedItems[0].SubItems[2].Text;
            labelPelicula.Text = lstPeliculas.SelectedItems[0].SubItems[0].Text;
            try
            {
                String commStringExistencias = $"SELECT SUM(CASE WHEN store_id = 1 THEN 1 END) AS tienda_1, " +
                    $"SUM(CASE WHEN store_id = 2 THEN 1 END) AS tienda_2 FROM inventory WHERE film_id = {id}";
                NpgsqlCommand comm = new NpgsqlCommand(commStringExistencias, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String existenciasTienda1 = reader.IsDBNull(0) ? "0" : reader.GetInt32(0).ToString();
                        String existenciasTienda2 = reader.IsDBNull(1) ? "0" : reader.GetInt32(1).ToString();
                        chckTienda1.Text = $"Tienda 1 (Existencias : {existenciasTienda1})";
                        chckTienda2.Text = $"Tienda 2 (Existencias : {existenciasTienda2})";
                        chckTienda1.Enabled = existenciasTienda1 != "0" ? true : false;
                        chckTienda2.Enabled = existenciasTienda2 != "0" ? true : false;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmEliminarDVD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void chckTienda1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckTienda2.Checked)
            {
                chckTienda1.Checked = false;
                return;
            }
        }

        private void chckTienda2_CheckedChanged(object sender, EventArgs e)
        {
            if (chckTienda1.Checked)
            {
                chckTienda2.Checked = false;
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTituloPelicula.Text))
            {
                lstPeliculas.Items.Clear();
                getPeliculas();
                return;
            }
            lstPeliculas.Items.Clear();
            try
            {
                String nombre = txtTituloPelicula.Text;
                String commString = $"SELECT title, COUNT(*), film_id FROM film F JOIN inventory USING (film_id) " +
                    $"WHERE title LIKE '{nombre}%' GROUP BY F.film_id ORDER BY title";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String tituloPelicula = reader.GetString(0);
                        String existencias = reader.GetInt32(1).ToString();
                        String id = reader.GetInt32(2).ToString();

                        ListViewItem item = new ListViewItem(tituloPelicula);
                        item.SubItems.Add(existencias);
                        item.SubItems.Add(id);
                        lstPeliculas.Items.Add(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPeliculas.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Por favor seleccione una película", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!chckTienda1.Checked && !chckTienda2.Checked)
            {
                MessageBox.Show("Por favor seleccione una tienda", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar esta película?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            String numeroTienda = chckTienda1.Checked ? "1" : "2";
            String idPelicula = lstPeliculas.SelectedItems[0].SubItems[2].Text;
            try
            {
                String commString = $"DELETE FROM inventory WHERE inventory_id IN (SELECT inventory_id " +
                    $"FROM inventory WHERE film_id = {idPelicula} AND store_id = {numeroTienda} ORDER BY inventory_id " +
                    $"DESC LIMIT 1)";
                NpgsqlCommand comm2 = new NpgsqlCommand(commString, connection);
                int estado = comm2.ExecuteNonQuery();
                if (estado == 1)
                {
                    MessageBox.Show("Eliminacion exitosa", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getInfoPelicula();
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se puede eliminar el DVD porque ya se rentó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
