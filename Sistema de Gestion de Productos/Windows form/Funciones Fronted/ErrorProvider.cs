using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Productos_.Windows_form.Funciones_Fronted
{
    internal class Error_providers
    {
        public static void ErrorUsuario(ErrorProvider errorProvider,
            TextBox txtNombre)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El Usuario es obligatorio.");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        public static void ErrorContraseña(ErrorProvider errorProvider,
            TextBox txtContraseña)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                errorProvider.SetError(txtContraseña, "La contraseña es obligatoria.");
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
