using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Productos_.Windows_form.Funciones_Fronted
{
    internal class ErrorProviders
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
        public static void ErrorNombreC(ErrorProvider errorProvider,
            TextBox txtNombre)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El Nombre de la categoría es obligatorio.");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        public static void ErrorDescripcionC(ErrorProvider errorProvider,
            TextBox txtDescripcion)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "La Descripción de la categoría es obligatoria.");
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
