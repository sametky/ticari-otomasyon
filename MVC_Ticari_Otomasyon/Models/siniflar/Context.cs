using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Ticari_Otomasyon.Models.siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Müsteriler> Müsterilers { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }
        public DbSet<Faturalar> Faturalars { get; set; }
        public DbSet<Giderler> Giderlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<SatisHareketleri> SatisHareketleris { get; set; }

    }

}