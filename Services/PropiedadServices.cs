using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yokanjeo.DAL;
using Yokanjeo.Entities;

namespace Yokanjeo.services
{
    public class PropiedadServices
    {

        //public void SavePropiedad(Propiedades propiedad)
        //{
        //    InmoYOKAEntities context = new InmoYOKAEntities();
        //context..Add(propiedad);
        //    context.SaveChanges();
        //}


    


        public Tbl_Propiedad GetPropiedadID(int? PropiedadId)
        {
            InmoYOKAEntities context = new InmoYOKAEntities();
            return context.Tbl_Propiedad.Find(PropiedadId);
        }


        //public void UpdatePropiedad(Propiedad propiedad)
        //{
        //    InmoYOKAEntities context = new InmoYOKAEntities();
        //    context.Entry(propiedad).State = System.Data.Entity.EntityState.Modified;
        //    context.SaveChanges();
        //}

        public List<Tbl_Propiedad> GetAllPropiedad()
        {
            InmoYOKAEntities context = new InmoYOKAEntities();
            return context.Tbl_Propiedad.ToList();
        }
        public void DeletePropiedad(Tbl_Propiedad propiedad)
        {
            InmoYOKAEntities context = new InmoYOKAEntities();
            context.Entry(propiedad).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
