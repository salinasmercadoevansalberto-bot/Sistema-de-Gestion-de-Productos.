using Sistema_de_Gestion_de_Productos_.Clases;

using System;

namespace Sistema_de_Gestion_de_Productos_
{
    public class Producto
    {
        private int id_Producto;
        private string nombre = string.Empty;
        private decimal precio;
        private int cantidad;
        private DateTime fechaRegistro;
        private int id_Categoria;

        // Constructor
        public Producto(string nombre, decimal precio, int cantidad, int id_categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Id_Categoria = id_categoria;
            fechaRegistro = DateTime.Now;
        }

        // Identificador del producto
        public int Id_Producto
        {
            get => id_Producto;
            set => id_Producto = value;
        }

        // Nombre del producto
        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre es obligatorio.");

                nombre = value.Trim();
            }
        }

        // Precio del producto
        public decimal Precio
        {
            get => precio;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(
                        nameof(Precio), "El precio debe ser mayor que cero.");

                precio = value;
            }
        }

        // Cantidad disponible
        public int Cantidad
        {
            get => cantidad;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                        nameof(Cantidad), "La cantidad no puede ser negativa.");

                cantidad = value;
            }
        }

        // Fecha automática de registro
        public DateTime FechaRegistro
        {
            get => fechaRegistro;
        }

        // Identificador de la categoría relacionada
        public int Id_Categoria
        {
            get => id_Categoria;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(
                        nameof(Id_Categoria), "Debe seleccionar una categoría válida.");

                id_Categoria = value;
            }
        }

        // Valor total del inventario
        public decimal ValorInventario => Precio * Cantidad;

        public virtual string Tipo => "General";
    }
}