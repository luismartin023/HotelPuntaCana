using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Reportes
    {
        private CD_Reportes objCD_Reportes = new CD_Reportes();
        public DataTable OcupacionGeneral()
        {
            return objCD_Reportes.OcupacionGeneral();
        }

        public DataTable DetallesPorCanal(string canal)
        {
            return objCD_Reportes.DetallesPorCanal(canal);
        }

        public DataTable VerTodasLasReservas()
        {
            return objCD_Reportes.VerTodasLasReservas();
        }
    }
}
