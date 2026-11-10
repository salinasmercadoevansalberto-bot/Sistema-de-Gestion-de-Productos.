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
        public static void ErrorNombreP(ErrorProvider errorProvider,
            TextBox txtNombre)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El Nombre del producto es obligatorio.");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        public static void ErrorPrecio(ErrorProvider errorProvider,
            TextBox txtPrecio)
        {
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                errorProvider.SetError(txtPrecio, "El Precio del producto es obligatorio.");
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                errorProvider.SetError(txtPrecio, "El Precio del producto debe ser un número mayor que cero.");
            }
            else
            {
                errorProvider.Clear();
            }
          
        }
        public static void Stock(ErrorProvider errorProvider,
            TextBox txtStock)
        {
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                errorProvider.SetError(txtStock, "El Stock  del producto es obligatorio.");
            }
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                errorProvider.SetError(txtStock, "El Stock del producto debe ser un número mayor o igual que cero.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

    }
}
