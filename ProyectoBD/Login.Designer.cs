namespace ProyectoBD
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
            Acceso.Location = new Point(383, 168);
            Acceso.Margin = new Padding(3, 4, 3, 4);
            Acceso.Name = "Acceso";
            Acceso.Padding = new Padding(3, 4, 3, 4);
            Acceso.Size = new Size(355, 320);
            Acceso.TabIndex = 0;
            Acceso.TabStop = false;
            Acceso.Text = "Bienvenido";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(50, 78);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(274, 28);
            txtUsuario.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(50, 133);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(50, 51);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = SystemColors.Window;
            txtContrasenia.BorderStyle = BorderStyle.None;
            txtContrasenia.Location = new Point(50, 161);
            txtContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(274, 28);
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
            btnIniciar.Location = new Point(50, 251);
            btnIniciar.Margin = new Padding(3, 4, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(274, 52);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Sesión ";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(54, 168);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoerp;
            pictureBox2.Location = new Point(752, 671);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(782, 653);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Acceso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
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