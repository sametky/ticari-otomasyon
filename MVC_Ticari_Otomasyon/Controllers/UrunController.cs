using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MVC_Ticari_Otomasyon.Models.siniflar;

namespace MVC_Ticari_Otomasyon.Controllers
{
    public class UrunController : Controller
    {
        Context c=new Context();
        // GET: Urun

        public ActionResult Index()
        {
            var urunler=c.Urunlers.Where(x=>x.durum==true).ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList() select new SelectListItem {
                Text = x.kategoriAd,
                Value = x.kategoriID.ToString()
            }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urunler p)
        {
            c.Urunlers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult UrunSil(int id)
        {
            var deger = c.Urunlers.Find(id);
            deger.durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.kategoriAd,
                                               Value = x.kategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            var urundeger=c.Urunlers.Find(id);
            return View("UrunGetir", urundeger);
        }
        public ActionResult UrunGuncelle(Urunler p)
        {
            var urn = c.Urunlers.Find(p.urunID);
            urn.alisFiyati = p.alisFiyati;
            urn.durum = p.durum;
            urn.Kategoriid = p.Kategoriid;
            urn.urunMarka = p.urunMarka;
            urn.satisFiyati = p.satisFiyati;
            urn.stok = p.stok;
            urn.urunAd = p.urunAd;
            urn.gorsel = p.gorsel;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}