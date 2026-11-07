using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Productos_.Windows_form
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal(string v)
        {
            InitializeComponent();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            FrmProductos formulario = new FrmProductos();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias formulario = new FrmCategorias();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }
    }
}
