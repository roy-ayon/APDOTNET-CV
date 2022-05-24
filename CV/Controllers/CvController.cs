using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class CvController : Controller
    {
        // GET: Cv
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersonalBackground()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Reference()
        {
            return View();
        }
    }
}