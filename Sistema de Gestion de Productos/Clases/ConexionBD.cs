
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Sistema_de_Gestion_de_Productos_.Clases
{
    public class ConexionBD
    {
       

        private readonly string cadenaConexion =
            @"Server=Evans-PC\SQLEXPRESS;
              Database=SistemaGestionProductos;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        private SqlConnection conexion;

        
        public ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        // Obtener el objeto de conexion
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }

        // Abrir la conexion
        public void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed ||
                conexion.State == ConnectionState.Broken)
            {
                conexion.Open();
            }
        }

        // Cerrar la conexion
        public void CerrarConexion()
        {
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        // Verificar si existe conexion con SQL Server
        public bool ProbarConexion()
        {
            try
            {
                AbrirConexion();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void Dispose()
        {
            if (conexion != null)
            {
                conexion.Dispose();
            }
        }
    }
}

