using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _50DersteMvc.Models.Entity;

namespace _50DersteMvc.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis

        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(TblSatıslar p)
        {
           

            db.TblSatıslar.Add(p);
            db.SaveChanges();
            
            return View("Index");
        }

        public PartialViewResult liste()
        {
            var satis = db.TblSatıslar.ToList();
            return PartialView(satis);
        }

        public PartialViewResult liste2()
        {
            var satis2 = db.TblSatıslar.ToList();
            return PartialView(satis2);
        }

       
    }
}