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
    public class Productos : BaseModel
    {
        [PrimaryKey("id_producto")]
        public int idProducto { get; set; }
        [Column("codigo_producto")]
        public string codigoProducto { get; set; }
        [Column("nombre_producto")]
        public string nombreProducto { get; set; }
        [Column("id_presentacion")]
        public int idPresentacion { get; set; }

        [Column("id_fabricante")]
        public int idFabricante { get; set; }

        //[Column("id_unidad")]
        //public int idUnidad { get; set; }

        [Column("id_estado")]
        public int idEstado { get; set; }

        //[Column("peso_teorico")]
        //public decimal pesoTeorico { get; set; }

        //[Column("id_tara")]
        //public int idTara { get; set; }

        [Column("id_categoria")]
        public int idCategoria { get; set; }

        [Column("contenido")]
        public string contenidoProducto { get; set; }

        [Column("id_pais")]
        public int idPais { get; set; }

        /// <summary>
        /// Esto va a permitir que no tenga que estar duplicando modelados
        /// usando las navegaciones para las relaciones
        /// </summary>
        public Presentacion Presentacion { get; set; }
        public Fabricante Fabricante { get; set; }
        public Categoria Categoria { get; set; }
        public Paises Pais { get; set; }

        public string nombre_Presentacion => Presentacion?.nombrePresentacion ?? "Sin presentación";
        public string nombre_Fabricante => Fabricante?.nombreFabricante ?? "Sin fabricante";
        public string nombre_Categoria => Categoria?.nombreCategoria ?? "Sin categoría";
        public string nombre_Pais => Pais?.nombrePais ?? "Sin país";

    }
}
