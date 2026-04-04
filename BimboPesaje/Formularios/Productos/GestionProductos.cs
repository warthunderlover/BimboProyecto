using CapaDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using productosLista = CapaDatos.Modelados.Productos.Productos;
using CapaDatos.Modelados.Productos;

namespace BimboPesaje.Formularios.Productos
{
    public partial class GestionProductos : Form
    {
        private List<productosLista> _listaOriginal = new List<productosLista>();
        // Propiedades públicas con los datos del producto seleccionado
        public string CodigoSeleccionado { get; private set; }
        public string ProductoSeleccionado { get; private set; }
        public string ProveedorSeleccionado { get; private set; }
        public string EstadoSeleccionado { get; private set; }
        public GestionProductos()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;

        }

        private async void GestionProductos_Load(object sender, EventArgs e)
        {
            await CargarDatos();
            await CargarComboBoxes();
            await cargarPaises.CargarPaises(cmbPais);
            //rbHabilitados.Checked = true;
        }

        private async Task CargarDatos()
        {
            try
            {
                // Usar el nombre de tipo para llamar al método estático
                _listaOriginal = await RepositorioProducto.obtenerProductosJoin();
                dgvProductos.DataSource = _listaOriginal;
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async Task CargarComboBoxes()
        {
            cmbMarca.Items.Clear();
            cmbMarca.Items.AddRange(new string[]
            {
                "Bimbo", "Marinela", "Tía Rosa", "Ricolino",
                "Barcel", "Wonder", "Entenmann's", "Thomas'",
                "Sara Lee", "Oroweat"
            });

            cmbPais.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0) return;

            CodigoSeleccionado = dgvProductos.SelectedRows[0].Cells["Codigo"].Value?.ToString();
            ProductoSeleccionado = dgvProductos.SelectedRows[0].Cells["Producto"].Value?.ToString();
            ProveedorSeleccionado = dgvProductos.SelectedRows[0].Cells["Fabricante"].Value?.ToString();
            //EstadoSeleccionado = dgvProductos.SelectedRows[0].Cells["EstadoProducto"].Value?.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FiltrarDGV();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FiltrarDGV();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FiltrarDGV();
        }

        private void AplicarFiltros()
        {
            var query = _listaOriginal.AsEnumerable();

            // Filtro por estado (radio buttons)
            if (rbHabilitados.Checked)
                query = query.Where(p => p.idEstado == 1);
            else if (rbDeshabilitados.Checked)
                query = query.Where(p => p.idEstado != 1);

            // Filtro por país
            if (cmbPais.SelectedItem is Paises paisSeleccionado)
                query = query.Where(p => p.idPais == paisSeleccionado.idPais);

            // Filtro por marca
            if (cmbMarca.SelectedIndex != -1)
                query = query.Where(p => p.Fabricante?.nombreFabricante == cmbMarca.SelectedItem.ToString());

            // Filtro por búsqueda de texto
            string texto = txtBusqueda.Text.Trim();
            if (!string.IsNullOrWhiteSpace(texto))
                query = query.Where(p =>
                    (p.nombreProducto?.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (p.codigoProducto?.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0));

            dgvProductos.DataSource = query.ToList();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar selecciones de los ComboBox
            cmbPais.SelectedIndex = -1;
            //cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;

            // Limpiar radio buttons
            rbTodos.Checked = true;

            // Restaurar tabla original
            AplicarFiltros();
        }
        private void rbHabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHabilitados.Checked) AplicarFiltros();
        }

        private void rbDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeshabilitados.Checked) AplicarFiltros();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked) AplicarFiltros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            agregarEditarProducto formAgregar = new agregarEditarProducto();    
            formAgregar.ShowDialog();
        }
    }
}
