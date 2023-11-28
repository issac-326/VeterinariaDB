namespace ProyectoBD
{
    partial class Citas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            txtFechaFinal = new TextBox();
            txtFechaInicio = new TextBox();
            selEstadoCitas = new ComboBox();
            txtFechaCita = new DateTimePicker();
            selMascotaCita = new ComboBox();
            selEmpleadoCitas = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            citasBindingSource = new BindingSource(components);
            btnVolver = new Button();
            btnAgregarCitas = new Button();
            btnModificarCitas = new Button();
            btnLimpiarCitas = new Button();
            gestionMascotasBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)citasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gestionMascotasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFechaFinal);
            groupBox1.Controls.Add(txtFechaInicio);
            groupBox1.Controls.Add(selEstadoCitas);
            groupBox1.Controls.Add(txtFechaCita);
            groupBox1.Controls.Add(selMascotaCita);
            groupBox1.Controls.Add(selEmpleadoCitas);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(2, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 262);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario de Citas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(598, 146);
            label8.Name = "label8";
            label8.Size = new Size(164, 17);
            label8.TabIndex = 13;
            label8.Text = "yyyy/MM/dd hh:mm:ss";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(518, 146);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 12;
            label7.Text = "Formato:";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaFinal.Location = new Point(517, 104);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(245, 27);
            txtFechaFinal.TabIndex = 11;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaInicio.Location = new Point(517, 45);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(245, 27);
            txtFechaInicio.TabIndex = 10;
            txtFechaInicio.TextChanged += txtFechaInicio_TextChanged;
            // 
            // selEstadoCitas
            // 
            selEstadoCitas.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            selEstadoCitas.FormattingEnabled = true;
            selEstadoCitas.Location = new Point(179, 214);
            selEstadoCitas.Name = "selEstadoCitas";
            selEstadoCitas.Size = new Size(219, 28);
            selEstadoCitas.TabIndex = 9;
            // 
            // txtFechaCita
            // 
            txtFechaCita.CustomFormat = "";
            txtFechaCita.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaCita.Location = new Point(128, 161);
            txtFechaCita.Name = "txtFechaCita";
            txtFechaCita.Size = new Size(187, 27);
            txtFechaCita.TabIndex = 8;
            txtFechaCita.ValueChanged += txtFechaCita_ValueChanged;
            // 
            // selMascotaCita
            // 
            selMascotaCita.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            selMascotaCita.FormattingEnabled = true;
            selMascotaCita.Location = new Point(128, 104);
            selMascotaCita.Name = "selMascotaCita";
            selMascotaCita.Size = new Size(186, 28);
            selMascotaCita.TabIndex = 7;
            // 
            // selEmpleadoCitas
            // 
            selEmpleadoCitas.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            selEmpleadoCitas.FormattingEnabled = true;
            selEmpleadoCitas.Location = new Point(128, 48);
            selEmpleadoCitas.Name = "selEmpleadoCitas";
            selEmpleadoCitas.Size = new Size(186, 28);
            selEmpleadoCitas.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(353, 107);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 5;
            label6.Text = "Fecha/Hora Fin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(353, 48);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha/Hora Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 217);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 3;
            label4.Text = "Estado de la Cita:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 166);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 107);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Mascota:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 51);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(759, 241);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // citasBindingSource
            // 
            citasBindingSource.DataSource = typeof(Citas);
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVolver.BackColor = Color.Red;
            btnVolver.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(625, 581);
            btnVolver.Name = "btnVolver";
            btnVolver.Padding = new Padding(10, 11, 25, 11);
            btnVolver.Size = new Size(145, 55);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregarCitas
            // 
            btnAgregarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarCitas.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarCitas.Image = (Image)resources.GetObject("btnAgregarCitas.Image");
            btnAgregarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCitas.Location = new Point(10, 581);
            btnAgregarCitas.Name = "btnAgregarCitas";
            btnAgregarCitas.Padding = new Padding(10, 11, 25, 11);
            btnAgregarCitas.Size = new Size(173, 55);
            btnAgregarCitas.TabIndex = 8;
            btnAgregarCitas.Text = "Agregar";
            btnAgregarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarCitas.UseVisualStyleBackColor = false;
            btnAgregarCitas.Click += btnAgregarCitas_Click;
            // 
            // btnModificarCitas
            // 
            btnModificarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificarCitas.BackColor = Color.FromArgb(255, 128, 0);
            btnModificarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnModificarCitas.Image = (Image)resources.GetObject("btnModificarCitas.Image");
            btnModificarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarCitas.Location = new Point(221, 581);
            btnModificarCitas.Name = "btnModificarCitas";
            btnModificarCitas.Padding = new Padding(10, 11, 25, 11);
            btnModificarCitas.Size = new Size(178, 55);
            btnModificarCitas.TabIndex = 9;
            btnModificarCitas.Text = "Modificar";
            btnModificarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnModificarCitas.UseVisualStyleBackColor = false;
            btnModificarCitas.Click += btnModificarCitas_Click;
            // 
            // btnLimpiarCitas
            // 
            btnLimpiarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarCitas.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarCitas.Image = (Image)resources.GetObject("btnLimpiarCitas.Image");
            btnLimpiarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCitas.Location = new Point(432, 581);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(10, 11, 25, 11);
            btnLimpiarCitas.Size = new Size(154, 55);
            btnLimpiarCitas.TabIndex = 10;
            btnLimpiarCitas.Text = "Limpiar";
            btnLimpiarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCitas.UseVisualStyleBackColor = false;
            btnLimpiarCitas.Click += btnLimpiarCitas_Click;
            // 
            // gestionMascotasBindingSource
            // 
            gestionMascotasBindingSource.DataSource = typeof(GestionMascotas);
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 653);
            Controls.Add(btnLimpiarCitas);
            Controls.Add(btnModificarCitas);
            Controls.Add(btnAgregarCitas);
            Controls.Add(btnVolver);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Citas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += Citas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)citasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gestionMascotasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox selMascotaCita;
        private ComboBox selEmpleadoCitas;
        private ComboBox selEstadoCitas;
        private DateTimePicker txtFechaCita;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private Button btnVolver;
        private Button btnAgregarCitas;
        private Button btnModificarCitas;
        private Button btnLimpiarCitas;
        private BindingSource citasBindingSource;
        private BindingSource gestionMascotasBindingSource;
        private TextBox txtFechaFinal;
        private TextBox txtFechaInicio;
        private Label label8;
        private Label label7;
    }
}