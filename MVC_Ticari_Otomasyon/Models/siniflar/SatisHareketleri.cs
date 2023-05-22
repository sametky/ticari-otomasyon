using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class SatisHareketleri
    {
        [Key]
        public int satisID { get; set; }
        //ürün
        //müşteri
        //personel
        public DateTime tarih { get; set; }
        public int adet { get; set; }
        public decimal fiyat { get; set; }
        public decimal toplamTutar { get; set; }

        public int Urunid { get; set; }
        public int Cariid { get; set; }
        public int Personelid { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual Müsteriler Müsteriler { get; set; }
        public virtual Personel Personel { get; set; }

    }
}