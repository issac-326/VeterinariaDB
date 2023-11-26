namespace ProyectoBD
{
    partial class Modulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulos));
            MÓDULOS = new Panel();
            button9 = new Button();
            button4 = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button10 = new Button();
            button7 = new Button();
            button5 = new Button();
            button8 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            MÓDULOS.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            MÓDULOS.TabIndex = 2;
            MÓDULOS.Paint += panel2_Paint;
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
            label1.Size = new Size(120, 24);
            label1.TabIndex = 0;
            label1.Text = "MÓDULOS";
            label1.Click += label1_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 198F));
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Location = new Point(12, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(817, 449);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Window;
            button10.BackgroundImageLayout = ImageLayout.Center;
            button10.CausesValidation = false;
            button10.FlatAppearance.BorderColor = Color.Navy;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.Navy;
            button10.Image = Properties.Resources.cerrar_con_llave;
            button10.Location = new Point(209, 301);
            button10.Name = "button10";
            button10.Size = new Size(200, 143);
            button10.TabIndex = 14;
            button10.Text = "Usuarios del Sistema";
            button10.TextImageRelation = TextImageRelation.ImageAboveText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
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
            button7.Location = new Point(415, 152);
            button7.Name = "button7";
            button7.Size = new Size(200, 143);
            button7.TabIndex = 13;
            button7.Text = "Atención al Cliente";
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
            button5.Location = new Point(3, 152);
            button5.Name = "button5";
            button5.Size = new Size(200, 143);
            button5.TabIndex = 12;
            button5.Text = "Recursos Humanos";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Navy;
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.CausesValidation = false;
            button8.FlatAppearance.BorderColor = Color.Navy;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.Window;
            button8.Image = Properties.Resources.facturas;
            button8.Location = new Point(621, 152);
            button8.Name = "button8";
            button8.Size = new Size(193, 143);
            button8.TabIndex = 7;
            button8.Text = "Facturas";
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = false;
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
            button6.Location = new Point(209, 152);
            button6.Name = "button6";
            button6.Size = new Size(200, 143);
            button6.TabIndex = 5;
            button6.Text = "Farmacia";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.CausesValidation = false;
            button3.FlatAppearance.BorderColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Window;
            button3.Image = Properties.Resources.sucursales;
            button3.Location = new Point(415, 3);
            button3.Name = "button3";
            button3.Size = new Size(200, 143);
            button3.TabIndex = 2;
            button3.Text = "Sucursales";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.CausesValidation = false;
            button2.FlatAppearance.BorderColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Image = Properties.Resources.empresa;
            button2.Location = new Point(209, 3);
            button2.Name = "button2";
            button2.Size = new Size(200, 143);
            button2.TabIndex = 1;
            button2.Text = "Información de la Empresa";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Image = Properties.Resources.usuario;
            button1.Location = new Point(415, 301);
            button1.Name = "button1";
            button1.Size = new Size(200, 143);
            button1.TabIndex = 15;
            button1.Text = "Tu Información\r\n";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // Modulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MÓDULOS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Modulos";
            Text = "Módulos";
            Load += Modulos_Load;
            MÓDULOS.ResumeLayout(false);
            MÓDULOS.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MÓDULOS;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button10;
        private Button button7;
        private Button button5;
        private Button button8;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button4;
        private Button button9;
    }
}