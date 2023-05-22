﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class Departman
    {
        [Key]
        public int departmanID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string departmanAd { get; set; }
        public bool Durum { get; set; } 

        public ICollection<Personel> Personels { get; set; }
    }
}