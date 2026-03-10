namespace CapaPrensentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnIrReservas_Click(object sender, EventArgs e)
        {
            FrmReservas formReservas = new FrmReservas();
            formReservas.ShowDialog();
        }

        private void btnIrReportes_Click(object sender, EventArgs e)
        {
            FrmReportes formReportes = new FrmReportes();
            formReportes.ShowDialog();
        }

        //Boton para salir o cerrar la aplicación
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para volver al estado original y maximizar la aplicación
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        //Boton para minimizar la aplicación
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //llama al formulario de pagos
        private void btnIrPagos_Click(object sender, EventArgs e)
        {
            FrmPagos formPagos = new FrmPagos();
            formPagos.ShowDialog();
        }
    }
}
