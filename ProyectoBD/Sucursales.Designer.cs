﻿namespace ProyectoBD
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
            txtId = new TextBox();
            label9 = new Label();
            btnDireccion = new Button();
            btnFarmacia = new Button();
            txtFarmacia = new ComboBox();
            label7 = new Label();
            txtGerente = new ComboBox();
            txtEstado = new ComboBox();
            txtDireccion = new ComboBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label8 = new Label();
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
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnDireccion);
            groupBox1.Controls.Add(btnFarmacia);
            groupBox1.Controls.Add(txtFarmacia);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGerente);
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label8);
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
            // txtId
            // 
            txtId.Location = new Point(599, 186);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(120, 26);
            txtId.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(461, 189);
            label9.Name = "label9";
            label9.Size = new Size(132, 18);
            label9.TabIndex = 27;
            label9.Text = "IdSeleccionado";
            // 
            // btnDireccion
            // 
            btnDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDireccion.BackColor = Color.FromArgb(0, 192, 0);
            btnDireccion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDireccion.ForeColor = SystemColors.ActiveCaptionText;
            btnDireccion.Image = (Image)resources.GetObject("btnDireccion.Image");
            btnDireccion.ImageAlign = ContentAlignment.MiddleLeft;
            btnDireccion.Location = new Point(369, 175);
            btnDireccion.Margin = new Padding(3, 2, 3, 2);
            btnDireccion.Name = "btnDireccion";
            btnDireccion.Padding = new Padding(9, 8, 22, 8);
            btnDireccion.Size = new Size(55, 47);
            btnDireccion.TabIndex = 26;
            btnDireccion.TextAlign = ContentAlignment.MiddleRight;
            btnDireccion.UseVisualStyleBackColor = false;
            btnDireccion.Click += btnDireccion_Click;
            // 
            // btnFarmacia
            // 
            btnFarmacia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFarmacia.BackColor = Color.FromArgb(0, 192, 0);
            btnFarmacia.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFarmacia.ForeColor = SystemColors.ActiveCaptionText;
            btnFarmacia.Image = (Image)resources.GetObject("btnFarmacia.Image");
            btnFarmacia.ImageAlign = ContentAlignment.MiddleLeft;
            btnFarmacia.Location = new Point(727, 16);
            btnFarmacia.Margin = new Padding(3, 2, 3, 2);
            btnFarmacia.Name = "btnFarmacia";
            btnFarmacia.Padding = new Padding(9, 8, 22, 8);
            btnFarmacia.Size = new Size(55, 47);
            btnFarmacia.TabIndex = 25;
            btnFarmacia.TextAlign = ContentAlignment.MiddleRight;
            btnFarmacia.UseVisualStyleBackColor = false;
            btnFarmacia.Click += btnFarmacia_Click;
            // 
            // txtFarmacia
            // 
            txtFarmacia.FormattingEnabled = true;
            txtFarmacia.Location = new Point(461, 27);
            txtFarmacia.Margin = new Padding(3, 2, 3, 2);
            txtFarmacia.Name = "txtFarmacia";
            txtFarmacia.Size = new Size(258, 26);
            txtFarmacia.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 27);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 16;
            label7.Text = "Farmacia";
            // 
            // txtGerente
            // 
            txtGerente.FormattingEnabled = true;
            txtGerente.Location = new Point(461, 127);
            txtGerente.Margin = new Padding(3, 2, 3, 2);
            txtGerente.Name = "txtGerente";
            txtGerente.Size = new Size(258, 26);
            txtGerente.TabIndex = 15;
            // 
            // txtEstado
            // 
            txtEstado.FormattingEnabled = true;
            txtEstado.Location = new Point(461, 76);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(258, 26);
            txtEstado.TabIndex = 13;
            // 
            // txtDireccion
            // 
            txtDireccion.FormattingEnabled = true;
            txtDireccion.Location = new Point(124, 186);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(238, 26);
            txtDireccion.TabIndex = 12;
            txtDireccion.SelectedIndexChanged += txtDireccion_SelectedIndexChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(124, 130);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(238, 26);
            txtCorreo.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 26);
            txtNombre.TabIndex = 9;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(124, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(238, 26);
            txtCodigo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(381, 127);
            label8.Name = "label8";
            label8.Size = new Size(74, 18);
            label8.TabIndex = 7;
            label8.Text = "Gerente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 82);
            label6.Name = "label6";
            label6.Size = new Size(64, 18);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 189);
            label5.Name = "label5";
            label5.Size = new Size(85, 18);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
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
        private Label label8;
        private Label label6;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private ComboBox txtDireccion;
        private ComboBox txtGerente;
        private ComboBox txtEstado;
        private Label label4;
        private Button btnAgregar;
        private Label label7;
        private ComboBox txtFarmacia;
        private Button btnFarmacia;
        private Button btnDireccion;
        private TextBox txtId;
        private Label label9;
    }
}