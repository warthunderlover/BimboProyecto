namespace BimboPesaje.Formularios.Productos
{
    partial class GestionCategorias
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnSalir = new Button();
            pnDgv = new Panel();
            dgvCategorias = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            nombreCategoria = new DataGridViewTextBoxColumn();
            descripcionCategoria = new DataGridViewTextBoxColumn();
            estadoCategoria = new DataGridViewCheckBoxColumn();
            pnFiltro = new Panel();
            btnLimpiar = new Button();
            pnBuscar = new Panel();
            txtBusqueda = new TextBox();
            button1 = new Button();
            pnFiltros = new Panel();
            rbHabilitados = new RadioButton();
            rbDeshabilitados = new RadioButton();
            rbTodos = new RadioButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            pnFiltro.SuspendLayout();
            pnBuscar.SuspendLayout();
            pnFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 230, 241);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(pnDgv);
            panel1.Controls.Add(pnFiltro);
            panel1.Controls.Add(pnBuscar);
            panel1.Controls.Add(pnFiltros);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 726);
            panel1.TabIndex = 0;
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
            tableLayoutPanel1.TabIndex = 11;
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
            btnNuevo.Text = "Nueva Categoría";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
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
            btnSalir.Click += btnSalir_Click;
            // 
            // pnDgv
            // 
            pnDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnDgv.Controls.Add(dgvCategorias);
            pnDgv.Location = new Point(12, 175);
            pnDgv.Name = "pnDgv";
            pnDgv.Size = new Size(890, 399);
            pnDgv.TabIndex = 10;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeColumns = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 230, 241);
            dataGridViewCellStyle1.Font = new Font("Itim", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle2.Font = new Font("Itim", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.ColumnHeadersHeight = 36;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Codigo, nombreCategoria, descripcionCategoria, estadoCategoria });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Itim", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.Dock = DockStyle.Fill;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.GridColor = Color.White;
            dgvCategorias.Location = new Point(0, 0);
            dgvCategorias.Margin = new Padding(4);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle4.Font = new Font("Itim", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(31, 60, 136);
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCategorias.RowHeadersWidth = 30;
            dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(890, 399);
            dgvCategorias.TabIndex = 2;
            dgvCategorias.UseWaitCursor = true;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Codigo.DataPropertyName = "idCategoria";
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 96;
            // 
            // nombreCategoria
            // 
            nombreCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreCategoria.DataPropertyName = "nombreCategoria";
            nombreCategoria.HeaderText = "Nombre categoría";
            nombreCategoria.MinimumWidth = 6;
            nombreCategoria.Name = "nombreCategoria";
            nombreCategoria.ReadOnly = true;
            // 
            // descripcionCategoria
            // 
            descripcionCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcionCategoria.DataPropertyName = "descripcionCategoria";
            descripcionCategoria.HeaderText = "Descripcion";
            descripcionCategoria.MinimumWidth = 6;
            descripcionCategoria.Name = "descripcionCategoria";
            descripcionCategoria.ReadOnly = true;
            // 
            // estadoCategoria
            // 
            estadoCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            estadoCategoria.DataPropertyName = "estadoCategoria";
            estadoCategoria.HeaderText = "Estado";
            estadoCategoria.MinimumWidth = 6;
            estadoCategoria.Name = "estadoCategoria";
            estadoCategoria.ReadOnly = true;
            estadoCategoria.Width = 72;
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
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(31, 60, 136);
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
            txtBusqueda.Multiline = true;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar categoria...";
            txtBusqueda.Size = new Size(473, 32);
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
            // pnFiltros
            // 
            pnFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnFiltros.BackColor = Color.White;
            pnFiltros.Controls.Add(rbHabilitados);
            pnFiltros.Controls.Add(rbDeshabilitados);
            pnFiltros.Controls.Add(rbTodos);
            pnFiltros.Location = new Point(23, 93);
            pnFiltros.Name = "pnFiltros";
            pnFiltros.Size = new Size(879, 39);
            pnFiltros.TabIndex = 6;
            // 
            // rbHabilitados
            // 
            rbHabilitados.AutoSize = true;
            rbHabilitados.Checked = true;
            rbHabilitados.Font = new Font("Itim", 11F);
            rbHabilitados.Location = new Point(4, 7);
            rbHabilitados.Name = "rbHabilitados";
            rbHabilitados.Size = new Size(124, 27);
            rbHabilitados.TabIndex = 9;
            rbHabilitados.TabStop = true;
            rbHabilitados.Text = "Habilitados";
            rbHabilitados.UseVisualStyleBackColor = true;
            // 
            // rbDeshabilitados
            // 
            rbDeshabilitados.AutoSize = true;
            rbDeshabilitados.Font = new Font("Itim", 11F);
            rbDeshabilitados.Location = new Point(134, 7);
            rbDeshabilitados.Name = "rbDeshabilitados";
            rbDeshabilitados.Size = new Size(149, 27);
            rbDeshabilitados.TabIndex = 10;
            rbDeshabilitados.Text = "Deshabilitados";
            rbDeshabilitados.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Font = new Font("Itim", 11F);
            rbTodos.Location = new Point(289, 7);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(78, 27);
            rbTodos.TabIndex = 11;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            // 
            // GestionCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 726);
            Controls.Add(panel1);
            Name = "GestionCategorias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GestionCategorias";
            Load += GestionCategorias_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            pnFiltro.ResumeLayout(false);
            pnBuscar.ResumeLayout(false);
            pnBuscar.PerformLayout();
            pnFiltros.ResumeLayout(false);
            pnFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnFiltros;
        private RadioButton rbHabilitados;
        private RadioButton rbDeshabilitados;
        private RadioButton rbTodos;
        private Panel pnBuscar;
        private TextBox txtBusqueda;
        private Button button1;
        private Panel pnFiltro;
        private Button btnLimpiar;
        private Panel pnDgv;
        private DataGridView dgvCategorias;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn nombreCategoria;
        private DataGridViewTextBoxColumn descripcionCategoria;
        private DataGridViewCheckBoxColumn estadoCategoria;
    }
}