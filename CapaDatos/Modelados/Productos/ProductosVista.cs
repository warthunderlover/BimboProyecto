using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CapaDatos.Modelados.Productos
{
    [Table("productos")]
    public class ProductosVista : BaseModel
    {
        [PrimaryKey("id_producto")]
        public int IdProducto { get; set; }

        [Column("codigo_producto")]
        public string CodigoProducto { get; set; }

        [Column("nombre_producto")]
        public string NombreProducto { get; set; }

        [Column("peso_teorico")]
        public decimal PesoTeorico { get; set; }

        [Column("contenido")]
        public string Contenido { get; set; }

        // Columnas de tablas relacionadas
        [Column("presentaciones.nombre_presentacion")]
        public string NombrePresentacion { get; set; }

        [Column("fabricantes.nombre_fabricante")]
        public string NombreFabricante { get; set; }

        [Column("categorias.nombre_categoria")]
        public string NombreCategoria { get; set; }

        [Column("paises.nombre_pais")]
        public string NombrePais { get; set; }
    }
}
