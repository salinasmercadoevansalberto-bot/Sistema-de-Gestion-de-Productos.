using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Productos_.Clases
{
    public class Categorias
    {
        private int id_Categoria;
        private string nombre = string.Empty;
        private string descripcion = string.Empty;

        public Categorias(int id_categoria)
        {
            Id_Categoria = id_categoria;
        }

        public Categorias(int id_categoria, string nombre, string descripcion)
        {
            Id_Categoria = id_categoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public int Id_Categoria
        {
            get => id_Categoria;
            set => id_Categoria = value;
        }

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

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value?.Trim() ?? string.Empty;
        }
    }
}
