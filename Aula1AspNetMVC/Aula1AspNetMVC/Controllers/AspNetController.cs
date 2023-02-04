using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1AspNetMVC.Controllers
{
    public class AspNetController : Controller
    {
        // GET: AspNet
        public ActionResult Index()
        {
            return View();
        }
    }
}