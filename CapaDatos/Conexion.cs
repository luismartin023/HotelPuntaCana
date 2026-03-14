using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public abstract class Conexion
    {
        // Cadena de conexión protegida (accesible por los hijos)
        protected readonly string CadenaConexion;

        // ── CONSTRUCTOR: inicializa la cadena de conexión
        protected Conexion()
        {
            CadenaConexion = @"Server=.; Database=HotelPuntaCana; 
                               Integrated Security=True; TrustServerCertificate=True;";
        }

        // ── MÉTODO NORMAL: devuelve una nueva conexión SQL
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        public virtual bool PuedoConectarme()
        {
            try
            {
                using (var cn = ObtenerConexion())
                {
                    cn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public string ObtenerNombreServidor()
        {
            var builder = new SqlConnectionStringBuilder(CadenaConexion);
            return builder.DataSource;
        }
    }
}
