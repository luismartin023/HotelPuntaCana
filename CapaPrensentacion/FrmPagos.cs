using CapaNegocios;
using System.Data;

namespace CapaPrensentacion
{
    public partial class FrmPagos : Form
    {
        private CN_Pago objCN_Pago = new CN_Pago();
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void cmbReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReserva.SelectedValue != null && cmbReserva.SelectedValue is int)
            {
                try
                {
                    int idReserva = (int)cmbReserva.SelectedValue;

                    DataTable dtInfo = objCN_Pago.ObtenerDetalleFactura(idReserva);

                    if (dtInfo.Rows.Count > 0)
                    {
                        // Sacamos el total en formato matemático puro
                        decimal totalPagar = Convert.ToDecimal(dtInfo.Rows[0]["TotalPagar"]);

                        // Le damos el formato hermoso con "RD $ " y comas (N2 = Number con 2 decimales)
                        string totalFormateado = "RD $ " + totalPagar.ToString("N2");

                        lblClienteInfo.Text = "Cliente: " + dtInfo.Rows[0]["Cliente"].ToString();
                        lblNochesInfo.Text = "Noches: " + dtInfo.Rows[0]["Noches"].ToString();

                        Pago pago = new Pago(0, (int)cmbReserva.SelectedValue,DateTime.Today, totalPagar, "");

                        // Formateamos también el precio por noche para que combine
                        decimal precioNoche = Convert.ToDecimal(dtInfo.Rows[0]["Precio"]);
                        lblPrecioInfo.Text = "Precio p/n: RD $ " + precioNoche.ToString("N2");

                        // Mostramos la belleza en pantalla
                        lblTotalInfo.Text = "TOTAL A PAGAR: " + totalFormateado;
                        txtMonto.Text = totalFormateado;

                        // Guardamos el decimal puro escondido en el Tag del TextBox
                        txtMonto.Tag = totalPagar;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los detalles: " + ex.Message);
                }
            }
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenar el ComboBox de Reservas al abrir
                cmbReserva.DataSource = objCN_Pago.ObtenerReservasParaPago();
                cmbReserva.DisplayMember = "Detalle";
                cmbReserva.ValueMember = "IdReserva";
                cmbReserva.SelectedIndex = -1; // Que arranque vacío
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReserva.SelectedIndex == -1 || string.IsNullOrEmpty(cmbMetodoPago.Text) || string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Por favor, selecciona una reserva y un método de pago antes de cobrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idReserva = Convert.ToInt32(cmbReserva.SelectedValue);

                // leemos el Tag (que tiene el número puro)
                decimal monto = Convert.ToDecimal(txtMonto.Tag);

                string metodoPago = cmbMetodoPago.Text;

                string respuesta = objCN_Pago.RegistrarPago(idReserva, monto, metodoPago);
                MessageBox.Show(respuesta, "Caja Registradora", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos todo
                cmbReserva.SelectedIndex = -1;
                txtMonto.Clear();
                txtMonto.Tag = null;
                cmbMetodoPago.SelectedIndex = -1;
                lblClienteInfo.Text = "Cliente: -";
                lblNochesInfo.Text = "Noches: -";
                lblPrecioInfo.Text = "Precio por noche: -";
                lblTotalInfo.Text = "TOTAL: -";

                // Refrescamos la lista de reservas al instante para que desaparezca la que acabamos de pagar
                cmbReserva.DataSource = objCN_Pago.ObtenerReservasParaPago();
                cmbReserva.DisplayMember = "Detalle";
                cmbReserva.ValueMember = "IdReserva";
                cmbReserva.SelectedIndex = -1; // Lo dejamos en blanco para el siguiente cliente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago. Detalle: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
