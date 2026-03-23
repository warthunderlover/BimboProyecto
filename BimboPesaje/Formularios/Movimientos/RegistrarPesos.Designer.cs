namespace BimboPesaje.Formularios.Productos
{
    partial class RegistrarPesos
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
            pnContenedorHijo = new Panel();
            pnDiferencia = new Panel();
            label16 = new Label();
            label15 = new Label();
            lblDiferencia = new Label();
            panel1 = new Panel();
            btnImprimir = new Button();
            btnSeguir = new Button();
            btnGuardar = new Button();
            btnVolver = new Button();
            pnTextboxses = new Panel();
            dtpFechaSalida = new DateTimePicker();
            dtpFechaEntrada = new DateTimePicker();
            txtObservaciones = new TextBox();
            label14 = new Label();
            txtNoBultos = new TextBox();
            label13 = new Label();
            txtPesoTaraExtra = new TextBox();
            label12 = new Label();
            txtPesoNetTotal = new TextBox();
            label11 = new Label();
            txtPeseTaraInd = new TextBox();
            label10 = new Label();
            txtPesoNeto = new TextBox();
            label9 = new Label();
            txtPesoBruto = new TextBox();
            label8 = new Label();
            txtProducto = new TextBox();
            label7 = new Label();
            txtProveedor = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtPlaca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtReporteNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnContenedorHijo.SuspendLayout();
            pnDiferencia.SuspendLayout();
            panel1.SuspendLayout();
            pnTextboxses.SuspendLayout();
            SuspendLayout();
            // 
            // pnContenedorHijo
            // 
            pnContenedorHijo.BackColor = Color.FromArgb(233, 238, 247);
            pnContenedorHijo.Controls.Add(pnDiferencia);
            pnContenedorHijo.Controls.Add(panel1);
            pnContenedorHijo.Controls.Add(pnTextboxses);
            pnContenedorHijo.Controls.Add(label1);
            pnContenedorHijo.Dock = DockStyle.Fill;
            pnContenedorHijo.Location = new Point(0, 0);
            pnContenedorHijo.Name = "pnContenedorHijo";
            pnContenedorHijo.Size = new Size(914, 726);
            pnContenedorHijo.TabIndex = 0;
            // 
            // pnDiferencia
            // 
            pnDiferencia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnDiferencia.BackColor = Color.FromArgb(31, 60, 136);
            pnDiferencia.Controls.Add(label16);
            pnDiferencia.Controls.Add(label15);
            pnDiferencia.Controls.Add(lblDiferencia);
            pnDiferencia.Location = new Point(642, 96);
            pnDiferencia.Name = "pnDiferencia";
            pnDiferencia.Size = new Size(260, 230);
            pnDiferencia.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Silver;
            label16.Location = new Point(22, 142);
            label16.Name = "label16";
            label16.Size = new Size(192, 36);
            label16.TabIndex = 2;
            label16.Text = "Desviacion estandar \r\ncalculado en tiempo real";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(22, 31);
            label15.Name = "label15";
            label15.Size = new Size(86, 20);
            label15.TabIndex = 1;
            label15.Text = "Diferencia";
            // 
            // lblDiferencia
            // 
            lblDiferencia.AutoSize = true;
            lblDiferencia.Font = new Font("Microsoft Sans Serif", 13F);
            lblDiferencia.ForeColor = Color.White;
            lblDiferencia.Location = new Point(84, 88);
            lblDiferencia.Name = "lblDiferencia";
            lblDiferencia.Size = new Size(0, 26);
            lblDiferencia.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnImprimir);
            panel1.Controls.Add(btnSeguir);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnVolver);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 664);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 62);
            panel1.TabIndex = 2;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimir.BackColor = Color.FromArgb(12, 92, 92);
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Itim", 12F);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(383, 12);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(186, 38);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSeguir
            // 
            btnSeguir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeguir.BackColor = Color.FromArgb(46, 90, 172);
            btnSeguir.FlatAppearance.BorderSize = 0;
            btnSeguir.FlatStyle = FlatStyle.Flat;
            btnSeguir.Font = new Font("Itim", 12F);
            btnSeguir.ForeColor = Color.White;
            btnSeguir.Location = new Point(575, 12);
            btnSeguir.Name = "btnSeguir";
            btnSeguir.Size = new Size(186, 38);
            btnSeguir.TabIndex = 2;
            btnSeguir.Text = "Seguir Pesando";
            btnSeguir.UseVisualStyleBackColor = false;
            btnSeguir.Click += btnSeguir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(46, 90, 172);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Itim", 12F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(767, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 38);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.Gray;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Itim", 12F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(25, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(177, 38);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pnTextboxses
            // 
            pnTextboxses.BackColor = Color.White;
            pnTextboxses.Controls.Add(dtpFechaSalida);
            pnTextboxses.Controls.Add(dtpFechaEntrada);
            pnTextboxses.Controls.Add(txtObservaciones);
            pnTextboxses.Controls.Add(label14);
            pnTextboxses.Controls.Add(txtNoBultos);
            pnTextboxses.Controls.Add(label13);
            pnTextboxses.Controls.Add(txtPesoTaraExtra);
            pnTextboxses.Controls.Add(label12);
            pnTextboxses.Controls.Add(txtPesoNetTotal);
            pnTextboxses.Controls.Add(label11);
            pnTextboxses.Controls.Add(txtPeseTaraInd);
            pnTextboxses.Controls.Add(label10);
            pnTextboxses.Controls.Add(txtPesoNeto);
            pnTextboxses.Controls.Add(label9);
            pnTextboxses.Controls.Add(txtPesoBruto);
            pnTextboxses.Controls.Add(label8);
            pnTextboxses.Controls.Add(txtProducto);
            pnTextboxses.Controls.Add(label7);
            pnTextboxses.Controls.Add(txtProveedor);
            pnTextboxses.Controls.Add(label6);
            pnTextboxses.Controls.Add(label5);
            pnTextboxses.Controls.Add(txtPlaca);
            pnTextboxses.Controls.Add(label4);
            pnTextboxses.Controls.Add(label3);
            pnTextboxses.Controls.Add(txtReporteNo);
            pnTextboxses.Controls.Add(label2);
            pnTextboxses.Location = new Point(25, 96);
            pnTextboxses.Name = "pnTextboxses";
            pnTextboxses.Size = new Size(598, 550);
            pnTextboxses.TabIndex = 1;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Format = DateTimePickerFormat.Custom;
            dtpFechaSalida.Location = new Point(326, 115);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(229, 27);
            dtpFechaSalida.TabIndex = 27;
            dtpFechaSalida.Value = new DateTime(2026, 3, 22, 23, 19, 44, 0);
            // 
            // dtpFechaEntrada
            // 
            dtpFechaEntrada.Enabled = false;
            dtpFechaEntrada.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrada.Location = new Point(326, 49);
            dtpFechaEntrada.Name = "dtpFechaEntrada";
            dtpFechaEntrada.Size = new Size(229, 27);
            dtpFechaEntrada.TabIndex = 26;
            dtpFechaEntrada.Value = new DateTime(2026, 3, 22, 23, 19, 44, 0);
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.FromArgb(233, 238, 247);
            txtObservaciones.BorderStyle = BorderStyle.None;
            txtObservaciones.Font = new Font("Microsoft Sans Serif", 10F);
            txtObservaciones.Location = new Point(13, 414);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(531, 79);
            txtObservaciones.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10F);
            label14.Location = new Point(13, 391);
            label14.Name = "label14";
            label14.Size = new Size(121, 20);
            label14.TabIndex = 24;
            label14.Text = "Observaciones";
            // 
            // txtNoBultos
            // 
            txtNoBultos.BackColor = Color.FromArgb(233, 238, 247);
            txtNoBultos.BorderStyle = BorderStyle.None;
            txtNoBultos.Enabled = false;
            txtNoBultos.Font = new Font("Microsoft Sans Serif", 10F);
            txtNoBultos.Location = new Point(139, 331);
            txtNoBultos.Name = "txtNoBultos";
            txtNoBultos.Size = new Size(103, 19);
            txtNoBultos.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8F);
            label13.Location = new Point(139, 308);
            label13.Name = "label13";
            label13.Size = new Size(92, 17);
            label13.TabIndex = 22;
            label13.Text = "No. de bultos";
            // 
            // txtPesoTaraExtra
            // 
            txtPesoTaraExtra.BackColor = Color.FromArgb(233, 238, 247);
            txtPesoTaraExtra.BorderStyle = BorderStyle.None;
            txtPesoTaraExtra.Enabled = false;
            txtPesoTaraExtra.Font = new Font("Microsoft Sans Serif", 10F);
            txtPesoTaraExtra.Location = new Point(13, 331);
            txtPesoTaraExtra.Name = "txtPesoTaraExtra";
            txtPesoTaraExtra.Size = new Size(106, 19);
            txtPesoTaraExtra.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8F);
            label12.Location = new Point(13, 308);
            label12.Name = "label12";
            label12.Size = new Size(104, 17);
            label12.TabIndex = 20;
            label12.Text = "Peso tara extra";
            // 
            // txtPesoNetTotal
            // 
            txtPesoNetTotal.BackColor = Color.FromArgb(233, 238, 247);
            txtPesoNetTotal.BorderStyle = BorderStyle.None;
            txtPesoNetTotal.Font = new Font("Microsoft Sans Serif", 10F);
            txtPesoNetTotal.Location = new Point(452, 331);
            txtPesoNetTotal.Name = "txtPesoNetTotal";
            txtPesoNetTotal.Size = new Size(103, 19);
            txtPesoNetTotal.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8F);
            label11.Location = new Point(452, 308);
            label11.Name = "label11";
            label11.Size = new Size(103, 17);
            label11.TabIndex = 18;
            label11.Text = "Peso neto total";
            // 
            // txtPeseTaraInd
            // 
            txtPeseTaraInd.BackColor = Color.FromArgb(233, 238, 247);
            txtPeseTaraInd.BorderStyle = BorderStyle.None;
            txtPeseTaraInd.Enabled = false;
            txtPeseTaraInd.Font = new Font("Microsoft Sans Serif", 10F);
            txtPeseTaraInd.Location = new Point(326, 331);
            txtPeseTaraInd.Name = "txtPeseTaraInd";
            txtPeseTaraInd.Size = new Size(103, 19);
            txtPeseTaraInd.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8F);
            label10.Location = new Point(326, 308);
            label10.Name = "label10";
            label10.Size = new Size(96, 17);
            label10.TabIndex = 16;
            label10.Text = "Peso tara ind.";
            // 
            // txtPesoNeto
            // 
            txtPesoNeto.BackColor = Color.FromArgb(233, 238, 247);
            txtPesoNeto.BorderStyle = BorderStyle.None;
            txtPesoNeto.Font = new Font("Microsoft Sans Serif", 10F);
            txtPesoNeto.Location = new Point(139, 262);
            txtPesoNeto.Name = "txtPesoNeto";
            txtPesoNeto.Size = new Size(103, 19);
            txtPesoNeto.TabIndex = 15;
            txtPesoNeto.TextChanged += txtPesoNeto_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8F);
            label9.Location = new Point(139, 239);
            label9.Name = "label9";
            label9.Size = new Size(103, 17);
            label9.TabIndex = 14;
            label9.Text = "Peso neto (Kg)";
            // 
            // txtPesoBruto
            // 
            txtPesoBruto.BackColor = Color.FromArgb(233, 238, 247);
            txtPesoBruto.BorderStyle = BorderStyle.None;
            txtPesoBruto.Enabled = false;
            txtPesoBruto.Font = new Font("Microsoft Sans Serif", 10F);
            txtPesoBruto.Location = new Point(13, 262);
            txtPesoBruto.Name = "txtPesoBruto";
            txtPesoBruto.Size = new Size(106, 19);
            txtPesoBruto.TabIndex = 13;
            txtPesoBruto.TextChanged += txtPesoBruto_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8F);
            label8.Location = new Point(13, 239);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 12;
            label8.Text = "Peso bruto (kg)";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(233, 238, 247);
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.Enabled = false;
            txtProducto.Font = new Font("Microsoft Sans Serif", 10F);
            txtProducto.Location = new Point(326, 181);
            txtProducto.Multiline = true;
            txtProducto.Name = "txtProducto";
            txtProducto.ScrollBars = ScrollBars.Horizontal;
            txtProducto.Size = new Size(218, 75);
            txtProducto.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F);
            label7.Location = new Point(326, 158);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 10;
            label7.Text = "Producto ";
            // 
            // txtProveedor
            // 
            txtProveedor.BackColor = Color.FromArgb(233, 238, 247);
            txtProveedor.BorderStyle = BorderStyle.None;
            txtProveedor.Enabled = false;
            txtProveedor.Font = new Font("Microsoft Sans Serif", 10F);
            txtProveedor.Location = new Point(13, 190);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(229, 19);
            txtProveedor.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(13, 158);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 8;
            label6.Text = "Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(326, 88);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 6;
            label5.Text = "Fecha/Hora de salida";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.FromArgb(233, 238, 247);
            txtPlaca.BorderStyle = BorderStyle.None;
            txtPlaca.Enabled = false;
            txtPlaca.Font = new Font("Microsoft Sans Serif", 10F);
            txtPlaca.Location = new Point(13, 120);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(229, 19);
            txtPlaca.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(13, 88);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 4;
            label4.Text = "Placa del vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(326, 22);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha/Hora de entrada";
            // 
            // txtReporteNo
            // 
            txtReporteNo.BackColor = Color.FromArgb(233, 238, 247);
            txtReporteNo.BorderStyle = BorderStyle.None;
            txtReporteNo.Enabled = false;
            txtReporteNo.Font = new Font("Microsoft Sans Serif", 10F);
            txtReporteNo.Location = new Point(13, 54);
            txtReporteNo.Name = "txtReporteNo";
            txtReporteNo.Size = new Size(229, 19);
            txtReporteNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(13, 22);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Reporte No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Itim", 15F);
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 0;
            label1.Text = "Registrar Pesaje";
            // 
            // RegistrarPesos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 726);
            Controls.Add(pnContenedorHijo);
            Name = "RegistrarPesos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RegistrarPesos";
            Load += RegistrarPesos_Load;
            pnContenedorHijo.ResumeLayout(false);
            pnContenedorHijo.PerformLayout();
            pnDiferencia.ResumeLayout(false);
            pnDiferencia.PerformLayout();
            panel1.ResumeLayout(false);
            pnTextboxses.ResumeLayout(false);
            pnTextboxses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnContenedorHijo;
        private Panel panel1;
        private Button btnVolver;
        private Panel pnTextboxses;
        private Label label1;
        private Button btnImprimir;
        private Button btnSeguir;
        private Button btnGuardar;
        private TextBox txtObservaciones;
        private Label label14;
        private TextBox txtNoBultos;
        private Label label13;
        private TextBox txtPesoTaraExtra;
        private Label label12;
        private TextBox txtPesoNetTotal;
        private Label label11;
        private TextBox txtPeseTaraInd;
        private Label label10;
        private TextBox txtPesoNeto;
        private Label label9;
        private TextBox txtPesoBruto;
        private Label label8;
        private TextBox txtProducto;
        private Label label7;
        private TextBox txtProveedor;
        private Label label6;
        private Label label5;
        private TextBox txtPlaca;
        private Label label4;
        private Label label3;
        private TextBox txtReporteNo;
        private Label label2;
        private Panel pnDiferencia;
        private Label lblDiferencia;
        private Label label16;
        private Label label15;
        private DateTimePicker dtpFechaEntrada;
        private DateTimePicker dtpFechaSalida;
    }
}