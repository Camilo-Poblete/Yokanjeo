using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Yokanjeo.Entities;

namespace Yokanjeo.DAL.Database
{
    public class CBContext: DbContext
    {
        public CBContext(): base("InmoYOKAEntities")
        {
        }




        public DbSet<Propiedades> Propiedades { get; set; }
        public DbSet<Propiedades> Tipos { get; set; }



    }
}