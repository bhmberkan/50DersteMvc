using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _50DersteMvc.Models.Entity;

namespace _50DersteMvc.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri

        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index(string p)
        {
            var arama = from x in db.TblMusteriler select x;
            if (!string.IsNullOrEmpty(p))
            {
                arama = arama.Where(x => x.MUSTERAD.Contains(p)); // contains içermek
            }
            return View(arama.ToList());
         //   var degerler = db.TblMusteriler.ToList();
          //  return View(degerler);
        }


        [HttpGet]

        public ActionResult YeniMüsteri()
        {
            return View();
        }

        [HttpPost]

        public ActionResult YeniMüsteri(TblMusteriler p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMüsteri");
            }

            db.TblMusteriler.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult Sil(int id)
        {
            var müsterisil = db.TblMusteriler.Find(id);
            db.TblMusteriler.Remove(müsterisil);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult MusteriGetir(int id)
        {
            var mus = db.TblMusteriler.Find(id);
            
            return View("MusteriGetir",mus);
        }

        public ActionResult Guncelle(TblMusteriler p)
        {
            var musgnc = db.TblMusteriler.Find(p.MUSTERIID);
            musgnc.MUSTERAD = p.MUSTERAD;
            musgnc.MUSTERISOYAD = p.MUSTERISOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}