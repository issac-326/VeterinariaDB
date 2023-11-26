namespace ProyectoBD
{
    partial class FormularioFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioFactura));
            panel3 = new Panel();
            button6 = new Button();
            label12 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboTipo = new ComboBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label11 = new Label();
            txtPrecio = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            btnLimpiarCitas = new Button();
            btnAgregarMedicamento = new Button();
            button2 = new Button();
            txtFecha = new DateTimePicker();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Navy;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(10, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 45);
            panel3.TabIndex = 27;
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
            button6.Text = "buscar";
            button6.UseVisualStyleBackColor = false;
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
            label12.Size = new Size(145, 18);
            label12.TabIndex = 1;
            label12.Text = "Nombre paciente";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(14, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(814, 133);
            groupBox2.TabIndex = 26;
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
            tableLayoutPanel2.Size = new Size(808, 108);
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
            txtCantidad.Location = new Point(132, 57);
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
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 1;
            label3.Text = "Cantidad";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 36);
            label6.TabIndex = 4;
            label6.Text = "Tipo de documento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(406, 54);
            label11.Name = "label11";
            label11.Size = new Size(125, 18);
            label11.TabIndex = 9;
            label11.Text = "Precio unitario";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(567, 57);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(233, 26);
            txtPrecio.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-22, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 52);
            panel2.TabIndex = 25;
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
            label1.Size = new Size(80, 22);
            label1.TabIndex = 0;
            label1.Text = "Factura";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Navy;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(btnLimpiarCitas);
            panel4.Controls.Add(btnAgregarMedicamento);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(-22, 500);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 80);
            panel4.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 23);
            textBox1.TabIndex = 24;
            // 
            // btnLimpiarCitas
            // 
            btnLimpiarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarCitas.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarCitas.Image = (Image)resources.GetObject("btnLimpiarCitas.Image");
            btnLimpiarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCitas.Location = new Point(537, 13);
            btnLimpiarCitas.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(9, 8, 22, 8);
            btnLimpiarCitas.Size = new Size(150, 43);
            btnLimpiarCitas.TabIndex = 23;
            btnLimpiarCitas.Text = "Limpiar";
            btnLimpiarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCitas.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMedicamento
            // 
            btnAgregarMedicamento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarMedicamento.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarMedicamento.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarMedicamento.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarMedicamento.Image = (Image)resources.GetObject("btnAgregarMedicamento.Image");
            btnAgregarMedicamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarMedicamento.Location = new Point(32, 13);
            btnAgregarMedicamento.Margin = new Padding(3, 2, 3, 2);
            btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            btnAgregarMedicamento.Padding = new Padding(9, 8, 22, 8);
            btnAgregarMedicamento.Size = new Size(150, 43);
            btnAgregarMedicamento.TabIndex = 22;
            btnAgregarMedicamento.Text = "Factuar";
            btnAgregarMedicamento.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarMedicamento.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(704, 13);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 8, 22, 8);
            button2.Size = new Size(150, 43);
            button2.TabIndex = 21;
            button2.Text = "Salir";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(132, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(227, 26);
            txtFecha.TabIndex = 23;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(14, 266);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(388, 214);
            dataGridView2.TabIndex = 30;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(10, 241);
            label4.Name = "label4";
            label4.Size = new Size(144, 22);
            label4.TabIndex = 1;
            label4.Text = "Detalle factura";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.ImeMode = ImeMode.Disable;
            groupBox1.Location = new Point(454, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 228);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9832649F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.01674F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.4074059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.5925941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(368, 203);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 26);
            textBox2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 0;
            label5.Text = "Subtotal";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 45);
            label7.Name = "label7";
            label7.Size = new Size(119, 18);
            label7.TabIndex = 1;
            label7.Text = "impuesto 15%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 96);
            label8.Name = "label8";
            label8.Size = new Size(119, 18);
            label8.TabIndex = 4;
            label8.Text = "impuesto 18%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 158);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 9;
            label9.Text = "Total";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 26);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 26);
            textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(135, 99);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(230, 26);
            textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(135, 161);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(230, 26);
            textBox6.TabIndex = 26;
            // 
            // FormularioFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(panel3);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "FormularioFactura";
            Text = "FormularioFactura";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Button button6;
        private Label label12;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboTipo;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label11;
        private TextBox txtPrecio;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private TextBox textBox1;
        private DateTimePicker txtFecha;
        private Button btnLimpiarCitas;
        private Button btnAgregarMedicamento;
        private Button button2;
        private DataGridView dataGridView2;
        private Label label4;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}