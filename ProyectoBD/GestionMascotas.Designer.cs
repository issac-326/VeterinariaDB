namespace ProyectoBD
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
            label1 = new Label();
            panel4 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button8 = new Button();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)mostradorMascotas).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // mostradorMascotas
            // 
            mostradorMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorMascotas.Location = new Point(14, 302);
            mostradorMascotas.Name = "mostradorMascotas";
            mostradorMascotas.RowTemplate.Height = 25;
            mostradorMascotas.Size = new Size(814, 166);
            mostradorMascotas.TabIndex = 19;
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
            groupBox2.Location = new Point(11, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 234);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 175);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 20;
            label2.Text = "Estado";
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(137, 38);
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(233, 26);
            txtCaracteristicas.TabIndex = 14;
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
            Nombre.Size = new Size(71, 18);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 35);
            label3.Name = "label3";
            label3.Size = new Size(123, 18);
            label3.TabIndex = 1;
            label3.Text = "Caracteristica";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 105);
            label5.Name = "label5";
            label5.Size = new Size(101, 18);
            label5.TabIndex = 3;
            label5.Text = "Esterilizado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 140);
            label7.Name = "label7";
            label7.Size = new Size(79, 18);
            label7.TabIndex = 5;
            label7.Text = "Agresivo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 26);
            txtNombre.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 4;
            label6.Text = "Peso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 70);
            label10.Name = "label10";
            label10.Size = new Size(72, 18);
            label10.TabIndex = 8;
            label10.Text = "Especie";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 105);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 7;
            label9.Text = "Raza";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 140);
            label8.Name = "label8";
            label8.Size = new Size(68, 18);
            label8.TabIndex = 6;
            label8.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 70);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 2;
            label4.Text = "Fecha_nac";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(414, 35);
            label11.Name = "label11";
            label11.Size = new Size(72, 18);
            label11.TabIndex = 9;
            label11.Text = "Tamaño";
            // 
            // txtTamano
            // 
            txtTamano.Location = new Point(539, 38);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(233, 26);
            txtTamano.TabIndex = 13;
            // 
            // selEstado
            // 
            selEstado.FormattingEnabled = true;
            selEstado.Location = new Point(137, 178);
            selEstado.Name = "selEstado";
            selEstado.Size = new Size(233, 26);
            selEstado.TabIndex = 21;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(137, 73);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(233, 26);
            txtFecha.TabIndex = 22;
            // 
            // txtAgresivo
            // 
            txtAgresivo.AutoSize = true;
            txtAgresivo.Location = new Point(137, 143);
            txtAgresivo.Name = "txtAgresivo";
            txtAgresivo.Size = new Size(70, 22);
            txtAgresivo.TabIndex = 24;
            txtAgresivo.Text = "Lo es";
            txtAgresivo.UseVisualStyleBackColor = true;
            // 
            // selEspecie
            // 
            selEspecie.FormattingEnabled = true;
            selEspecie.Location = new Point(539, 73);
            selEspecie.Name = "selEspecie";
            selEspecie.Size = new Size(233, 26);
            selEspecie.TabIndex = 25;
            selEspecie.SelectedIndexChanged += selEspecie_SelectedIndexChanged;
            // 
            // selRaza
            // 
            selRaza.FormattingEnabled = true;
            selRaza.Location = new Point(539, 108);
            selRaza.Name = "selRaza";
            selRaza.Size = new Size(233, 26);
            selRaza.TabIndex = 26;
            // 
            // selGenero
            // 
            selGenero.FormattingEnabled = true;
            selGenero.Location = new Point(539, 143);
            selGenero.Name = "selGenero";
            selGenero.Size = new Size(233, 26);
            selGenero.TabIndex = 27;
            // 
            // txtEsterilizacion
            // 
            txtEsterilizacion.AutoSize = true;
            txtEsterilizacion.Location = new Point(137, 108);
            txtEsterilizacion.Name = "txtEsterilizacion";
            txtEsterilizacion.Size = new Size(86, 22);
            txtEsterilizacion.TabIndex = 28;
            txtEsterilizacion.Text = "Lo está";
            txtEsterilizacion.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-22, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 52);
            panel2.TabIndex = 17;
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
            label1.Location = new Point(286, 16);
            label1.Name = "label1";
            label1.Size = new Size(329, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre de lo que se esta haciendo";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Navy;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button11);
            panel4.Location = new Point(-22, 480);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 100);
            panel4.TabIndex = 16;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = SystemColors.ButtonFace;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.BorderColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(386, 15);
            button5.Name = "button5";
            button5.Size = new Size(105, 55);
            button5.TabIndex = 9;
            button5.Text = "LIMPIAR ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = SystemColors.ButtonFace;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(26, 15);
            button4.Name = "button4";
            button4.Size = new Size(105, 55);
            button4.TabIndex = 8;
            button4.Text = "AGREGAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = SystemColors.ButtonFace;
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.FlatAppearance.BorderColor = Color.Navy;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.Navy;
            button8.Location = new Point(568, 15);
            button8.Name = "button8";
            button8.Size = new Size(105, 55);
            button8.TabIndex = 7;
            button8.Text = "SALIR";
            button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button11.BackColor = SystemColors.ButtonFace;
            button11.BackgroundImageLayout = ImageLayout.Center;
            button11.FlatAppearance.BorderColor = Color.Navy;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.Navy;
            button11.Location = new Point(203, 15);
            button11.Name = "button11";
            button11.Size = new Size(105, 55);
            button11.TabIndex = 5;
            button11.Text = "MODIFICAR";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // GestionMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 567);
            Controls.Add(mostradorMascotas);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "GestionMascotas";
            Text = "GestionMascotas";
            Load += GestionMascotas_Load;
            ((System.ComponentModel.ISupportInitialize)mostradorMascotas).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
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
        private Panel panel4;
        private Button button5;
        private Button button4;
        private Button button8;
        private Button button11;
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
    }
}