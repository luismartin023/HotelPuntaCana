namespace CapaPrensentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void CargarFormulario(Form formulario)
        {
            panel1.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();
        }

        private void btnIrReservas_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmReservas());
        }

        private void btnIrReportes_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmReportes());
        }

        private void btnIrPagos_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmPagos());
        }

        // Botón cerrar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botón maximizar/restaurar
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        // Botón minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
