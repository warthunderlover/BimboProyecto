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
    public partial class GestionFabricantes : Form
    {
        private DataTable _tablaOriginal;
        public GestionFabricantes()
        {
            InitializeComponent();
        }
        private async void GestionFabricantes_Load(object sender, EventArgs e)
        {
            await CargarDatosDummy();
            await CargarComboBoxes();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task CargarDatosDummy()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("IdFabricante");
            tabla.Columns.Add("RTNFabricante");
            tabla.Columns.Add("NombreFabricante");      // verifica este en el diseñador
            tabla.Columns.Add("TelefonoFabricante");
            tabla.Columns.Add("CorreoFabricante");
            tabla.Columns.Add("DireccionFabricante");
            tabla.Columns.Add("EstadoFabricante");

            tabla.Rows.Add("001", "08019999123456", "Fabricante Ejemplo", "+504 2232-1100", "ventas@jaremar.com", "Col. Las Lomas, Tegucigalpa", "Activo");
            tabla.Rows.Add("002", "08019998765432", "Fabricante Ejemplo", "+52 81 8888-0101", "contacto@alpezzi.com.mx", "Monterrey, Nuevo León, México", "Activo");
            tabla.Rows.Add("003", "08019997654321", "Fabricante Ejepmlo", "+52 55 5555-2233", "pedidos@altexflexport.mx", "Ciudad de México, México", "Activo");
            tabla.Rows.Add("004", "08019996543210", "Fabricante Ejepmlo", "+52 55 4444-9988", "mx.ventas@barry-callebaut.com", "Tlalnepantla, México", "Activo");
            tabla.Rows.Add("005", "08019995432109", "Fabricante Ejepmlo", "+502 2223-4400", "proveedores@bimboca.com", "Ciudad de Guatemala, Guatemala", "Activo");
            tabla.Rows.Add("006", "08019994321098", "Fabricante Ejemplo", "+504 2220-3300", "contacto@cisa.hn", "San Pedro Sula, Cortés", "Activo");
            tabla.Rows.Add("007", "08019993210987", "Fabricante Ejemplo", "+52 55 6677-8899", "sensient.mx@sensient.com", "Querétaro, México", "Activo");
            tabla.Rows.Add("008", "08019992109876", "Fabricante Ejemplo", "+52 55 3344-5566", "danisco.ventas@dupont.com", "Monterrey, Nuevo León, México", "Activo");
            tabla.Rows.Add("009", "08019991098765", "Fabricante Ejemplo", "+57 1 800-0123", "ventas@levapan.com", "Bogotá, Colombia", "Activo");
            tabla.Rows.Add("010", "08019990987654", "Fabricante Ejemplo", "+32 3 890-0200", "info@puratos.com", "Groot-Bijgaarden, Bélgica", "Inactivo");

            dgvFabricante.AutoGenerateColumns = false;
            _tablaOriginal = tabla;
            dgvFabricante.DataSource = tabla;
        }

        protected async Task CargarComboBoxes()
        {
            // === PAÍSES ===
            cmbPaises.Items.Clear();
            cmbPaises.Items.AddRange(new string[]
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
            // === PROVEEDORES ===
            cmbProveedor.Items.Clear();
            cmbProveedor.Items.AddRange(new string[]
            {
                "AGROTOR/JAREMAR",
                "ALPEZZI",
                "ALTEX FLEXPORT",
                "BARRY CALLEBAUT",
                "BIMBO CENTROAMERICA",
                "CISA",
                "COLOR SENSIENT",
                "DANISCO",
                "LEVAPAN",
                "PURATOS"
            });

            // Opcional: texto por defecto
            cmbPaises.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            //cmbCategoria.SelectedIndex = -1;
        }
       

        private void rbHabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHabilitados.Checked)
                FiltrarPorEstado("Activo");
        }

        private void rbDeshabilitados_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDeshabilitados.Checked)
                FiltrarPorEstado("Inactivo");
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
                dgvFabricante.DataSource = _tablaOriginal;
        }
        private void FiltrarPorEstado(string estado)
        {
            var filasFiltradas = _tablaOriginal.AsEnumerable()
     .Where(row => row["EstadoFabricante"].ToString() == estado);

            dgvFabricante.DataSource = filasFiltradas.Any()
                ? filasFiltradas.CopyToDataTable()
                : _tablaOriginal.Clone();
        }
    }
}
