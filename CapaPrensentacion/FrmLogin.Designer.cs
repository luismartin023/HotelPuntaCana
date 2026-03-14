namespace CapaPrensentacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnIngresar = new Button();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(155, 401);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(126, 473);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(104, 23);
            lblClave.TabIndex = 1;
            lblClave.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(236, 401);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(175, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(236, 472);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(175, 27);
            txtClave.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(458, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LawnGreen;
            btnIngresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(188, 532);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(164, 68);
            btnIngresar.TabIndex = 18;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(110, 328);
            label7.Name = "label7";
            label7.Size = new Size(301, 30);
            label7.TabIndex = 20;
            label7.Text = "REALICE EL PAGO AQUI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGoldenrod;
            label6.Location = new Point(33, 251);
            label6.Name = "label6";
            label6.Size = new Size(475, 50);
            label6.TabIndex = 19;
            label6.Text = "Hotel Punta Cana";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(536, 647);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnIngresar;
        private Label label7;
        private Label label6;
    }
}