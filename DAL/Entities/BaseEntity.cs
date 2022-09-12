using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yokanjeo.DAL.Entities
{
    public class BaseEntity
    {

        public int Tipoid { get; set; }
        public string TipoNombre { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminar { get; set; }




    }
}