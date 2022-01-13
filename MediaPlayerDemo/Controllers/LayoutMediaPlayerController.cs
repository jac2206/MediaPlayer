using MediaPlayerDemo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPlayerDemo.Controllers
{
    public class LayoutMediaPlayerController : Controller
    {


        // GET: LayoutMediaPlayer
        public ActionResult Index(string videos)
        {
            Session["videosLista"] = videos;
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MostrarContenido(string nombreContenido)
        {
            var videos = Session["videosLista"].ToString();
            var videoSeleccinado = from vid in VideoLogic.ObtenerVideos(videos)
                                   where vid.title.Contains(nombreContenido)
                                   select vid;

            return Json(new { titulo = videoSeleccinado.FirstOrDefault().title, source = videoSeleccinado.FirstOrDefault().source, descripcion = videoSeleccinado.FirstOrDefault().description }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult ObtenerNombreVideosLista()
        {
            var videos = Session["videosLista"].ToString();

            var listaVideos = VideoLogic.ObtenerVideos(videos);

            return Json(listaVideos, JsonRequestBehavior.AllowGet);
        }

    }
}