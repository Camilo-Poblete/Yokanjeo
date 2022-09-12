using PagedList;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yokanjeo.DAL;

using PagedList.Mvc;

using Yokanjeo.Repository;

namespace Yokanjeo.Models.Home
{
    public class HomeIndexViewModel
    {

        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        InmoYOKAEntities context = new InmoYOKAEntities();

        public IPagedList<Tbl_Propiedad> PropiedadList { get; set; }

        public HomeIndexViewModel CreateModel(string search, int pageSize, int? page)
        {
            SqlParameter[] param = new SqlParameter[] {

                new SqlParameter("@search",search??(object)DBNull.Value)

            };

            IPagedList<Tbl_Propiedad> data = context.Database.SqlQuery<Tbl_Propiedad>("GetSearch @search", param).ToList().ToPagedList(page ?? 1, pageSize);
            return new HomeIndexViewModel
            {

                PropiedadList = data



            };
        }
    }


}