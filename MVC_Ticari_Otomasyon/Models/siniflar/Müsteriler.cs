using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class Müsteriler
    {
        [Key]
        public int cariID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string müsteriAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string müsteriSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string müsteriSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string müsteriMail { get; set; }

        public ICollection<SatisHareketleri> SatisHareketleris { get; set; }
    }
}