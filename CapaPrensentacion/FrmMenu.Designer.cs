namespace CapaPrensentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            label1 = new Label();
            btnIrReservas = new Button();
            btnIrReportes = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnIrPagos = new Button();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(563, 45);
            label1.Name = "label1";
            label1.Size = new Size(475, 50);
            label1.TabIndex = 0;
            label1.Text = "Hotel Punta Cana";
            // 
            // btnIrReservas
            // 
            btnIrReservas.BackColor = Color.FromArgb(255, 128, 0);
            btnIrReservas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrReservas.Location = new Point(21, 332);
            btnIrReservas.Name = "btnIrReservas";
            btnIrReservas.Size = new Size(246, 75);
            btnIrReservas.TabIndex = 1;
            btnIrReservas.Text = "Módulo de Reservas";
            btnIrReservas.UseVisualStyleBackColor = false;
            btnIrReservas.Click += btnIrReservas_Click;
            // 
            // btnIrReportes
            // 
            btnIrReportes.BackColor = Color.Silver;
            btnIrReportes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrReportes.Location = new Point(21, 477);
            btnIrReportes.Name = "btnIrReportes";
            btnIrReportes.Size = new Size(246, 74);
            btnIrReportes.TabIndex = 2;
            btnIrReportes.Text = "Módulo de Reportes";
            btnIrReportes.UseVisualStyleBackColor = false;
            btnIrReportes.Click += btnIrReportes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1137, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1249, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1193, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btnIrPagos
            // 
            btnIrPagos.BackColor = Color.FromArgb(0, 192, 0);
            btnIrPagos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrPagos.Location = new Point(21, 612);
            btnIrPagos.Name = "btnIrPagos";
            btnIrPagos.Size = new Size(246, 75);
            btnIrPagos.TabIndex = 7;
            btnIrPagos.Text = "Modulo De Pagos";
            btnIrPagos.UseVisualStyleBackColor = false;
            btnIrPagos.Click += btnIrPagos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(312, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 750);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-4, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1536, 1024);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 953);
            Controls.Add(panel1);
            Controls.Add(btnIrPagos);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnIrReportes);
            Controls.Add(btnIrReservas);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            Text = "Hotel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIrReservas;
        private Button btnIrReportes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnIrPagos;
        private Panel panel1;
        private PictureBox pictureBox5;
    }
}