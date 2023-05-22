using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class Urunler
    {
        [Key]
        public int urunID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string urunAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string urunMarka { get; set; }
        public int stok { get; set; }
        public decimal alisFiyati { get; set; }
        public decimal satisFiyati { get; set; }
        public bool durum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string gorsel { get; set; }

        public int Kategoriid { get; set; }
        public virtual Kategori Kategori { get; set; }
        public ICollection<SatisHareketleri> SatisHareketleris { get; set; }
    }
}