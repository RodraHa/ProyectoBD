using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class FrmIngresarPelicula : Form
    {
        private NpgsqlConnection connection;

        public FrmIngresarPelicula()
        {
            InitializeComponent();
            connection = new NpgsqlConnection(Login.connectionString);
            OpenConnection();
            getIdiomas();
        }

        private void getIdiomas()
        {
            try
            {
                String commString = $"SELECT name FROM language";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String idioma = reader.GetString(0);
                        cmbBoxIdioma.Items.Add(idioma);
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

        private void FrmIngresarPelicula_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void btnIngresarPelicula_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTituloPelicula.Text))
            {
                MessageBox.Show("Por favor ingrese un título", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtFechaLanzamiento.Text) ||
                !Regex.IsMatch(txtFechaLanzamiento.Text, @"^\d+$") || Convert.ToInt32(txtFechaLanzamiento.Text) > 2100 || Convert.ToInt32(txtFechaLanzamiento.Text) < 1950)
            {
                MessageBox.Show("Por favor ingrese una fecha válida", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrWhiteSpace(cmbBoxIdioma.Text))
            {
                MessageBox.Show("Por favor ingrese un idioma", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ingresarPelicula();
        }

        private void ingresarPelicula()
        {
            try
            {
                String titulo = txtTituloPelicula.Text;
                String fecha = txtFechaLanzamiento.Text;
                String idiomaID = getIdiomaID(cmbBoxIdioma.Text);
                String precio = precioUpDown.Value.ToString().Replace(',', '.');
                String reemplazo = costoReemplazoUpDown.Value.ToString().Replace(',', '.');

                String commStringInsertar = $"INSERT INTO film(film_id, title, release_year, language_id, rental_duration, rental_rate, " +
                    $"replacement_cost, last_update, fulltext) VALUES(((SELECT film_id FROM film ORDER BY film_id DESC LIMIT 1) + 1), '{titulo}', " +
                    $"{fecha}, {idiomaID}, 7, {precio}, {reemplazo}, (SELECT now()::timestamp(0)), to_tsvector('english'))";
                NpgsqlCommand comm = new NpgsqlCommand(commStringInsertar, connection);
                int estado = comm.ExecuteNonQuery();
                if (estado == 1)
                {
                    MessageBox.Show("Ingreso exitoso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiarCampos();
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtTituloPelicula.Text = "";
            txtFechaLanzamiento.Text = "";
        }

        private string getIdiomaID(string text)
        {
            try
            {
                String commString = $"SELECT language_id FROM language WHERE name = '{text}'";
                NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                String idiomaID = comm.ExecuteScalar().ToString();
                return idiomaID;
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
