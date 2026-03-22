using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimboPesaje.Formularios.Productos
{
    public partial class GestionProductos : Form
    {
        private DataTable _tablaOriginal;
        public GestionProductos()
        {
            InitializeComponent();
        }

        private async void GestionProductos_Load(object sender, EventArgs e)
        {
            await CargarDatosDummy();
            await CargarComboBoxes();
        }

        private async Task CargarDatosDummy()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("MarcaProducto");
            tabla.Columns.Add("Pais");
            tabla.Columns.Add("Contenido");
            tabla.Columns.Add("Presentacion");
            tabla.Columns.Add("Proveedor");
            tabla.Columns.Add("EstadoProducto");

            // Codigo, Producto, Marca, Pais, Contenido, Presentacion, Proveedor, Estado
            tabla.Rows.Add("A28910", "ACEITE DE PALMA RBD", "Bimbo", "Honduras", "-", "-", "AGROTOR/JAREMAR", "Activo");
            tabla.Rows.Add("A81314", "ACEITE DE SOYA", "Bimbo", "Honduras", "-", "-", "AGROTOR/JAREMAR", "Activo");
            tabla.Rows.Add("A953506", "CHISPAS GOTAS SABOR CHOCOLATE BLANCO 2M PT0301171", "Marinela", "México", "-", "-", "ALPEZZI", "Activo");
            tabla.Rows.Add("A906414", "RELLENO WAFER CACAHUATE", "Ricolino", "México", "-", "-", "ALPEZZI", "Activo");
            tabla.Rows.Add("A953571", "CHISPAS GOTAS SABOR LIMON 7M", "Marinela", "México", "-", "-", "ALPEZZI", "Activo");
            tabla.Rows.Add("A953501", "CHISPAS GOTAS SABOR LIMON 2M", "Marinela", "México", "-", "-", "ALPEZZI", "Activo");
            tabla.Rows.Add("A953503", "CHISPAS GOTAS SABOR CHOCOLATE 7M", "Tía Rosa", "México", "-", "-", "ALPEZZI", "Activo");
            tabla.Rows.Add("A943551", "COBERTURA SABOR CHOCOLATE BLANCO", "Barcel", "México", "-", "-", "ALPEZZI", "Activo");
            tabla.Rows.Add("A82620", "MERMELADA DE FRESA (1) BARRITA", "Marinela", "México", "-", "-", "ALTEX FLEXPORT", "Activo");
            tabla.Rows.Add("A82621", "MERMELADA DE PIÑA (1) BARRITA", "Marinela", "México", "-", "-", "ALTEX FLEXPORT", "Activo");
            tabla.Rows.Add("A906557", "COBERTURA LAYER LACTEA BL", "Bimbo", "México", "-", "-", "BARRY CALLEBAUT", "Inactivo");
            tabla.Rows.Add("A82144", "GOTAS DE CHOCOLATE 7000", "Ricolino", "México", "-", "-", "BARRY CALLEBAUT", "Inactivo");
            tabla.Rows.Add("A953508", "CHISPAS DE CHOCOLATE 2000CT CHD-DR-7000322-050", "Barcel", "México", "-", "-", "BARRY CALLEBAUT", "Inactivo");
            tabla.Rows.Add("A52221", "CHISPA DE CHOCOLATE AMARGO CHD-DR-7144101-050", "Wonder", "México", "-", "-", "BARRY CALLEBAUT", "Inactivo");
            tabla.Rows.Add("A50568", "MANTECA VEGETAL TIPO VIII", "Bimbo", "Guatemala", "-", "-", "BIMBO CENTROAMERICA", "Inactivo");
            tabla.Rows.Add("A82131", "COCOA EN POLVO ALCALINA (Roja)", "Tía Rosa", "Guatemala", "-", "-", "BIMBO CENTROAMERICA", "Inactivo");
            tabla.Rows.Add("A82197", "COCOA EN POLVO ALCALINA 11-D-050", "Oroweat", "Guatemala", "-", "-", "BIMBO CENTROAMERICA", "Inactivo");
            tabla.Rows.Add("A81502", "AZUCAR NORMAL", "Bimbo", "Honduras", "-", "-", "CISA", "Inactivo");
            tabla.Rows.Add("A82331", "COLOR ROJO FRESA 6-340 (3%)", "Entenmann's", "México", "-", "-", "COLOR SENSIENT", "Inactivo");
            tabla.Rows.Add("A962771", "COLOR TERRA NATURAL BROWN POWDER 04919 SENSIENT", "Sara Lee", "México", "-", "-", "COLOR SENSIENT", "Inactivo");

            dgvProductos.AutoGenerateColumns = false;
            _tablaOriginal = tabla;
            dgvProductos.DataSource = tabla;
        }

        protected async Task CargarComboBoxes()
        {
            // === PAÍSES ===
            cmbPais.Items.Clear();
            cmbPais.Items.AddRange(new string[]
            {
                "México",
                "Honduras",
                "Guatemala",
                "El Salvador",
                "Nicaragua",
                "Costa Rica",
                "Panamá",
                "Colombia",
                "Chile",
                "Argentina"
            });

            // === CATEGORÍAS ===
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(new string[]
            {
                "Pan de Caja",
                "Pan Dulce",
                "Galletas",
                "Pasteles y Tortas",
                "Bollería",
                "Barras y Snacks",
                "Tortillas",
                "Tostadas",
                "Bagels y Muffins",
                "Productos Sin Gluten"
            });

            // === PROVEEDORES ===
            cmbMarca.Items.Clear();
            cmbMarca.Items.AddRange(new string[]
            {
                "Bimbo",
                "Marinela",
                "Tía Rosa",
                "Ricolino",
                "Barcel",
                "Wonder",
                "Entenmann's",
                "Thomas'",
                "Sara Lee",
                "Oroweat"
            });

            // Opcional: texto por defecto
            cmbPais.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDGV();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDGV();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDGV();
        }

        private void FiltrarPorEstado(string estado)
        {
            var filasFiltradas = _tablaOriginal.AsEnumerable()
                                               .Where(row => row["EstadoProducto"]
                                               .ToString() == estado);

            dgvProductos.DataSource = filasFiltradas.Any()
                ? filasFiltradas.CopyToDataTable()
                : _tablaOriginal.Clone();
        }
        private void FiltrarDGV()
        {
            var filas = _tablaOriginal.AsEnumerable().AsEnumerable();

            // Filtro por País
            if (cmbPais.SelectedIndex != -1)
                filas = filas.Where(row => row["Pais"].ToString() == cmbPais.SelectedItem.ToString());

            // Filtro por Categoría
            //if (cmbCategoria.SelectedIndex != -1)
            //    filas = filas.Where(row => row["Categoria"].ToString() == cmbCategoria.SelectedItem.ToString());

            // Filtro por Proveedor
            if (cmbMarca.SelectedIndex != -1)
                filas = filas.Where(row => row["MarcaProducto"].ToString() == cmbMarca.SelectedItem.ToString());

            // Aplicar filtro
            dgvProductos.DataSource = filas.Any()
                ? filas.CopyToDataTable()
                : _tablaOriginal.Clone();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar selecciones de los ComboBox
            cmbPais.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;

            // Limpiar radio buttons
            rbTodos.Checked = true;

            // Restaurar tabla original
            dgvProductos.DataSource = _tablaOriginal;
        }
        private void rbHabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHabilitados.Checked)
                FiltrarPorEstado("Activo");
        }
        private void rbDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeshabilitados.Checked)
                FiltrarPorEstado("Inactivo");
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
                dgvProductos.DataSource = _tablaOriginal;
        }
    }
}
