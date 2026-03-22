namespace BimboPesaje.Formularios.Productos
{
    partial class GestionProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnContenedorHijo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnSalir = new Button();
            pnDgv = new Panel();
            dgvProveedor = new DataGridView();
            pnFiltros = new Panel();
            label1 = new Label();
            cmbPais = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            pnFiltro = new Panel();
            btnLimpiar = new Button();
            pnBuscar = new Panel();
            txtBusqueda = new TextBox();
            button1 = new Button();
            IdProveedor = new DataGridViewTextBoxColumn();
            RtnProveedor = new DataGridViewTextBoxColumn();
            NombreProveedor = new DataGridViewTextBoxColumn();
            TelefonoProveedor = new DataGridViewTextBoxColumn();
            CorreoProveedor = new DataGridViewTextBoxColumn();
            DireccionProveedor = new DataGridViewTextBoxColumn();
            EstadoProveedor = new DataGridViewTextBoxColumn();
            pnContenedorHijo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            pnFiltros.SuspendLayout();
            pnFiltro.SuspendLayout();
            pnBuscar.SuspendLayout();
            SuspendLayout();
            // 
            // pnContenedorHijo
            // 
            pnContenedorHijo.BackColor = Color.FromArgb(220, 230, 241);
            pnContenedorHijo.Controls.Add(tableLayoutPanel1);
            pnContenedorHijo.Controls.Add(pnDgv);
            pnContenedorHijo.Controls.Add(pnFiltros);
            pnContenedorHijo.Controls.Add(pnFiltro);
            pnContenedorHijo.Controls.Add(pnBuscar);
            pnContenedorHijo.Dock = DockStyle.Fill;
            pnContenedorHijo.Location = new Point(0, 0);
            pnContenedorHijo.Name = "pnContenedorHijo";
            pnContenedorHijo.Size = new Size(914, 726);
            pnContenedorHijo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnNuevo, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEditar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSalir, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 589);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(273, 125);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(12, 92, 92);
            btnNuevo.Dock = DockStyle.Fill;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Itim", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(3, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 56);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo Producto";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 90, 172);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Itim", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(139, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 56);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gray;
            btnSalir.Dock = DockStyle.Fill;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Itim", 12F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(3, 65);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 57);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // pnDgv
            // 
            pnDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnDgv.Controls.Add(dgvProveedor);
            pnDgv.Location = new Point(12, 175);
            pnDgv.Name = "pnDgv";
            pnDgv.Size = new Size(890, 399);
            pnDgv.TabIndex = 11;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 230, 241);
            dataGridViewCellStyle1.Font = new Font("Itim", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvProveedor.BackgroundColor = Color.White;
            dgvProveedor.BorderStyle = BorderStyle.None;
            dgvProveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle2.Font = new Font("Itim", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedor.ColumnHeadersHeight = 36;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { IdProveedor, RtnProveedor, NombreProveedor, TelefonoProveedor, CorreoProveedor, DireccionProveedor, EstadoProveedor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Itim", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedor.Dock = DockStyle.Fill;
            dgvProveedor.EnableHeadersVisualStyles = false;
            dgvProveedor.GridColor = Color.White;
            dgvProveedor.Location = new Point(0, 0);
            dgvProveedor.Margin = new Padding(4);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle4.Font = new Font("Itim", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProveedor.RowHeadersWidth = 30;
            dgvProveedor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(890, 399);
            dgvProveedor.TabIndex = 2;
            dgvProveedor.UseWaitCursor = true;
            // 
            // pnFiltros
            // 
            pnFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnFiltros.BackColor = Color.White;
            pnFiltros.Controls.Add(label1);
            pnFiltros.Controls.Add(cmbPais);
            pnFiltros.Controls.Add(radioButton1);
            pnFiltros.Controls.Add(radioButton2);
            pnFiltros.Controls.Add(radioButton3);
            pnFiltros.Location = new Point(23, 93);
            pnFiltros.Name = "pnFiltros";
            pnFiltros.Size = new Size(879, 39);
            pnFiltros.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Itim", 11F);
            label1.Location = new Point(679, 9);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 18;
            label1.Text = "Pais";
            // 
            // cmbPais
            // 
            cmbPais.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(725, 6);
            cmbPais.Margin = new Padding(0, 0, 3, 0);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(146, 28);
            cmbPais.TabIndex = 19;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Itim", 11F);
            radioButton1.Location = new Point(4, 7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(124, 27);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Habilitados";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Itim", 11F);
            radioButton2.Location = new Point(134, 7);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(149, 27);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Deshabilitados";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Itim", 11F);
            radioButton3.Location = new Point(289, 7);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(78, 27);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Todos";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // pnFiltro
            // 
            pnFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnFiltro.BackColor = Color.White;
            pnFiltro.Controls.Add(btnLimpiar);
            pnFiltro.Location = new Point(685, 27);
            pnFiltro.Name = "pnFiltro";
            pnFiltro.Size = new Size(217, 34);
            pnFiltro.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(31, 60, 136);
            btnLimpiar.Dock = DockStyle.Right;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Itim", 12F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = Properties.Resources.escoba;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(0, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(217, 34);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar Filtros";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // pnBuscar
            // 
            pnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnBuscar.BackColor = Color.White;
            pnBuscar.Controls.Add(txtBusqueda);
            pnBuscar.Controls.Add(button1);
            pnBuscar.Font = new Font("Itim", 12F);
            pnBuscar.ForeColor = Color.Transparent;
            pnBuscar.Location = new Point(23, 27);
            pnBuscar.Name = "pnBuscar";
            pnBuscar.Size = new Size(516, 32);
            pnBuscar.TabIndex = 8;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.BackColor = Color.White;
            txtBusqueda.BorderStyle = BorderStyle.None;
            txtBusqueda.Font = new Font("Itim", 14F);
            txtBusqueda.ForeColor = Color.Black;
            txtBusqueda.Location = new Point(40, 0);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar proveedor...";
            txtBusqueda.Size = new Size(792, 28);
            txtBusqueda.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 60, 136);
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.buscar_24;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(40, 32);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // IdProveedor
            // 
            IdProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            IdProveedor.DataPropertyName = "IdProveedor";
            IdProveedor.HeaderText = "Id";
            IdProveedor.MinimumWidth = 6;
            IdProveedor.Name = "IdProveedor";
            IdProveedor.ReadOnly = true;
            IdProveedor.Width = 55;
            // 
            // RtnProveedor
            // 
            RtnProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RtnProveedor.DataPropertyName = "RtnProveedor";
            RtnProveedor.HeaderText = "RTN";
            RtnProveedor.MinimumWidth = 6;
            RtnProveedor.Name = "RtnProveedor";
            RtnProveedor.ReadOnly = true;
            RtnProveedor.Width = 74;
            // 
            // NombreProveedor
            // 
            NombreProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NombreProveedor.DataPropertyName = "NombreProveedor";
            NombreProveedor.HeaderText = "Proveedor";
            NombreProveedor.MinimumWidth = 6;
            NombreProveedor.Name = "NombreProveedor";
            NombreProveedor.ReadOnly = true;
            NombreProveedor.Width = 124;
            // 
            // TelefonoProveedor
            // 
            TelefonoProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TelefonoProveedor.DataPropertyName = "TelefonoProveedor";
            TelefonoProveedor.HeaderText = "Teléfono";
            TelefonoProveedor.MinimumWidth = 6;
            TelefonoProveedor.Name = "TelefonoProveedor";
            TelefonoProveedor.ReadOnly = true;
            TelefonoProveedor.Width = 111;
            // 
            // CorreoProveedor
            // 
            CorreoProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CorreoProveedor.DataPropertyName = "CorreoProveedor";
            CorreoProveedor.HeaderText = "Correo";
            CorreoProveedor.MinimumWidth = 6;
            CorreoProveedor.Name = "CorreoProveedor";
            CorreoProveedor.ReadOnly = true;
            CorreoProveedor.Width = 96;
            // 
            // DireccionProveedor
            // 
            DireccionProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DireccionProveedor.DataPropertyName = "DireccionProveedor";
            DireccionProveedor.HeaderText = "Pais";
            DireccionProveedor.MinimumWidth = 6;
            DireccionProveedor.Name = "DireccionProveedor";
            DireccionProveedor.ReadOnly = true;
            DireccionProveedor.Width = 71;
            // 
            // EstadoProveedor
            // 
            EstadoProveedor.HeaderText = "Estado";
            EstadoProveedor.MinimumWidth = 6;
            EstadoProveedor.Name = "EstadoProveedor";
            EstadoProveedor.ReadOnly = true;
            EstadoProveedor.Width = 125;
            // 
            // GestionProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 726);
            Controls.Add(pnContenedorHijo);
            Name = "GestionProveedores";
            Text = "Gestion de proveedores";
            Load += GestionProveedores_Load;
            pnContenedorHijo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            pnFiltros.ResumeLayout(false);
            pnFiltros.PerformLayout();
            pnFiltro.ResumeLayout(false);
            pnBuscar.ResumeLayout(false);
            pnBuscar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnContenedorHijo;
        private Panel pnBuscar;
        private TextBox txtBusqueda;
        private Button button1;
        private Panel pnFiltro;
        private Button btnLimpiar;
        private Panel pnFiltros;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label4;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label6;
        private ComboBox comboBox6;
        private Panel pnDgv;
        private DataGridView dgvProveedor;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnSalir;
        private Label label1;
        private ComboBox cmbPais;
        private DataGridViewTextBoxColumn IdProveedor;
        private DataGridViewTextBoxColumn RtnProveedor;
        private DataGridViewTextBoxColumn NombreProveedor;
        private DataGridViewTextBoxColumn TelefonoProveedor;
        private DataGridViewTextBoxColumn CorreoProveedor;
        private DataGridViewTextBoxColumn DireccionProveedor;
        private DataGridViewTextBoxColumn EstadoProveedor;
    }
}