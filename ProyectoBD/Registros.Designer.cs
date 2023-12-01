namespace ProyectoBD
{
    partial class Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboTipo = new ComboBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label11 = new Label();
            txtPrecio = new TextBox();
            txtFecha = new DateTimePicker();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnLimpiarCitas = new Button();
            btnAgregarCitas = new Button();
            button2 = new Button();
            label12 = new Label();
            nombreMedicamento = new ComboBox();
            panel3 = new Panel();
            button6 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            comboProveedores = new ComboBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(7, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(814, 146);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formulario";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(comboTipo, 4, 0);
            tableLayoutPanel2.Controls.Add(txtCantidad, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(label11, 3, 1);
            tableLayoutPanel2.Controls.Add(txtPrecio, 4, 1);
            tableLayoutPanel2.Controls.Add(txtFecha, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(808, 121);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(567, 3);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(238, 26);
            comboTipo.TabIndex = 23;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(132, 63);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(233, 26);
            txtCantidad.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 0;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 1;
            label3.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 18);
            label6.TabIndex = 4;
            label6.Text = "Tipo de registro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(406, 60);
            label11.Name = "label11";
            label11.Size = new Size(125, 18);
            label11.TabIndex = 9;
            label11.Text = "Precio unitario";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(567, 63);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(233, 26);
            txtPrecio.TabIndex = 13;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(132, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(227, 26);
            txtFecha.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-22, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 52);
            panel2.TabIndex = 17;
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
            label1.Location = new Point(396, 13);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Navy;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(btnLimpiarCitas);
            panel4.Controls.Add(btnAgregarCitas);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(-22, 480);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 100);
            panel4.TabIndex = 16;
            // 
            // btnLimpiarCitas
            // 
            btnLimpiarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarCitas.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarCitas.Image = (Image)resources.GetObject("btnLimpiarCitas.Image");
            btnLimpiarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCitas.Location = new Point(478, 22);
            btnLimpiarCitas.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(9, 8, 22, 8);
            btnLimpiarCitas.Size = new Size(150, 43);
            btnLimpiarCitas.TabIndex = 15;
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
            btnAgregarCitas.Location = new Point(29, 22);
            btnAgregarCitas.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCitas.Name = "btnAgregarCitas";
            btnAgregarCitas.Padding = new Padding(9, 8, 22, 8);
            btnAgregarCitas.Size = new Size(150, 43);
            btnAgregarCitas.TabIndex = 13;
            btnAgregarCitas.Text = "Agregar";
            btnAgregarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarCitas.UseVisualStyleBackColor = false;
            btnAgregarCitas.Click += btnAgregarCitas_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(701, 22);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 8, 22, 8);
            button2.Size = new Size(150, 43);
            button2.TabIndex = 11;
            button2.Text = "Salir";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Navy;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Window;
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(25, 13);
            label12.Name = "label12";
            label12.Size = new Size(211, 18);
            label12.TabIndex = 1;
            label12.Text = "Nombre del medicamento";
            // 
            // nombreMedicamento
            // 
            nombreMedicamento.FormattingEnabled = true;
            nombreMedicamento.Location = new Point(242, 12);
            nombreMedicamento.Name = "nombreMedicamento";
            nombreMedicamento.Size = new Size(291, 23);
            nombreMedicamento.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Navy;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(nombreMedicamento);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(7, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 45);
            panel3.TabIndex = 21;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.Crimson;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.FlatAppearance.BorderColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(551, 9);
            button6.Name = "button6";
            button6.Size = new Size(233, 27);
            button6.TabIndex = 8;
            button6.Text = "Ingresar Nuevo Medicamento";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Navy;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboProveedores);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(7, 366);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 45);
            panel1.TabIndex = 23;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Crimson;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(551, 9);
            button1.Name = "button1";
            button1.Size = new Size(233, 27);
            button1.TabIndex = 8;
            button1.Text = "Ingresar Nuevo Proveedor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboProveedores
            // 
            comboProveedores.FormattingEnabled = true;
            comboProveedores.Location = new Point(242, 12);
            comboProveedores.Name = "comboProveedores";
            comboProveedores.Size = new Size(291, 23);
            comboProveedores.TabIndex = 22;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Navy;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(25, 12);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 1;
            label4.Text = "Proveedor";
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "Registros";
            Text = "Registros";
            Load += Registros_Load;
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Label label12;
        private ComboBox nombreMedicamento;
        private Panel panel3;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label11;
        private TextBox txtPrecio;
        private ComboBox comboTipo;
        private DateTimePicker txtFecha;
        private Panel panel1;
        private Button button1;
        private ComboBox comboProveedores;
        private Label label4;
        private Button btnLimpiarCitas;
        private Button btnAgregarCitas;
        private Button button2;
    }
}