﻿namespace ProyectoBD
{
    partial class GestionMascotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMascotas));
            mostradorMascotas = new DataGridView();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            txtCaracteristicas = new TextBox();
            txtPeso = new TextBox();
            Nombre = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label11 = new Label();
            txtTamano = new TextBox();
            selEstado = new ComboBox();
            txtFecha = new DateTimePicker();
            txtAgresivo = new CheckBox();
            selEspecie = new ComboBox();
            selRaza = new ComboBox();
            selGenero = new ComboBox();
            txtEsterilizacion = new CheckBox();
            panel2 = new Panel();
            label13 = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)mostradorMascotas).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mostradorMascotas
            // 
            mostradorMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorMascotas.Location = new Point(20, 503);
            mostradorMascotas.Margin = new Padding(4, 5, 4, 5);
            mostradorMascotas.Name = "mostradorMascotas";
            mostradorMascotas.RowHeadersWidth = 51;
            mostradorMascotas.RowTemplate.Height = 25;
            mostradorMascotas.Size = new Size(1161, 277);
            mostradorMascotas.TabIndex = 19;
            mostradorMascotas.CellContentClick += mostradorMascotas_CellContentClick;
            mostradorMascotas.CellMouseClick += mostradorMascotas_CellMouseClick;
            mostradorMascotas.CellMouseDoubleClick += mostradorMascotas_CellMouseDoubleClick;
            mostradorMascotas.MouseDoubleClick += mostradorMascotas_MouseDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(16, 73);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1169, 390);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formulario";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5562935F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8013229F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.31565952F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4130707F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8013229F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.97350979F));
            tableLayoutPanel2.Controls.Add(label2, 0, 5);
            tableLayoutPanel2.Controls.Add(txtCaracteristicas, 1, 1);
            tableLayoutPanel2.Controls.Add(txtPeso, 4, 0);
            tableLayoutPanel2.Controls.Add(Nombre, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(label10, 3, 2);
            tableLayoutPanel2.Controls.Add(label9, 3, 3);
            tableLayoutPanel2.Controls.Add(label8, 3, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label11, 3, 1);
            tableLayoutPanel2.Controls.Add(txtTamano, 4, 1);
            tableLayoutPanel2.Controls.Add(selEstado, 1, 5);
            tableLayoutPanel2.Controls.Add(txtFecha, 1, 2);
            tableLayoutPanel2.Controls.Add(txtAgresivo, 1, 4);
            tableLayoutPanel2.Controls.Add(selEspecie, 4, 2);
            tableLayoutPanel2.Controls.Add(selRaza, 4, 3);
            tableLayoutPanel2.Controls.Add(selGenero, 4, 4);
            tableLayoutPanel2.Controls.Add(txtEsterilizacion, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel2.Location = new Point(4, 33);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.Size = new Size(1161, 352);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 295);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 20;
            label2.Text = "Estado";
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(196, 64);
            txtCaracteristicas.Margin = new Padding(4, 5, 4, 5);
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(333, 35);
            txtCaracteristicas.TabIndex = 14;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(771, 5);
            txtPeso.Margin = new Padding(4, 5, 4, 5);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(333, 35);
            txtPeso.TabIndex = 12;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(4, 0);
            Nombre.Margin = new Padding(4, 0, 4, 0);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(105, 28);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 28);
            label3.TabIndex = 1;
            label3.Text = "Caracteristica";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 3;
            label5.Text = "Esterilizado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 236);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 28);
            label7.TabIndex = 5;
            label7.Text = "Agresivo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(196, 5);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(333, 35);
            txtNombre.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(592, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 4;
            label6.Text = "Peso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(592, 118);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 28);
            label10.TabIndex = 8;
            label10.Text = "Especie";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(592, 177);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 28);
            label9.TabIndex = 7;
            label9.Text = "Raza";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(592, 236);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 28);
            label8.TabIndex = 6;
            label8.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 118);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 2;
            label4.Text = "Fecha_nac";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(592, 59);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 28);
            label11.TabIndex = 9;
            label11.Text = "Tamaño";
            // 
            // txtTamano
            // 
            txtTamano.Location = new Point(771, 64);
            txtTamano.Margin = new Padding(4, 5, 4, 5);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(333, 35);
            txtTamano.TabIndex = 13;
            // 
            // selEstado
            // 
            selEstado.FormattingEnabled = true;
            selEstado.Location = new Point(196, 300);
            selEstado.Margin = new Padding(4, 5, 4, 5);
            selEstado.Name = "selEstado";
            selEstado.Size = new Size(333, 36);
            selEstado.TabIndex = 21;
            // 
            // txtFecha
            // 
            txtFecha.CustomFormat = "";
            txtFecha.Location = new Point(196, 123);
            txtFecha.Margin = new Padding(4, 5, 4, 5);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(333, 35);
            txtFecha.TabIndex = 22;
            txtFecha.ValueChanged += txtFecha_ValueChanged;
            // 
            // txtAgresivo
            // 
            txtAgresivo.AutoSize = true;
            txtAgresivo.Location = new Point(196, 241);
            txtAgresivo.Margin = new Padding(4, 5, 4, 5);
            txtAgresivo.Name = "txtAgresivo";
            txtAgresivo.Size = new Size(99, 32);
            txtAgresivo.TabIndex = 24;
            txtAgresivo.Text = "Lo es";
            txtAgresivo.UseVisualStyleBackColor = true;
            // 
            // selEspecie
            // 
            selEspecie.FormattingEnabled = true;
            selEspecie.Location = new Point(771, 123);
            selEspecie.Margin = new Padding(4, 5, 4, 5);
            selEspecie.Name = "selEspecie";
            selEspecie.Size = new Size(333, 36);
            selEspecie.TabIndex = 25;
            selEspecie.SelectedIndexChanged += selEspecie_SelectedIndexChanged;
            // 
            // selRaza
            // 
            selRaza.FormattingEnabled = true;
            selRaza.Location = new Point(771, 182);
            selRaza.Margin = new Padding(4, 5, 4, 5);
            selRaza.Name = "selRaza";
            selRaza.Size = new Size(333, 36);
            selRaza.TabIndex = 26;
            // 
            // selGenero
            // 
            selGenero.FormattingEnabled = true;
            selGenero.Location = new Point(771, 241);
            selGenero.Margin = new Padding(4, 5, 4, 5);
            selGenero.Name = "selGenero";
            selGenero.Size = new Size(333, 36);
            selGenero.TabIndex = 27;
            // 
            // txtEsterilizacion
            // 
            txtEsterilizacion.AutoSize = true;
            txtEsterilizacion.Location = new Point(196, 182);
            txtEsterilizacion.Margin = new Padding(4, 5, 4, 5);
            txtEsterilizacion.Name = "txtEsterilizacion";
            txtEsterilizacion.Size = new Size(121, 32);
            txtEsterilizacion.TabIndex = 28;
            txtEsterilizacion.Text = "Lo está";
            txtEsterilizacion.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-19, -23);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1239, 87);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = SystemColors.GradientActiveCaption;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Navy;
            label13.ImageAlign = ContentAlignment.TopCenter;
            label13.Location = new Point(389, 35);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(529, 33);
            label13.TabIndex = 2;
            label13.Text = "Gestión de expedientes de Mascotas";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(439, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(24, 833);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(11, 13, 31, 13);
            btnAgregar.Size = new Size(220, 72);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(255, 128, 0);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(336, 833);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Padding = new Padding(11, 13, 31, 13);
            btnModificar.Size = new Size(220, 72);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(647, 833);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(11, 13, 31, 13);
            btnLimpiar.Size = new Size(220, 72);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(954, 833);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(11, 13, 31, 13);
            btnSalir.Size = new Size(220, 72);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Volver";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // GestionMascotas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 937);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(mostradorMascotas);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionMascotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionMascotas";
            Load += GestionMascotas_Load;
            ((System.ComponentModel.ISupportInitialize)mostradorMascotas).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView mostradorMascotas;
        private GroupBox groupBox2;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox txtCaracteristicas;
        private TextBox txtPeso;
        private Label Nombre;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox txtNombre;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label11;
        private TextBox txtTamano;
        private ComboBox selEstado;
        private DateTimePicker txtFecha;
        private CheckBox txtAgresivo;
        private ComboBox selEspecie;
        private ComboBox selRaza;
        private ComboBox selGenero;
        private CheckBox txtEsterilizacion;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label13;
    }
}