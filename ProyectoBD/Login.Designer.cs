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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            Usuario = new TextBox();
            button1 = new Button();
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
            Acceso.Controls.Add(label2);
            Acceso.Controls.Add(label1);
            Acceso.Controls.Add(textBox2);
            Acceso.Controls.Add(Usuario);
            Acceso.Controls.Add(button1);
            Acceso.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Acceso.ForeColor = Color.Navy;
            Acceso.Location = new Point(471, 156);
            Acceso.Margin = new Padding(3, 4, 3, 4);
            Acceso.Name = "Acceso";
            Acceso.Padding = new Padding(3, 4, 3, 4);
            Acceso.Size = new Size(288, 344);
            Acceso.TabIndex = 0;
            Acceso.TabStop = false;
            Acceso.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(7, 133);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(7, 51);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(7, 161);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 28);
            textBox2.TabIndex = 2;
            // 
            // Usuario
            // 
            Usuario.BackColor = SystemColors.Window;
            Usuario.BorderStyle = BorderStyle.None;
            Usuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usuario.ForeColor = SystemColors.InactiveCaptionText;
            Usuario.Location = new Point(7, 84);
            Usuario.Margin = new Padding(3, 4, 3, 4);
            Usuario.Name = "Usuario";
            Usuario.RightToLeft = RightToLeft.Yes;
            Usuario.ScrollBars = ScrollBars.Both;
            Usuario.Size = new Size(274, 24);
            Usuario.TabIndex = 1;
            Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(7, 251);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(274, 52);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesión ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(162, 169);
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
            ClientSize = new Size(961, 756);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Acceso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            ShowIcon = false;
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
        private Button button1;
        private TextBox textBox2;
        private TextBox Usuario;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}