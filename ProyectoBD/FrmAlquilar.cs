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
    public partial class FrmAlquilar : Form
    {
        private int id_cliente;
        private NpgsqlConnection connection;  

        public FrmAlquilar(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            connection = new NpgsqlConnection(Login.connectionString);
            OpenConnection();
            getPeliculas();
            lstPeliculas.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lstPeliculas.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void getPeliculas()
        {
            try
            {
                String commString = $"SELECT title, COUNT(*), film_id FROM film F JOIN inventory USING (film_id) " +
                                       $"GROUP BY F.film_id ORDER BY title";
                String commStringGeneros = $"SELECT name FROM category";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                NpgsqlCommand comm2 = new NpgsqlCommand(commStringGeneros, connection);

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

                using (NpgsqlDataReader reader = comm2.ExecuteReader())
                {
                    cmBoxGeneros.Items.Add("");
                    while (reader.Read())
                    {
                        String nombreGenero = reader.GetString(0);
                        cmBoxGeneros.Items.Add(nombreGenero);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTituloPelicula.Text) &&
                String.IsNullOrEmpty(cmBoxGeneros.Text))
            {
                return;
            }
            lstPeliculas.Items.Clear();
            if (String.IsNullOrWhiteSpace(txtTituloPelicula.Text) &&
                !String.IsNullOrEmpty(cmBoxGeneros.Text))
            {
                buscarPorGenero();
            }
            else if (!String.IsNullOrWhiteSpace(txtTituloPelicula.Text) &&
                String.IsNullOrEmpty(cmBoxGeneros.Text))
            {
                buscarPorNombre();
            }
            else
            {
                buscarPorNombreYGenero();
            }
        }

        private void buscarPorNombreYGenero()
        {
            try
            {
                String nombre = txtTituloPelicula.Text;
                String genero = cmBoxGeneros.Text;
                String commString = $"SELECT title, COUNT(*), film_id FROM film F JOIN inventory USING (film_id) WHERE " +
                                    $"F.film_id IN (SELECT F.film_id FROM film F JOIN film_category USING (film_id) " +
                                    $"JOIN category USING (category_id) WHERE name LIKE '{genero}') AND title LIKE '{nombre}%' " +
                                    $"GROUP BY F.film_id ORDER BY title";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String tituloPelicula = reader.GetString(0);
                        String existencias = reader.GetInt32(1).ToString();
                        String id = reader.GetString(2).ToString();

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

        private void buscarPorNombre()
        {
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

        private void buscarPorGenero()
        {
            try
            {
                String genero = cmBoxGeneros.Text;
                String commString = $"SELECT title, COUNT(*), film_id FROM film F JOIN inventory USING (film_id) " +
                    $"WHERE F.film_id IN (SELECT F.film_id FROM film F JOIN film_category USING (film_id) JOIN category" +
                    $" USING (category_id) WHERE name LIKE '{genero}') GROUP BY F.film_id ORDER BY title";
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

        private void FrmAlquilar_FormClosed(object sender, FormClosedEventArgs e)
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

        private void lstPeliculas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstPeliculas.SelectedItems.Count > 0)
            {
                chckTienda1.Checked = false;
                chckTienda2.Checked = false;
                String id = lstPeliculas.SelectedItems[0].SubItems[2].Text;
                try
                {
                    String commString = $"SELECT title, release_year, name, replacement_cost FROM film JOIN language " +
                        $"USING (language_id) WHERE film_id = {id}";
                    String commStringExistencias = $"SELECT SUM(CASE WHEN store_id = 1 THEN 1 END) AS tienda_1, " +
                        $"SUM(CASE WHEN store_id = 2 THEN 1 END) AS tienda_2 FROM inventory WHERE film_id = {id}";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    NpgsqlCommand comm2 = new NpgsqlCommand(commStringExistencias, connection);

                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String tituloPelicula = reader.GetString(0);
                            String lanzamiento = reader.GetInt32(1).ToString();
                            String idioma = reader.GetString(2);
                            String costoReemplazo = reader.GetDecimal(3).ToString();

                            txtPeliculaInformacion.Text = $"Película: {tituloPelicula}";
                            txtFechaPelicula.Text = $"Fecha de lanzamiento: {lanzamiento}";
                            txtIdioma.Text = $"Idioma: {idioma}";
                            txtCostoSustitucion.Text = $"Costo de sustitución: {costoReemplazo}";
                        }
                    }

                    using (NpgsqlDataReader reader = comm2.ExecuteReader())
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

        private void btnAlquilar_Click(object sender, EventArgs e)
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

            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea alquilar esta película?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;         
            }

            String numeroTienda = chckTienda1.Checked ? "1" : "2";
            String idPelicula = lstPeliculas.SelectedItems[0].SubItems[2].Text;

            try
            {
                String commString = $"SELECT inventory_id FROM inventory WHERE film_id = {idPelicula} " +
                                    $"ORDER BY inventory_id DESC LIMIT 1";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                String inventoryID = comm.ExecuteScalar().ToString();

                String commStringInsertar = $"INSERT INTO rental VALUES(((SELECT rental_id FROM rental ORDER BY rental_id DESC LIMIT 1) " +
                                            $"+ 1), (SELECT now()::timestamp(0)), {inventoryID}, {this.id_cliente}, NULL, {numeroTienda}, " +
                                            $"(SELECT now()::timestamp(0)))";
                NpgsqlCommand comm2 = new NpgsqlCommand(commStringInsertar, connection);
                int estado = comm2.ExecuteNonQuery();
                if (estado == 1)
                {
                    MessageBox.Show("Alquiler exitoso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
