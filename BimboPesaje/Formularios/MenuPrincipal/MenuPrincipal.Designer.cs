namespace BimboPesaje
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            nombresFrms = new Panel();
            lblHeader = new Label();
            panelimagenVolver = new Panel();
            pictureBox1 = new PictureBox();
            btnSlide = new PictureBox();
            menuVertical = new Panel();
            btnReporteria = new Button();
            pnPesajes = new Panel();
            btnMovimientosEntradas = new Button();
            btnPesaje = new Button();
            pnProductos = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnGestionFabricantes = new Button();
            btnGestionProveedores = new Button();
            btnGestionProductos = new Button();
            btnProductos = new Button();
            pnUsers = new Panel();
            btnBitacora = new Button();
            btnGestionRoles = new Button();
            btnGestionUsuarios = new Button();
            btnGestionEmpleados = new Button();
            btnUsuarios = new Button();
            pnContenedor = new Panel();
            pictureBox2 = new PictureBox();
            nombresFrms.SuspendLayout();
            panelimagenVolver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            menuVertical.SuspendLayout();
            pnPesajes.SuspendLayout();
            pnProductos.SuspendLayout();
            pnUsers.SuspendLayout();
            pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nombresFrms
            // 
            nombresFrms.BackColor = Color.FromArgb(31, 60, 136);
            nombresFrms.Controls.Add(lblHeader);
            resources.ApplyResources(nombresFrms, "nombresFrms");
            nombresFrms.Name = "nombresFrms";
            // 
            // lblHeader
            // 
            resources.ApplyResources(lblHeader, "lblHeader");
            lblHeader.ForeColor = Color.White;
            lblHeader.Name = "lblHeader";
            // 
            // panelimagenVolver
            // 
            panelimagenVolver.Controls.Add(pictureBox1);
            panelimagenVolver.Controls.Add(btnSlide);
            resources.ApplyResources(panelimagenVolver, "panelimagenVolver");
            panelimagenVolver.Name = "panelimagenVolver";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bimbo_nombre_escalado;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnSlide
            // 
            btnSlide.Image = Properties.Resources.menu_hamburguesa_80;
            resources.ApplyResources(btnSlide, "btnSlide");
            btnSlide.Name = "btnSlide";
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // menuVertical
            // 
            resources.ApplyResources(menuVertical, "menuVertical");
            menuVertical.BackColor = Color.FromArgb(31, 60, 136);
            menuVertical.Controls.Add(btnReporteria);
            menuVertical.Controls.Add(pnPesajes);
            menuVertical.Controls.Add(btnPesaje);
            menuVertical.Controls.Add(pnProductos);
            menuVertical.Controls.Add(btnProductos);
            menuVertical.Controls.Add(pnUsers);
            menuVertical.Controls.Add(btnUsuarios);
            menuVertical.Controls.Add(panelimagenVolver);
            menuVertical.ForeColor = Color.Transparent;
            menuVertical.Name = "menuVertical";
            // 
            // btnReporteria
            // 
            resources.ApplyResources(btnReporteria, "btnReporteria");
            btnReporteria.FlatAppearance.BorderSize = 0;
            btnReporteria.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnReporteria.Image = Properties.Resources.informe;
            btnReporteria.Name = "btnReporteria";
            btnReporteria.UseVisualStyleBackColor = true;
            // 
            // pnPesajes
            // 
            pnPesajes.BackColor = Color.FromArgb(79, 125, 209);
            pnPesajes.Controls.Add(btnMovimientosEntradas);
            resources.ApplyResources(pnPesajes, "pnPesajes");
            pnPesajes.Name = "pnPesajes";
            // 
            // btnMovimientosEntradas
            // 
            resources.ApplyResources(btnMovimientosEntradas, "btnMovimientosEntradas");
            btnMovimientosEntradas.FlatAppearance.BorderSize = 0;
            btnMovimientosEntradas.Name = "btnMovimientosEntradas";
            btnMovimientosEntradas.UseVisualStyleBackColor = true;
            btnMovimientosEntradas.Click += btnMovimientosEntradas_Click;
            // 
            // btnPesaje
            // 
            resources.ApplyResources(btnPesaje, "btnPesaje");
            btnPesaje.FlatAppearance.BorderSize = 0;
            btnPesaje.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnPesaje.Image = Properties.Resources.camion;
            btnPesaje.Name = "btnPesaje";
            btnPesaje.UseVisualStyleBackColor = true;
            btnPesaje.Click += btnPesaje_Click;
            // 
            // pnProductos
            // 
            pnProductos.BackColor = Color.FromArgb(79, 125, 209);
            pnProductos.Controls.Add(button2);
            pnProductos.Controls.Add(button1);
            pnProductos.Controls.Add(btnGestionFabricantes);
            pnProductos.Controls.Add(btnGestionProveedores);
            pnProductos.Controls.Add(btnGestionProductos);
            resources.ApplyResources(pnProductos, "pnProductos");
            pnProductos.Name = "pnProductos";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.FlatAppearance.BorderSize = 0;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.FlatAppearance.BorderSize = 0;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGestionFabricantes
            // 
            resources.ApplyResources(btnGestionFabricantes, "btnGestionFabricantes");
            btnGestionFabricantes.FlatAppearance.BorderSize = 0;
            btnGestionFabricantes.Name = "btnGestionFabricantes";
            btnGestionFabricantes.UseVisualStyleBackColor = true;
            btnGestionFabricantes.Click += btnGestionFabricantes_Click;
            // 
            // btnGestionProveedores
            // 
            resources.ApplyResources(btnGestionProveedores, "btnGestionProveedores");
            btnGestionProveedores.FlatAppearance.BorderSize = 0;
            btnGestionProveedores.Name = "btnGestionProveedores";
            btnGestionProveedores.UseVisualStyleBackColor = true;
            btnGestionProveedores.Click += btnGestionProveedores_Click;
            // 
            // btnGestionProductos
            // 
            resources.ApplyResources(btnGestionProductos, "btnGestionProductos");
            btnGestionProductos.FlatAppearance.BorderSize = 0;
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // btnProductos
            // 
            resources.ApplyResources(btnProductos, "btnProductos");
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnProductos.Image = Properties.Resources.cajas;
            btnProductos.Name = "btnProductos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // pnUsers
            // 
            pnUsers.BackColor = Color.FromArgb(79, 125, 209);
            pnUsers.Controls.Add(btnBitacora);
            pnUsers.Controls.Add(btnGestionRoles);
            pnUsers.Controls.Add(btnGestionUsuarios);
            pnUsers.Controls.Add(btnGestionEmpleados);
            resources.ApplyResources(pnUsers, "pnUsers");
            pnUsers.Name = "pnUsers";
            // 
            // btnBitacora
            // 
            resources.ApplyResources(btnBitacora, "btnBitacora");
            btnBitacora.FlatAppearance.BorderSize = 0;
            btnBitacora.Name = "btnBitacora";
            btnBitacora.UseVisualStyleBackColor = true;
            btnBitacora.Click += btnBitacora_Click;
            // 
            // btnGestionRoles
            // 
            resources.ApplyResources(btnGestionRoles, "btnGestionRoles");
            btnGestionRoles.FlatAppearance.BorderSize = 0;
            btnGestionRoles.Name = "btnGestionRoles";
            btnGestionRoles.UseVisualStyleBackColor = true;
            btnGestionRoles.Click += btnGestionRoles_Click;
            // 
            // btnGestionUsuarios
            // 
            resources.ApplyResources(btnGestionUsuarios, "btnGestionUsuarios");
            btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = true;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnGestionEmpleados
            // 
            resources.ApplyResources(btnGestionEmpleados, "btnGestionEmpleados");
            btnGestionEmpleados.FlatAppearance.BorderSize = 0;
            btnGestionEmpleados.Name = "btnGestionEmpleados";
            btnGestionEmpleados.UseVisualStyleBackColor = true;
            btnGestionEmpleados.Click += btnGestionEmpleados_Click;
            // 
            // btnUsuarios
            // 
            resources.ApplyResources(btnUsuarios, "btnUsuarios");
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnUsuarios.Image = Properties.Resources.avatar;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // pnContenedor
            // 
            pnContenedor.BackColor = Color.White;
            pnContenedor.Controls.Add(pictureBox2);
            resources.ApplyResources(pnContenedor, "pnContenedor");
            pnContenedor.Name = "pnContenedor";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.bimbo_logo;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 60, 136);
            Controls.Add(pnContenedor);
            Controls.Add(nombresFrms);
            Controls.Add(menuVertical);
            Name = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            nombresFrms.ResumeLayout(false);
            nombresFrms.PerformLayout();
            panelimagenVolver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            menuVertical.ResumeLayout(false);
            pnPesajes.ResumeLayout(false);
            pnProductos.ResumeLayout(false);
            pnUsers.ResumeLayout(false);
            pnContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel nombresFrms;
        private Panel panelimagenVolver;
        private PictureBox btnSlide;
        private Panel menuVertical;
        private Panel pnUsers;
        private Button btnUsuarios;
        private Button btnGestionEmpleados;
        private Panel pnProductos;
        private Button btnGestionFabricantes;
        private Button btnGestionProveedores;
        private Button btnGestionProductos;
        private Button btnProductos;
        private Button btnBitacora;
        private Button btnGestionRoles;
        private Button btnGestionUsuarios;
        private Panel pnPesajes;
        private Button btnMovimientosEntradas;
        private Button btnPesaje;
        private Button btnReporteria;
        private PictureBox pictureBox1;
        private Label lblHeader;
        private Panel pnContenedor;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
    }
}
