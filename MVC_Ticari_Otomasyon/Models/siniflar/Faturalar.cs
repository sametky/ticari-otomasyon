using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class Faturalar
    {
        [Key]
        public int faturaID { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public char faturaSeriNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string faturaSiraNo { get; set; }
        public DateTime faturaTarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string VergiDairesi { get; set ; }
        public DateTime faturaSaat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string teslimEden { get;set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string teslimAlan { get;set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}