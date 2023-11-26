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
            txtFechaFin = new DateTimePicker();
            txtFechaInicio = new DateTimePicker();
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
            button1 = new Button();
            btnEliminarCitas = new Button();
            btnAgregarCitas = new Button();
            btnModificarCitas = new Button();
            btnLimpiarCitas = new Button();
            citasBindingSource = new BindingSource(components);
            gestionMascotasBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)citasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gestionMascotasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFechaFin);
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
            groupBox1.Location = new Point(10, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(929, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario de Citas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtFechaFin
            // 
            txtFechaFin.CustomFormat = "";
            txtFechaFin.Location = new Point(598, 121);
            txtFechaFin.Margin = new Padding(3, 2, 3, 2);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(264, 24);
            txtFechaFin.TabIndex = 11;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(598, 80);
            txtFechaInicio.Margin = new Padding(3, 2, 3, 2);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(264, 24);
            txtFechaInicio.TabIndex = 10;
            // 
            // selEstadoCitas
            // 
            selEstadoCitas.FormattingEnabled = true;
            selEstadoCitas.Location = new Point(598, 36);
            selEstadoCitas.Margin = new Padding(3, 2, 3, 2);
            selEstadoCitas.Name = "selEstadoCitas";
            selEstadoCitas.Size = new Size(264, 24);
            selEstadoCitas.TabIndex = 9;
            // 
            // txtFechaCita
            // 
            txtFechaCita.CustomFormat = "";
            txtFechaCita.Enabled = false;
            txtFechaCita.Location = new Point(135, 121);
            txtFechaCita.Margin = new Padding(3, 2, 3, 2);
            txtFechaCita.Name = "txtFechaCita";
            txtFechaCita.Size = new Size(236, 24);
            txtFechaCita.TabIndex = 8;
            txtFechaCita.ValueChanged += txtFechaCita_ValueChanged;
            // 
            // selMascotaCita
            // 
            selMascotaCita.FormattingEnabled = true;
            selMascotaCita.Location = new Point(135, 78);
            selMascotaCita.Margin = new Padding(3, 2, 3, 2);
            selMascotaCita.Name = "selMascotaCita";
            selMascotaCita.Size = new Size(235, 24);
            selMascotaCita.TabIndex = 7;
            // 
            // selEmpleadoCitas
            // 
            selEmpleadoCitas.FormattingEnabled = true;
            selEmpleadoCitas.Location = new Point(135, 36);
            selEmpleadoCitas.Margin = new Padding(3, 2, 3, 2);
            selEmpleadoCitas.Name = "selEmpleadoCitas";
            selEmpleadoCitas.Size = new Size(235, 24);
            selEmpleadoCitas.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 126);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 5;
            label6.Text = "Fecha Final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 84);
            label5.Name = "label5";
            label5.Size = new Size(102, 17);
            label5.TabIndex = 4;
            label5.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 42);
            label4.Name = "label4";
            label4.Size = new Size(135, 17);
            label4.TabIndex = 3;
            label4.Text = "Estado de la Cita:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 126);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 84);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Mascota:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 188);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(918, 219);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(815, 425);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 8, 22, 8);
            button1.Size = new Size(121, 43);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCitas
            // 
            btnEliminarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarCitas.BackColor = Color.Red;
            btnEliminarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarCitas.Image = (Image)resources.GetObject("btnEliminarCitas.Image");
            btnEliminarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarCitas.Location = new Point(429, 425);
            btnEliminarCitas.Margin = new Padding(3, 2, 3, 2);
            btnEliminarCitas.Name = "btnEliminarCitas";
            btnEliminarCitas.Padding = new Padding(9, 8, 22, 8);
            btnEliminarCitas.Size = new Size(154, 43);
            btnEliminarCitas.TabIndex = 7;
            btnEliminarCitas.Text = "Eliminar";
            btnEliminarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarCitas.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCitas
            // 
            btnAgregarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarCitas.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarCitas.Image = (Image)resources.GetObject("btnAgregarCitas.Image");
            btnAgregarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCitas.Location = new Point(29, 425);
            btnAgregarCitas.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCitas.Name = "btnAgregarCitas";
            btnAgregarCitas.Padding = new Padding(9, 8, 22, 8);
            btnAgregarCitas.Size = new Size(154, 43);
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
            btnModificarCitas.Location = new Point(228, 425);
            btnModificarCitas.Margin = new Padding(3, 2, 3, 2);
            btnModificarCitas.Name = "btnModificarCitas";
            btnModificarCitas.Padding = new Padding(9, 8, 22, 8);
            btnModificarCitas.Size = new Size(154, 43);
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
            btnLimpiarCitas.Location = new Point(620, 425);
            btnLimpiarCitas.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(9, 8, 22, 8);
            btnLimpiarCitas.Size = new Size(154, 43);
            btnLimpiarCitas.TabIndex = 10;
            btnLimpiarCitas.Text = "Limpiar";
            btnLimpiarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCitas.UseVisualStyleBackColor = false;
            btnLimpiarCitas.Click += btnLimpiarCitas_Click;
            // 
            // citasBindingSource
            // 
            citasBindingSource.DataSource = typeof(Citas);
            // 
            // gestionMascotasBindingSource
            // 
            gestionMascotasBindingSource.DataSource = typeof(GestionMascotas);
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 489);
            Controls.Add(btnLimpiarCitas);
            Controls.Add(btnModificarCitas);
            Controls.Add(btnAgregarCitas);
            Controls.Add(btnEliminarCitas);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker txtFechaFin;
        private DateTimePicker txtFechaInicio;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnEliminarCitas;
        private Button btnAgregarCitas;
        private Button btnModificarCitas;
        private Button btnLimpiarCitas;
        private BindingSource citasBindingSource;
        private BindingSource gestionMascotasBindingSource;
    }
}