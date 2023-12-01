namespace ProyectoBD
{
    partial class Direcciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Direcciones));
            label4 = new Label();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnSalir = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtReferencia = new TextBox();
            groupBox1 = new GroupBox();
            txtCiudad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            label4.Location = new Point(373, 11);
            label4.Name = "label4";
            label4.Size = new Size(118, 22);
            label4.TabIndex = 29;
            label4.Text = "Direcciones";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(443, 503);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(9, 8, 22, 8);
            btnLimpiar.Size = new Size(152, 52);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(0, 192, 192);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(254, 503);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Padding = new Padding(9, 8, 22, 8);
            btnModificar.Size = new Size(152, 52);
            btnModificar.TabIndex = 26;
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
            btnAgregar.Location = new Point(37, 503);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(9, 8, 22, 8);
            btnAgregar.Size = new Size(152, 52);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(656, 503);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(9, 8, 22, 8);
            btnSalir.Size = new Size(152, 52);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(37, 286);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(771, 202);
            dataGridView2.TabIndex = 23;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 0;
            label1.Text = "Referencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 111);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "Ciudad";
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(169, 38);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(292, 26);
            txtReferencia.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(txtReferencia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(4, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 244);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario";
            // 
            // txtCiudad
            // 
            txtCiudad.FormattingEnabled = true;
            txtCiudad.Location = new Point(169, 103);
            txtCiudad.Margin = new Padding(3, 2, 3, 2);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(292, 26);
            txtCiudad.TabIndex = 14;
            // 
            // Direcciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 567);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView2);
            Name = "Direcciones";
            Text = "Direcciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnSalir;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtReferencia;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private ComboBox txtDireccion;
        private GroupBox groupBox1;
        private ComboBox txtCiudad;
    }
}