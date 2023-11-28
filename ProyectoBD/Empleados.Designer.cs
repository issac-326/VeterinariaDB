namespace ProyectoBD
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            dataGridViewEmpleados = new DataGridView();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Location = new Point(141, 71);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.RowTemplate.Height = 25;
            dataGridViewEmpleados.Size = new Size(542, 349);
            dataGridViewEmpleados.TabIndex = 0;
            dataGridViewEmpleados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Red;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(598, 488);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(9, 8, 22, 8);
            button4.Size = new Size(209, 0);
            button4.TabIndex = 53;
            button4.Text = "Salir";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(655, 492);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 8, 22, 8);
            button1.Size = new Size(152, 52);
            button1.TabIndex = 54;
            button1.Text = "Salir";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dataGridViewEmpleados);
            Name = "Empleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Personal";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmpleados;
        private Button button4;
        private Button button1;
    }
}