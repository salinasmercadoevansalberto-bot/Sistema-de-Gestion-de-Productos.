using Sistema_de_Gestion_de_Productos_.Clases;
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

        private void buttonProbarBd_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();

            if (conexion.ProbarConexion())
            {
                MessageBox.Show(
                    "Conexión exitosa con la base de datos.",
                    "Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "No se pudo conectar con la base de datos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas cerrar la ventana del inventario?",
             "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Application.Exit();
        }
    }
}
