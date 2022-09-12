using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yokanjeo.Entities;

namespace Yokanjeo.DAL.Entities
{
    public class Tipo: BaseEntity
    {

        public int Tipoid { get; set; }
        public string TipoNombre { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminar { get; set; }


        public List<Propiedades> Propiedad { get; set; }

    }
}