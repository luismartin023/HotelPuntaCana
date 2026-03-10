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
            return objCD_Pago.RegistrarPago(idReserva, monto, metodoPago);
        }

        public DataTable ObtenerDetalleFactura(int idReserva)
        {
            return objCD_Pago.ObtenerDetalleFactura(idReserva);
        }
    }
}
