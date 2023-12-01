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
            Acceso.Location = new Point(335, 126);
            Acceso.Name = "Acceso";
            Acceso.Size = new Size(467, 358);
            Acceso.TabIndex = 0;
            Acceso.TabStop = false;
            Acceso.Text = "Bienvenido";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(43, 59);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 22);
            txtUsuario.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(43, 100);
            label2.Name = "label2";
            label2.Size = new Size(107, 18);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = SystemColors.Window;
            txtContrasenia.BorderStyle = BorderStyle.None;
            txtContrasenia.Location = new Point(43, 121);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(239, 22);
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
            btnIniciar.Location = new Point(43, 188);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(239, 39);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Sesión ";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(48, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoerp;
            pictureBox2.Location = new Point(658, 503);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(841, 567);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Acceso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
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