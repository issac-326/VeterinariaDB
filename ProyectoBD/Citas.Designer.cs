﻿namespace ProyectoBD
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
            button1 = new Button();
            btnEliminarCitas = new Button();
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
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1248, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario de Citas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1020, 137);
            label8.Name = "label8";
            label8.Size = new Size(203, 21);
            label8.TabIndex = 13;
            label8.Text = "yyyy/MM/dd hh:mm:ss";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1020, 108);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 12;
            label7.Text = "Formato:";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(687, 161);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(301, 28);
            txtFechaFinal.TabIndex = 11;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(687, 105);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(301, 28);
            txtFechaInicio.TabIndex = 10;
            // 
            // selEstadoCitas
            // 
            selEstadoCitas.FormattingEnabled = true;
            selEstadoCitas.Location = new Point(687, 48);
            selEstadoCitas.Name = "selEstadoCitas";
            selEstadoCitas.Size = new Size(301, 29);
            selEstadoCitas.TabIndex = 9;
            // 
            // txtFechaCita
            // 
            txtFechaCita.CustomFormat = "";
            txtFechaCita.Location = new Point(154, 161);
            txtFechaCita.Name = "txtFechaCita";
            txtFechaCita.Size = new Size(269, 28);
            txtFechaCita.TabIndex = 8;
            // 
            // selMascotaCita
            // 
            selMascotaCita.FormattingEnabled = true;
            selMascotaCita.Location = new Point(154, 104);
            selMascotaCita.Name = "selMascotaCita";
            selMascotaCita.Size = new Size(268, 29);
            selMascotaCita.TabIndex = 7;
            // 
            // selEmpleadoCitas
            // 
            selEmpleadoCitas.FormattingEnabled = true;
            selEmpleadoCitas.Location = new Point(154, 48);
            selEmpleadoCitas.Name = "selEmpleadoCitas";
            selEmpleadoCitas.Size = new Size(268, 29);
            selEmpleadoCitas.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 168);
            label6.Name = "label6";
            label6.Size = new Size(168, 21);
            label6.TabIndex = 5;
            label6.Text = "Fecha Y Hora Fin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 112);
            label5.Name = "label5";
            label5.Size = new Size(190, 21);
            label5.TabIndex = 4;
            label5.Text = "Fecha Y Hora Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 56);
            label4.Name = "label4";
            label4.Size = new Size(165, 21);
            label4.TabIndex = 3;
            label4.Text = "Estado de la Cita:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 168);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 112);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Mascota:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 56);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
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
            dataGridView1.Location = new Point(25, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1235, 292);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // citasBindingSource
            // 
            citasBindingSource.DataSource = typeof(Citas);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1067, 567);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 10, 25, 10);
            button1.Size = new Size(146, 56);
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
            btnEliminarCitas.Location = new Point(555, 567);
            btnEliminarCitas.Name = "btnEliminarCitas";
            btnEliminarCitas.Padding = new Padding(10, 10, 25, 10);
            btnEliminarCitas.Size = new Size(172, 56);
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
            btnAgregarCitas.Location = new Point(33, 567);
            btnAgregarCitas.Name = "btnAgregarCitas";
            btnAgregarCitas.Padding = new Padding(10, 10, 25, 10);
            btnAgregarCitas.Size = new Size(182, 56);
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
            btnModificarCitas.Location = new Point(293, 567);
            btnModificarCitas.Name = "btnModificarCitas";
            btnModificarCitas.Padding = new Padding(10, 10, 25, 10);
            btnModificarCitas.Size = new Size(182, 56);
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
            btnLimpiarCitas.Location = new Point(811, 567);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(10, 10, 25, 10);
            btnLimpiarCitas.Size = new Size(179, 56);
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
            ClientSize = new Size(1286, 651);
            Controls.Add(btnLimpiarCitas);
            Controls.Add(btnModificarCitas);
            Controls.Add(btnAgregarCitas);
            Controls.Add(btnEliminarCitas);
            Controls.Add(button1);
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
        private Button button1;
        private Button btnEliminarCitas;
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