﻿namespace ProyectoBD
{
    partial class Factura
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label34 = new Label();
            label35 = new Label();
            label30 = new Label();
            label31 = new Label();
            label28 = new Label();
            label29 = new Label();
            label27 = new Label();
            label26 = new Label();
            label24 = new Label();
            label25 = new Label();
            lblTotal = new Label();
            label23 = new Label();
            lblIsv18 = new Label();
            label21 = new Label();
            lblIsv15 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            lblRtnCliente = new Label();
            lblFecha = new Label();
            label12 = new Label();
            label14 = new Label();
            lblCliente = new Label();
            lblNumero = new Label();
            lblCai = new Label();
            label8 = new Label();
            CAI = new Label();
            label10 = new Label();
            telefonoEmpresa = new Label();
            lblRtn = new Label();
            lblCorreo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblDireccion = new Label();
            lblEmpresa = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label34);
            panel1.Controls.Add(label35);
            panel1.Controls.Add(label30);
            panel1.Controls.Add(label31);
            panel1.Controls.Add(label28);
            panel1.Controls.Add(label29);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(lblIsv18);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(lblIsv15);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lblRtnCliente);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblNumero);
            panel1.Controls.Add(lblCai);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(CAI);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(telefonoEmpresa);
            panel1.Controls.Add(lblRtn);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(lblEmpresa);
            panel1.Location = new Point(12, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 516);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(83, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(242, 425);
            label34.Name = "label34";
            label34.Size = new Size(40, 23);
            label34.TabIndex = 41;
            label34.Text = "Inicio";
            label34.TextAlign = ContentAlignment.TopCenter;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label35.Location = new Point(84, 425);
            label35.Name = "label35";
            label35.Size = new Size(152, 23);
            label35.TabIndex = 40;
            label35.Text = "Fecha Límite de Emisión:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(610, 474);
            label30.Name = "label30";
            label30.Size = new Size(53, 13);
            label30.TabIndex = 39;
            label30.Text = "I.S.V 18%";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(491, 473);
            label31.Name = "label31";
            label31.Size = new Size(59, 13);
            label31.TabIndex = 38;
            label31.Text = "EFECTIVO";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(610, 492);
            label28.Name = "label28";
            label28.Size = new Size(53, 13);
            label28.TabIndex = 37;
            label28.Text = "I.S.V 18%";
            label28.Click += label28_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(491, 491);
            label29.Name = "label29";
            label29.Size = new Size(48, 13);
            label29.TabIndex = 36;
            label29.Text = "CAMBIO";
            label29.Click += label29_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(288, 402);
            label27.Name = "label27";
            label27.Size = new Size(15, 23);
            label27.TabIndex = 35;
            label27.Text = "-";
            label27.TextAlign = ContentAlignment.TopCenter;
            label27.Click += label27_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(309, 402);
            label26.Name = "label26";
            label26.Size = new Size(26, 23);
            label26.TabIndex = 34;
            label26.Text = "Fin";
            label26.TextAlign = ContentAlignment.TopCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(242, 402);
            label24.Name = "label24";
            label24.Size = new Size(40, 23);
            label24.TabIndex = 33;
            label24.Text = "Inicio";
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(84, 402);
            label25.Name = "label25";
            label25.Size = new Size(119, 23);
            label25.TabIndex = 32;
            label25.Text = "Rango Autorizado:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(610, 451);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(164, 23);
            lblTotal.TabIndex = 31;
            lblTotal.Text = "RTN del Cliente (Opcional)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(490, 450);
            label23.Name = "label23";
            label23.Size = new Size(116, 24);
            label23.TabIndex = 30;
            label23.Text = "TOTAL A PAGAR:";
            // 
            // lblIsv18
            // 
            lblIsv18.AutoSize = true;
            lblIsv18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsv18.Location = new Point(610, 434);
            lblIsv18.Name = "lblIsv18";
            lblIsv18.Size = new Size(53, 13);
            lblIsv18.TabIndex = 29;
            lblIsv18.Text = "I.S.V 18%";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(491, 433);
            label21.Name = "label21";
            label21.Size = new Size(53, 13);
            label21.TabIndex = 28;
            label21.Text = "I.S.V 18%";
            // 
            // lblIsv15
            // 
            lblIsv15.AutoSize = true;
            lblIsv15.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsv15.Location = new Point(610, 411);
            lblIsv15.Name = "lblIsv15";
            lblIsv15.Size = new Size(115, 23);
            lblIsv15.TabIndex = 27;
            lblIsv15.Text = "Subtotal I.S.V 15%";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(610, 385);
            label15.Name = "label15";
            label15.Size = new Size(115, 23);
            label15.TabIndex = 26;
            label15.Text = "Subtotal I.S.V 15%";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(610, 362);
            label16.Name = "label16";
            label16.Size = new Size(115, 23);
            label16.TabIndex = 25;
            label16.Text = "Subtotal I.S.V 15%";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(491, 410);
            label17.Name = "label17";
            label17.Size = new Size(63, 23);
            label17.TabIndex = 24;
            label17.Text = "I.S.V 15%";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(491, 362);
            label18.Name = "label18";
            label18.Size = new Size(115, 23);
            label18.TabIndex = 23;
            label18.Text = "Subtotal I.S.V 15%";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(491, 386);
            label19.Name = "label19";
            label19.Size = new Size(115, 23);
            label19.TabIndex = 22;
            label19.Text = "Subtotal I.S.V 18%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(84, 469);
            label11.Name = "label11";
            label11.Size = new Size(180, 23);
            label11.TabIndex = 21;
            label11.Text = "***GRACIAS POR SU VISITA***";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(642, 114);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblRtnCliente
            // 
            lblRtnCliente.AutoSize = true;
            lblRtnCliente.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRtnCliente.Location = new Point(554, 196);
            lblRtnCliente.Name = "lblRtnCliente";
            lblRtnCliente.Size = new Size(164, 23);
            lblRtnCliente.TabIndex = 19;
            lblRtnCliente.Text = "RTN del Cliente (Opcional)";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(554, 173);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 23);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Fecha";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(462, 196);
            label12.Name = "label12";
            label12.Size = new Size(40, 24);
            label12.TabIndex = 16;
            label12.Text = "RTN:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(462, 172);
            label14.Name = "label14";
            label14.Size = new Size(55, 24);
            label14.TabIndex = 14;
            label14.Text = "FECHA:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(168, 196);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(142, 23);
            lblCliente.TabIndex = 13;
            lblCliente.Text = "NOMBRE DEL CLIENTE";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(168, 173);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(123, 23);
            lblNumero.TabIndex = 12;
            lblNumero.Text = "Número de Factura";
            // 
            // lblCai
            // 
            lblCai.AutoSize = true;
            lblCai.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCai.Location = new Point(168, 149);
            lblCai.Name = "lblCai";
            lblCai.Size = new Size(29, 23);
            lblCai.TabIndex = 11;
            lblCai.Text = "CAI";
            lblCai.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(76, 196);
            label8.Name = "label8";
            label8.Size = new Size(65, 24);
            label8.TabIndex = 10;
            label8.Text = "CLIENTE:";
            // 
            // CAI
            // 
            CAI.AutoSize = true;
            CAI.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CAI.Location = new Point(76, 148);
            CAI.Name = "CAI";
            CAI.Size = new Size(39, 24);
            CAI.TabIndex = 9;
            CAI.Text = "C.A.I";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(76, 172);
            label10.Name = "label10";
            label10.Size = new Size(72, 24);
            label10.TabIndex = 8;
            label10.Text = "FACTURA:";
            // 
            // telefonoEmpresa
            // 
            telefonoEmpresa.AutoSize = true;
            telefonoEmpresa.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoEmpresa.Location = new Point(383, 114);
            telefonoEmpresa.Name = "telefonoEmpresa";
            telefonoEmpresa.Size = new Size(149, 23);
            telefonoEmpresa.TabIndex = 7;
            telefonoEmpresa.Text = "Teléfono de la Empresa";
            telefonoEmpresa.Click += label7_Click;
            // 
            // lblRtn
            // 
            lblRtn.AutoSize = true;
            lblRtn.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRtn.Location = new Point(383, 91);
            lblRtn.Name = "lblRtn";
            lblRtn.Size = new Size(123, 23);
            lblRtn.TabIndex = 6;
            lblRtn.Text = "RTN de la Empresa";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(415, 72);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(139, 23);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo de la Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(319, 113);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 4;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(291, 71);
            label3.Name = "label3";
            label3.Size = new Size(127, 24);
            label3.TabIndex = 3;
            label3.Text = "Correo Electrónico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(348, 91);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 2;
            label2.Text = "RTN:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(242, 48);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(64, 23);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpresa.Location = new Point(339, 24);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(150, 24);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Nombre de la Empresa";
            lblEmpresa.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.back;
            button4.Location = new Point(22, 10);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(button4);
            Controls.Add(panel1);
            Name = "Factura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Factura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblEmpresa;
        private Label lblDireccion;
        private Label label3;
        private Label label2;
        private Label telefonoEmpresa;
        private Label lblRtn;
        private Label lblCorreo;
        private Label label4;
        private Label lblCliente;
        private Label lblNumero;
        private Label lblCai;
        private Label label8;
        private Label CAI;
        private Label label10;
        private Label lblRtnCliente;
        private Label lblFecha;
        private Label label12;
        private Label label14;
        private Label label11;
        private DataGridView dataGridView1;
        private Label lblIsv15;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label lblIsv18;
        private Label label21;
        private Label lblTotal;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label27;
        private Label label26;
        private Label label30;
        private Label label31;
        private Label label28;
        private Label label29;
        private Label label34;
        private Label label35;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button1;
    }
}