using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _50DersteMvc.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace _50DersteMvc.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDbStokEntities db = new MvcDbStokEntities();

        public ActionResult Index(int sayfa=1)
        {
            //var degerler = db.TblKategoriler.ToList();
            var degerler = db.TblKategoriler.ToList().ToPagedList(sayfa, 4); // burada sağa 2 yazarsak 2 tane 4 yazarsak 4 tane veri tabanından değer getiriyor.
                                                                        // yazdığımız ilk değer ise kaçıncı elemandan sornasını listeleyecek onu belirtir   
            return View(degerler);
        
           // sayfalama işlemi için PagedList.Mvc nugetpaket kısmından eklenmelidir.
        }

        [HttpGet]
        public ActionResult YeniKategori()
        {

            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(TblKategoriler p)
        {

            if (!ModelState.IsValid)
            {

                return View("YeniKategori");
                // boş girildiğine ekleme yapmasın 
            }

            db.TblKategoriler.Add(p);
            db.SaveChanges();
            return View();
        }



        public ActionResult Sil(int id)
        {
            var kategori = db.TblKategoriler.Find(id);
            db.TblKategoriler.Remove(kategori); 
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult KategoriGetir(int id )
        {
            var ktgr = db.TblKategoriler.Find(id);

            return View("KategoriGetir",ktgr); // KategoriGetir viewini göndür ktgr'den gelen değerlerle birlikte
        }
         
        public ActionResult Guncelle(TblKategoriler p)
        {
            var ktg = db.TblKategoriler.Find(p.KATEGORIID);
            ktg.KATEGORIAD = p.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}