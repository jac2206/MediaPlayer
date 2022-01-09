using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPlayerDemo.Controllers
{
    public class SelectedPlayListController : Controller
    {
        // GET: SelectedPlayList
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SeleccionarListaReproduccion()
        {
            return RedirectToAction("Index", "PlayList");

        }

    }
}