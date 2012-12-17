using System;
using System.IO;
using System.Web.Mvc;
using PublishWeb.Models;

namespace PublishWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ToolIndexLoader loader = new ToolIndexLoader();
            loader.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tools\\MaRinToolsIndex.xml"));
            return View(loader.GetToolList());
        }
    }
}
