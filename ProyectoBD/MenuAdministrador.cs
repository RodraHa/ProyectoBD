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
    public partial class MenuAdministrador : Form
    {
        private int id_administrador;

        public MenuAdministrador(int id_administrador)
        {
            InitializeComponent();
            this.id_administrador = id_administrador;
        }

        private void btnIngresarPelicula_Click(object sender, EventArgs e)
        {
            FrmIngresarPelicula ingresarPelicula = new FrmIngresarPelicula();
            ingresarPelicula.ShowDialog();
        }

        private void btnIngresarDVD_Click(object sender, EventArgs e)
        {
            FrmIngresarDVD ingresarDVD = new FrmIngresarDVD(this.id_administrador);
            ingresarDVD.ShowDialog();
        }

        private void btnEliminarDVD_Click(object sender, EventArgs e)
        {
            FrmEliminarDVD eliminar = new FrmEliminarDVD();
            eliminar.ShowDialog();
        }
    }
}
