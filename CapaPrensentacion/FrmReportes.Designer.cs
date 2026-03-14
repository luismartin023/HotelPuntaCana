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
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnOcupacion
            // 
            btnOcupacion.BackColor = Color.Orange;
            btnOcupacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOcupacion.Location = new Point(130, 637);
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
            btnIngresos.Location = new Point(368, 691);
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
            dgvReportes.Location = new Point(24, 81);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(916, 520);
            dgvReportes.TabIndex = 2;
            dgvReportes.CellContentClick += dgvReportes_CellContentClick;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(908, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnTodasReservas
            // 
            btnTodasReservas.BackColor = Color.Orange;
            btnTodasReservas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodasReservas.Location = new Point(607, 637);
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
            cmbCanalFiltro.Location = new Point(395, 661);
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
            label1.Location = new Point(366, 629);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 19;
            label1.Text = "SELECIONA UN CANAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGoldenrod;
            label6.Location = new Point(252, 12);
            label6.Name = "label6";
            label6.Size = new Size(475, 50);
            label6.TabIndex = 20;
            label6.Text = "Hotel Punta Cana";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(970, 750);
            Controls.Add(label6);
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
            Load += FrmReportes_Load;
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
        private Label label6;
    }
}