using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Sistema_de_Gestion_de_Productos_.Clases;

namespace Sistema_de_Gestion_de_Productos_
{
    public class BaseDatosCategoria
    {
        private readonly ConexionBD conexionBD = new ConexionBD();

        // 1. OBTENER TODAS LAS CATEGORÍAS
        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> lista = new List<Categorias>();

            string consulta = @"SELECT IdCategoria, Nombre, Descripcion
                                FROM Categorias
                                ORDER BY Nombre";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Categorias categoria = new Categorias(
                            Convert.ToInt32(lector["IdCategoria"]),
                            lector["Nombre"].ToString(),
                            lector["Descripcion"].ToString()
                        );

                        lista.Add(categoria);
                    }
                }
            }

            return lista;
        }

        // 2. REGISTRAR UNA CATEGORÍA
        public void RegistrarCategoria(Categorias categoria)
        {
            string consulta = @"INSERT INTO Categorias (Nombre, Descripcion)
                                VALUES (@Nombre, @Descripcion)";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                    comando.ExecuteNonQuery();
                }
            }
        }

        // 3. MODIFICAR UNA CATEGORÍA
        public void ModificarCategoria(Categorias categoria)
        {
            string consulta = @"UPDATE Categorias
                                SET Nombre = @Nombre,
                                    Descripcion = @Descripcion
                                WHERE IdCategoria = @IdCategoria";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdCategoria", categoria.Id_Categoria);
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                    comando.ExecuteNonQuery();
                }
            }
        }

        // 4. ELIMINAR UNA CATEGORÍA
        public void EliminarCategoria(int idCategoria)
        {
            string consulta = @"DELETE FROM Categorias
                                WHERE IdCategoria = @IdCategoria";

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}