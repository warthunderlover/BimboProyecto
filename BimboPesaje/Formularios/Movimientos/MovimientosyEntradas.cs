using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimboPesaje.Formularios.Movimientos
{
    public partial class MovimientosyEntradas : Form
    {
        private DataTable _tablaCamiones;
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
                dgvCamiones.Refresh();
                ActualizarVisibilidadEntradas();
            }

        }

        private void ActualizarVisibilidadEntradas()
        {
            dgvMateriaPrima.Visible = dgvCamiones.Rows.Count > 0;
        }
    }
}
