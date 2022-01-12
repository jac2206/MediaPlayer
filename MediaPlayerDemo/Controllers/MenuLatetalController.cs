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

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult MostrarContenido(string nombreContenido)
        //{
        //    //Video videosMostrar = VideoLogic.ObtenerVideos("theStrokes").Where(video => video.title = nombreContenido);

        //    //List<Video> videos  = (List<Video>)VideoLogic.ObtenerVideos("theStrokes");

        //    //var videoSeleccinado = from vid in videos
        //    //                       where vid.source = "sas"
        //    //                       select vid.

        //    //List<Video> videos = (List<Video>)VideoLogic.ObtenerVideos("theStrokes");

        //    var videoSeleccinado = from vid in VideoLogic.ObtenerVideos("theStrokes")
        //                           where vid.title.Contains(nombreContenido)
        //                           select vid;

        //    //IEnumerable<Video> videoSeleccinado = from vid in VideoLogic.ObtenerVideos("theStrokes")
        //    //                                      where vid.title.Contains(nombreContenido)
        //    //                                      select vid;            


        //    //return Json(new {titulo = "Video", source = "https://www.youtube.com/watch?v=2OGc66e2E9s"}, JsonRequestBehavior.AllowGet);
        //    return Json(new { titulo = videoSeleccinado.FirstOrDefault().title, source = videoSeleccinado.FirstOrDefault().source }, JsonRequestBehavior.AllowGet);

        //}

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