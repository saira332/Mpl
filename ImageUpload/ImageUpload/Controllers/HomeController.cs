using ImageUpload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageUpload.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        SchoolEntities _db;
        public HomeController()
        {
            _db = new SchoolEntities();
        }
        public ActionResult Index()
        {
            List<upload> result = (from k in _db.uploads select k).ToList();
            return View(result);
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            string realpath = Server.MapPath("/images") + "//" + file.FileName;
            file.SaveAs(realpath);

            upload u = new upload();
            u.path = file.FileName;
            _db.uploads.Add(u);
            _db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}