namespace ProyectoBD
{
    partial class RegistroConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroConsulta));
            panel2 = new Panel();
            label13 = new Label();
            label1 = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            mostradorMascotas = new DataGridView();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtPeso = new TextBox();
            Nombre = new Label();
            label3 = new Label();
            label6 = new Label();
            label10 = new Label();
            label4 = new Label();
            label11 = new Label();
            txtTamano = new TextBox();
            selEspecie = new ComboBox();
            selRaza = new ComboBox();
            txtNombre = new TextBox();
            txtFecha = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label12 = new Label();
            label14 = new Label();
            label9 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mostradorMascotas).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-33, -53);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 52);
            panel2.TabIndex = 24;
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
            label13.Location = new Point(272, 21);
            label13.Name = "label13";
            label13.Size = new Size(344, 22);
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
            label1.Location = new Point(306, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(670, 519);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(9, 8, 22, 8);
            btnSalir.Size = new Size(154, 43);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Volver";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(447, 519);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(9, 8, 22, 8);
            btnLimpiar.Size = new Size(154, 43);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(255, 128, 0);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(229, 519);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Padding = new Padding(9, 8, 22, 8);
            btnModificar.Size = new Size(154, 43);
            btnModificar.TabIndex = 29;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(16, 519);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(9, 8, 22, 8);
            btnAgregar.Size = new Size(154, 43);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // mostradorMascotas
            // 
            mostradorMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorMascotas.Location = new Point(13, 321);
            mostradorMascotas.Name = "mostradorMascotas";
            mostradorMascotas.RowTemplate.Height = 25;
            mostradorMascotas.Size = new Size(814, 166);
            mostradorMascotas.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(10, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 234);
            groupBox2.TabIndex = 26;
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
            tableLayoutPanel2.Controls.Add(txtPeso, 4, 0);
            tableLayoutPanel2.Controls.Add(Nombre, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(label10, 3, 2);
            tableLayoutPanel2.Controls.Add(label9, 3, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label11, 3, 1);
            tableLayoutPanel2.Controls.Add(txtTamano, 4, 1);
            tableLayoutPanel2.Controls.Add(selEspecie, 4, 2);
            tableLayoutPanel2.Controls.Add(selRaza, 4, 3);
            tableLayoutPanel2.Controls.Add(txtNombre, 1, 2);
            tableLayoutPanel2.Controls.Add(txtFecha, 1, 0);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 3);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Size = new Size(811, 209);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(539, 3);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(233, 26);
            txtPeso.TabIndex = 12;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(3, 0);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(58, 18);
            Nombre.TabIndex = 0;
            Nombre.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 35);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 1;
            label3.Text = "Hora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 4;
            label6.Text = "Medico";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 70);
            label10.Name = "label10";
            label10.Size = new Size(97, 18);
            label10.TabIndex = 8;
            label10.Text = "Expediente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 70);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 2;
            label4.Text = "Sintomas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(414, 35);
            label11.Name = "label11";
            label11.Size = new Size(112, 18);
            label11.TabIndex = 9;
            label11.Text = "Responsable";
            // 
            // txtTamano
            // 
            txtTamano.Location = new Point(539, 38);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(233, 26);
            txtTamano.TabIndex = 13;
            // 
            // selEspecie
            // 
            selEspecie.FormattingEnabled = true;
            selEspecie.Location = new Point(539, 73);
            selEspecie.Name = "selEspecie";
            selEspecie.Size = new Size(233, 26);
            selEspecie.TabIndex = 25;
            // 
            // selRaza
            // 
            selRaza.FormattingEnabled = true;
            selRaza.Location = new Point(539, 108);
            selRaza.Name = "selRaza";
            selRaza.Size = new Size(233, 26);
            selRaza.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 26);
            txtNombre.TabIndex = 10;
            // 
            // txtFecha
            // 
            txtFecha.CustomFormat = "";
            txtFecha.Location = new Point(137, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(233, 26);
            txtFecha.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(137, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 26);
            dateTimePicker1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 140);
            label5.Name = "label5";
            label5.Size = new Size(40, 18);
            label5.TabIndex = 3;
            label5.Text = "Cita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 105);
            label7.Name = "label7";
            label7.Size = new Size(103, 18);
            label7.TabIndex = 5;
            label7.Text = "Diagnostico";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 26);
            textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 26);
            textBox2.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(-13, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 52);
            panel1.TabIndex = 25;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = SystemColors.GradientActiveCaption;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Navy;
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(326, 15);
            label12.Name = "label12";
            label12.Size = new Size(215, 22);
            label12.TabIndex = 2;
            label12.Text = "Creacion de Consultas";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = SystemColors.GradientActiveCaption;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Navy;
            label14.ImageAlign = ContentAlignment.TopCenter;
            label14.Location = new Point(306, 33);
            label14.Name = "label14";
            label14.Size = new Size(0, 22);
            label14.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 105);
            label9.Name = "label9";
            label9.Size = new Size(42, 18);
            label9.TabIndex = 7;
            label9.Text = "Tipo";
            // 
            // RegistroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 567);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(mostradorMascotas);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "RegistroConsulta";
            Text = "RegistroConsulta";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mostradorMascotas).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label13;
        private Label label1;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView mostradorMascotas;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtPeso;
        private Label Nombre;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox txtNombre;
        private Label label6;
        private Label label10;
        private Label label4;
        private Label label11;
        private TextBox txtTamano;
        private DateTimePicker txtFecha;
        private ComboBox selEspecie;
        private ComboBox selRaza;
        private Panel panel1;
        private Label label12;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label9;
    }
}