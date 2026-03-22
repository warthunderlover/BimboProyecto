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
    public partial class AgregarVehiculo : Form
    {
        public string PlacaIngresada { get; private set; }
        public AgregarVehiculo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Ingrese una placa.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlacaIngresada = txtPlaca.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
