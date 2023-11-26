namespace ProyectoBD
{
    partial class BonosDeducciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonosDeducciones));
            EncabezadoBeneficios = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            Nombre = new Label();
            mostradorBonificaciones = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            MostradorDeducciones = new DataGridView();
            comboBoxBeneficios = new ComboBox();
            comboBoxDeducciones = new ComboBox();
            btnEliminarCitas = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)mostradorBonificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostradorDeducciones).BeginInit();
            SuspendLayout();
            // 
            // EncabezadoBeneficios
            // 
            EncabezadoBeneficios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EncabezadoBeneficios.AutoSize = true;
            EncabezadoBeneficios.BackColor = SystemColors.GradientActiveCaption;
            EncabezadoBeneficios.FlatStyle = FlatStyle.Popup;
            EncabezadoBeneficios.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EncabezadoBeneficios.ForeColor = Color.Navy;
            EncabezadoBeneficios.ImageAlign = ContentAlignment.TopCenter;
            EncabezadoBeneficios.Location = new Point(197, 73);
            EncabezadoBeneficios.Name = "EncabezadoBeneficios";
            EncabezadoBeneficios.Size = new Size(464, 22);
            EncabezadoBeneficios.TabIndex = 34;
            EncabezadoBeneficios.Text = "Gestión de Beneficios y Deducciones del Contrato";
            EncabezadoBeneficios.Click += EncabezadoBeneficios_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(340, 384);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(0, 23);
            txtNombre.TabIndex = 40;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(300, 352);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(9, 8, 22, 8);
            btnAgregar.Size = new Size(58, 43);
            btnAgregar.TabIndex = 39;
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.Navy;
            Nombre.Location = new Point(56, 143);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(92, 18);
            Nombre.TabIndex = 36;
            Nombre.Text = "Beneficios";
            // 
            // mostradorBonificaciones
            // 
            mostradorBonificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorBonificaciones.Location = new Point(56, 175);
            mostradorBonificaciones.Name = "mostradorBonificaciones";
            mostradorBonificaciones.RowTemplate.Height = 25;
            mostradorBonificaciones.Size = new Size(349, 166);
            mostradorBonificaciones.TabIndex = 35;
            mostradorBonificaciones.CellContentClick += mostradorBonificaciones_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(711, 378);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 23);
            textBox1.TabIndex = 46;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(667, 352);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 8, 22, 8);
            button1.Size = new Size(58, 43);
            button1.TabIndex = 45;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(439, 143);
            label3.Name = "label3";
            label3.Size = new Size(113, 18);
            label3.TabIndex = 42;
            label3.Text = "Deducciones";
            // 
            // MostradorDeducciones
            // 
            MostradorDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostradorDeducciones.Location = new Point(439, 175);
            MostradorDeducciones.Name = "MostradorDeducciones";
            MostradorDeducciones.RowTemplate.Height = 25;
            MostradorDeducciones.Size = new Size(349, 166);
            MostradorDeducciones.TabIndex = 41;
            MostradorDeducciones.CellContentClick += MostradorDeducciones_CellContentClick;
            // 
            // comboBoxBeneficios
            // 
            comboBoxBeneficios.FormattingEnabled = true;
            comboBoxBeneficios.Location = new Point(137, 364);
            comboBoxBeneficios.Name = "comboBoxBeneficios";
            comboBoxBeneficios.Size = new Size(147, 23);
            comboBoxBeneficios.TabIndex = 47;
            // 
            // comboBoxDeducciones
            // 
            comboBoxDeducciones.FormattingEnabled = true;
            comboBoxDeducciones.Location = new Point(519, 364);
            comboBoxDeducciones.Name = "comboBoxDeducciones";
            comboBoxDeducciones.Size = new Size(142, 23);
            comboBoxDeducciones.TabIndex = 48;
            // 
            // btnEliminarCitas
            // 
            btnEliminarCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarCitas.BackColor = Color.Red;
            btnEliminarCitas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarCitas.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarCitas.Image = (Image)resources.GetObject("btnEliminarCitas.Image");
            btnEliminarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarCitas.Location = new Point(364, 352);
            btnEliminarCitas.Margin = new Padding(3, 2, 3, 2);
            btnEliminarCitas.Name = "btnEliminarCitas";
            btnEliminarCitas.Padding = new Padding(9, 8, 22, 8);
            btnEliminarCitas.Size = new Size(58, 43);
            btnEliminarCitas.TabIndex = 49;
            btnEliminarCitas.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarCitas.UseVisualStyleBackColor = false;
            btnEliminarCitas.Click += btnEliminarCitas_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(731, 352);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 8, 22, 8);
            button2.Size = new Size(58, 43);
            button2.TabIndex = 50;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Red;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(667, 473);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(9, 8, 22, 8);
            button4.Size = new Size(152, 52);
            button4.TabIndex = 51;
            button4.Text = "Salir";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // BonosDeducciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(btnEliminarCitas);
            Controls.Add(comboBoxDeducciones);
            Controls.Add(comboBoxBeneficios);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(MostradorDeducciones);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(Nombre);
            Controls.Add(mostradorBonificaciones);
            Controls.Add(EncabezadoBeneficios);
            Name = "BonosDeducciones";
            Text = "Bonificaciones y Deducciones del Contrato";
            Load += BonosDeducciones_Load;
            ((System.ComponentModel.ISupportInitialize)mostradorBonificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostradorDeducciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EncabezadoBeneficios;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Label Nombre;
        private DataGridView mostradorBonificaciones;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private DataGridView MostradorDeducciones;
        private ComboBox comboBoxBeneficios;
        private ComboBox comboBoxDeducciones;
        private Button btnEliminarCitas;
        private Button button2;
        private Button button4;
    }
}