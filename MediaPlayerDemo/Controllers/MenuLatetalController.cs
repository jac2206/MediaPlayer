using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaPlayerDemo.Logic;
using MediaPlayerDemo.Models;

namespace MediaPlayerDemo.Controllers
{
    public class MenuLatetalController : Controller
    {
        // GET: MenuLatetal
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MostrarContenido(string nombreContenido)
        {
           
            var videoSeleccinado = from vid in VideoLogic.ObtenerVideos("theStrokes")
                                   where vid.title.Contains(nombreContenido)
                                   select vid;

            return Json(new { titulo = videoSeleccinado.FirstOrDefault().title, source = videoSeleccinado.FirstOrDefault().source, descripcion = videoSeleccinado.FirstOrDefault().description }, JsonRequestBehavior.AllowGet);

        }
    }
}