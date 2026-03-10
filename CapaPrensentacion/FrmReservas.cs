using CapaNegocios;

namespace CapaPrensentacion
{
    public partial class FrmReservas : Form
    {
        // Instanciamos la Capa de Negocio
        private CN_Reserva objCN_Reserva = new CN_Reserva();
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e) 
        {
            try
            {
                // 1. Llenamos las Habitaciones
                cmbHabitacion.DataSource = objCN_Reserva.ObtenerHabitaciones();
                cmbHabitacion.DisplayMember = "Numero"; 
                cmbHabitacion.ValueMember = "IdHabitacion"; 

                // 2. Llenamos los Huéspedes
                cmbHuesped.DataSource = objCN_Reserva.ObtenerHuespedes();
                cmbHuesped.DisplayMember = "NombreCompleto"; 
                cmbHuesped.ValueMember = "IdHuesped";

                // 3. Llenamos el Canal (Por si no lo hiciste manual en las propiedades)
                cmbCanal.Items.Clear();
                cmbCanal.Items.Add("Booking");
                cmbCanal.Items.Add("Expedia");
                cmbCanal.Items.Add("Directo");

                // Dejamos todo en blanco al principio
                cmbHabitacion.SelectedIndex = -1;
                cmbHuesped.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los IDs reales (ValueMember) 
                int idHabitacion = Convert.ToInt32(cmbHabitacion.SelectedValue);
                int idHuesped = Convert.ToInt32(cmbHuesped.SelectedValue);
                DateTime fechaEntrada = dtpEntrada.Value.Date;
                DateTime fechaSalida = dtpSalida.Value.Date;
                string canal = cmbCanal.Text;

                // Llamamos a la validación de Overbooking y creación
                string respuesta = objCN_Reserva.CrearReserva(idHabitacion, idHuesped, fechaEntrada, fechaSalida, canal);

                if (respuesta == "Reserva creada con éxito")
                {
                    MessageBox.Show(respuesta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbHabitacion.SelectedIndex = -1;
                    cmbHuesped.SelectedIndex = -1;
                    cmbCanal.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(respuesta, "Alerta de Overbooking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, verifica que todos los campos estén llenos correctamente. Detalle: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
