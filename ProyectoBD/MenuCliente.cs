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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoBD
{
    public partial class MenuCliente : Form
    {
        private int id_cliente;

        public MenuCliente(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            setBienvenida();
        }

        private void setBienvenida()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Login.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT first_name, last_name FROM customer WHERE customer_id = '{this.id_cliente}'";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    NpgsqlDataReader reader = comm.ExecuteReader();
                    reader.Read();
                    String nombre = reader.GetString(0);
                    String apellido = reader.GetString(1);
                    labelBienvenida.Text += " " + nombre + " " + apellido;
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial historial = new FrmHistorial(this.id_cliente);
            historial.ShowDialog();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            FrmAlquilar alquilar = new FrmAlquilar(this.id_cliente);
            alquilar.ShowDialog();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            FrmDevolver devolver = new FrmDevolver(this.id_cliente);
            devolver.ShowDialog();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FrmPagar pagar = new FrmPagar(this.id_cliente);
            pagar.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmListar listar = new FrmListar(this.id_cliente);
            listar.ShowDialog();
        }
    }
}
