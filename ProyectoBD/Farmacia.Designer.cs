namespace ProyectoBD
{
    partial class Farmacia
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button7 = new Button();
            button1 = new Button();
            MÓDULOS = new Panel();
            button9 = new Button();
            button4 = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            MÓDULOS.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.75969F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9844551F));
            tableLayoutPanel1.Controls.Add(button7, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(817, 449);
            tableLayoutPanel1.TabIndex = 5;
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
            button7.Location = new Point(175, 152);
            button7.Name = "button7";
            button7.Size = new Size(200, 143);
            button7.TabIndex = 13;
            button7.Text = "Registro";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.CausesValidation = false;
            button1.FlatAppearance.BorderColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Image = Properties.Resources.farmacia;
            button1.Location = new Point(425, 152);
            button1.Name = "button1";
            button1.Size = new Size(200, 143);
            button1.TabIndex = 14;
            button1.Text = "Entregas";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MÓDULOS
            // 
            MÓDULOS.Controls.Add(button9);
            MÓDULOS.Controls.Add(button4);
            MÓDULOS.Controls.Add(label1);
            MÓDULOS.Dock = DockStyle.Fill;
            MÓDULOS.Location = new Point(0, 0);
            MÓDULOS.Name = "MÓDULOS";
            MÓDULOS.Size = new Size(841, 567);
            MÓDULOS.TabIndex = 4;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.Image = Properties.Resources.salida;
            button9.Location = new Point(754, 12);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(15, 13);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(366, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 24);
            label1.TabIndex = 0;
            label1.Text = "FARMACIA";
            label1.Click += label1_Click;
            // 
            // Farmacia
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MÓDULOS);
            Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Navy;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Farmacia";
            Text = "Farmacia";
            tableLayoutPanel1.ResumeLayout(false);
            MÓDULOS.ResumeLayout(false);
            MÓDULOS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private Panel MÓDULOS;
        private Button button9;
        private Button button4;
        private Label label1;
        private Button button1;
    }
}