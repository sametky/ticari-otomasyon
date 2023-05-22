using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class FaturaKalem
    {
        [Key]
        public int faturaKalemID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string aciklama { get; set; }
        public int miktar { get; set; }
        public decimal birimFiyat { get; set; }
        public decimal tutar { get; set; }
        public Faturalar Faturalar { get; set; }
    }
}