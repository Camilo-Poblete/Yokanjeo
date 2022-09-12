using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YOKANJEO.Models
{
    public class CompraDetalles
    {
        public int CompraDetalleId { get; set; }
        [Required]
        public Nullable<int> MiembroId { get; set; }
        [Required]

        public string Direccion { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string CodigoPostal { get; set; }

        public string Pais { get; set; }
        [Required]

        public Nullable<int> CompraId { get; set; }
        public Nullable<decimal> Pagado { get; set; }
        public string TipoPago { get; set; }



    }
}