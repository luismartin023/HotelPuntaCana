using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Pago
    {
        private CD_Pago objCD_Pago = new CD_Pago();

        public DataTable ObtenerReservasParaPago()
        {
            return objCD_Pago.ObtenerReservasParaPago();
        }

        public string RegistrarPago(int idReserva, decimal monto, string metodoPago)
        {
            Pago pago = new Pago(0, idReserva, DateTime.Today, monto, metodoPago);
            if (!pago.Validar())
                return "Datos del pago incorrectos. Verifica los campos.";

            return objCD_Pago.RegistrarPago(idReserva, monto, metodoPago);
        }

        public DataTable ObtenerDetalleFactura(int idReserva)
        {
            return objCD_Pago.ObtenerDetalleFactura(idReserva);
        }

        // Método que usa CalcularNoches y MontoFormateado
        public string ObtenerResumenPago(int idReserva, decimal monto, string metodoPago)
        {
            Pago pago = new Pago(0, idReserva, DateTime.Today, monto, metodoPago);
            return pago.ObtenerResumen(); // Método abstracto implementado
        }
    }
}
