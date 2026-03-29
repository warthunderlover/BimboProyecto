using CapaDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BimboPesaje.Formularios.Productos
{
    public static class cargarPaises
    {
        public static async Task CargarPaises(ComboBox cmb)
        {
            var repo = new RepositorioPais();
            var paises = await repo.ObtenerTodosLosPaises();

            cmb.DataSource = paises;
            cmb.DisplayMember = "nombrePais";
            cmb.ValueMember = "idPais";
        }
    }
}
