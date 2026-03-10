using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Pago : Conexion
    {
        // 1. Buscamos las reservas para elegirlas en una lista
        public DataTable ObtenerReservasParaPago()
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                // Solo trae las reservas que NO tienen un registro en la tabla Pago
                string query = @"SELECT R.IdReserva, 
                                 CONCAT('Reserva #', R.IdReserva, ' - Hab: ', Hab.NumeroHabitacion, ' (', R.Canal, ')') AS Detalle
                                 FROM Reserva R
                                 INNER JOIN Habitacion Hab ON R.IdHabitacion = Hab.IdHabitacion
                                 WHERE R.Estado IN ('Confirmada', 'Pendiente')
                                 AND R.IdReserva NOT IN (SELECT IdReserva FROM Pago)";
                using (var comando = new SqlCommand(query, conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // 2. Insertamos el pago en la base de datos
        public string RegistrarPago(int idReserva, decimal monto, string metodoPago)
        {
            using (var conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Pago (IdReserva, FechaPago, Monto, MetodoPago) VALUES (@IdReserva, GETDATE(), @Monto, @MetodoPago)";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdReserva", idReserva);
                        comando.Parameters.AddWithValue("@Monto", monto);
                        comando.Parameters.AddWithValue("@MetodoPago", metodoPago);
                        comando.ExecuteNonQuery();

                        return "Pago registrado correctamente. El reporte de ingresos ha sido actualizado.";
                    }
                }
                catch (Exception ex)
                {
                    return "Error al registrar pago: " + ex.Message;
                }
            }
        }

        // método para busca los detalles y calcula el total de la reserva
        public DataTable ObtenerDetalleFactura(int idReserva)
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                // Usamos DATEDIFF para calcular los días entre la entrada y la salida
                string query = @"SELECT 
                                    H.Nombre + ' ' + H.Apellido AS Cliente,
                                    Hab.NumeroHabitacion AS Habitacion,
                                    DATEDIFF(day, R.FechaEntrada, R.FechaSalida) AS Noches,
                                    TH.PrecioPorNoche AS Precio,
                                    (DATEDIFF(day, R.FechaEntrada, R.FechaSalida) * TH.PrecioPorNoche) AS TotalPagar
                                 FROM Reserva R
                                 INNER JOIN Habitacion Hab ON R.IdHabitacion = Hab.IdHabitacion
                                 INNER JOIN TipoHabitacion TH ON Hab.IdTipoHabitacion = TH.IdTipoHabitacion
                                 INNER JOIN Huesped H ON R.IdHuesped = H.IdHuesped
                                 WHERE R.IdReserva = @IdReserva";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdReserva", idReserva);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
