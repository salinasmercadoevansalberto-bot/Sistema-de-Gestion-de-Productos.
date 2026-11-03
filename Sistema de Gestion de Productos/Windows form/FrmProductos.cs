using Sistema_de_Gestion_de_Productos_;
using System;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Productos_
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcion_de_Regreso_Boton.Regreso(this);
        }
    }
}
