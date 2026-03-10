using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Reserva : Conexion
    {
        public string CrearReserva(int idHabitacion, int idHuesped, DateTime fechaEntrada, DateTime fechaSalida, string canal)
        {
            using (var conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (var comando = new SqlCommand("sp_CrearReserva", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                        comando.Parameters.AddWithValue("@IdHuesped", idHuesped);
                        comando.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);
                        comando.Parameters.AddWithValue("@FechaSalida", fechaSalida);
                        comando.Parameters.AddWithValue("@Canal", canal);

                        comando.ExecuteNonQuery();
                        return "Reserva creada con éxito";
                    }
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
        }

        public DataTable ObtenerHabitaciones()
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT IdHabitacion, CONCAT('Hab: ', NumeroHabitacion) AS Numero FROM Habitacion", conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable ObtenerHuespedes()
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT IdHuesped, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM Huesped", conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

    }
}
