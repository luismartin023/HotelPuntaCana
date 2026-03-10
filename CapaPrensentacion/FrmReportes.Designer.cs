namespace CapaPrensentacion
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            btnOcupacion = new Button();
            btnIngresos = new Button();
            dgvReportes = new DataGridView();
            pictureBox3 = new PictureBox();
            btnTodasReservas = new Button();
            cmbCanalFiltro = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnOcupacion
            // 
            btnOcupacion.BackColor = Color.Orange;
            btnOcupacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOcupacion.Location = new Point(58, 419);
            btnOcupacion.Name = "btnOcupacion";
            btnOcupacion.Size = new Size(207, 37);
            btnOcupacion.TabIndex = 0;
            btnOcupacion.Text = "Reporte General";
            btnOcupacion.UseVisualStyleBackColor = false;
            btnOcupacion.Click += btnOcupacion_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.BackColor = Color.Orange;
            btnIngresos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresos.Location = new Point(296, 473);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(201, 37);
            btnIngresos.TabIndex = 1;
            btnIngresos.Text = "Ver Detalles de Canal";
            btnIngresos.UseVisualStyleBackColor = false;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.BackgroundColor = SystemColors.ActiveCaption;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.GridColor = Color.RosyBrown;
            dgvReportes.Location = new Point(58, 56);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(678, 346);
            dgvReportes.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(738, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnTodasReservas
            // 
            btnTodasReservas.BackColor = Color.Orange;
            btnTodasReservas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodasReservas.Location = new Point(535, 419);
            btnTodasReservas.Name = "btnTodasReservas";
            btnTodasReservas.Size = new Size(201, 37);
            btnTodasReservas.TabIndex = 17;
            btnTodasReservas.Text = "Ver Todas las Reservas";
            btnTodasReservas.UseVisualStyleBackColor = false;
            btnTodasReservas.Click += btnTodasReservas_Click;
            // 
            // cmbCanalFiltro
            // 
            cmbCanalFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCanalFiltro.FormattingEnabled = true;
            cmbCanalFiltro.Items.AddRange(new object[] { "Booking", "Expedia", "Directo" });
            cmbCanalFiltro.Location = new Point(323, 439);
            cmbCanalFiltro.Name = "cmbCanalFiltro";
            cmbCanalFiltro.Size = new Size(151, 28);
            cmbCanalFiltro.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(292, 411);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 19;
            label1.Text = "SELECIONA UN CANAL";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(792, 514);
            Controls.Add(label1);
            Controls.Add(cmbCanalFiltro);
            Controls.Add(btnTodasReservas);
            Controls.Add(pictureBox3);
            Controls.Add(dgvReportes);
            Controls.Add(btnIngresos);
            Controls.Add(btnOcupacion);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOcupacion;
        private Button btnIngresos;
        private DataGridView dgvReportes;
        private PictureBox pictureBox3;
        private Button btnTodasReservas;
        private ComboBox cmbCanalFiltro;
        private Label label1;
    }
}