using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yokanjeo.Models
{
    public class PropiedadesModel
    {
       public int Id { get; set; }
       public string Nombre { get; set; }

       public string Comuna { get; set; }

        public string Correo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }


        public string Usuarios { get; set; }


        public  string Clave { get; set; }

    }
}