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
    public partial class FrmIngresarDVD : Form
    {
        private int id_administrador;
        private NpgsqlConnection connection;

        public FrmIngresarDVD(int id_administrador)
        {
            InitializeComponent();
            this.id_administrador = id_administrador;
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
                String commString = $"SELECT title, COUNT(inventory_id), film_id FROM film F LEFT OUTER JOIN inventory USING (film_id) GROUP BY F.film_id " +
                    $"ORDER BY title";
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (lstPeliculas.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Por favor seleccione una pelicula", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!chckTienda1.Checked && !chckTienda2.Checked)
            {
                MessageBox.Show("Por favor seleccione una tienda", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                String peliculaID = lstPeliculas.SelectedItems[0].SubItems[2].Text;
                String numeroTienda = chckTienda1.Checked ? "1" : "2";

                String commStringInsertar = $"INSERT INTO inventory VALUES(((SELECT inventory_id FROM inventory ORDER BY " +
                    $"inventory_id DESC LIMIT 1) + 1), {peliculaID}, {numeroTienda}, (SELECT now()::timestamp(0)))";
                NpgsqlCommand comm = new NpgsqlCommand(commStringInsertar, connection);
                int estado = comm.ExecuteNonQuery();
                if (estado == 1)
                {
                    MessageBox.Show("Ingreso exitoso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
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
                String commString = $"SELECT title, COUNT(inventory_id), film_id FROM film F LEFT OUTER JOIN inventory USING (film_id) WHERE " +
                    $"title LIKE '{nombre}%' GROUP BY F.film_id ORDER BY title";
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

        private void lstPeliculas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstPeliculas.SelectedItems.Count > 0)
            {
                labelPelicula.Text = lstPeliculas.SelectedItems[0].SubItems[0].Text;
                chckTienda1.Checked = false;
                chckTienda2.Checked = false;
            }
        }

        private void FrmIngresarDVD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
