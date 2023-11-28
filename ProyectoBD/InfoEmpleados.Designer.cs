namespace ProyectoBD
{
    partial class InfoEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmpleados));
            button1 = new Button();
            pictureBoxPerfil = new PictureBox();
            identidad = new Label();
            nombreCompleto = new Label();
            label8 = new Label();
            label10 = new Label();
            correo = new Label();
            telefono = new Label();
            label3 = new Label();
            label4 = new Label();
            cargo = new Label();
            edad = new Label();
            label11 = new Label();
            label12 = new Label();
            ss = new Label();
            label16 = new Label();
            salario = new Label();
            periodoLab = new Label();
            label19 = new Label();
            label20 = new Label();
            horario = new Label();
            label22 = new Label();
            direccion = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            btnAgregarContrato = new Button();
            periodoPago = new Label();
            label2 = new Label();
            salarioB = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(655, 489);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 8, 22, 8);
            button1.Size = new Size(152, 52);
            button1.TabIndex = 55;
            button1.Text = "Salir";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBoxPerfil
            // 
            pictureBoxPerfil.Location = new Point(132, 45);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(153, 151);
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfil.TabIndex = 56;
            pictureBoxPerfil.TabStop = false;
            pictureBoxPerfil.Click += pictureBox1_Click;
            // 
            // identidad
            // 
            identidad.AutoSize = true;
            identidad.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            identidad.Location = new Point(529, 100);
            identidad.Name = "identidad";
            identidad.Size = new Size(65, 23);
            identidad.TabIndex = 60;
            identidad.Text = "Identidad";
            identidad.Click += label5_Click;
            // 
            // nombreCompleto
            // 
            nombreCompleto.AutoSize = true;
            nombreCompleto.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nombreCompleto.Location = new Point(529, 76);
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.Size = new Size(59, 23);
            nombreCompleto.TabIndex = 59;
            nombreCompleto.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(353, 100);
            label8.Name = "label8";
            label8.Size = new Size(142, 24);
            label8.TabIndex = 58;
            label8.Text = "Número de Identidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(353, 76);
            label10.Name = "label10";
            label10.Size = new Size(128, 24);
            label10.TabIndex = 57;
            label10.Text = "Nombre Completo:";
            // 
            // correo
            // 
            correo.AutoSize = true;
            correo.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            correo.Location = new Point(529, 148);
            correo.Name = "correo";
            correo.Size = new Size(51, 23);
            correo.TabIndex = 64;
            correo.Text = "Correo";
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            telefono.Location = new Point(529, 123);
            telefono.Name = "telefono";
            telefono.Size = new Size(61, 23);
            telefono.TabIndex = 63;
            telefono.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(353, 148);
            label3.Name = "label3";
            label3.Size = new Size(127, 24);
            label3.TabIndex = 62;
            label3.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(353, 124);
            label4.Name = "label4";
            label4.Size = new Size(142, 24);
            label4.TabIndex = 61;
            label4.Text = "Número de Teléfono:";
            // 
            // cargo
            // 
            cargo.AutoSize = true;
            cargo.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cargo.Location = new Point(529, 288);
            cargo.Name = "cargo";
            cargo.Size = new Size(46, 23);
            cargo.TabIndex = 68;
            cargo.Text = "Cargo";
            // 
            // edad
            // 
            edad.AutoSize = true;
            edad.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            edad.Location = new Point(529, 171);
            edad.Name = "edad";
            edad.Size = new Size(40, 23);
            edad.TabIndex = 67;
            edad.Text = "Edad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(353, 289);
            label11.Name = "label11";
            label11.Size = new Size(50, 24);
            label11.TabIndex = 66;
            label11.Text = "Cargo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(353, 172);
            label12.Name = "label12";
            label12.Size = new Size(44, 24);
            label12.TabIndex = 65;
            label12.Text = "Edad:";
            // 
            // ss
            // 
            ss.AutoSize = true;
            ss.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ss.Location = new Point(529, 312);
            ss.Name = "ss";
            ss.Size = new Size(90, 23);
            ss.TabIndex = 71;
            ss.Text = "Seguro Social";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(353, 312);
            label16.Name = "label16";
            label16.Size = new Size(170, 24);
            label16.TabIndex = 69;
            label16.Text = "Número de Seguro Social:";
            // 
            // salario
            // 
            salario.AutoSize = true;
            salario.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salario.Location = new Point(529, 360);
            salario.Name = "salario";
            salario.Size = new Size(83, 23);
            salario.TabIndex = 76;
            salario.Text = "Salario Neto";
            // 
            // periodoLab
            // 
            periodoLab.AutoSize = true;
            periodoLab.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            periodoLab.Location = new Point(529, 407);
            periodoLab.Name = "periodoLab";
            periodoLab.Size = new Size(104, 23);
            periodoLab.TabIndex = 75;
            periodoLab.Text = "Periodo Laboral";
            periodoLab.Click += periodoLab_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(353, 360);
            label19.Name = "label19";
            label19.Size = new Size(90, 24);
            label19.TabIndex = 74;
            label19.Text = "Salario Neto:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(353, 406);
            label20.Name = "label20";
            label20.Size = new Size(112, 24);
            label20.TabIndex = 73;
            label20.Text = "Periodo Laboral:";
            // 
            // horario
            // 
            horario.AutoSize = true;
            horario.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            horario.Location = new Point(529, 384);
            horario.Name = "horario";
            horario.Size = new Size(55, 23);
            horario.TabIndex = 78;
            horario.Text = "Horario";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(353, 384);
            label22.Name = "label22";
            label22.Size = new Size(61, 24);
            label22.TabIndex = 77;
            label22.Text = "Horario:";
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            direccion.Location = new Point(529, 197);
            direccion.Name = "direccion";
            direccion.Size = new Size(64, 23);
            direccion.TabIndex = 80;
            direccion.Text = "Dirección";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(353, 196);
            label24.Name = "label24";
            label24.Size = new Size(72, 24);
            label24.TabIndex = 79;
            label24.Text = "Dirección:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.MenuHighlight;
            label25.Location = new Point(353, 42);
            label25.Name = "label25";
            label25.Size = new Size(201, 34);
            label25.TabIndex = 81;
            label25.Text = "DATOS PERSONALES";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.MenuHighlight;
            label26.Location = new Point(353, 254);
            label26.Name = "label26";
            label26.Size = new Size(296, 34);
            label26.TabIndex = 82;
            label26.Text = "INFORMACIÓN DEL CONTRATO";
            // 
            // btnAgregarContrato
            // 
            btnAgregarContrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarContrato.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarContrato.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarContrato.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarContrato.Image = (Image)resources.GetObject("btnAgregarContrato.Image");
            btnAgregarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarContrato.Location = new Point(28, 489);
            btnAgregarContrato.Margin = new Padding(3, 2, 3, 2);
            btnAgregarContrato.Name = "btnAgregarContrato";
            btnAgregarContrato.Padding = new Padding(9, 8, 22, 8);
            btnAgregarContrato.Size = new Size(225, 52);
            btnAgregarContrato.TabIndex = 83;
            btnAgregarContrato.Text = "Renovar Contrato";
            btnAgregarContrato.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarContrato.UseVisualStyleBackColor = false;
            btnAgregarContrato.Click += btnAgregarContrato_Click;
            // 
            // periodoPago
            // 
            periodoPago.AutoSize = true;
            periodoPago.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            periodoPago.Location = new Point(529, 430);
            periodoPago.Name = "periodoPago";
            periodoPago.Size = new Size(109, 23);
            periodoPago.TabIndex = 85;
            periodoPago.Text = "Periodo de Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(353, 429);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 84;
            label2.Text = "Periodo de Pago:";
            // 
            // salarioB
            // 
            salarioB.AutoSize = true;
            salarioB.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salarioB.Location = new Point(529, 336);
            salarioB.Name = "salarioB";
            salarioB.Size = new Size(85, 23);
            salarioB.TabIndex = 87;
            salarioB.Text = "Salario Bruto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(353, 336);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 86;
            label5.Text = "Salario Bruto:";
            // 
            // InfoEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(salarioB);
            Controls.Add(label5);
            Controls.Add(periodoPago);
            Controls.Add(label2);
            Controls.Add(btnAgregarContrato);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(direccion);
            Controls.Add(label24);
            Controls.Add(horario);
            Controls.Add(label22);
            Controls.Add(salario);
            Controls.Add(periodoLab);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(ss);
            Controls.Add(label16);
            Controls.Add(cargo);
            Controls.Add(edad);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(correo);
            Controls.Add(telefono);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(identidad);
            Controls.Add(nombreCompleto);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(pictureBoxPerfil);
            Controls.Add(button1);
            Name = "InfoEmpleados";
            Text = "Información del Empleado";
            Load += InfoEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBoxPerfil;
        private Label identidad;
        private Label label6;
        private Label label8;
        private Label label10;
        private Label correo;
        private Label telefono;
        private Label label3;
        private Label label4;
        private Label cargo;
        private Label edad;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label ss;
        private Label label15;
        private Label label16;
        private Label salario;
        private Label periodoLab;
        private Label label19;
        private Label label20;
        private Label horario;
        private Label label22;
        private Label direccion;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button btnAgregarContrato;
        private Label nombreCompleto;
        private Label periodoPago;
        private Label label2;
        private Label salarioB;
        private Label label5;
    }
}