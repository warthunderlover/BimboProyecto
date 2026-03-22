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
            tabla.Columns.Add("Pais");
            tabla.Columns.Add("Contenido");
            tabla.Columns.Add("Presentacion");
            tabla.Columns.Add("Proveedor");

            // Datos reales de Bimbo Honduras - Materias Primas
            tabla.Rows.Add("A28910", "ACEITE DE PALMA RBD", "Honduras", "-", "-", "AGROTOR/JAREMAR");
            tabla.Rows.Add("A81314", "ACEITE DE SOYA", "Honduras", "-", "-", "AGROTOR/JAREMAR");
            tabla.Rows.Add("A953506", "CHISPAS GOTAS SABOR CHOCOLATE BLANCO 2M PT0301171", "México", "-", "-", "ALPEZZI");
            tabla.Rows.Add("A906414", "RELLENO WAFER CACAHUATE", "México", "-", "-", "ALPEZZI");
            tabla.Rows.Add("A953571", "CHISPAS GOTAS SABOR LIMON 7M", "México", "-", "-", "ALPEZZI");
            tabla.Rows.Add("A953501", "CHISPAS GOTAS SABOR LIMON 2M", "México", "-", "-", "ALPEZZI");
            tabla.Rows.Add("A953503", "CHISPAS GOTAS SABOR CHOCOLATE 7M", "México", "-", "-", "ALPEZZI");
            tabla.Rows.Add("A943551", "COBERTURA SABOR CHOCOLATE BLANCO", "México", "-", "-", "ALPEZZI");
            tabla.Rows.Add("A82620", "MERMELADA DE FRESA (1) BARRITA", "México", "-", "-", "ALTEX FLEXPORT");
            tabla.Rows.Add("A82621", "MERMELADA DE PIÑA (1) BARRITA", "México", "-", "-", "ALTEX FLEXPORT");
            tabla.Rows.Add("A906557", "COBERTURA LAYER LACTEA BL", "México", "-", "-", "BARRY CALLEBAUT");
            tabla.Rows.Add("A82144", "GOTAS DE CHOCOLATE 7000", "México", "-", "-", "BARRY CALLEBAUT");
            tabla.Rows.Add("A953508", "CHISPAS DE CHOCOLATE 2000CT CHD-DR-7000322-050", "México", "-", "-", "BARRY CALLEBAUT");
            tabla.Rows.Add("A52221", "CHISPA DE CHOCOLATE AMARGO CHD-DR-7144101-050", "México", "-", "-", "BARRY CALLEBAUT");
            tabla.Rows.Add("A50568", "MANTECA VEGETAL TIPO VIII", "Guatemala", "-", "-", "BIMBO CENTROAMERICA");
            tabla.Rows.Add("A82131", "COCOA EN POLVO ALCALINA (Roja)", "Guatemala", "-", "-", "BIMBO CENTROAMERICA");
            tabla.Rows.Add("A82197", "COCOA EN POLVO ALCALINA 11-D-050", "Guatemala", "-", "-", "BIMBO CENTROAMERICA");
            tabla.Rows.Add("A81502", "AZUCAR NORMAL", "Honduras", "-", "-", "CISA");
            tabla.Rows.Add("A82331", "COLOR ROJO FRESA 6-340 (3%)", "México", "-", "-", "COLOR SENSIENT");
            tabla.Rows.Add("A962771", "COLOR TERRA NATURAL BROWN POWDER 04919 SENSIENT", "México", "-", "-", "COLOR SENSIENT");

            dgvProductos.AutoGenerateColumns = false;
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
    }
}
