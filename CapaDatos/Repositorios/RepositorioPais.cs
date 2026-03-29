using CapaDatos.Modelados;
using ServicioConexión.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioPais
    {
        public async Task<List<Paises>> ObtenerTodosLosPaises()
        {
            var client = await ConexionSupabase.GetClientAsync();

            var resultado = await client
                .From<Paises>()
                .Get();

            return resultado.Models;
        }
    }
}
