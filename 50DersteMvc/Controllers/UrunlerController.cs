using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _50DersteMvc.Models.Entity;

namespace _50DersteMvc.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var urun = db.TblUrunler.ToList();
            return View(urun);
        }


        [HttpGet]

        public ActionResult YeniUrunEkle()
        {
            List<SelectListItem> degerler = (from x in db.TblKategoriler
                                             select new SelectListItem
                                             {
                                                 Text = x.KATEGORIAD,
                                                 Value = x.KATEGORIID.ToString()
                                             }).ToList(); // dropdawnliste verileri çekmek için bunu kullandık

            ViewBag.DropDownDegerler = degerler;
            //  @Html.DropDownListFor(x=>x.TblKategoriler.KATEGORIID,(List<SelectListItem>)ViewBag.DropDownDegerler, new {@class="form-control" })
            // cshtml kısmında bu ifade için bu şekilde bir kullanım oluşturduk.

            return View();
        }

        [HttpPost]

        public ActionResult YeniUrunEkle(TblUrunler p)
        {

            var ktg = db.TblKategoriler.Where(x => x.KATEGORIID == p.TblKategoriler.KATEGORIID).FirstOrDefault();
            p.TblKategoriler = ktg;
            db.TblUrunler.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Sil(int id)
        {
            var ürünsil = db.TblUrunler.Find(id);
            db.TblUrunler.Remove(ürünsil);
            db.SaveChanges();


            return RedirectToAction("Index");
        }


        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> degerler = (from x in db.TblKategoriler
                                             select new SelectListItem
                                             {
                                                 Text = x.KATEGORIAD,
                                                 Value = x.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.DropDownDegerler = degerler;

            var Urun = db.TblUrunler.Find(id);


            return View("UrunGetir",Urun);
        }


        public ActionResult Guncelle(TblUrunler p)
        {
            var ktgr = db.TblKategoriler.Where(x => x.KATEGORIID == p.TblKategoriler.KATEGORIID).FirstOrDefault();
            // burda kategoriyi null olarak almasın diye böyle bir şey yaptık yani sayfadan gelen p üzerinden değeri kategorilerdeki ıd değerine
            // eşitledik bu değeri de ktgr ye aktardık onu da en osnra urungnc ye aktarmış olduk
          
            var urungnc = db.TblUrunler.Find(p.URUNID);
            urungnc.URUNAD = p.URUNAD;
            urungnc.MARKA = p.MARKA;
            urungnc.STOK = p.STOK;
            urungnc.FIYAT = p.FIYAT;
            urungnc.URUNKATEGORI = ktgr.KATEGORIID;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        
    }
}