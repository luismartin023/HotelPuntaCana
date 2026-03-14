using CapaNegocios;


namespace CapaPrensentacion
{
    public partial class FrmReportes : Form
    {
        private CN_Reportes objCN_Reportes = new CN_Reportes();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnOcupacion_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Reporte General (Año y Mes)
                dgvReportes.DataSource = objCN_Reportes.OcupacionGeneral();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            try
            {
                // 2. Reporte desplegable por Canal
                if (string.IsNullOrEmpty(cmbCanalFiltro.Text))
                {
                    MessageBox.Show("Mi amor, por favor selecciona un canal de la lista primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string canalSeleccionado = cmbCanalFiltro.Text;
                dgvReportes.DataSource = objCN_Reportes.DetallesPorCanal(canalSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTodasReservas_Click(object sender, EventArgs e)
        {
            try
            {
                // 3. Todas las reservas con estado de pago
                dgvReportes.DataSource = objCN_Reportes.VerTodasLasReservas();

                Reserva reserva = new Reserva();
                MessageBox.Show("Reporte cargado. " + reserva.ObtenerDescripcion(),"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
