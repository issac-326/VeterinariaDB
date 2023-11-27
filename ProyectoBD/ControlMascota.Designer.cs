namespace ProyectoBD
{
    partial class ControlMascota
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
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(21, 17);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 30;
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(389, 99);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 29;
            label2.Text = "SUBMÓDULOS";
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.CausesValidation = false;
            button6.FlatAppearance.BorderColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Window;
            button6.Image = Properties.Resources.farmacia;
            button6.Location = new Point(202, 252);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(229, 191);
            button6.TabIndex = 28;
            button6.Text = "Gestión de Mascotas";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseMnemonic = false;
            button6.UseVisualStyleBackColor = false;
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
            button7.Location = new Point(544, 252);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(229, 191);
            button7.TabIndex = 27;
            button7.Text = "Agendar citas";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // ControlMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 756);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ControlMascota";
            Text = "ControlMascota";
            Load += ControlMascota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label2;
        private Button button6;
        private Button button7;
    }
}