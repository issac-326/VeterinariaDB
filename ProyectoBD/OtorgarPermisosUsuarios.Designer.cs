namespace ProyectoBD
{
    partial class OtorgarPermisosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtorgarPermisosUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnLimpiarUsuarios = new Button();
            btnModificarUsuarios = new Button();
            btnAgregarUsuarios = new Button();
            btnEliminarUsuarios = new Button();
            dgvPermisosUsuarios = new DataGridView();
            groupBox1 = new GroupBox();
            txtUsuario = new TextBox();
            selPermisos = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPermisosUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiarUsuarios
            // 
            btnLimpiarUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarUsuarios.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiarUsuarios.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarUsuarios.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarUsuarios.Image = (Image)resources.GetObject("btnLimpiarUsuarios.Image");
            btnLimpiarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarUsuarios.Location = new Point(659, 839);
            btnLimpiarUsuarios.Margin = new Padding(4);
            btnLimpiarUsuarios.Name = "btnLimpiarUsuarios";
            btnLimpiarUsuarios.Padding = new Padding(12, 14, 25, 14);
            btnLimpiarUsuarios.Size = new Size(205, 73);
            btnLimpiarUsuarios.TabIndex = 20;
            btnLimpiarUsuarios.Text = "Limpiar";
            btnLimpiarUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarUsuarios.UseVisualStyleBackColor = false;
            btnLimpiarUsuarios.Click += btnLimpiarUsuarios_Click;
            // 
            // btnModificarUsuarios
            // 
            btnModificarUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificarUsuarios.BackColor = Color.FromArgb(255, 128, 0);
            btnModificarUsuarios.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarUsuarios.ForeColor = SystemColors.ActiveCaptionText;
            btnModificarUsuarios.Image = (Image)resources.GetObject("btnModificarUsuarios.Image");
            btnModificarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarUsuarios.Location = new Point(353, 839);
            btnModificarUsuarios.Margin = new Padding(4);
            btnModificarUsuarios.Name = "btnModificarUsuarios";
            btnModificarUsuarios.Padding = new Padding(12, 14, 25, 14);
            btnModificarUsuarios.Size = new Size(205, 73);
            btnModificarUsuarios.TabIndex = 19;
            btnModificarUsuarios.Text = "Modificar";
            btnModificarUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnModificarUsuarios.UseVisualStyleBackColor = false;
            btnModificarUsuarios.Click += btnModificarUsuarios_Click;
            // 
            // btnAgregarUsuarios
            // 
            btnAgregarUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarUsuarios.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarUsuarios.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarUsuarios.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarUsuarios.Image = (Image)resources.GetObject("btnAgregarUsuarios.Image");
            btnAgregarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarUsuarios.Location = new Point(57, 839);
            btnAgregarUsuarios.Margin = new Padding(4);
            btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            btnAgregarUsuarios.Padding = new Padding(12, 14, 25, 14);
            btnAgregarUsuarios.Size = new Size(205, 73);
            btnAgregarUsuarios.TabIndex = 18;
            btnAgregarUsuarios.Text = "Agregar";
            btnAgregarUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarUsuarios.UseVisualStyleBackColor = false;
            btnAgregarUsuarios.Click += btnAgregarUsuarios_Click;
            // 
            // btnEliminarUsuarios
            // 
            btnEliminarUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarUsuarios.BackColor = Color.Red;
            btnEliminarUsuarios.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarUsuarios.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarUsuarios.Image = (Image)resources.GetObject("btnEliminarUsuarios.Image");
            btnEliminarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarUsuarios.Location = new Point(957, 839);
            btnEliminarUsuarios.Margin = new Padding(4);
            btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            btnEliminarUsuarios.Padding = new Padding(15, 14, 20, 14);
            btnEliminarUsuarios.Size = new Size(205, 73);
            btnEliminarUsuarios.TabIndex = 17;
            btnEliminarUsuarios.Text = "Eliminar";
            btnEliminarUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarUsuarios.UseVisualStyleBackColor = false;
            btnEliminarUsuarios.Click += btnEliminarUsuarios_Click;
            // 
            // dgvPermisosUsuarios
            // 
            dgvPermisosUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPermisosUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPermisosUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisosUsuarios.Location = new Point(13, 338);
            dgvPermisosUsuarios.Margin = new Padding(4);
            dgvPermisosUsuarios.Name = "dgvPermisosUsuarios";
            dgvPermisosUsuarios.RowHeadersWidth = 51;
            dgvPermisosUsuarios.RowTemplate.Height = 29;
            dgvPermisosUsuarios.Size = new Size(1175, 463);
            dgvPermisosUsuarios.TabIndex = 16;
            dgvPermisosUsuarios.CellContentClick += dgvPermisosUsuarios_CellContentClick;
            dgvPermisosUsuarios.CellMouseClick += dgvPermisosUsuarios_CellMouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(selPermisos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(178, 82);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(967, 227);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario para Otorgar Permisos de Usuarios:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(396, 65);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(404, 35);
            txtUsuario.TabIndex = 14;
            // 
            // selPermisos
            // 
            selPermisos.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selPermisos.FormattingEnabled = true;
            selPermisos.Location = new Point(396, 142);
            selPermisos.Margin = new Padding(4);
            selPermisos.Name = "selPermisos";
            selPermisos.Size = new Size(404, 36);
            selPermisos.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 145);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(274, 28);
            label4.TabIndex = 3;
            label4.Text = "Permisos de Usuarios:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(27, 25);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // OtorgarPermisosUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 945);
            Controls.Add(button4);
            Controls.Add(btnLimpiarUsuarios);
            Controls.Add(btnModificarUsuarios);
            Controls.Add(btnAgregarUsuarios);
            Controls.Add(btnEliminarUsuarios);
            Controls.Add(dgvPermisosUsuarios);
            Controls.Add(groupBox1);
            Name = "OtorgarPermisosUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OtorgarPermisosUsuarios";
            Load += OtorgarPermisosUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPermisosUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimpiarUsuarios;
        private Button btnModificarUsuarios;
        private Button btnAgregarUsuarios;
        private Button btnEliminarUsuarios;
        private DataGridView dgvPermisosUsuarios;
        private GroupBox groupBox1;
        private TextBox txtUsuario;
        private ComboBox selPermisos;
        private Label label4;
        private Label label1;
        private Button button4;
    }
}