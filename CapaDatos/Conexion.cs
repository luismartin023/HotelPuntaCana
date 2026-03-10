using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        // Conexión a SQL
        private readonly string cadenaConexion = @"Server=.; Database=HotelPuntaCana; Integrated Security=True; TrustServerCertificate=True;";

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
