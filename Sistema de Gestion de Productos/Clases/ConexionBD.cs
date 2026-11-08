
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

        // Crear una conexión nueva cada vez que se solicite.
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        // Verificar si existe conexión con SQL Server.
        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
