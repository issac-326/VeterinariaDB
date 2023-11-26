namespace ProyectoBD
{
    partial class Medicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamento));
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            Precio = new Label();
            label6 = new Label();
            txtFecha = new DateTimePicker();
            label2 = new Label();
            formulaFarmaceutica = new ComboBox();
            txtNombre = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnLimpiarCitas = new Button();
            btnAgregarMedicamento = new Button();
            button2 = new Button();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            groupBox2.Location = new Point(4, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 198);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formulario";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2413788F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0344849F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.13793135F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5517254F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0344849F));
            tableLayoutPanel2.Controls.Add(Precio, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(txtFecha, 4, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(formulaFarmaceutica, 1, 1);
            tableLayoutPanel2.Controls.Add(txtNombre, 1, 0);
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
            tableLayoutPanel2.Size = new Size(811, 173);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(3, 86);
            Precio.Name = "Precio";
            Precio.Size = new Size(73, 18);
            Precio.TabIndex = 1;
            Precio.Text = "Formula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 18);
            label6.TabIndex = 4;
            label6.Text = "Vencimiento";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(560, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(227, 26);
            txtFecha.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // formulaFarmaceutica
            // 
            formulaFarmaceutica.FormattingEnabled = true;
            formulaFarmaceutica.Location = new Point(142, 89);
            formulaFarmaceutica.Name = "formulaFarmaceutica";
            formulaFarmaceutica.Size = new Size(233, 26);
            formulaFarmaceutica.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 26);
            txtNombre.TabIndex = 26;
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
            label1.Location = new Point(347, 17);
            label1.Name = "label1";
            label1.Size = new Size(215, 22);
            label1.TabIndex = 0;
            label1.Text = "Ingresar Medicamento";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Navy;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(btnLimpiarCitas);
            panel4.Controls.Add(btnAgregarMedicamento);
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
            btnLimpiarCitas.Location = new Point(536, 29);
            btnLimpiarCitas.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCitas.Name = "btnLimpiarCitas";
            btnLimpiarCitas.Padding = new Padding(9, 8, 22, 8);
            btnLimpiarCitas.Size = new Size(150, 43);
            btnLimpiarCitas.TabIndex = 20;
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
            btnAgregarMedicamento.Location = new Point(31, 29);
            btnAgregarMedicamento.Margin = new Padding(3, 2, 3, 2);
            btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            btnAgregarMedicamento.Padding = new Padding(9, 8, 22, 8);
            btnAgregarMedicamento.Size = new Size(150, 43);
            btnAgregarMedicamento.TabIndex = 18;
            btnAgregarMedicamento.Text = "Agregar";
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
            button2.Location = new Point(703, 29);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 8, 22, 8);
            button2.Size = new Size(150, 43);
            button2.TabIndex = 16;
            button2.Text = "Salir";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Medicamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "Medicamento";
            Text = "Medicamento";
            Load += Medicamento_Load;
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label Precio;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Button btnLimpiarCitas;
        private Button btnAgregarMedicamento;
        private Button button2;
        private DateTimePicker txtFecha;
        private ComboBox tipoFormula;
        private ComboBox formulaFarmaceutica;
        private TextBox txtNombre;
    }
}