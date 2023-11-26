namespace ProyectoBD
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
<<<<<<< HEAD
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Form1";
        }

        #endregion
=======
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
            label22 = new Label();
            label23 = new Label();
            label20 = new Label();
            label21 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label9 = new Label();
            label12 = new Label();
            label14 = new Label();
            label5 = new Label();
            label6 = new Label();
            CAIEmp = new Label();
            label8 = new Label();
            CAI = new Label();
            label10 = new Label();
            telefonoEmpresa = new Label();
            RTN = new Label();
            correoEmpresa = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            direccionEmpresa = new Label();
            label1 = new Label();
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
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(CAIEmp);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(CAI);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(telefonoEmpresa);
            panel1.Controls.Add(RTN);
            panel1.Controls.Add(correoEmpresa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(direccionEmpresa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 543);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(83, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(241, 447);
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
            label35.Location = new Point(83, 447);
            label35.Name = "label35";
            label35.Size = new Size(152, 23);
            label35.TabIndex = 40;
            label35.Text = "Fecha Límite de Emisión:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(610, 475);
            label30.Name = "label30";
            label30.Size = new Size(53, 13);
            label30.TabIndex = 39;
            label30.Text = "I.S.V 18%";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(491, 474);
            label31.Name = "label31";
            label31.Size = new Size(59, 13);
            label31.TabIndex = 38;
            label31.Text = "EFECTIVO";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(610, 493);
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
            label29.Location = new Point(491, 492);
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
            label27.Location = new Point(287, 424);
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
            label26.Location = new Point(308, 424);
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
            label24.Location = new Point(241, 424);
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
            label25.Location = new Point(83, 424);
            label25.Name = "label25";
            label25.Size = new Size(119, 23);
            label25.TabIndex = 32;
            label25.Text = "Rango Autorizado:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(610, 452);
            label22.Name = "label22";
            label22.Size = new Size(164, 23);
            label22.TabIndex = 31;
            label22.Text = "RTN del Cliente (Opcional)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(490, 451);
            label23.Name = "label23";
            label23.Size = new Size(116, 24);
            label23.TabIndex = 30;
            label23.Text = "TOTAL A PAGAR:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(610, 435);
            label20.Name = "label20";
            label20.Size = new Size(53, 13);
            label20.TabIndex = 29;
            label20.Text = "I.S.V 18%";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(491, 434);
            label21.Name = "label21";
            label21.Size = new Size(53, 13);
            label21.TabIndex = 28;
            label21.Text = "I.S.V 18%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(610, 412);
            label13.Name = "label13";
            label13.Size = new Size(115, 23);
            label13.TabIndex = 27;
            label13.Text = "Subtotal I.S.V 15%";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(610, 386);
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
            label16.Location = new Point(610, 363);
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
            label17.Location = new Point(491, 411);
            label17.Name = "label17";
            label17.Size = new Size(63, 23);
            label17.TabIndex = 24;
            label17.Text = "I.S.V 15%";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(491, 363);
            label18.Name = "label18";
            label18.Size = new Size(115, 23);
            label18.TabIndex = 23;
            label18.Text = "Subtotal I.S.V 15%";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(491, 387);
            label19.Name = "label19";
            label19.Size = new Size(115, 23);
            label19.TabIndex = 22;
            label19.Text = "Subtotal I.S.V 18%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(83, 491);
            label11.Name = "label11";
            label11.Size = new Size(180, 23);
            label11.TabIndex = 21;
            label11.Text = "***GRACIAS POR SU VISITA***";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(642, 114);
            dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(561, 185);
            label7.Name = "label7";
            label7.Size = new Size(164, 23);
            label7.TabIndex = 19;
            label7.Text = "RTN del Cliente (Opcional)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(561, 162);
            label9.Name = "label9";
            label9.Size = new Size(123, 23);
            label9.TabIndex = 18;
            label9.Text = "Número de Factura";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(469, 185);
            label12.Name = "label12";
            label12.Size = new Size(40, 24);
            label12.TabIndex = 16;
            label12.Text = "RTN:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(469, 161);
            label14.Name = "label14";
            label14.Size = new Size(55, 24);
            label14.TabIndex = 14;
            label14.Text = "FECHA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(175, 185);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 13;
            label5.Text = "NOMBRE DEL CLIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(175, 162);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 12;
            label6.Text = "Número de Factura";
            // 
            // CAIEmp
            // 
            CAIEmp.AutoSize = true;
            CAIEmp.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CAIEmp.Location = new Point(175, 138);
            CAIEmp.Name = "CAIEmp";
            CAIEmp.Size = new Size(29, 23);
            CAIEmp.TabIndex = 11;
            CAIEmp.Text = "CAI";
            CAIEmp.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(83, 185);
            label8.Name = "label8";
            label8.Size = new Size(65, 24);
            label8.TabIndex = 10;
            label8.Text = "CLIENTE:";
            // 
            // CAI
            // 
            CAI.AutoSize = true;
            CAI.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CAI.Location = new Point(83, 137);
            CAI.Name = "CAI";
            CAI.Size = new Size(39, 24);
            CAI.TabIndex = 9;
            CAI.Text = "C.A.I";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(83, 161);
            label10.Name = "label10";
            label10.Size = new Size(72, 24);
            label10.TabIndex = 8;
            label10.Text = "FACTURA:";
            // 
            // telefonoEmpresa
            // 
            telefonoEmpresa.AutoSize = true;
            telefonoEmpresa.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoEmpresa.Location = new Point(378, 105);
            telefonoEmpresa.Name = "telefonoEmpresa";
            telefonoEmpresa.Size = new Size(149, 23);
            telefonoEmpresa.TabIndex = 7;
            telefonoEmpresa.Text = "Teléfono de la Empresa";
            telefonoEmpresa.Click += label7_Click;
            // 
            // RTN
            // 
            RTN.AutoSize = true;
            RTN.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RTN.Location = new Point(378, 82);
            RTN.Name = "RTN";
            RTN.Size = new Size(123, 23);
            RTN.TabIndex = 6;
            RTN.Text = "RTN de la Empresa";
            // 
            // correoEmpresa
            // 
            correoEmpresa.AutoSize = true;
            correoEmpresa.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            correoEmpresa.Location = new Point(410, 63);
            correoEmpresa.Name = "correoEmpresa";
            correoEmpresa.Size = new Size(139, 23);
            correoEmpresa.TabIndex = 5;
            correoEmpresa.Text = "Correo de la Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(314, 106);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 4;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(286, 62);
            label3.Name = "label3";
            label3.Size = new Size(127, 24);
            label3.TabIndex = 3;
            label3.Text = "Correo Electrónico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(343, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 2;
            label2.Text = "RTN:";
            // 
            // direccionEmpresa
            // 
            direccionEmpresa.AutoSize = true;
            direccionEmpresa.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            direccionEmpresa.Location = new Point(334, 39);
            direccionEmpresa.Name = "direccionEmpresa";
            direccionEmpresa.Size = new Size(152, 23);
            direccionEmpresa.TabIndex = 1;
            direccionEmpresa.Text = "Dirección de la Empresa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 15);
            label1.Name = "label1";
            label1.Size = new Size(150, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la Empresa";
            label1.Click += label1_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(841, 567);
            Controls.Add(panel1);
            Name = "Factura";
            Text = "Factura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label direccionEmpresa;
        private Label label3;
        private Label label2;
        private Label telefonoEmpresa;
        private Label RTN;
        private Label correoEmpresa;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label CAIEmp;
        private Label label8;
        private Label CAI;
        private Label label10;
        private Label label7;
        private Label label9;
        private Label label12;
        private Label label14;
        private Label label11;
        private DataGridView dataGridView1;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
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
>>>>>>> 1458c6f4de74d04bb1bdc84643213af4d8c264b6
    }
}