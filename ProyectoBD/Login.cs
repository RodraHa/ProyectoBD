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
    public partial class Login : Form
    {
        public static String user = "postgres";
        public static String password = "eeee2003";
        public static String connectionString = $"Server=localhost;Port=5432;User Id={user};Password={password};Database=dvdrental";
        private String placeholder;

        public Login()
        {
            InitializeComponent();
            placeholder = "Email";
            setPlaceholder();
        }

        private void setPlaceholder()
        {
            txtEmail.Text = placeholder;
            txtEmail.ForeColor = Color.Gray;
        }


        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == placeholder)
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                setPlaceholder();
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            if (String.IsNullOrWhiteSpace(email) || email == placeholder || email.Length < 12)
            {
                MessageBox.Show("Por favor ingrese un email válido", "No se ingresaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection =  new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (email.Contains("staff"))
                    {
                        String commString = $"SELECT staff_id FROM staff WHERE email = '{email}'";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        NpgsqlDataReader reader = comm.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Administrador no registrado", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        int id_administrador = reader.GetInt32(0);
                        MenuAdministrador menu = new MenuAdministrador(id_administrador);
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        String commString = $"SELECT customer_id FROM customer WHERE email = '{email}'";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        NpgsqlDataReader reader = comm.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Cliente no registrado", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        int id_cliente = reader.GetInt32(0);
                        MenuCliente menu = new MenuCliente(id_cliente);
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                    }
                } 
                catch (NpgsqlException ex) {
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
    }
}
