using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YOKANJEO.Models
{
    public class TipoDetalles
    {
        public int Tipoid { get; set; }
        [Required (ErrorMessage ="Tipo nombre requerido")]
        [StringLength(100, ErrorMessage ="Minimo 3 y minimo 5 y maximo 100 se permiten caracteres ", MinimumLength =3)]
        public string TipoNombre { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminar { get; set; }


    }

    public class PropiedadDetalles
    {
        public int PropiedadId { get; set; }
        [Required(ErrorMessage ="El nombre de la propiedad es requerido")]
        [StringLength(100,ErrorMessage = "Minimo 3 y minimo 5 y maximo 100 se permiten caracteres ",MinimumLength =3)]
        public string PropiedadNombre { get; set; }
        [Required]
        [Range(1,50)]
        public Nullable<int> Tipoid { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminar { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> ModificaCreacion { get; set; }
        [Required(ErrorMessage ="Descripcion es requerida")]

        public Nullable<System.DateTime> Descripcion { get; set; }
        public string PropiedadImagen { get; set; }
        public Nullable<bool> Destacado { get; set; }
        [Required]
        [Range(typeof(int),"1","500",ErrorMessage ="Cantidad invalida")]
        public Nullable<int> Cantidad { get; set; }
        [Required]
        [Range(typeof(decimal),"1","200000",ErrorMessage ="Precio invalido")]
        public Nullable<decimal> Precio { get; set; }
        public SelectList Propiedades { get; set; }

    }
 




}