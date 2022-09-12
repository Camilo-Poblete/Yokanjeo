using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Yokanjeo.Repository;
//using YOKANJEO.Models.Home;
using Newtonsoft.Json;
using Yokanjeo.DAL;
using Yokanjeo.Models.Home;

namespace Yokanjeo.Controllers
{



    public class HomeController : Controller
    {


        InmoYOKAEntities ctx = new InmoYOKAEntities();
        public ActionResult Index(string search, int? page)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel(search, 12, page));
        }



        public ActionResult Checkout()
        {
            return View();
        }



        public ActionResult CheckoutDetails()
        {
            return View();
        }
               public ActionResult DecreaseQty(int propiedadId)
                {
            if (Session["venta"] != null)
            {
                List<Item> venta = (List<Item>)Session["venta"];
                var propiedad = ctx.Tbl_Propiedad.Find(propiedadId);
                foreach (var item in venta)
                {
                    if (item.Propiedad.PropiedadId == propiedadId)
                          {
                               int prevQty = item.Cantidad;
                               if (prevQty > 0)
                              {
                                    venta.Remove(item);
                                   venta.Add(new Item()
                                   {
                                        Propiedad = propiedad,
                                        Cantidad = prevQty - 1
                                    });
                                }
                                break;
                            }
                    }
                      Session["venta"] = venta;
                  }
                  return Redirect("Checkout");
              }

        public ActionResult AddVenta(int propiedadId, string url)
        {
            if (Session["venta"] == null)
            {
                List<Item> venta = new List<Item>();
                var propiedad = ctx.Tbl_Propiedad.Find(propiedadId);
                venta.Add(new Item()
                {
                    Propiedad = propiedad,
                    Cantidad = 1
                });
                Session["venta"] = venta;
            }
            else
            {
                List<Item> venta = (List<Item>)Session["venta"];
                var count = venta.Count();
                var propiedad = ctx.Tbl_Propiedad.Find(propiedadId);
                for (int i = 0; i < count; i++)
                {
                    if (venta[i].Propiedad.PropiedadId == propiedadId)
                    {
                        int prevQty = venta[i].Cantidad;
                        venta.Remove(venta[i]);
                        venta.Add(new Item()
                        {
                            Propiedad = propiedad,
                            Cantidad = prevQty + 1
                        });
                        break;
                    }
                    else
                    {
                        var prd = venta.Where(x => x.Propiedad.PropiedadId == propiedadId).SingleOrDefault();
                        if (prd == null)
                        {
                            venta.Add(new Item()
                            {
                                Propiedad = propiedad,
                                Cantidad = 1
                            });
                        }
                    }
                }
                Session["venta"] = venta;
            }
            return Redirect("Index");
        }

        public ActionResult RemoveFromSale(int propiedadId)
        {
            List<Item> venta = (List<Item>)Session["venta"];
            foreach (var item in venta)
            {
                if (item.Propiedad.PropiedadId == propiedadId)
                {
                    venta.Remove(item);
                    break;
                }
            }
            Session["venta"] = venta;
            return Redirect("Index");
        }
    }
}


