using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yokanjeo.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int Id { get; set; }
        public string PropiedadNombre { get; set; }
        public Nullable<int> Tipoid { get; set; }
        public Nullable<int> Numero_habitaciones { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminar { get; set; }
        public Nullable<decimal> metro_cuadrado { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> ModificaCreacion { get; set; }
        public string Descripcion { get; set; }
        public string PropiedadImagen { get; set; }
        public Nullable<bool> Destacado { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Comuna { get; set; }




    }
}