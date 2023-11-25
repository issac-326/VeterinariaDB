namespace ProyectoBD
{
    partial class InfoMascota
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
            mostradorResponsables = new DataGridView();
            mostradorVacunas = new DataGridView();
            dataGridView1 = new DataGridView();
            Nombre = new Label();
            label1 = new Label();
            txtCaracteristicas = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)mostradorResponsables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostradorVacunas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // mostradorResponsables
            // 
            mostradorResponsables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorResponsables.Location = new Point(31, 73);
            mostradorResponsables.Name = "mostradorResponsables";
            mostradorResponsables.RowTemplate.Height = 25;
            mostradorResponsables.Size = new Size(349, 166);
            mostradorResponsables.TabIndex = 0;
            // 
            // mostradorVacunas
            // 
            mostradorVacunas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostradorVacunas.Location = new Point(31, 345);
            mostradorVacunas.Name = "mostradorVacunas";
            mostradorVacunas.RowTemplate.Height = 25;
            mostradorVacunas.Size = new Size(319, 166);
            mostradorVacunas.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(476, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(319, 310);
            dataGridView1.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.Navy;
            Nombre.Location = new Point(29, 41);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(121, 18);
            Nombre.TabIndex = 3;
            Nombre.Text = "Responsables";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(29, 259);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 4;
            label1.Text = "DNI responsable";
            label1.Click += label1_Click;
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(162, 256);
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(135, 23);
            txtCaracteristicas.TabIndex = 15;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = SystemColors.ButtonFace;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(305, 256);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 16;
            button4.Text = "AGREGAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // InfoMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 567);
            Controls.Add(button4);
            Controls.Add(txtCaracteristicas);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(dataGridView1);
            Controls.Add(mostradorVacunas);
            Controls.Add(mostradorResponsables);
            Name = "InfoMascota";
            Text = "InfoMascota";
            Load += InfoMascota_Load;
            ((System.ComponentModel.ISupportInitialize)mostradorResponsables).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostradorVacunas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mostradorResponsables;
        private DataGridView mostradorVacunas;
        private DataGridView dataGridView1;
        private Label Nombre;
        private Label label1;
        private TextBox txtCaracteristicas;
        private Button button4;
    }
}