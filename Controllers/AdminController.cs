using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yokanjeo.DAL;

using YOKANJEO.Models;
using Yokanjeo.Repository;




namespace YOKANJEO.Controllers
{
    public class AdminController : Controller
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


        public ActionResult Dashboard()
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


        public ActionResult TipoEdit(int catId)
        {
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Tipo>().GetFirstorDefault(catId));
        }
        [HttpPost]
        public ActionResult TipoEdit(Tbl_Tipo tbl)
        {
            _unitOfWork.GetRepositoryInstance<Tbl_Tipo>().Update(tbl);
            return RedirectToAction("TiposPropiedades");
        }





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






        public ActionResult PropiedadAdd()
        {
            ViewBag.TipoList = GetTipo();
            return View();
        }
        [HttpPost]
        public ActionResult PropiedadAdd(Tbl_Propiedad tbl, HttpPostedFileBase file)
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
            return RedirectToAction("Propiedad");
        }








        public ActionResult PropiedadEdit(int propiedadId)
        {
            ViewBag.TipoList = GetTipo();
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Propiedad>().GetFirstorDefault(propiedadId));
        }

        [HttpPost]
        public ActionResult PropiedadEdit(Tbl_Propiedad tbl, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/PropiedadImg/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }

            tbl.PropiedadImagen = file != null ? pic : tbl.PropiedadImagen;
            tbl.ModificaCreacion = DateTime.Now;

            _unitOfWork.GetRepositoryInstance<Tbl_Propiedad>().Update(tbl);
            return RedirectToAction("Propiedad");
        }


        //public ActionResult PropiedaComuna()
        //{
        //    InmoYOKAEntities db= new InmoYOKAEntities();

        //    var collection = db.Tbl_Propiedad.Where(p => p.Comuna)
        //    return View();
        //}

    }


}