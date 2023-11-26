namespace ProyectoBD
{
    partial class Recetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recetas));
            panel3 = new Panel();
            textBox1 = new TextBox();
            button6 = new Button();
            label12 = new Label();
            nombreMedicamento = new ComboBox();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnLimpiarCitas = new Button();
            btnAgregarMedicamento = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            panel3.Location = new Point(12, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 45);
            panel3.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 30;
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
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
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
            label12.Size = new Size(144, 18);
            label12.TabIndex = 1;
            label12.Text = "Nombre mascota";
            // 
            // nombreMedicamento
            // 
            nombreMedicamento.FormattingEnabled = true;
            nombreMedicamento.Location = new Point(3, 49);
            nombreMedicamento.Name = "nombreMedicamento";
            nombreMedicamento.Size = new Size(425, 26);
            nombreMedicamento.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-22, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 52);
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
            label1.Location = new Point(396, 13);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 0;
            label1.Text = "Recetas";
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
            btnLimpiarCitas.Location = new Point(536, 29);
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
            btnAgregarMedicamento.Location = new Point(31, 29);
            btnAgregarMedicamento.Margin = new Padding(3, 2, 3, 2);
            btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            btnAgregarMedicamento.Padding = new Padding(9, 8, 22, 8);
            btnAgregarMedicamento.Size = new Size(150, 43);
            btnAgregarMedicamento.TabIndex = 22;
            btnAgregarMedicamento.Text = "Agregar";
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
            button2.Location = new Point(703, 29);
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 95);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(820, 145);
            dataGridView2.TabIndex = 29;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.ImeMode = ImeMode.Disable;
            groupBox2.Location = new Point(12, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(819, 218);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Medicamentos";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.318573F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8031979F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.87823F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txtCantidad, 2, 1);
            tableLayoutPanel2.Controls.Add(label3, 1, 1);
            tableLayoutPanel2.Controls.Add(nombreMedicamento, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ImeMode = ImeMode.KatakanaHalf;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(813, 193);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(332, 18);
            label2.TabIndex = 29;
            label2.Text = "Seleccione el medicamento y la cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(630, 49);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(66, 26);
            txtCantidad.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 46);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 1;
            label3.Text = "Cantidad";
            // 
            // Recetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "Recetas";
            Text = "Recetas";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private ComboBox nombreMedicamento;
        private Label label12;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Button button6;
        private Button btnLimpiarCitas;
        private Button btnAgregarMedicamento;
        private Button button2;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TextBox txtCantidad;
        private Label label2;
        private TextBox textBox1;
    }
}