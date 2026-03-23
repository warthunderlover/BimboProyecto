using BimboPesaje.Formularios.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimboPesaje.Formularios.Movimientos
{
    public partial class MovimientosyEntradas : Form
    {
        private DataTable _tablaCamiones;
        private DataTable _tablaMateriaPrima;
        private DataTable _tablaEntradas;

        private Dictionary<int, DataTable> _productosPorCamion = new Dictionary<int, DataTable>();
        private int _contadorCamion = 0;
        private const int MAX_CAMIONES = 3;
        public MovimientosyEntradas()
        {
            InitializeComponent();

        }

        private void MovimientosyEntradas_Load(object sender, EventArgs e)
        {
            _tablaCamiones = new DataTable();
            _tablaCamiones.Columns.Add("IdEntrada");
            _tablaCamiones.Columns.Add("PlacaCamion");


            dgvCamiones.AutoGenerateColumns = false;
            dgvCamiones.DataSource = _tablaCamiones;
            dgvMateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriaPrima.MultiSelect = false;
            dgvMateriaPrima.ReadOnly = true; // opcional pero recomendado
            dgvMateriaPrima.AllowUserToAddRows = false;
            _tablaEntradas = new DataTable();
            _tablaEntradas = new DataTable();
            _tablaEntradas.Columns.Add("Codigo");
            _tablaEntradas.Columns.Add("Producto");
            _tablaEntradas.Columns.Add("Proveedor");
            _tablaEntradas.Columns.Add("PesoNeto", typeof(double));

            dgvEntradas.DataSource = _tablaEntradas;
            dgvMateriaPrima.Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (_contadorCamion >= MAX_CAMIONES)
            {
                MessageBox.Show("Ya se alcanzó el máximo de 3 camiones.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AgregarVehiculo form = new AgregarVehiculo();
            //ShowDialog(form);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _contadorCamion++;

                _tablaCamiones.Rows.Add(_contadorCamion.ToString(), form.PlacaIngresada);


                _productosPorCamion[_contadorCamion] = CrearTablaMateriaPrima();


                dgvMateriaPrima.DataSource = _productosPorCamion[_contadorCamion];

                dgvCamiones.Refresh();
                ActualizarVisibilidadEntradas();
            }

        }
        private void dgvCamiones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCamiones.CurrentRow == null) return;

            int idCamion = Convert.ToInt32(dgvCamiones.CurrentRow.Cells["IdEntrada"].Value);

            // 🔥 Cambiar productos según el camión seleccionado
            if (_productosPorCamion.ContainsKey(idCamion))
            {
                dgvMateriaPrima.DataSource = _productosPorCamion[idCamion];
            }
        }

        private void ActualizarVisibilidadEntradas()
        {
            dgvMateriaPrima.Visible = dgvCamiones.Rows.Count > 0;
        }
        private DataTable CrearTablaMateriaPrima()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CodigoInternoProducto");
            dt.Columns.Add("NombreProducto");
            dt.Columns.Add("Proveedor_Producto");
            dt.Columns.Add("EstadoProceso").DefaultValue = "En proceso";
            return dt;
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            if (_contadorCamion == 0)
            {
                MessageBox.Show("Primero agregue un camión.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GestionProductos form = new GestionProductos();

            if (form.ShowDialog(this) == DialogResult.OK) // ← Solo UNA vez
            {
                // Usar el DataTable del camión actual en lugar de _tablaMateriaPrima
                _productosPorCamion[_contadorCamion].Rows.Add(
                    form.CodigoSeleccionado,
                    form.ProductoSeleccionado,
                    form.ProveedorSeleccionado
                //form.EstadoSeleccionado
                );
            }
        }

        private void btnGuardarEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarMovimiento_Click(object sender, EventArgs e)
        {
            if (dgvCamiones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un camión.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCamion = Convert.ToInt32(dgvCamiones.CurrentRow.Cells["IdEntrada"].Value);

            if (!_productosPorCamion.ContainsKey(idCamion) ||
                 _productosPorCamion[idCamion].Rows.Count == 0)
            {
                MessageBox.Show("El camión no tiene productos registrados.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cambiar EstadoProceso a "Completado"
            foreach (DataRow fila in _productosPorCamion[idCamion].Rows)
            {
                fila["EstadoProceso"] = "Completado";
            }

            // Refrescar el DGV
            dgvMateriaPrima.DataSource = null;
            dgvMateriaPrima.DataSource = _productosPorCamion[idCamion];

            MessageBox.Show("Movimiento guardado, estado actualizado a Completado.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPesar_Click(object sender, EventArgs e)
        {
            if (dgvMateriaPrima.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = dgvMateriaPrima.CurrentRow.Cells[0].Value?.ToString();
            string producto = dgvMateriaPrima.CurrentRow.Cells[1].Value?.ToString();
            string proveedor = dgvMateriaPrima.CurrentRow.Cells[2].Value?.ToString();
            string placa = dgvCamiones.CurrentRow?.Cells["PlacaCamion"].Value?.ToString();

            RegistrarPesos form = new RegistrarPesos(placa, producto, proveedor);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // 🔥 AGREGA O ACUMULA PESO
                AgregarOActualizarEntrada(
                    codigo,
                    producto,
                    proveedor,
                    form.PesoIngresado
                );

                // 🔁 Si el usuario quiere seguir pesando
                if (form.SeguirPesando)
                {
                    btnPesar_Click(sender, e);
                }
            }
        }
        private void btnEditarEntrada_Click(object sender, EventArgs e)
        {
            if (dgvEntradas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una entrada", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = dgvEntradas.CurrentRow.Cells[0].Value.ToString();
            string producto = dgvEntradas.CurrentRow.Cells[1].Value.ToString();
            string proveedor = dgvEntradas.CurrentRow.Cells[2].Value.ToString();
            double pesoNeto = Convert.ToDouble(dgvEntradas.CurrentRow.Cells[3].Value);
            double pesoBruto = Convert.ToDouble(dgvEntradas.CurrentRow.Cells[4].Value);

            RegistrarPesos form = new RegistrarPesos(
                codigo,
                producto,
                proveedor,
                pesoNeto,
                pesoBruto
            );

            form.ShowDialog(this);
        }
        private void AgregarOActualizarEntrada(string codigo, string producto, string proveedor, double peso)
        {
            var filaExistente = _tablaEntradas.AsEnumerable()
                .FirstOrDefault(row => row["Codigo"].ToString() == codigo);

            if (filaExistente != null)
            {
                double pesoActual = Convert.ToDouble(filaExistente["PesoNeto"]);
                filaExistente["PesoNeto"] = pesoActual + peso;
            }
            else
            {
                _tablaEntradas.Rows.Add(codigo, producto, proveedor, peso);
            }

            dgvEntradas.Refresh();
        }

    }
}
