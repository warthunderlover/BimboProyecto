using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Modelados.Usuarios;
using CapaDatos.Repositorios;
using ServicioConexión.Conexion;

namespace BimboPesaje.Formularios.Usuarios
{
    public partial class agregarEditarEmpleado : Form
    {
        public agregarEditarEmpleado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ///<summary>
                ///Este de aquí solo se usa cuando se va a usar el repositorio para ingresar un empleado / algo 
                ///nuevo a la base de datos.
                /// </summary>
                Empleados nuevoEmpleado = new Empleados
                {
                    numeroIdentidad = txtDNI.Text.Trim(),
                    nombreEmpleado = txtNombre.Text.Trim(),
                    apellidoEmpleado = txtApellido.Text.Trim(),
                    telefonoEmpleado = txtTelefono.Text.Trim(),
                    correoEmpleado = txtCorreo.Text.Trim(),
                    idEstado = rbActivo.Checked ? 1 : 2
                };

                //await RepositorioEmpleado.ingresarEmpleado(nuevoEmpleado);

                // y se llama a la conexion para obtener el cliente de supabase, y se le asigna a una variable llamada insert, que es la que se va a usar para llamar a la función de la base de datos.
                var insert = await ConexionSupabase.GetClientAsync();
                
                ///<summary>
                ///Y esto se hace por que cada nombre de aqui es el mismo que el de la función en la base de datos, y se le asigna el valor del textbox correspondiente.
                /// </summary>
                await insert.Rpc("ingresar_empleado_tabla_bitacora", new
                {
                    p_dni = txtDNI.Text.Trim(),
                    p_nombre_empleado = txtNombre.Text.Trim(),
                    p_apellido_empleado = txtApellido.Text.Trim(),
                    p_numero_telefonico = txtTelefono.Text.Trim(),
                    p_correo_empleado = txtCorreo.Text.Trim(),
                    p_estado_empleado = rbActivo.Checked ? 1 : 2
                });
                MessageBox.Show("Empleado guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al guardar el empleado {ex.Message}","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
