namespace ProyectoBD
{
    partial class subModuloUsuarios
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
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(13, 14);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 30;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(263, 206);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 37);
            label2.TabIndex = 29;
            label2.Text = "SUBMÓDULOS";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Window;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.CausesValidation = false;
            button5.FlatAppearance.BorderColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Navy;
            button5.Image = Properties.Resources.mano;
            button5.Location = new Point(123, 310);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(227, 172);
            button5.TabIndex = 28;
            button5.Text = "Agregar Usuarios";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Window;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.CausesValidation = false;
            button7.FlatAppearance.BorderColor = Color.Navy;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Navy;
            button7.Image = Properties.Resources.atencion_al_cliente;
            button7.Location = new Point(440, 310);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(218, 172);
            button7.TabIndex = 27;
            button7.Text = "Otorgar Permisos";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // subModuloUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(778, 644);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button7);
            Name = "subModuloUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "subModuloUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label2;
        private Button button5;
        private Button button7;
    }
}