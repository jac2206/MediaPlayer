using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MediaPlayerDemo.Models;
using MediaPlayerDemo.Logic;

namespace MediaPlayerDemo.Controllers
{
    public class PlayListController : Controller
    {
        // GET: PlayList
        public ActionResult Index(string videos)
        {
            return View(VideoLogic.ObtenerVideos(videos));
        }

        public ActionResult Videos_Read([DataSourceRequest] DataSourceRequest request, string videos)
        {
            return Json(VideoLogic.ObtenerVideos(videos).ToDataSourceResult(request));
        }

       
    }
}