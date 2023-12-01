namespace ProyectoBD
{
    partial class RegistrarUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuarios));
            groupBox1 = new GroupBox();
            txtActivo = new CheckBox();
            label5 = new Label();
            txtDNIEmpleado = new TextBox();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            selRoles = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvUsuarios = new DataGridView();
            btnLimpiarUsuarios = new Button();
            btnModificarUsuarios = new Button();
            btnAgregarUsuarios = new Button();
            btnEliminarUsuarios = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtActivo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDNIEmpleado);
            groupBox1.Controls.Add(txtContrasenia);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(selRoles);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(63, 75);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1064, 342);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario de Usuarios:";
            // 
            // txtActivo
            // 
            txtActivo.AutoSize = true;
            txtActivo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtActivo.Location = new Point(918, 51);
            txtActivo.Margin = new Padding(4, 5, 4, 5);
            txtActivo.Name = "txtActivo";
            txtActivo.Size = new Size(121, 32);
            txtActivo.TabIndex = 29;
            txtActivo.Text = "Lo está";
            txtActivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(784, 52);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 17;
            label5.Text = "Activo:";
            label5.Click += label5_Click;
            // 
            // txtDNIEmpleado
            // 
            txtDNIEmpleado.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNIEmpleado.Location = new Point(273, 193);
            txtDNIEmpleado.Margin = new Padding(4);
            txtDNIEmpleado.Name = "txtDNIEmpleado";
            txtDNIEmpleado.Size = new Size(373, 35);
            txtDNIEmpleado.TabIndex = 16;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(273, 122);
            txtContrasenia.Margin = new Padding(4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(373, 35);
            txtContrasenia.TabIndex = 15;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(273, 51);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(373, 35);
            txtUsuario.TabIndex = 14;
            // 
            // selRoles
            // 
            selRoles.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selRoles.FormattingEnabled = true;
            selRoles.Location = new Point(273, 265);
            selRoles.Margin = new Padding(4);
            selRoles.Name = "selRoles";
            selRoles.Size = new Size(373, 36);
            selRoles.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 273);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(203, 28);
            label4.TabIndex = 3;
            label4.Text = "Tipo de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 2;
            label3.Text = "Empleado (DNI):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.ColumnHeadersHeight = 34;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            dgvUsuarios.Location = new Point(13, 447);
            dgvUsuarios.Margin = new Padding(4);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 29;
            dgvUsuarios.Size = new Size(1175, 382);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellMouseClick += dgvUsuarios_CellMouseClick;
            // 
            // btnLimpiarUsuarios
            // 
            btnLimpiarUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarUsuarios.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiarUsuarios.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarUsuarios.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarUsuarios.Image = (Image)resources.GetObject("btnLimpiarUsuarios.Image");
            btnLimpiarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarUsuarios.Location = new Point(665, 854);
            btnLimpiarUsuarios.Margin = new Padding(4);
            btnLimpiarUsuarios.Name = "btnLimpiarUsuarios";
            btnLimpiarUsuarios.Padding = new Padding(12, 14, 25, 14);
            btnLimpiarUsuarios.Size = new Size(205, 66);
            btnLimpiarUsuarios.TabIndex = 14;
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
            btnModificarUsuarios.Location = new Point(345, 854);
            btnModificarUsuarios.Margin = new Padding(4);
            btnModificarUsuarios.Name = "btnModificarUsuarios";
            btnModificarUsuarios.Padding = new Padding(12, 14, 25, 14);
            btnModificarUsuarios.Size = new Size(234, 66);
            btnModificarUsuarios.TabIndex = 13;
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
            btnAgregarUsuarios.Location = new Point(36, 854);
            btnAgregarUsuarios.Margin = new Padding(4);
            btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            btnAgregarUsuarios.Padding = new Padding(12, 14, 15, 14);
            btnAgregarUsuarios.Size = new Size(216, 66);
            btnAgregarUsuarios.TabIndex = 12;
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
            btnEliminarUsuarios.Location = new Point(952, 854);
            btnEliminarUsuarios.Margin = new Padding(4);
            btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            btnEliminarUsuarios.Padding = new Padding(15, 14, 20, 14);
            btnEliminarUsuarios.Size = new Size(211, 66);
            btnEliminarUsuarios.TabIndex = 11;
            btnEliminarUsuarios.Text = "Eliminar";
            btnEliminarUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarUsuarios.UseVisualStyleBackColor = false;
            btnEliminarUsuarios.Click += btnEliminarUsuarios_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(22, 14);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // RegistrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 945);
            Controls.Add(button4);
            Controls.Add(btnLimpiarUsuarios);
            Controls.Add(btnModificarUsuarios);
            Controls.Add(btnAgregarUsuarios);
            Controls.Add(btnEliminarUsuarios);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "RegistrarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarUsuarios";
            Load += RegistrarUsuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDNIEmpleado;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private ComboBox selRoles;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvUsuarios;
        private Button btnLimpiarUsuarios;
        private Button btnModificarUsuarios;
        private Button btnAgregarUsuarios;
        private Button btnEliminarUsuarios;
        private Label label5;
        private CheckBox txtActivo;
        private Button button4;
    }
}