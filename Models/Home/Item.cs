using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yokanjeo.DAL;


namespace Yokanjeo.Models.Home
{
    public class Item
    {
      
        public Tbl_Propiedad Propiedad { get; set; }
        public int Cantidad { get; set; }


    }
}