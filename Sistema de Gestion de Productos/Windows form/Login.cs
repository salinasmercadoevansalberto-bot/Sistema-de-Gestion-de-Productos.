using Sistema_de_Gestion_de_Productos_.Windows_form;
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
            // Credenciales de demostración; no usar este método en un sistema real.
            if (textBoxUsuario.Text.Trim() != "admin" || textBoxContraseña.Text != "1234")
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxContraseña.Clear();
                textBoxContraseña.Focus();
                return;
            }

            Hide();
            using (var ventanaPrincipal = new Menu_Principal(textBoxUsuario.Text.Trim()))
            {
                ventanaPrincipal.ShowDialog();
            }
            Close();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            ErrorProviders.ErrorUsuario(errorProvider1, textBoxUsuario);
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            ErrorProviders.ErrorContraseña(errorProvider2, textBoxContraseña);
        }
    }
}
