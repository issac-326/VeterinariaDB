﻿namespace ProyectoBD
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Acceso = new GroupBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtContrasenia = new TextBox();
            btnIniciar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Acceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Acceso
            // 
            Acceso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Acceso.Controls.Add(txtUsuario);
            Acceso.Controls.Add(label2);
            Acceso.Controls.Add(label1);
            Acceso.Controls.Add(txtContrasenia);
            Acceso.Controls.Add(btnIniciar);
            Acceso.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Acceso.ForeColor = Color.Navy;
            Acceso.Location = new Point(502, 256);
            Acceso.Margin = new Padding(4, 5, 4, 5);
            Acceso.Name = "Acceso";
            Acceso.Padding = new Padding(4, 5, 4, 5);
            Acceso.Size = new Size(648, 503);
            Acceso.TabIndex = 0;
            Acceso.TabStop = false;
            Acceso.Text = "Bienvenido";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(142, 132);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(386, 33);
            txtUsuario.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(142, 203);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(142, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = SystemColors.Window;
            txtContrasenia.BorderStyle = BorderStyle.None;
            txtContrasenia.Location = new Point(142, 248);
            txtContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(386, 33);
            txtContrasenia.TabIndex = 2;
            // 
            // btnIniciar
            // 
            btnIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIniciar.BackColor = Color.Navy;
            btnIniciar.BackgroundImageLayout = ImageLayout.Center;
            btnIniciar.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = SystemColors.HighlightText;
            btnIniciar.Location = new Point(165, 350);
            btnIniciar.Margin = new Padding(4, 5, 4, 5);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(341, 65);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Sesión ";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(74, 314);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoerp;
            pictureBox2.Location = new Point(940, 838);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1201, 945);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Acceso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += Login_Load;
            Acceso.ResumeLayout(false);
            Acceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Acceso;
        private Button btnIniciar;
        private TextBox txtContrasenia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUsuario;
    }
}