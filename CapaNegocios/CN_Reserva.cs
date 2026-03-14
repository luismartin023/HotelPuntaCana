using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Reserva
    {
        // Instanciamos la clase de la Capa de Datos
        private CD_Reserva objCapaDatos = new CD_Reserva();

        public string CrearReserva(int idHabitacion, int idHuesped, DateTime fechaEntrada, DateTime fechaSalida, string canal)
        {
            Reserva reserva = new Reserva(0, idHabitacion, idHuesped,
                                          fechaEntrada, fechaSalida, canal, "Pendiente");
            if (!reserva.Validar())
                return "Datos incompletos. Verifica los campos.";

            return objCapaDatos.CrearReserva(idHabitacion, idHuesped, fechaEntrada, fechaSalida, canal);
        }

        public DataTable ObtenerHabitaciones()
        {
            return objCapaDatos.ObtenerHabitaciones();
        }

        public DataTable ObtenerHuespedes()
        {
            return objCapaDatos.ObtenerHuespedes();
        }
    }
}
