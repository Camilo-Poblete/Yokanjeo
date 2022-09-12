using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Yokanjeo.DAL.Entities;

namespace Yokanjeo.Entities
{
    public class Propiedades:BaseEntity
    {
        public Tipo Tipopropiedad { get; set; }

        public int PropiedadId{ get; set; }
        public string PropiedadNombre { get; set; }
        public int Tipoid { get; set; }
        public int Numero_habitaciones { get; set; }
        public bool Activo { get; set; }
        public bool Eliminar { get; set; }
        public decimal Metro_cuadrado { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime ModificaCreacion { get; set; }
        public string Descripcion { get; set; }
        public string PropiedadImagen { get; set; }
        public bool Destacado { get; set; }
        public int Cantidad { get; set; }
        public string Comuna { get; set; }

    }






}