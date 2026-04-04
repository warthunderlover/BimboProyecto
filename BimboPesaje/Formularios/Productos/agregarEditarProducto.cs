using CapaDatos.Modelados;
using CapaDatos.Modelados.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimboPesaje.Formularios.Productos
{
    public partial class agregarEditarProducto : Form
    {
        private List<Paises> _listaPaises= new List<Paises>();
        private int idFabricanteSeleccionado;
        private int idCategoriaSeleccionada;
        private int idPresentacionSeleccionada;

        public agregarEditarProducto()
        {
            InitializeComponent();
        }
        
        private async void agregarEditarProducto_Load(object sender, EventArgs e)
        {
            await cargarPaises.CargarPaises(cmbPaisImportado);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                var parametros = new Productos
                {
                    codigoProducto = txtCodigoInterno.Text,
                    nombreProducto = txtNombreProducto.Text,

                    idFabricante = idFabricanteSeleccionado,
                    idCategoria = idCategoriaSeleccionada,
                    idPresentacion = idPresentacionSeleccionada,

                    contenidoProducto = txtContenido.Text,

                    idPais = (cmbPaisImportado.SelectedItem as Paises)?.idPais ?? 0,

                    idEstado = rbActivo.Checked ? 1 : 0
                };

                MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
