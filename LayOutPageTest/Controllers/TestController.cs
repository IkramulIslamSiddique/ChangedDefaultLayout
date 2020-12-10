using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayOutPageTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dummy()
        {
            return View();
        }

        public ActionResult BootStrapModal()
        {
            return View();
        }
    }
}