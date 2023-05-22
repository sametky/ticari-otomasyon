using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MVC_Ticari_Otomasyon.Models.siniflar;

namespace MVC_Ticari_Otomasyon.Controllers
{
    public class KategoriController : Controller
    {
        MVC_Ticari_Otomasyon.Models.siniflar.Context c = new MVC_Ticari_Otomasyon.Models.siniflar.Context();

        // GET: Kategori
        public ActionResult Index()
        {
            var kategoriler =c.Kategoris.ToList();

            return View(kategoriler);
        }
        [HttpGet]
        public ActionResult KategoriEkle() {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori kategori)
        {
            c.Kategoris.Add(kategori);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);
            return View("KategoriGetir",kategori);
        }
        public ActionResult KategoriSil(int id)
        {
            var ktg= c.Kategoris.Find(id);
            c.Kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //eklemede olduğu gibi kategori tablomdan parametre gönderiyorum
        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = c.Kategoris.Find(k.kategoriID);
            ktgr.kategoriAd = k.kategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}