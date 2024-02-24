using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class FrmListar : Form
    {
        private int id_cliente;
        private NpgsqlConnection connection;

        public FrmListar(int id_cliente)
        {
            this.id_cliente = id_cliente;
            InitializeComponent();
            connection = new NpgsqlConnection(Login.connectionString);
            OpenConnection();
            getGeneros();
        }

        private void getGeneros()
        {
            try
            {
                String commStringGeneros = $"SELECT name FROM category";
                NpgsqlCommand comm = new NpgsqlCommand(commStringGeneros, connection);
                using (NpgsqlDataReader reader = comm.ExecuteReader())
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

        private void btnConsultarDirector_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtActor.Text) &&
                    String.IsNullOrEmpty(cmBoxGeneros.Text))
            {
                return;
            }
            lstConsultaDVD.Items.Clear();
            if (String.IsNullOrWhiteSpace(txtActor.Text) &&
                !String.IsNullOrEmpty(cmBoxGeneros.Text))
            {
                buscarPorGenero();
            }
            else if (!String.IsNullOrWhiteSpace(txtActor.Text) &&
                String.IsNullOrEmpty(cmBoxGeneros.Text))
            {
                buscarPorActor();
            }
            else
            {
                buscarPorActorYGenero();
            }
        }

        private void buscarPorActorYGenero()
        {
            try
            {
                String genero = cmBoxGeneros.Text;
                String actor = txtActor.Text;
                String[] nombres = actor.Split(' ');
                if (nombres.Length > 2)
                {
                    MessageBox.Show("El actor solo puede constar de un nombre y un apellido", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                String commString = nombres.Length == 1 ? $"SELECT title, release_year, L.name FROM film JOIN language L USING (language_id) " +
                    $"JOIN film_category USING (film_id) JOIN category C USING (category_id) JOIN film_actor USING (film_id) " +
                    $"WHERE actor_id IN (SELECT actor_id FROM actor WHERE first_name LIKE '{nombres[0]}%') AND C.name LIKE '{genero}'" :
                    $"SELECT title, release_year, L.name FROM film JOIN language L USING (language_id) " +
                    $"JOIN film_category USING (film_id) JOIN category C USING (category_id) JOIN film_actor USING (film_id) " +
                    $"WHERE actor_id IN (SELECT actor_id FROM actor WHERE first_name LIKE '{nombres[0]}%' AND last_name LIKE '{nombres[1]}%') " +
                    $"AND C.name LIKE '{genero}'";

                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String tituloPelicula = reader.GetString(0);
                        String fechaLanzamiento = reader.GetInt32(1).ToString();
                        String idioma = reader.GetString(2);

                        ListViewItem item = new ListViewItem(tituloPelicula);
                        item.SubItems.Add(fechaLanzamiento);
                        item.SubItems.Add(idioma);
                        lstConsultaDVD.Items.Add(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarPorActor()
        {
            try
            {
                String actor = txtActor.Text;
                String[] nombres = actor.Split(' ');
                if (nombres.Length > 2)
                {
                    MessageBox.Show("El actor solo puede constar de un nombre y un apellido", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                String commString = nombres.Length == 1? $"SELECT title, release_year, L.name FROM film JOIN language L USING (language_id) " +
                    $"JOIN film_category USING (film_id) JOIN category C USING (category_id) JOIN film_actor USING (film_id) " +
                    $"WHERE actor_id IN (SELECT actor_id FROM actor WHERE first_name LIKE '{nombres[0]}%')" : 
                    $"SELECT title, release_year, L.name FROM film JOIN language L USING (language_id) " +
                    $"JOIN film_category USING (film_id) JOIN category C USING (category_id) JOIN film_actor USING (film_id) " +
                    $"WHERE actor_id IN (SELECT actor_id FROM actor WHERE first_name LIKE '{nombres[0]}%' AND last_name LIKE '{nombres[1]}%')";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String tituloPelicula = reader.GetString(0);
                        String fechaLanzamiento = reader.GetInt32(1).ToString();
                        String idioma = reader.GetString(2);

                        ListViewItem item = new ListViewItem(tituloPelicula);
                        item.SubItems.Add(fechaLanzamiento);
                        item.SubItems.Add(idioma);
                        lstConsultaDVD.Items.Add(item);
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
                String commString = $"SELECT title, release_year, L.name FROM film JOIN language L USING (language_id) " +
                    $"JOIN film_category USING (film_id) JOIN category C USING (category_id) " +
                    $"WHERE C.name LIKE '{genero}'";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String tituloPelicula = reader.GetString(0);
                        String fechaLanzamiento = reader.GetInt32(1).ToString();
                        String idioma = reader.GetString(2);

                        ListViewItem item = new ListViewItem(tituloPelicula);
                        item.SubItems.Add(fechaLanzamiento);
                        item.SubItems.Add(idioma);
                        lstConsultaDVD.Items.Add(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmListar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
