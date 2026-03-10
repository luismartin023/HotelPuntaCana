using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Reportes : Conexion
    {
        // 1. REPORTE GENERAL (Ver por Año y Mes)
        public DataTable OcupacionGeneral()
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = @"SELECT 
                                    YEAR(FechaEntrada) AS [Año],
                                    CASE MONTH(FechaEntrada)
                                        WHEN 1 THEN 'Enero' WHEN 2 THEN 'Febrero' WHEN 3 THEN 'Marzo'
                                        WHEN 4 THEN 'Abril' WHEN 5 THEN 'Mayo' WHEN 6 THEN 'Junio'
                                        WHEN 7 THEN 'Julio' WHEN 8 THEN 'Agosto' WHEN 9 THEN 'Septiembre'
                                        WHEN 10 THEN 'Octubre' WHEN 11 THEN 'Noviembre' WHEN 12 THEN 'Diciembre'
                                    END AS [Mes], 
                                    COUNT(*) AS [Cantidad de Reservas] 
                                 FROM Reserva 
                                 GROUP BY YEAR(FechaEntrada), MONTH(FechaEntrada)
                                 ORDER BY [Año] DESC, MONTH(FechaEntrada) DESC";
                using (var comando = new SqlCommand(query, conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // 2. REPORTE DESPLEGABLE POR CANAL
        public DataTable DetallesPorCanal(string canal)
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = @"SELECT 
                                    Hab.NumeroHabitacion AS [Habitación],
                                    H.Nombre + ' ' + H.Apellido AS [Cliente],
                                    R.FechaEntrada AS [Entrada],
                                    DATEDIFF(day, R.FechaEntrada, R.FechaSalida) AS [Noches],
                                    ISNULL(P.Monto, 0) AS [Monto Pagado (RD$)]
                                 FROM Reserva R
                                 INNER JOIN Habitacion Hab ON R.IdHabitacion = Hab.IdHabitacion
                                 INNER JOIN Huesped H ON R.IdHuesped = H.IdHuesped
                                 LEFT JOIN Pago P ON R.IdReserva = P.IdReserva
                                 WHERE R.Canal = @Canal";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Canal", canal);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // 3. REPORTE DE TODAS LAS RESERVAS (Con estado real de pago)
        public DataTable VerTodasLasReservas()
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = @"SELECT 
                                    R.IdReserva AS [No. Reserva],
                                    H.Nombre + ' ' + H.Apellido AS [Huésped],
                                    Hab.NumeroHabitacion AS [Habitación],
                                    R.FechaEntrada AS [Entrada],
                                    R.Canal,
                                    CASE 
                                        WHEN P.IdPago IS NOT NULL THEN 'PAGADA' 
                                        ELSE 'PENDIENTE DE PAGO' 
                                    END AS [Estado Financiero],
                                    ISNULL(P.Monto, 0) AS [Monto Pagado]
                                 FROM Reserva R
                                 INNER JOIN Huesped H ON R.IdHuesped = H.IdHuesped
                                 INNER JOIN Habitacion Hab ON R.IdHabitacion = Hab.IdHabitacion
                                 LEFT JOIN Pago P ON R.IdReserva = P.IdReserva
                                 ORDER BY R.IdReserva DESC";
                using (var comando = new SqlCommand(query, conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
