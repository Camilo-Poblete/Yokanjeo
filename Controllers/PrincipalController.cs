using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Yokanjeo.DAL;
using Yokanjeo.Entities;
using Yokanjeo.Models.ViewModels;
using Yokanjeo.Repository;
using Yokanjeo.services;
using YOKANJEO.Models;
using YOKANJEO.Repository;


namespace Yokanjeo.Controllers

{
    public class PrincipalController : Controller
    {

        // GET: Admin
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();

        public List<SelectListItem> GetTipo()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var tipo = _unitOfWork.GetRepositoryInstance<Tbl_Tipo>().GetAllRecords();
            foreach (var item in tipo)
            {
                list.Add(new SelectListItem { Value = item.Tipoid.ToString(), Text = item.TipoNombre });
            }
            return list;
        }


        public ActionResult Index()
        {
            return View();
        }









        public ActionResult TiposPropiedades()
        {
            List<Tbl_Tipo> allcategories = _unitOfWork.GetRepositoryInstance<Tbl_Tipo>().GetAllRecordsIQueryable().Where(i => i.Eliminar == false).ToList();
            return View(allcategories);
        }


        public ActionResult AddTipo()
        {
            return UpdateCategory(0);
        }

        public ActionResult UpdateCategory(int categoryId)
        {
            TipoDetalles cd;
            if (categoryId != null)
            {
                cd = JsonConvert.DeserializeObject<TipoDetalles>(JsonConvert.SerializeObject(_unitOfWork.GetRepositoryInstance<Tbl_Tipo>().GetFirstorDefault(categoryId)));
            }
            else
            {
                cd = new TipoDetalles();
            }
            return View("UpdateCategory", cd);

        }


        //public ActionResult Edit(int propiedadId)
        //{
        //    return View(_unitOfWork.GetRepositoryInstance<Tbl_Propiedad>().GetFirstorDefault(propiedadId));
        //}
        //[HttpPost]
        //public ActionResult Edit(Tbl_Propiedad tbl)
        //{
        //    _unitOfWork.GetRepositoryInstance<Tbl_Tipo>().Update(tbl);
        //    return RedirectToAction("../Principal/Create");
        //}





        public ActionResult AgregarTipo()
        {
            return ActualizaTipo(0);
        }


        public ActionResult ActualizaTipo(int Id)
        {
            TipoDetalles cd;
            if (Id != null)
            {
                cd = JsonConvert.DeserializeObject<TipoDetalles>(JsonConvert.SerializeObject(_unitOfWork.GetRepositoryInstance<Tbl_Tipo>().GetFirstorDefault(Id)));
            }
            else
            {
                cd = new TipoDetalles();
            }
            return View("ActualizaTipo", cd);

        }








        public ActionResult Propiedad()
        {
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Propiedad>().GetPropiedad());






        }






        public ActionResult Create()
        {
            ViewBag.TipoList = GetTipo();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Tbl_Propiedad tbl, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/PropiedadImg/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            tbl.PropiedadImagen = pic;
            tbl.FechaCreacion = DateTime.Now;
            _unitOfWork.GetRepositoryInstance<Tbl_Propiedad>().Add(tbl);
            return RedirectToAction("Index");
        }


        //public ActionResult PropiedadEdit(int PropiedadId)
        //{
        //    ViewBag.TipoList = GetTipo();
        //    return View(_unitOfWork.GetRepositoryInstance<Tbl_Propiedad>().GetFirstorDefault(PropiedadId));
        //}

        //[HttpPost]
        //public ActionResult PropiedadEdit(Tbl_Propiedad tbl, HttpPostedFileBase file)
        //{
        //    string pic = null;
        //    if (file != null)
        //    {
        //        pic = System.IO.Path.GetFileName(file.FileName);
        //        string path = System.IO.Path.Combine(Server.MapPath("~/PropiedadImg/"), pic);
        //        // file is uploaded
        //        file.SaveAs(path);
        //    }

        //    tbl.PropiedadImagen = file != null ? pic : tbl.PropiedadImagen;
        //    tbl.ModificaCreacion = DateTime.Now;

        //    _unitOfWork.GetRepositoryInstance<Tbl_Propiedad>().Update(tbl);
        //    return RedirectToAction("Index");
        //}




        //public ActionResult PropiedaComuna()
        //{
        //    InmoYOKAEntities db= new InmoYOKAEntities();

        //    var collection = db.Tbl_Propiedad.Where(p => p.Comuna)
        //    return View();
        //}














        //InmoYOKAEntities dbo = new InmoYOKAEntities();

        //        public ActionResult Index()
        //        {
        //            List<ListTablaViewModel> lst;
        //            using (InmoYOKAEntities db = new InmoYOKAEntities())
        //            {
        //                lst = (from d in db.Tbl_Propiedad
        //                       select new ListTablaViewModel
        //                       {
        //                           Id = d.PropiedadId,
        //                           PropiedadNombre = d.PropiedadNombre,
        //                           Tipoid = d.Tipoid,
        //                           Numero_habitaciones = d.Numero_habitaciones,
        //                           Activo = d.Activo,
        //                           Eliminar = d.Eliminar,
        //                           metro_cuadrado = d.metro_cuadrado,
        //                           Precio = d.Precio,
        //                           FechaCreacion = d.FechaCreacion,
        //                           Descripcion = d.Descripcion,
        //                           PropiedadImagen = d.PropiedadImagen,
        //                           Destacado = d.Destacado,
        //                           Cantidad = d.Cantidad,
        //                           Comuna = d.Comuna

        //                       }).ToList();



        //            }
        //            return View(lst);
        //        }






        public ActionResult Nuevo()
        {
            return View();
        }

    }

}





//        public ActionResult Edit(int PropiedadId)
//        {
//            using (var context = new InmoYOKAEntities())
//            {
//                var data = context.Tbl_Propiedad.Where(x => x.PropiedadId == PropiedadId).SingleOrDefault();
//                return View(data);
//            }

//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int PropiedadId, Tbl_Propiedad model)
//        {
//            using (var context = new InmoYOKAEntities())
//            {
//                var data = context.Tbl_Propiedad.FirstOrDefault(x => x.PropiedadId == PropiedadId);
//                if (data != null)
//                {
//                    data.PropiedadId = PropiedadId;
//                    data.PropiedadNombre = model.PropiedadNombre;
//                    data.Tipoid = model.Tipoid;
//                    data.Numero_habitaciones = model.Numero_habitaciones;
//                    data.Activo = model.Activo;
//                    data.Eliminar = model.Eliminar;
//                    data.metro_cuadrado = model.metro_cuadrado;
//                    data.Precio = model.Precio;
//                    data.FechaCreacion = model.FechaCreacion;
//                    data.ModificaCreacion = model.ModificaCreacion;
//                    data.Descripcion = model.Descripcion;
//                    data.PropiedadImagen = model.Descripcion;
//                    data.Descripcion = model.Descripcion;
//                    data.Descripcion = model.Descripcion;
//                    data.Descripcion = model.Descripcion;

//                    context.SaveChanges();
//                    return RedirectToAction("Create");

//                }
//                else
//                {
//                    return View();
//                }
//            }
//        }

//    }

//}