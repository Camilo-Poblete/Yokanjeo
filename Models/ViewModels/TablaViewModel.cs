using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yokanjeo.Models.ViewModels
{
    public class TablaViewModel
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "PropiedadNombre")]
        public string PropiedadNombre { get; set; }
        [Required]
        public Nullable<int> Tipoid { get; set; }
        [Required]
        public Nullable<int> Numero_habitaciones { get; set; }
        [Required]
        public Nullable<bool> Activo { get; set; }
        [Required]
        public Nullable<bool> Eliminar { get; set; }
        [Required]
        public Nullable<decimal> metro_cuadrado { get; set; }
        [Required]
        public Nullable<decimal> Precio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Fecha de creacion")]
        public DateTime FechaCreacion { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ModificaCreacion { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public string PropiedadImagen { get; set; }
        [Required]
        public Nullable<bool> Destacado { get; set; }
        [Required]
        public Nullable<int> Cantidad { get; set; }

        [Required]
        [Display(Name = "Comuna")]
        public string Comuna { get; set; }



    }
}