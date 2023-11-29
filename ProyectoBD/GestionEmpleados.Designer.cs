namespace ProyectoBD
{
    partial class GestionEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEmpleados));
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxSalarioBruto = new TextBox();
            label2 = new Label();
            btnLimpiarCitas = new Button();
            btnAgregarCitas = new Button();
            button4 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            fechaNacimiento = new DateTimePicker();
            label12 = new Label();
            primerApellido = new TextBox();
            segundoNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            primerNombre = new TextBox();
            label6 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            identidad = new TextBox();
            referencia = new TextBox();
            correo = new TextBox();
            telefono = new TextBox();
            label11 = new Label();
            label13 = new Label();
            segundoApellido = new TextBox();
            seguroSocial = new TextBox();
            label15 = new Label();
            comboBoxCiudad = new ComboBox();
            foto = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2355118F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8261414F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5092487F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.3057938F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(textBoxSalarioBruto, 1, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxSalarioBruto
            // 
            textBoxSalarioBruto.Location = new Point(41, 23);
            textBoxSalarioBruto.Name = "textBoxSalarioBruto";
            textBoxSalarioBruto.Size = new Size(55, 23);
            textBoxSalarioBruto.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 60);
            label2.TabIndex = 0;
            label2.Text = "Fecha de Inicio";
            // 
            // btnLimpiarCitas
            // 
            btnLimpiarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarCitas.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarCitas.Image = (Image)resources.GetObject("btnLimpiarCitas.Image");
            btnLimpiarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCitas.Location = new Point(511, 482);
            btnLimpiarCitas.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(9, 8, 22, 8);
            btnLimpiarCitas.Size = new Size(152, 52);
            btnLimpiarCitas.TabIndex = 42;
            btnLimpiarCitas.Text = "Limpiar";
            btnLimpiarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCitas.UseVisualStyleBackColor = false;
            btnLimpiarCitas.Click += btnLimpiarCitas_Click;
            // 
            // btnAgregarCitas
            // 
            btnAgregarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarCitas.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarCitas.Image = (Image)resources.GetObject("btnAgregarCitas.Image");
            btnAgregarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCitas.Location = new Point(13, 482);
            btnAgregarCitas.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCitas.Name = "btnAgregarCitas";
            btnAgregarCitas.Padding = new Padding(9, 8, 22, 8);
            btnAgregarCitas.Size = new Size(152, 52);
            btnAgregarCitas.TabIndex = 40;
            btnAgregarCitas.Text = "Agregar";
            btnAgregarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarCitas.UseVisualStyleBackColor = false;
            btnAgregarCitas.Click += btnAgregarCitas_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Red;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(678, 482);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(9, 8, 22, 8);
            button4.Size = new Size(152, 52);
            button4.TabIndex = 38;
            button4.Text = "Salir";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            label1.Location = new Point(364, 32);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 36;
            label1.Text = "Contratar";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(13, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 198);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nuevo Empleado";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6054249F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8532677F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.988903F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.3740959F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(fechaNacimiento, 3, 2);
            tableLayoutPanel1.Controls.Add(label12, 0, 5);
            tableLayoutPanel1.Controls.Add(primerApellido, 1, 1);
            tableLayoutPanel1.Controls.Add(segundoNombre, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(primerNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(label10, 2, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 3);
            tableLayoutPanel1.Controls.Add(label8, 2, 4);
            tableLayoutPanel1.Controls.Add(identidad, 1, 2);
            tableLayoutPanel1.Controls.Add(referencia, 1, 4);
            tableLayoutPanel1.Controls.Add(correo, 3, 3);
            tableLayoutPanel1.Controls.Add(telefono, 3, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 2);
            tableLayoutPanel1.Controls.Add(label13, 2, 1);
            tableLayoutPanel1.Controls.Add(segundoApellido, 3, 1);
            tableLayoutPanel1.Controls.Add(seguroSocial, 1, 5);
            tableLayoutPanel1.Controls.Add(label15, 2, 5);
            tableLayoutPanel1.Controls.Add(comboBoxCiudad, 1, 3);
            tableLayoutPanel1.Controls.Add(foto, 3, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0140839F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0140839F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.608696F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(811, 173);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Location = new Point(550, 59);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(233, 26);
            fechaNacimiento.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 142);
            label12.Name = "label12";
            label12.Size = new Size(150, 18);
            label12.TabIndex = 20;
            label12.Text = "No. Seguro Social";
            // 
            // primerApellido
            // 
            primerApellido.Location = new Point(162, 31);
            primerApellido.Name = "primerApellido";
            primerApellido.Size = new Size(228, 26);
            primerApellido.TabIndex = 14;
            // 
            // segundoNombre
            // 
            segundoNombre.Location = new Point(550, 3);
            segundoNombre.Name = "segundoNombre";
            segundoNombre.Size = new Size(233, 26);
            segundoNombre.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 0;
            label3.Text = "Primer Nombre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 28);
            label4.Name = "label4";
            label4.Size = new Size(129, 18);
            label4.TabIndex = 1;
            label4.Text = "Primer Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 83);
            label5.Name = "label5";
            label5.Size = new Size(64, 18);
            label5.TabIndex = 3;
            label5.Text = "Ciudad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 110);
            label7.Name = "label7";
            label7.Size = new Size(96, 18);
            label7.TabIndex = 5;
            label7.Text = "Referencia";
            // 
            // primerNombre
            // 
            primerNombre.Location = new Point(162, 3);
            primerNombre.Name = "primerNombre";
            primerNombre.Size = new Size(228, 26);
            primerNombre.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 18);
            label6.TabIndex = 4;
            label6.Text = "Segundo Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(396, 56);
            label10.Name = "label10";
            label10.Size = new Size(123, 18);
            label10.TabIndex = 8;
            label10.Text = "Fecha de Nac.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(396, 83);
            label9.Name = "label9";
            label9.Size = new Size(64, 18);
            label9.TabIndex = 7;
            label9.Text = "Correo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(396, 110);
            label8.Name = "label8";
            label8.Size = new Size(77, 18);
            label8.TabIndex = 6;
            label8.Text = "Teléfono";
            // 
            // identidad
            // 
            identidad.Location = new Point(162, 59);
            identidad.Name = "identidad";
            identidad.Size = new Size(228, 26);
            identidad.TabIndex = 11;
            // 
            // referencia
            // 
            referencia.Location = new Point(162, 113);
            referencia.Name = "referencia";
            referencia.Size = new Size(228, 26);
            referencia.TabIndex = 16;
            // 
            // correo
            // 
            correo.Location = new Point(550, 86);
            correo.Name = "correo";
            correo.Size = new Size(233, 26);
            correo.TabIndex = 18;
            // 
            // telefono
            // 
            telefono.Location = new Point(550, 113);
            telefono.Name = "telefono";
            telefono.Size = new Size(233, 26);
            telefono.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 56);
            label11.Name = "label11";
            label11.Size = new Size(138, 18);
            label11.TabIndex = 2;
            label11.Text = "No. de Identidad";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(396, 28);
            label13.Name = "label13";
            label13.Size = new Size(147, 18);
            label13.TabIndex = 9;
            label13.Text = "Segundo Apellido";
            // 
            // segundoApellido
            // 
            segundoApellido.Location = new Point(550, 31);
            segundoApellido.Name = "segundoApellido";
            segundoApellido.Size = new Size(233, 26);
            segundoApellido.TabIndex = 13;
            // 
            // seguroSocial
            // 
            seguroSocial.Location = new Point(162, 145);
            seguroSocial.Name = "seguroSocial";
            seguroSocial.Size = new Size(228, 26);
            seguroSocial.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(396, 142);
            label15.Name = "label15";
            label15.Size = new Size(113, 18);
            label15.TabIndex = 22;
            label15.Text = "Foto de Perfil";
            // 
            // comboBoxCiudad
            // 
            comboBoxCiudad.FormattingEnabled = true;
            comboBoxCiudad.Location = new Point(162, 86);
            comboBoxCiudad.Name = "comboBoxCiudad";
            comboBoxCiudad.Size = new Size(228, 26);
            comboBoxCiudad.TabIndex = 26;
            // 
            // foto
            // 
            foto.Location = new Point(550, 145);
            foto.Name = "foto";
            foto.Size = new Size(233, 26);
            foto.TabIndex = 27;
            // 
            // GestionEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(btnLimpiarCitas);
            Controls.Add(btnAgregarCitas);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "GestionEmpleados";
            Text = "Gestión de Personal";
            Load += GestionEmpleados_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxSalarioBruto;
        private Label label2;
        private Button btnLimpiarCitas;
        private Button btnModificarCitas;
        private Button btnAgregarCitas;
        private Button btnEliminarCitas;
        private Button button4;
        private DataGridView dataGridView2;
        private Label label1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
        private TextBox primerApellido;
        private TextBox segundoNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox primerNombre;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox identidad;
        private TextBox referencia;
        private TextBox correo;
        private TextBox telefono;
        private Label label11;
        private Label label13;
        private TextBox segundoApellido;
        private TextBox seguroSocial;
        private Label label15;
        private ComboBox comboBoxCiudad;
        private TextBox foto;
        private DateTimePicker fechaNacimiento;
    }
}