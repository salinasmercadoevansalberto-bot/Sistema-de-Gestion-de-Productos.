using Sistema_de_Gestion_de_Productos_.Windows_form.Funciones_Fronted;

namespace Sistema_de_Gestion_de_Productos_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIniciar_secion_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            Error_providers.ErrorUsuario(errorProvider1, textBoxUsuario);
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            Error_providers.ErrorContraseña(errorProvider2, textBoxContraseña);
        }
    }
}
