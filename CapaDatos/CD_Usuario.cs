using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuario : Conexion
    {
        // ── Autentica con el Procedure sp_Login
        public DataTable Login(string usuario, string clave)
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = new SqlCommand("sp_Login", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Clave", clave);
                    new SqlDataAdapter(cmd).Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
