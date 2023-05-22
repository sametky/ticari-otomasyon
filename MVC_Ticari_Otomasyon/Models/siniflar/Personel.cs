using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class Personel
    {
        [Key]
        public int personelID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string personelAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string personelSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string personelGorsel { get; set; }

        public ICollection<SatisHareketleri> SatisHareketleris { get; set; }

        public int Departmanid { get; set; }
        public virtual Departman Departman { get; set; }
    }
}