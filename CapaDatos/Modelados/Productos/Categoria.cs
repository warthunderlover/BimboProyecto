using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CapaDatos.Modelados.Productos
{
    [Table("categoria")]
    public class Categoria
    {
        [PrimaryKey("id_categoria")]
        public int idCategoria { get; set; }
        [Column("nombre_categoria")]
        public string nombreCategoria { get; set; }
    }
}
