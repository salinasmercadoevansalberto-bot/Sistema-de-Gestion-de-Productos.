

using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Sistema_de_Gestion_de_Productos_.Clases;

namespace Sistema_de_Gestion_de_Productos_
{
    internal class BaseDatosProductos
    {
        private readonly ConexionBD conexionBD = new ConexionBD();

        // Obtener todos los productos
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            string consulta = @"
                SELECT IdProducto, Nombre, Precio, Stock,
                       FechaRegistro, IdCategoria
                FROM dbo.Productos";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Producto producto = new Producto(
                            lector["Nombre"].ToString(),
                            Convert.ToDecimal(lector["Precio"]),
                            Convert.ToInt32(lector["Stock"]),
                            Convert.ToInt32(lector["IdCategoria"])
                        );

                        producto.Id_Producto =
                            Convert.ToInt32(lector["IdProducto"]);

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }

        // Registrar un producto
        public void RegistrarProducto(Producto producto)
        {
            string consulta = @"
                INSERT INTO dbo.Productos
                    (Nombre, Precio, Stock, IdCategoria)
                VALUES
                    (@Nombre, @Precio, @Stock, @IdCategoria)";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Stock", producto.Cantidad);
                    comando.Parameters.AddWithValue("@IdCategoria", producto.Id_Categoria);

                    comando.ExecuteNonQuery();
                }
            }
        }

        // Modificar un producto
        public void ModificarProducto(Producto producto)
        {
            string consulta = @"
                UPDATE dbo.Productos
                SET Nombre = @Nombre,
                    Precio = @Precio,
                    Stock = @Stock,
                    IdCategoria = @IdCategoria
                WHERE IdProducto = @IdProducto";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProducto", producto.Id_Producto);
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Stock", producto.Cantidad);
                    comando.Parameters.AddWithValue("@IdCategoria", producto.Id_Categoria);

                    comando.ExecuteNonQuery();
                }
            }
        }

        // Eliminar un producto
        public void EliminarProducto(int idProducto)
        {
            string consulta = @"
                DELETE FROM dbo.Productos
                WHERE IdProducto = @IdProducto";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProducto", idProducto);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Buscar productos por nombre
        public List<Producto> BuscarProductos(string texto)
        {
            List<Producto> productos = new List<Producto>();

            string consulta = @"
                SELECT IdProducto, Nombre, Precio, Stock,
                       FechaRegistro, IdCategoria
                FROM dbo.Productos
                WHERE Nombre LIKE @Busqueda";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Busqueda", "%" + texto + "%");

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Producto producto = new Producto(
                                lector["Nombre"].ToString(),
                                Convert.ToDecimal(lector["Precio"]),
                                Convert.ToInt32(lector["Stock"]),
                                Convert.ToInt32(lector["IdCategoria"])
                            );

                            producto.Id_Producto =
                                Convert.ToInt32(lector["IdProducto"]);

                            productos.Add(producto);
                        }
                    }
                }
            }

            return productos;
        }
    }
}
