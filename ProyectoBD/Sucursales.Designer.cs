namespace ProyectoBD
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            dataGridView2 = new DataGridView();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtIdDireccion = new TextBox();
            txtCiudad = new ComboBox();
            label10 = new Label();
            txtFarmacia = new TextBox();
            txtDireccion = new TextBox();
            txtId = new TextBox();
            label9 = new Label();
            label7 = new Label();
            txtEstado = new ComboBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(37, 284);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(771, 202);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(457, 501);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(9, 8, 22, 8);
            btnLimpiar.Size = new Size(152, 52);
            btnLimpiar.TabIndex = 20;
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
            btnModificar.Location = new Point(233, 501);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Padding = new Padding(9, 8, 22, 8);
            btnModificar.Size = new Size(152, 52);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(667, 501);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(9, 8, 22, 8);
            btnSalir.Size = new Size(152, 52);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtIdDireccion);
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtFarmacia);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(37, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 244);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(565, 203);
            label8.Name = "label8";
            label8.Size = new Size(100, 18);
            label8.TabIndex = 36;
            label8.Text = "IdDireccion";
            // 
            // txtIdDireccion
            // 
            txtIdDireccion.Location = new Point(671, 200);
            txtIdDireccion.Name = "txtIdDireccion";
            txtIdDireccion.ReadOnly = true;
            txtIdDireccion.Size = new Size(29, 26);
            txtIdDireccion.TabIndex = 35;
            // 
            // txtCiudad
            // 
            txtCiudad.FormattingEnabled = true;
            txtCiudad.Location = new Point(520, 74);
            txtCiudad.Margin = new Padding(3, 2, 3, 2);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(240, 26);
            txtCiudad.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(391, 79);
            label10.Name = "label10";
            label10.Size = new Size(64, 18);
            label10.TabIndex = 32;
            label10.Text = "Ciudad";
            // 
            // txtFarmacia
            // 
            txtFarmacia.Location = new Point(122, 186);
            txtFarmacia.Name = "txtFarmacia";
            txtFarmacia.ReadOnly = true;
            txtFarmacia.Size = new Size(240, 26);
            txtFarmacia.TabIndex = 30;
            txtFarmacia.TextChanged += txtFarmacia_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(520, 127);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(240, 26);
            txtDireccion.TabIndex = 29;
            // 
            // txtId
            // 
            txtId.Location = new Point(493, 200);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(29, 26);
            txtId.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(393, 203);
            label9.Name = "label9";
            label9.Size = new Size(94, 18);
            label9.TabIndex = 27;
            label9.Text = "IdSucursal";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 189);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 16;
            label7.Text = "Farmacia";
            // 
            // txtEstado
            // 
            txtEstado.FormattingEnabled = true;
            txtEstado.Location = new Point(520, 22);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(240, 26);
            txtEstado.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(124, 130);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(240, 26);
            txtCorreo.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 26);
            txtNombre.TabIndex = 9;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(124, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 26);
            txtCodigo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 25);
            label6.Name = "label6";
            label6.Size = new Size(64, 18);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 130);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 4;
            label5.Text = "Referencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 130);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 82);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
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
            label4.Location = new Point(406, 9);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 22;
            label4.Text = "Sucursales";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(27, 501);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(9, 8, 22, 8);
            btnAgregar.Size = new Size(152, 52);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Sucursales
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
            Name = "Sucursales";
            Text = "Sucursales";
            Load += Sucursales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnSalir;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private Label label6;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private ComboBox txtEstado;
        private Label label4;
        private Button btnAgregar;
        private Label label7;
        private TextBox txtId;
        private Label label9;
        private TextBox txtDireccion;
        private TextBox txtFarmacia;
        private Label label10;
        private ComboBox txtCiudad;
        private Label label8;
        private TextBox txtIdDireccion;
    }
}