namespace CapaPrensentacion
{
    partial class FrmReservas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservas));
            cmbHabitacion = new ComboBox();
            cmbHuesped = new ComboBox();
            cmbCanal = new ComboBox();
            dtpEntrada = new DateTimePicker();
            dtpSalida = new DateTimePicker();
            btnCrearReserva = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cmbHabitacion
            // 
            cmbHabitacion.BackColor = SystemColors.HighlightText;
            cmbHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHabitacion.FormattingEnabled = true;
            cmbHabitacion.Location = new Point(75, 66);
            cmbHabitacion.Name = "cmbHabitacion";
            cmbHabitacion.Size = new Size(151, 28);
            cmbHabitacion.TabIndex = 0;
            // 
            // cmbHuesped
            // 
            cmbHuesped.BackColor = SystemColors.Control;
            cmbHuesped.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHuesped.FormattingEnabled = true;
            cmbHuesped.Location = new Point(75, 148);
            cmbHuesped.Name = "cmbHuesped";
            cmbHuesped.Size = new Size(151, 28);
            cmbHuesped.TabIndex = 1;
            // 
            // cmbCanal
            // 
            cmbCanal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCanal.FormattingEnabled = true;
            cmbCanal.Items.AddRange(new object[] { "Booking", "Expedia", "Directo" });
            cmbCanal.Location = new Point(75, 223);
            cmbCanal.Name = "cmbCanal";
            cmbCanal.Size = new Size(151, 28);
            cmbCanal.TabIndex = 2;
            // 
            // dtpEntrada
            // 
            dtpEntrada.CalendarForeColor = SystemColors.ActiveCaptionText;
            dtpEntrada.CalendarMonthBackground = SystemColors.HighlightText;
            dtpEntrada.Location = new Point(406, 43);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(273, 27);
            dtpEntrada.TabIndex = 3;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(406, 136);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(273, 27);
            dtpSalida.TabIndex = 4;
            // 
            // btnCrearReserva
            // 
            btnCrearReserva.BackColor = Color.Orange;
            btnCrearReserva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearReserva.Location = new Point(457, 212);
            btnCrearReserva.Name = "btnCrearReserva";
            btnCrearReserva.Size = new Size(151, 48);
            btnCrearReserva.TabIndex = 5;
            btnCrearReserva.Text = "Confirmar Reserva";
            btnCrearReserva.UseVisualStyleBackColor = false;
            btnCrearReserva.Click += btnCrearReserva_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "Habitación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 112);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Huésped";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 191);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 8;
            label3.Text = "Canal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(513, 20);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 9;
            label4.Text = "Entrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(513, 112);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "Salida";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGoldenrod;
            label6.Location = new Point(255, 77);
            label6.Name = "label6";
            label6.Size = new Size(475, 50);
            label6.TabIndex = 12;
            label6.Text = "Hotel Punta Cana";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(396, 258);
            label7.Name = "label7";
            label7.Size = new Size(196, 30);
            label7.TabIndex = 13;
            label7.Text = "RESERVA AQUI";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(cmbHabitacion);
            panel1.Controls.Add(cmbHuesped);
            panel1.Controls.Add(cmbCanal);
            panel1.Controls.Add(dtpEntrada);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpSalida);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCrearReserva);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(122, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 288);
            panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(898, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(970, 750);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReservas";
            Text = "Hotel";
            Load += FrmReservas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbHabitacion;
        private ComboBox cmbHuesped;
        private ComboBox cmbCanal;
        private DateTimePicker dtpEntrada;
        private DateTimePicker dtpSalida;
        private Button btnCrearReserva;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}
