namespace ProyectoBD
{
    partial class Modulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulos));
            MÓDULOS = new Panel();
            button9 = new Button();
            button4 = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUsuarios = new Button();
            btnAtencion = new Button();
            btnRHH = new Button();
            btnFacturas = new Button();
            btnFarmacia = new Button();
            btnSucursal = new Button();
            btnInformacion = new Button();
            btnInfoPersonal = new Button();
            MÓDULOS.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MÓDULOS
            // 
            MÓDULOS.Controls.Add(button9);
            MÓDULOS.Controls.Add(button4);
            MÓDULOS.Controls.Add(label1);
            MÓDULOS.Dock = DockStyle.Fill;
            MÓDULOS.Location = new Point(0, 0);
            MÓDULOS.Margin = new Padding(4, 5, 4, 5);
            MÓDULOS.Name = "MÓDULOS";
            MÓDULOS.Size = new Size(1201, 945);
            MÓDULOS.TabIndex = 2;
            MÓDULOS.Paint += panel2_Paint;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.Image = Properties.Resources.salida;
            button9.Location = new Point(1077, 20);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(107, 38);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(21, 22);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(523, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "MÓDULOS";
            label1.Click += label1_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 283F));
            tableLayoutPanel1.Controls.Add(btnUsuarios, 1, 2);
            tableLayoutPanel1.Controls.Add(btnAtencion, 2, 1);
            tableLayoutPanel1.Controls.Add(btnRHH, 0, 1);
            tableLayoutPanel1.Controls.Add(btnFacturas, 3, 1);
            tableLayoutPanel1.Controls.Add(btnFarmacia, 1, 1);
            tableLayoutPanel1.Controls.Add(btnSucursal, 2, 0);
            tableLayoutPanel1.Controls.Add(btnInformacion, 1, 0);
            tableLayoutPanel1.Controls.Add(btnInfoPersonal, 2, 2);
            tableLayoutPanel1.Location = new Point(17, 83);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1167, 815);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.Window;
            btnUsuarios.BackgroundImageLayout = ImageLayout.Center;
            btnUsuarios.CausesValidation = false;
            btnUsuarios.FlatAppearance.BorderColor = Color.Navy;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.Navy;
            btnUsuarios.Image = Properties.Resources.cerrar_con_llave;
            btnUsuarios.Location = new Point(298, 547);
            btnUsuarios.Margin = new Padding(4, 5, 4, 5);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(286, 238);
            btnUsuarios.TabIndex = 14;
            btnUsuarios.Text = "Usuarios del Sistema";
            btnUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += button10_Click;
            // 
            // btnAtencion
            // 
            btnAtencion.BackColor = SystemColors.Window;
            btnAtencion.BackgroundImageLayout = ImageLayout.Center;
            btnAtencion.CausesValidation = false;
            btnAtencion.FlatAppearance.BorderColor = Color.Navy;
            btnAtencion.FlatStyle = FlatStyle.Flat;
            btnAtencion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtencion.ForeColor = Color.Navy;
            btnAtencion.Image = Properties.Resources.atencion_al_cliente;
            btnAtencion.Location = new Point(592, 276);
            btnAtencion.Margin = new Padding(4, 5, 4, 5);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(286, 238);
            btnAtencion.TabIndex = 13;
            btnAtencion.Text = "Atención al Cliente";
            btnAtencion.TextAlign = ContentAlignment.BottomCenter;
            btnAtencion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAtencion.UseVisualStyleBackColor = false;
            btnAtencion.Click += button7_Click;
            // 
            // btnRHH
            // 
            btnRHH.BackColor = SystemColors.Window;
            btnRHH.BackgroundImageLayout = ImageLayout.Center;
            btnRHH.CausesValidation = false;
            btnRHH.FlatAppearance.BorderColor = Color.Navy;
            btnRHH.FlatStyle = FlatStyle.Flat;
            btnRHH.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRHH.ForeColor = Color.Navy;
            btnRHH.Image = Properties.Resources.mano;
            btnRHH.Location = new Point(4, 276);
            btnRHH.Margin = new Padding(4, 5, 4, 5);
            btnRHH.Name = "btnRHH";
            btnRHH.Size = new Size(286, 238);
            btnRHH.TabIndex = 12;
            btnRHH.Text = "Recursos Humanos";
            btnRHH.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRHH.UseVisualStyleBackColor = false;
            btnRHH.Click += button5_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = Color.Navy;
            btnFacturas.BackgroundImageLayout = ImageLayout.Center;
            btnFacturas.CausesValidation = false;
            btnFacturas.FlatAppearance.BorderColor = Color.Navy;
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturas.ForeColor = SystemColors.Window;
            btnFacturas.Image = Properties.Resources.facturas;
            btnFacturas.Location = new Point(886, 276);
            btnFacturas.Margin = new Padding(4, 5, 4, 5);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(276, 238);
            btnFacturas.TabIndex = 7;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFacturas.UseVisualStyleBackColor = false;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // btnFarmacia
            // 
            btnFarmacia.BackColor = Color.Navy;
            btnFarmacia.BackgroundImageLayout = ImageLayout.Center;
            btnFarmacia.CausesValidation = false;
            btnFarmacia.FlatAppearance.BorderColor = Color.Navy;
            btnFarmacia.FlatStyle = FlatStyle.Flat;
            btnFarmacia.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFarmacia.ForeColor = SystemColors.Window;
            btnFarmacia.Image = Properties.Resources.farmacia;
            btnFarmacia.Location = new Point(298, 276);
            btnFarmacia.Margin = new Padding(4, 5, 4, 5);
            btnFarmacia.Name = "btnFarmacia";
            btnFarmacia.Size = new Size(286, 238);
            btnFarmacia.TabIndex = 5;
            btnFarmacia.Text = "Farmacia";
            btnFarmacia.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFarmacia.UseVisualStyleBackColor = false;
            btnFarmacia.Click += btnFarmacia_Click;
            // 
            // btnSucursal
            // 
            btnSucursal.BackColor = Color.Navy;
            btnSucursal.BackgroundImageLayout = ImageLayout.Center;
            btnSucursal.CausesValidation = false;
            btnSucursal.FlatAppearance.BorderColor = Color.Navy;
            btnSucursal.FlatStyle = FlatStyle.Flat;
            btnSucursal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSucursal.ForeColor = SystemColors.Window;
            btnSucursal.Image = Properties.Resources.sucursales;
            btnSucursal.Location = new Point(592, 5);
            btnSucursal.Margin = new Padding(4, 5, 4, 5);
            btnSucursal.Name = "btnSucursal";
            btnSucursal.Size = new Size(286, 238);
            btnSucursal.TabIndex = 2;
            btnSucursal.Text = "Sucursales";
            btnSucursal.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSucursal.UseVisualStyleBackColor = false;
            btnSucursal.Click += button3_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.BackColor = SystemColors.Window;
            btnInformacion.BackgroundImageLayout = ImageLayout.Center;
            btnInformacion.CausesValidation = false;
            btnInformacion.FlatAppearance.BorderColor = Color.Navy;
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInformacion.ForeColor = Color.Navy;
            btnInformacion.Image = Properties.Resources.empresa;
            btnInformacion.Location = new Point(298, 5);
            btnInformacion.Margin = new Padding(4, 5, 4, 5);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(286, 238);
            btnInformacion.TabIndex = 1;
            btnInformacion.Text = "Información de la Empresa";
            btnInformacion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInformacion.UseVisualStyleBackColor = false;
            btnInformacion.Click += button2_Click;
            // 
            // btnInfoPersonal
            // 
            btnInfoPersonal.BackColor = Color.Navy;
            btnInfoPersonal.BackgroundImageLayout = ImageLayout.Center;
            btnInfoPersonal.CausesValidation = false;
            btnInfoPersonal.FlatAppearance.BorderColor = Color.Navy;
            btnInfoPersonal.FlatStyle = FlatStyle.Flat;
            btnInfoPersonal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfoPersonal.ForeColor = SystemColors.Window;
            btnInfoPersonal.Image = Properties.Resources.usuario;
            btnInfoPersonal.Location = new Point(592, 547);
            btnInfoPersonal.Margin = new Padding(4, 5, 4, 5);
            btnInfoPersonal.Name = "btnInfoPersonal";
            btnInfoPersonal.Size = new Size(286, 238);
            btnInfoPersonal.TabIndex = 15;
            btnInfoPersonal.Text = "Tu Información\r\n";
            btnInfoPersonal.TextAlign = ContentAlignment.BottomCenter;
            btnInfoPersonal.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInfoPersonal.UseVisualStyleBackColor = false;
            // 
            // Modulos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1201, 945);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MÓDULOS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Modulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulos";
            Load += Modulos_Load;
            MÓDULOS.ResumeLayout(false);
            MÓDULOS.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MÓDULOS;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnUsuarios;
        private Button btnAtencion;
        private Button btnRHH;
        private Button btnFacturas;
        private Button btnFarmacia;
        private Button btnSucursal;
        private Button btnInformacion;
        private Button btnInfoPersonal;
        private Label label1;
        private Button button4;
        private Button button9;
    }
}