using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Productos_
{
    internal class Funcion_de_Regreso_Boton
    {
        public static void Regreso(Form formularioActual)
        {
           formularioActual.Close();
        }
    }
}//Cierra el formulario actual y regresa al formulario principal
