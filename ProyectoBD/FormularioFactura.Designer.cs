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
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnLimpiarCitas = new Button();
            btnAgregarMedicamento = new Button();
            button2 = new Button();
            txtdni = new TextBox();
            panel3 = new Panel();
            textBoxEfectivo = new TextBox();
            efectivo = new Label();
            textBoxRTN = new TextBox();
            RTN = new Label();
            comboBoxPuntoEmision = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            subtotal = new Label();
            total = new Label();
            label7 = new Label();
            label8 = new Label();
            ivs15 = new Label();
            isv18 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            detalleFactura = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            isv = new DataGridViewTextBoxColumn();
            agregarProduto = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            impuesto = new ComboBox();
            label10 = new Label();
            txtCantidad = new TextBox();
            mostrarProducto = new DataGridView();
            label17 = new Label();
            label14 = new Label();
            txtProducto = new TextBox();
            buscarProducto = new Button();
            label15 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detalleFactura).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mostrarProducto).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-22, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 36);
            panel2.TabIndex = 25;
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
            label1.Location = new Point(397, 14);
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
            btnLimpiarCitas.Click += btnLimpiarCitas_Click;
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
            btnAgregarMedicamento.Click += btnAgregarMedicamento_Click;
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
            button2.Click += button2_Click;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(204, 11);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(164, 23);
            txtdni.TabIndex = 29;
            txtdni.TextChanged += txtdni_TextChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Navy;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(textBoxEfectivo);
            panel3.Controls.Add(efectivo);
            panel3.Controls.Add(textBoxRTN);
            panel3.Controls.Add(RTN);
            panel3.Controls.Add(comboBoxPuntoEmision);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtdni);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(10, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 81);
            panel3.TabIndex = 27;
            panel3.Paint += panel3_Paint;
            // 
            // textBoxEfectivo
            // 
            textBoxEfectivo.Location = new Point(583, 46);
            textBoxEfectivo.Name = "textBoxEfectivo";
            textBoxEfectivo.Size = new Size(206, 23);
            textBoxEfectivo.TabIndex = 36;
            // 
            // efectivo
            // 
            efectivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            efectivo.AutoSize = true;
            efectivo.BackColor = Color.Navy;
            efectivo.FlatStyle = FlatStyle.Popup;
            efectivo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            efectivo.ForeColor = SystemColors.Window;
            efectivo.ImageAlign = ContentAlignment.TopCenter;
            efectivo.Location = new Point(404, 46);
            efectivo.Name = "efectivo";
            efectivo.Size = new Size(147, 18);
            efectivo.TabIndex = 35;
            efectivo.Text = "Pago en Efectivo:";
            // 
            // textBoxRTN
            // 
            textBoxRTN.Location = new Point(204, 46);
            textBoxRTN.Name = "textBoxRTN";
            textBoxRTN.Size = new Size(164, 23);
            textBoxRTN.TabIndex = 34;
            // 
            // RTN
            // 
            RTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RTN.AutoSize = true;
            RTN.BackColor = Color.Navy;
            RTN.FlatStyle = FlatStyle.Popup;
            RTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RTN.ForeColor = SystemColors.Window;
            RTN.ImageAlign = ContentAlignment.TopCenter;
            RTN.Location = new Point(25, 46);
            RTN.Name = "RTN";
            RTN.Size = new Size(135, 18);
            RTN.TabIndex = 33;
            RTN.Text = "RTN del Cliente:";
            // 
            // comboBoxPuntoEmision
            // 
            comboBoxPuntoEmision.FormattingEnabled = true;
            comboBoxPuntoEmision.Location = new Point(583, 11);
            comboBoxPuntoEmision.Name = "comboBoxPuntoEmision";
            comboBoxPuntoEmision.Size = new Size(206, 23);
            comboBoxPuntoEmision.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(407, 11);
            label2.Name = "label2";
            label2.Size = new Size(150, 18);
            label2.TabIndex = 30;
            label2.Text = "Punto de Emisión.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Navy;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(25, 11);
            label3.Name = "label3";
            label3.Size = new Size(173, 18);
            label3.TabIndex = 26;
            label3.Text = "Numero de identidad";
            label3.Click += label3_Click_1;
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
            groupBox1.Location = new Point(1, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 100);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.85567F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.14433F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(subtotal, 1, 0);
            tableLayoutPanel1.Controls.Add(total, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(ivs15, 3, 0);
            tableLayoutPanel1.Controls.Add(isv18, 3, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.515152F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.484848F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(808, 75);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
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
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Location = new Point(174, 0);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(43, 18);
            subtotal.TabIndex = 10;
            subtotal.Text = "0.00";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(174, 38);
            total.Name = "total";
            total.Size = new Size(43, 18);
            total.TabIndex = 12;
            total.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(467, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 18);
            label7.TabIndex = 1;
            label7.Text = "impuesto 15%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(467, 38);
            label8.Name = "label8";
            label8.Size = new Size(119, 18);
            label8.TabIndex = 4;
            label8.Text = "impuesto 18%";
            // 
            // ivs15
            // 
            ivs15.AutoSize = true;
            ivs15.Location = new Point(653, 0);
            ivs15.Name = "ivs15";
            ivs15.Size = new Size(43, 18);
            ivs15.TabIndex = 11;
            ivs15.Text = "0.00";
            // 
            // isv18
            // 
            isv18.AutoSize = true;
            isv18.Location = new Point(653, 38);
            isv18.Name = "isv18";
            isv18.Size = new Size(43, 18);
            isv18.TabIndex = 13;
            isv18.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 38);
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
            // detalleFactura
            // 
            detalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detalleFactura.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Precio, cantidad, isv });
            detalleFactura.Location = new Point(7, 33);
            detalleFactura.Name = "detalleFactura";
            detalleFactura.RowTemplate.Height = 25;
            detalleFactura.Size = new Size(362, 177);
            detalleFactura.TabIndex = 28;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "nombre";
            Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            Precio.HeaderText = "precio";
            Precio.Name = "Precio";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "cantidad";
            cantidad.Name = "cantidad";
            // 
            // isv
            // 
            isv.HeaderText = "isv";
            isv.Name = "isv";
            // 
            // agregarProduto
            // 
            agregarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            agregarProduto.BackColor = Color.FromArgb(0, 192, 0);
            agregarProduto.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agregarProduto.ForeColor = SystemColors.ActiveCaptionText;
            agregarProduto.Image = (Image)resources.GetObject("agregarProduto.Image");
            agregarProduto.ImageAlign = ContentAlignment.MiddleLeft;
            agregarProduto.Location = new Point(125, 208);
            agregarProduto.Margin = new Padding(3, 2, 3, 2);
            agregarProduto.Name = "agregarProduto";
            agregarProduto.Padding = new Padding(9, 8, 22, 8);
            agregarProduto.Size = new Size(142, 45);
            agregarProduto.TabIndex = 29;
            agregarProduto.Text = "Agregar";
            agregarProduto.TextAlign = ContentAlignment.MiddleRight;
            agregarProduto.UseVisualStyleBackColor = false;
            agregarProduto.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Red;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(112, 215);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(9, 8, 22, 8);
            button3.Size = new Size(142, 45);
            button3.TabIndex = 24;
            button3.Text = "Eliminar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(detalleFactura);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(9, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 383);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(impuesto);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(txtCantidad);
            panel5.Controls.Add(mostrarProducto);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(agregarProduto);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txtProducto);
            panel5.Controls.Add(buscarProducto);
            panel5.Location = new Point(389, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(423, 260);
            panel5.TabIndex = 35;
            // 
            // impuesto
            // 
            impuesto.FormattingEnabled = true;
            impuesto.Items.AddRange(new object[] { "0.18", "0.15" });
            impuesto.Location = new Point(325, 174);
            impuesto.Name = "impuesto";
            impuesto.Size = new Size(56, 23);
            impuesto.TabIndex = 31;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientActiveCaption;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.ImageAlign = ContentAlignment.TopCenter;
            label10.Location = new Point(205, 176);
            label10.Name = "label10";
            label10.Size = new Size(114, 18);
            label10.TabIndex = 35;
            label10.Text = "Impuesto del ";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(124, 176);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(54, 23);
            txtCantidad.TabIndex = 32;
            // 
            // mostrarProducto
            // 
            mostrarProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostrarProducto.Location = new Point(3, 54);
            mostrarProducto.Name = "mostrarProducto";
            mostrarProducto.RowTemplate.Height = 25;
            mostrarProducto.Size = new Size(417, 111);
            mostrarProducto.TabIndex = 34;
            mostrarProducto.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.BackColor = SystemColors.GradientActiveCaption;
            label17.FlatStyle = FlatStyle.Popup;
            label17.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Navy;
            label17.ImageAlign = ContentAlignment.TopCenter;
            label17.Location = new Point(19, 176);
            label17.Name = "label17";
            label17.Size = new Size(80, 18);
            label17.TabIndex = 31;
            label17.Text = "Cantidad";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = SystemColors.GradientActiveCaption;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Navy;
            label14.ImageAlign = ContentAlignment.TopCenter;
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(154, 18);
            label14.TabIndex = 1;
            label14.Text = "Buscar Procducto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(3, 26);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(330, 23);
            txtProducto.TabIndex = 24;
            // 
            // buscarProducto
            // 
            buscarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buscarProducto.BackColor = Color.Crimson;
            buscarProducto.BackgroundImageLayout = ImageLayout.Center;
            buscarProducto.FlatAppearance.BorderColor = Color.Navy;
            buscarProducto.FlatStyle = FlatStyle.Flat;
            buscarProducto.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buscarProducto.ForeColor = Color.Transparent;
            buscarProducto.Location = new Point(339, 25);
            buscarProducto.Name = "buscarProducto";
            buscarProducto.Size = new Size(81, 23);
            buscarProducto.TabIndex = 8;
            buscarProducto.Text = "buscar";
            buscarProducto.UseVisualStyleBackColor = false;
            buscarProducto.Click += button4_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = SystemColors.GradientActiveCaption;
            label15.FlatStyle = FlatStyle.Popup;
            label15.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Navy;
            label15.ImageAlign = ContentAlignment.TopCenter;
            label15.Location = new Point(3, 7);
            label15.Name = "label15";
            label15.Size = new Size(168, 18);
            label15.TabIndex = 33;
            label15.Text = "Detalle de la factura";
            // 
            // FormularioFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "FormularioFactura";
            Text = "FormularioFactura";
            Load += FormularioFactura_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)detalleFactura).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mostrarProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Button btnLimpiarCitas;
        private Button btnAgregarMedicamento;
        private Button button2;
        private TextBox txtdni;
        private Panel panel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label subtotal;
        private Label label9;
        private Label total;
        private TextBox textBox3;
        private DataGridView detalleFactura;
        private Button agregarProduto;
        private Button button3;
        private Panel panel1;
        private Label ivs15;
        private Label isv18;
        private TextBox txtProducto;
        private Button buscarProducto;
        private Label label15;
        private DataGridView mostrarProducto;
        private Panel panel5;
        private TextBox txtCantidad;
        private Label label17;
        private Label label14;
        private ComboBox impuesto;
        private Label label10;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn isv;
        private Label label3;
        private ComboBox comboBoxPuntoEmision;
        private Label label2;
        private TextBox textBoxEfectivo;
        private Label efectivo;
        private TextBox textBoxRTN;
        private Label RTN;
    }
}