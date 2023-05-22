using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Ticari_Otomasyon.Models.siniflar;

namespace MVC_Ticari_Otomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler=c.Departmans.Where(x=>x.Durum==true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanSil(int id)
        {
            var dep = c.Departmans.Find(id);
            dep.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DepartmanGetir(int id)
        {
            var dpt = c.Departmans.Find(id);
            return View("DepartmanGetir",dpt);
        }
        public ActionResult DepartmanGuncelle(Departman d)
        {
            var dept = c.Departmans.Find(d.departmanID);
            dept.departmanAd = d.departmanAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanDetay(int id)
        {
            var degerler=c.personels.Where(x=>x.Departmanid==id).ToList();
            var dpt=c.Departmans.Where(x=>x.departmanID==id).Select(y=>y.departmanAd).FirstOrDefault();
            ViewBag.d = dpt;
            return View(degerler);
        }
        public ActionResult DepartmanSatisPersonel(int id)
        {
            var degerler = c.SatisHareketleris.Where(x => x.Personelid == id).ToList();
            var per = c.personels.Where(x => x.personelID == id).Select(y => y.personelAd +" " + y.personelSoyad).FirstOrDefault();
            ViewBag.dpers=per;
            return View(degerler);
        }
    }
}