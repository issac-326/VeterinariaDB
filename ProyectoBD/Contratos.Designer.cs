namespace ProyectoBD
{
    partial class Contratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contratos));
            btnLimpiarCitas = new Button();
            btnAgregarContrato = new Button();
            panel1 = new Panel();
            mostradorContratos = new DataGridView();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxSalarioBruto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label11 = new Label();
            comboBoxCargos = new ComboBox();
            label4 = new Label();
            comboBoxPeriodoPago = new ComboBox();
            label5 = new Label();
            comboBoxPeriodoLaboral = new ComboBox();
            label7 = new Label();
            comboBoxHorario = new ComboBox();
            dateTimePickerFechaI = new DateTimePicker();
            dateTimePickerFechaFin = new DateTimePicker();
            panel2 = new Panel();
            label1 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)mostradorContratos).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiarCitas
            // 
            btnLimpiarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarCitas.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarCitas.Image = (Image)resources.GetObject("btnLimpiarCitas.Image");
            btnLimpiarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCitas.Location = new Point(514, 504);
            btnLimpiarCitas.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(9, 8, 22, 8);
            btnLimpiarCitas.Size = new Size(152, 52);
            btnLimpiarCitas.TabIndex = 38;
            btnLimpiarCitas.Text = "Limpiar";
            btnLimpiarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCitas.UseVisualStyleBackColor = false;
            btnLimpiarCitas.Click += btnLimpiarCitas_Click;
            // 
            // btnAgregarContrato
            // 
            btnAgregarContrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarContrato.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarContrato.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarContrato.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarContrato.Image = (Image)resources.GetObject("btnAgregarContrato.Image");
            btnAgregarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarContrato.Location = new Point(19, 504);
            btnAgregarContrato.Margin = new Padding(3, 2, 3, 2);
            btnAgregarContrato.Name = "btnAgregarContrato";
            btnAgregarContrato.Padding = new Padding(9, 8, 22, 8);
            btnAgregarContrato.Size = new Size(152, 52);
            btnAgregarContrato.TabIndex = 36;
            btnAgregarContrato.Text = "Agregar";
            btnAgregarContrato.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarContrato.UseVisualStyleBackColor = false;
            btnAgregarContrato.Click += btnAgregarCitas_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Navy;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(16, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 45);
            panel1.TabIndex = 31;
            // 
            // mostradorContratos
            // 
            mostradorContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorContratos.Location = new Point(21, 314);
            mostradorContratos.Name = "mostradorContratos";
            mostradorContratos.RowTemplate.Height = 25;
            mostradorContratos.Size = new Size(806, 166);
            mostradorContratos.TabIndex = 30;
            mostradorContratos.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(13, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 198);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nuevo Contrato";
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
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 0);
            tableLayoutPanel2.Controls.Add(label11, 2, 1);
            tableLayoutPanel2.Controls.Add(comboBoxCargos, 3, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(comboBoxPeriodoPago, 1, 2);
            tableLayoutPanel2.Controls.Add(label5, 2, 2);
            tableLayoutPanel2.Controls.Add(comboBoxPeriodoLaboral, 3, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(comboBoxHorario, 1, 3);
            tableLayoutPanel2.Controls.Add(dateTimePickerFechaI, 1, 0);
            tableLayoutPanel2.Controls.Add(dateTimePickerFechaFin, 3, 0);
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
            tableLayoutPanel2.Size = new Size(811, 173);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // textBoxSalarioBruto
            // 
            textBoxSalarioBruto.Location = new Point(159, 37);
            textBoxSalarioBruto.Name = "textBoxSalarioBruto";
            textBoxSalarioBruto.Size = new Size(233, 26);
            textBoxSalarioBruto.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 0;
            label2.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(113, 18);
            label3.TabIndex = 1;
            label3.Text = "Salario Bruto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 18);
            label6.TabIndex = 4;
            label6.Text = "Fecha Final";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(409, 34);
            label11.Name = "label11";
            label11.Size = new Size(57, 18);
            label11.TabIndex = 9;
            label11.Text = "Cargo";
            label11.Click += label11_Click;
            // 
            // comboBoxCargos
            // 
            comboBoxCargos.FormattingEnabled = true;
            comboBoxCargos.Location = new Point(551, 37);
            comboBoxCargos.Name = "comboBoxCargos";
            comboBoxCargos.Size = new Size(233, 26);
            comboBoxCargos.TabIndex = 15;
            comboBoxCargos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 68);
            label4.Name = "label4";
            label4.Size = new Size(148, 18);
            label4.TabIndex = 16;
            label4.Text = "Periodos de Pago";
            // 
            // comboBoxPeriodoPago
            // 
            comboBoxPeriodoPago.FormattingEnabled = true;
            comboBoxPeriodoPago.Location = new Point(159, 71);
            comboBoxPeriodoPago.Name = "comboBoxPeriodoPago";
            comboBoxPeriodoPago.Size = new Size(233, 26);
            comboBoxPeriodoPago.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 68);
            label5.Name = "label5";
            label5.Size = new Size(135, 18);
            label5.TabIndex = 18;
            label5.Text = "Periodo Laboral";
            // 
            // comboBoxPeriodoLaboral
            // 
            comboBoxPeriodoLaboral.FormattingEnabled = true;
            comboBoxPeriodoLaboral.Location = new Point(551, 71);
            comboBoxPeriodoLaboral.Name = "comboBoxPeriodoLaboral";
            comboBoxPeriodoLaboral.Size = new Size(233, 26);
            comboBoxPeriodoLaboral.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 102);
            label7.Name = "label7";
            label7.Size = new Size(68, 18);
            label7.TabIndex = 20;
            label7.Text = "Horario";
            // 
            // comboBoxHorario
            // 
            comboBoxHorario.FormattingEnabled = true;
            comboBoxHorario.Location = new Point(159, 105);
            comboBoxHorario.Name = "comboBoxHorario";
            comboBoxHorario.Size = new Size(233, 26);
            comboBoxHorario.TabIndex = 21;
            // 
            // dateTimePickerFechaI
            // 
            dateTimePickerFechaI.Location = new Point(159, 3);
            dateTimePickerFechaI.Name = "dateTimePickerFechaI";
            dateTimePickerFechaI.Size = new Size(233, 26);
            dateTimePickerFechaI.TabIndex = 22;
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Location = new Point(551, 3);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(233, 26);
            dateTimePickerFechaFin.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-13, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 52);
            panel2.TabIndex = 28;
            panel2.Paint += panel2_Paint;
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
            label1.Location = new Point(374, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 0;
            label1.Text = "Contratos";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Red;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(678, 504);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(9, 8, 22, 8);
            button4.Size = new Size(152, 52);
            button4.TabIndex = 52;
            button4.Text = "Salir";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // Contratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(button4);
            Controls.Add(btnLimpiarCitas);
            Controls.Add(btnAgregarContrato);
            Controls.Add(panel1);
            Controls.Add(mostradorContratos);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Name = "Contratos";
            Text = "Gestión de Contratos";
            ((System.ComponentModel.ISupportInitialize)mostradorContratos).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimpiarCitas;
        private Button btnAgregarContrato;
        private Panel panel1;
        private DataGridView mostradorContratos;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxSalarioBruto;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label11;
        private ComboBox comboBoxCargos;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private ComboBox comboBoxPeriodoPago;
        private Label label5;
        private ComboBox comboBoxPeriodoLaboral;
        private Label label7;
        private ComboBox comboBoxHorario;
        private DateTimePicker dateTimePickerFechaI;
        private DateTimePicker dateTimePickerFechaFin;
        private Button button4;
    }
}