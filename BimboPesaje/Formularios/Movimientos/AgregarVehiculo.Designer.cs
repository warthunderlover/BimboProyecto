namespace BimboPesaje.Formularios.Movimientos
{
    partial class AgregarVehiculo
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
            pnContenedor = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnVolver = new Button();
            btnGuardar = new Button();
            txtPlaca = new TextBox();
            label1 = new Label();
            pnTitulo = new Panel();
            lblTitulo = new Label();
            pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnContenedor
            // 
            pnContenedor.BackColor = Color.FromArgb(79, 125, 209);
            pnContenedor.Controls.Add(pictureBox1);
            pnContenedor.Controls.Add(panel1);
            pnContenedor.Controls.Add(txtPlaca);
            pnContenedor.Controls.Add(label1);
            pnContenedor.Controls.Add(pnTitulo);
            pnContenedor.Dock = DockStyle.Fill;
            pnContenedor.Location = new Point(0, 0);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(852, 388);
            pnContenedor.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.bimbo_no_bg;
            pictureBox1.Location = new Point(12, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(592, 329);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 47);
            panel1.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Gray;
            btnVolver.Dock = DockStyle.Right;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Itim", 10F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(154, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 47);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(12, 92, 92);
            btnGuardar.Dock = DockStyle.Left;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Itim", 10F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(0, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 47);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Itim", 15F);
            txtPlaca.Location = new Point(293, 212);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(297, 37);
            txtPlaca.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Itim", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(195, 219);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 1;
            label1.Text = "Placa:";
            // 
            // pnTitulo
            // 
            pnTitulo.BackColor = Color.FromArgb(31, 60, 136);
            pnTitulo.Controls.Add(lblTitulo);
            pnTitulo.Location = new Point(3, 33);
            pnTitulo.Name = "pnTitulo";
            pnTitulo.Size = new Size(850, 90);
            pnTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Itim", 24F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(266, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(299, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Camión";
            // 
            // AgregarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 388);
            Controls.Add(pnContenedor);
            Name = "AgregarVehiculo";
            Text = "AgregarVehiculo";
            pnContenedor.ResumeLayout(false);
            pnContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            pnTitulo.ResumeLayout(false);
            pnTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnContenedor;
        private Panel pnTitulo;
        private Label lblTitulo;
        private Panel panel1;
        private Button btnVolver;
        private Button btnGuardar;
        private TextBox txtPlaca;
        private Label label1;
        private PictureBox pictureBox1;
    }
}