namespace CapaPrensentacion
{
    partial class FrmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagos));
            cmbReserva = new ComboBox();
            txtMonto = new TextBox();
            cmbMetodoPago = new ComboBox();
            btnPagar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            lblTotalInfo = new Label();
            lblPrecioInfo = new Label();
            lblNochesInfo = new Label();
            lblClienteInfo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cmbReserva
            // 
            cmbReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReserva.FormattingEnabled = true;
            cmbReserva.Location = new Point(8, 66);
            cmbReserva.Name = "cmbReserva";
            cmbReserva.Size = new Size(231, 28);
            cmbReserva.TabIndex = 0;
            cmbReserva.SelectedIndexChanged += cmbReserva_SelectedIndexChanged;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(38, 150);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(151, 30);
            txtMonto.TabIndex = 1;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.Location = new Point(8, 230);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(231, 28);
            cmbMetodoPago.TabIndex = 2;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.LawnGreen;
            btnPagar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(225, 650);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(193, 50);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Registrar Pago";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbMetodoPago);
            panel1.Controls.Add(cmbReserva);
            panel1.Controls.Add(txtMonto);
            panel1.Location = new Point(12, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 313);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblTotalInfo);
            panel2.Controls.Add(lblPrecioInfo);
            panel2.Controls.Add(lblNochesInfo);
            panel2.Controls.Add(lblClienteInfo);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(255, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 259);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 222);
            label5.Name = "label5";
            label5.Size = new Size(235, 25);
            label5.TabIndex = 7;
            label5.Text = "GRACIAS POR ELEGIRNOS";
            // 
            // lblTotalInfo
            // 
            lblTotalInfo.AutoSize = true;
            lblTotalInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInfo.Location = new Point(3, 173);
            lblTotalInfo.Name = "lblTotalInfo";
            lblTotalInfo.Size = new Size(84, 25);
            lblTotalInfo.TabIndex = 8;
            lblTotalInfo.Text = "TOTAL: -";
            // 
            // lblPrecioInfo
            // 
            lblPrecioInfo.AutoSize = true;
            lblPrecioInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioInfo.Location = new Point(3, 128);
            lblPrecioInfo.Name = "lblPrecioInfo";
            lblPrecioInfo.Size = new Size(173, 25);
            lblPrecioInfo.TabIndex = 7;
            lblPrecioInfo.Text = "Precio por noche: -";
            // 
            // lblNochesInfo
            // 
            lblNochesInfo.AutoSize = true;
            lblNochesInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNochesInfo.Location = new Point(3, 94);
            lblNochesInfo.Name = "lblNochesInfo";
            lblNochesInfo.Size = new Size(92, 25);
            lblNochesInfo.TabIndex = 6;
            lblNochesInfo.Text = "Noches: -";
            // 
            // lblClienteInfo
            // 
            lblClienteInfo.AutoSize = true;
            lblClienteInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteInfo.Location = new Point(3, 59);
            lblClienteInfo.Name = "lblClienteInfo";
            lblClienteInfo.Size = new Size(88, 25);
            lblClienteInfo.TabIndex = 5;
            lblClienteInfo.Text = "Cliente: -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 11);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 4;
            label4.Text = "FACTURA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 200);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 5;
            label3.Text = "Metodo De Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 115);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 4;
            label2.Text = "Monto A Pagar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 38);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 3;
            label1.Text = "Cliente/Reserva";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGoldenrod;
            label6.Location = new Point(88, 184);
            label6.Name = "label6";
            label6.Size = new Size(475, 50);
            label6.TabIndex = 13;
            label6.Text = "Hotel Punta Cana";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(164, 259);
            label7.Name = "label7";
            label7.Size = new Size(301, 30);
            label7.TabIndex = 14;
            label7.Text = "REALICE EL PAGO AQUI";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(591, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 746);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnPagar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagos";
            Text = "Hotel";
            Load += FrmPagos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbReserva;
        private TextBox txtMonto;
        private ComboBox cmbMetodoPago;
        private Button btnPagar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label label5;
        private Label lblTotalInfo;
        private Label lblPrecioInfo;
        private Label lblNochesInfo;
        private Label lblClienteInfo;
        private Label label4;
    }
}