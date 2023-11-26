namespace ProyectoBD
{
    partial class SubmodulosRRHH
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
            button7 = new Button();
            button5 = new Button();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
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
            button7.Location = new Point(475, 186);
            button7.Name = "button7";
            button7.Size = new Size(200, 143);
            button7.TabIndex = 14;
            button7.Text = "Gestión de Contratos";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            button5.Location = new Point(187, 186);
            button5.Name = "button5";
            button5.Size = new Size(200, 143);
            button5.TabIndex = 15;
            button5.Text = "Gestión de Personal";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(345, 87);
            label2.Name = "label2";
            label2.Size = new Size(165, 24);
            label2.TabIndex = 25;
            label2.Text = "SUBMÓDULOS";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 26;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // SubmodulosRRHH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button7);
            Name = "SubmodulosRRHH";
            Text = "Recursos Humanos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button5;
        private Label label2;
        private Button button4;
    }
}