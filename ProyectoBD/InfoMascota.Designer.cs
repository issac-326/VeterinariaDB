namespace ProyectoBD
{
    partial class InfoMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoMascota));
            mostradorResponsables = new DataGridView();
            mostradorVacunas = new DataGridView();
            mostradorConsultas = new DataGridView();
            Nombre = new Label();
            label1 = new Label();
            txtDni = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            selVacuna = new ComboBox();
            btnAgregarVacuna = new Button();
            mostradorEnfermedades = new DataGridView();
            txtNombre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAgregarEnfermedad = new Button();
            selEnferdad = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)mostradorResponsables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostradorVacunas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostradorConsultas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostradorEnfermedades).BeginInit();
            SuspendLayout();
            // 
            // mostradorResponsables
            // 
            mostradorResponsables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorResponsables.Location = new Point(32, 88);
            mostradorResponsables.Name = "mostradorResponsables";
            mostradorResponsables.RowTemplate.Height = 25;
            mostradorResponsables.Size = new Size(349, 166);
            mostradorResponsables.TabIndex = 0;
            // 
            // mostradorVacunas
            // 
            mostradorVacunas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorVacunas.Location = new Point(32, 345);
            mostradorVacunas.Name = "mostradorVacunas";
            mostradorVacunas.RowTemplate.Height = 25;
            mostradorVacunas.Size = new Size(349, 166);
            mostradorVacunas.TabIndex = 1;
            // 
            // mostradorConsultas
            // 
            mostradorConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorConsultas.Location = new Point(461, 87);
            mostradorConsultas.Name = "mostradorConsultas";
            mostradorConsultas.RowTemplate.Height = 25;
            mostradorConsultas.Size = new Size(341, 214);
            mostradorConsultas.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.Navy;
            Nombre.Location = new Point(32, 56);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(121, 18);
            Nombre.TabIndex = 3;
            Nombre.Text = "Responsables";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(30, 276);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 4;
            label1.Text = "DNI responsable";
            label1.Click += label1_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(163, 270);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(135, 23);
            txtDni.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(304, 259);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(9, 8, 22, 8);
            btnAgregar.Size = new Size(58, 43);
            btnAgregar.TabIndex = 21;
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(32, 316);
            label2.Name = "label2";
            label2.Size = new Size(147, 17);
            label2.TabIndex = 22;
            label2.Text = "Vacunas Aplicadas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(32, 529);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 23;
            label3.Text = "Ingresar vacuna";
            // 
            // selVacuna
            // 
            selVacuna.FormattingEnabled = true;
            selVacuna.Location = new Point(163, 524);
            selVacuna.Name = "selVacuna";
            selVacuna.Size = new Size(135, 23);
            selVacuna.TabIndex = 24;
            // 
            // btnAgregarVacuna
            // 
            btnAgregarVacuna.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarVacuna.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarVacuna.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarVacuna.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarVacuna.Image = (Image)resources.GetObject("btnAgregarVacuna.Image");
            btnAgregarVacuna.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarVacuna.Location = new Point(304, 516);
            btnAgregarVacuna.Margin = new Padding(3, 2, 3, 2);
            btnAgregarVacuna.Name = "btnAgregarVacuna";
            btnAgregarVacuna.Padding = new Padding(9, 8, 22, 8);
            btnAgregarVacuna.Size = new Size(58, 43);
            btnAgregarVacuna.TabIndex = 25;
            btnAgregarVacuna.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarVacuna.UseVisualStyleBackColor = false;
            btnAgregarVacuna.Click += btnAgregarVacuna_Click;
            // 
            // mostradorEnfermedades
            // 
            mostradorEnfermedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorEnfermedades.Location = new Point(461, 345);
            mostradorEnfermedades.Name = "mostradorEnfermedades";
            mostradorEnfermedades.RowTemplate.Height = 25;
            mostradorEnfermedades.Size = new Size(341, 167);
            mostradorEnfermedades.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(304, 291);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(0, 23);
            txtNombre.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(465, 56);
            label4.Name = "label4";
            label4.Size = new Size(149, 18);
            label4.TabIndex = 28;
            label4.Text = "Historial Consulta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(461, 316);
            label5.Name = "label5";
            label5.Size = new Size(153, 17);
            label5.TabIndex = 29;
            label5.Text = "Enfermedades base";
            // 
            // btnAgregarEnfermedad
            // 
            btnAgregarEnfermedad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarEnfermedad.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarEnfermedad.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarEnfermedad.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarEnfermedad.Image = (Image)resources.GetObject("btnAgregarEnfermedad.Image");
            btnAgregarEnfermedad.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarEnfermedad.Location = new Point(771, 517);
            btnAgregarEnfermedad.Margin = new Padding(3, 2, 3, 2);
            btnAgregarEnfermedad.Name = "btnAgregarEnfermedad";
            btnAgregarEnfermedad.Padding = new Padding(9, 8, 22, 8);
            btnAgregarEnfermedad.Size = new Size(58, 43);
            btnAgregarEnfermedad.TabIndex = 32;
            btnAgregarEnfermedad.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarEnfermedad.UseVisualStyleBackColor = false;
            btnAgregarEnfermedad.Click += btnAgregarEnfermedad_Click;
            // 
            // selEnferdad
            // 
            selEnferdad.FormattingEnabled = true;
            selEnferdad.Location = new Point(630, 523);
            selEnferdad.Name = "selEnferdad";
            selEnferdad.Size = new Size(135, 23);
            selEnferdad.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(461, 525);
            label6.Name = "label6";
            label6.Size = new Size(163, 17);
            label6.TabIndex = 30;
            label6.Text = "Ingresar enfermedad";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(32, 9);
            label7.Name = "label7";
            label7.Size = new Size(229, 22);
            label7.TabIndex = 33;
            label7.Text = "Informacion de Eduardo";
            // 
            // InfoMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 567);
            Controls.Add(label7);
            Controls.Add(btnAgregarEnfermedad);
            Controls.Add(selEnferdad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(mostradorEnfermedades);
            Controls.Add(btnAgregarVacuna);
            Controls.Add(selVacuna);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(mostradorConsultas);
            Controls.Add(mostradorVacunas);
            Controls.Add(mostradorResponsables);
            Name = "InfoMascota";
            Text = "InfoMascota";
            Load += InfoMascota_Load;
            ((System.ComponentModel.ISupportInitialize)mostradorResponsables).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostradorVacunas).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostradorConsultas).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostradorEnfermedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mostradorResponsables;
        private DataGridView mostradorVacunas;
        private DataGridView mostradorConsultas;
        private Label Nombre;
        private Label label1;
        private TextBox txtDni;
        private Button btnAgregar;
        private Label label2;
        private Label label3;
        private ComboBox selVacuna;
        private Button btnAgregarVacuna;
        private DataGridView mostradorEnfermedades;
        private TextBox txtNombre;
        private Label label4;
        private Label label5;
        private Button btnAgregarEnfermedad;
        private ComboBox selEnferdad;
        private Label label6;
        private Label label7;
    }
}