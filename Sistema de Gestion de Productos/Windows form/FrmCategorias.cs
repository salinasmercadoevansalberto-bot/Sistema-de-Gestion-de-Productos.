using Sistema_de_Gestion_de_Productos_;
using System;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Productos_
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Funcion_de_Regreso_Boton.Regreso(this);
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
