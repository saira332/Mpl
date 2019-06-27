using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IDictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Home", "");
            dic.Add("Products", "");
            dic.Add("", "Product 1");
            dic.Add(" ", "Product 2");
            dic.Add("About", "");
            dic.Add("Contact", "");
            return View(dic);
        }
    }
}