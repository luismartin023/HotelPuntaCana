using CapaNegocios;

namespace CapaPrensentacion
{
    public partial class FrmLogin : Form
    {
        private CN_Usuario _cnUsuario = new CN_Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
               string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Completa usuario y contraseña.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_cnUsuario.Login(txtUsuario.Text, txtClave.Text))
            {
                FrmMenu menu = new FrmMenu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtClave.Focus();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
