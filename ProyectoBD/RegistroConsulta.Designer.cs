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
            btnAgregar = new Button();
            mostradorMedicamentos = new DataGridView();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            Nombre = new Label();
            label3 = new Label();
            label6 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label11 = new Label();
            txtResponsable = new TextBox();
            txtSintoma = new TextBox();
            txtFecha = new DateTimePicker();
            txtHora = new DateTimePicker();
            label5 = new Label();
            label7 = new Label();
            txtDiagnostico = new TextBox();
            txtCita = new TextBox();
            txtExpendiente = new TextBox();
            selMedico = new ComboBox();
            txtTipo = new TextBox();
            panel1 = new Panel();
            label12 = new Label();
            label14 = new Label();
            button2 = new Button();
            button3 = new Button();
            btnAgregarConsulta = new Button();
            label2 = new Label();
            selMedicamento = new ComboBox();
            label8 = new Label();
            txtDosis = new TextBox();
            btnIr = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mostradorMedicamentos).BeginInit();
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
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(581, 319);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(9, 8, 22, 8);
            btnAgregar.Size = new Size(154, 43);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // mostradorMedicamentos
            // 
            mostradorMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorMedicamentos.Location = new Point(10, 364);
            mostradorMedicamentos.Name = "mostradorMedicamentos";
            mostradorMedicamentos.RowHeadersWidth = 51;
            mostradorMedicamentos.RowTemplate.Height = 25;
            mostradorMedicamentos.Size = new Size(814, 150);
            mostradorMedicamentos.TabIndex = 27;
            mostradorMedicamentos.CellContentClick += mostradorMedicamentos_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(10, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 216);
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
            tableLayoutPanel2.Controls.Add(Nombre, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(label10, 3, 2);
            tableLayoutPanel2.Controls.Add(label9, 3, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label11, 3, 1);
            tableLayoutPanel2.Controls.Add(txtResponsable, 4, 1);
            tableLayoutPanel2.Controls.Add(txtSintoma, 1, 2);
            tableLayoutPanel2.Controls.Add(txtFecha, 1, 0);
            tableLayoutPanel2.Controls.Add(txtHora, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(txtDiagnostico, 1, 3);
            tableLayoutPanel2.Controls.Add(txtCita, 1, 4);
            tableLayoutPanel2.Controls.Add(txtExpendiente, 4, 2);
            tableLayoutPanel2.Controls.Add(selMedico, 4, 0);
            tableLayoutPanel2.Controls.Add(txtTipo, 4, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(811, 191);
            tableLayoutPanel2.TabIndex = 4;
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
            label3.Location = new Point(3, 38);
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
            label10.Location = new Point(414, 76);
            label10.Name = "label10";
            label10.Size = new Size(97, 18);
            label10.TabIndex = 8;
            label10.Text = "Expediente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 114);
            label9.Name = "label9";
            label9.Size = new Size(42, 18);
            label9.TabIndex = 7;
            label9.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 76);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 2;
            label4.Text = "Sintomas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(414, 38);
            label11.Name = "label11";
            label11.Size = new Size(112, 18);
            label11.TabIndex = 9;
            label11.Text = "Responsable";
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(539, 41);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(233, 26);
            txtResponsable.TabIndex = 13;
            // 
            // txtSintoma
            // 
            txtSintoma.Location = new Point(137, 79);
            txtSintoma.Name = "txtSintoma";
            txtSintoma.Size = new Size(233, 26);
            txtSintoma.TabIndex = 10;
            // 
            // txtFecha
            // 
            txtFecha.CustomFormat = "";
            txtFecha.Location = new Point(137, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(233, 26);
            txtFecha.TabIndex = 22;
            // 
            // txtHora
            // 
            txtHora.CustomFormat = "";
            txtHora.Format = DateTimePickerFormat.Time;
            txtHora.Location = new Point(137, 41);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(233, 26);
            txtHora.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 152);
            label5.Name = "label5";
            label5.Size = new Size(40, 18);
            label5.TabIndex = 3;
            label5.Text = "Cita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 114);
            label7.Name = "label7";
            label7.Size = new Size(103, 18);
            label7.TabIndex = 5;
            label7.Text = "Diagnostico";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(137, 117);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(233, 26);
            txtDiagnostico.TabIndex = 30;
            // 
            // txtCita
            // 
            txtCita.Location = new Point(137, 155);
            txtCita.Name = "txtCita";
            txtCita.ReadOnly = true;
            txtCita.Size = new Size(233, 26);
            txtCita.TabIndex = 31;
            // 
            // txtExpendiente
            // 
            txtExpendiente.Location = new Point(539, 79);
            txtExpendiente.Name = "txtExpendiente";
            txtExpendiente.Size = new Size(233, 26);
            txtExpendiente.TabIndex = 12;
            // 
            // selMedico
            // 
            selMedico.FormattingEnabled = true;
            selMedico.Location = new Point(539, 3);
            selMedico.Name = "selMedico";
            selMedico.Size = new Size(233, 26);
            selMedico.TabIndex = 25;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(539, 117);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(233, 26);
            txtTipo.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(-13, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 52);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
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
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(447, 265);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 8, 22, 8);
            button2.Size = new Size(154, 43);
            button2.TabIndex = 34;
            button2.Text = "Limpiar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(229, 265);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(9, 8, 22, 8);
            button3.Size = new Size(154, 43);
            button3.TabIndex = 33;
            button3.Text = "Modificar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAgregarConsulta
            // 
            btnAgregarConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarConsulta.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarConsulta.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarConsulta.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarConsulta.Image = (Image)resources.GetObject("btnAgregarConsulta.Image");
            btnAgregarConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarConsulta.Location = new Point(10, 265);
            btnAgregarConsulta.Margin = new Padding(3, 2, 3, 2);
            btnAgregarConsulta.Name = "btnAgregarConsulta";
            btnAgregarConsulta.Padding = new Padding(9, 8, 22, 8);
            btnAgregarConsulta.Size = new Size(154, 43);
            btnAgregarConsulta.TabIndex = 32;
            btnAgregarConsulta.Text = "Agregar";
            btnAgregarConsulta.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarConsulta.UseVisualStyleBackColor = false;
            btnAgregarConsulta.Click += btnAgregarConsulta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 331);
            label2.Name = "label2";
            label2.Size = new Size(124, 18);
            label2.TabIndex = 32;
            label2.Text = "Medicamentos";
            // 
            // selMedicamento
            // 
            selMedicamento.FormattingEnabled = true;
            selMedicamento.Location = new Point(150, 331);
            selMedicamento.Name = "selMedicamento";
            selMedicamento.Size = new Size(143, 23);
            selMedicamento.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(313, 331);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 35;
            label8.Text = "Dosis";
            // 
            // txtDosis
            // 
            txtDosis.Location = new Point(381, 331);
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new Size(158, 23);
            txtDosis.TabIndex = 36;
            // 
            // btnIr
            // 
            btnIr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIr.BackColor = Color.FromArgb(0, 192, 0);
            btnIr.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIr.ForeColor = SystemColors.ActiveCaptionText;
            btnIr.Image = (Image)resources.GetObject("btnIr.Image");
            btnIr.ImageAlign = ContentAlignment.MiddleLeft;
            btnIr.Location = new Point(10, 519);
            btnIr.Margin = new Padding(3, 2, 3, 2);
            btnIr.Name = "btnIr";
            btnIr.Padding = new Padding(9, 8, 22, 8);
            btnIr.Size = new Size(154, 43);
            btnIr.TabIndex = 37;
            btnIr.Text = "Listo";
            btnIr.TextAlign = ContentAlignment.MiddleRight;
            btnIr.UseVisualStyleBackColor = false;
            btnIr.Click += btnIr_Click;
            // 
            // RegistroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 562);
            Controls.Add(btnIr);
            Controls.Add(txtDosis);
            Controls.Add(label8);
            Controls.Add(selMedicamento);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnAgregarConsulta);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(mostradorMedicamentos);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "RegistroConsulta";
            Text = "RegistroConsulta";
            Load += RegistroConsulta_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mostradorMedicamentos).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label13;
        private Label label1;
        private Button btnSalir;
        private Button btnAgregar;
        private DataGridView mostradorMedicamentos;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtExpendiente;
        private Label Nombre;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox txtSintoma;
        private Label label6;
        private Label label10;
        private Label label4;
        private Label label11;
        private TextBox txtResponsable;
        private DateTimePicker txtFecha;
        private ComboBox selMedico;
        private Panel panel1;
        private Label label12;
        private Label label14;
        private DateTimePicker txtHora;
        private TextBox txtDiagnostico;
        private Label label9;
        private Button button2;
        private Button button3;
        private Button btnAgregarConsulta;
        private Label label2;
        private ComboBox selMedicamento;
        private TextBox txtCita;
        private Label label8;
        private TextBox txtDosis;
        private TextBox txtTipo;
        private Button btnIr;
    }
}