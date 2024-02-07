using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class ArGeDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0QCR5AD;initial Catalog=UdemyCarBookDB6;integrated Security=True; TrustServerCertificate= true;");
        }
        public DbSet<Domain.Entities.ArgePersoneliDisaridaGecirilenSureler> ArgePersoneliDisaridaGecirilenSureler { get; set; }
        public DbSet<Domain.Entities.ArgeProjeleri> ArgeProjeleri { get; set; }
        public DbSet<Domain.Entities.ArgeProjeMaliyetleri> ArgeProjeMaliyetleri { get; set; }
        public DbSet<Domain.Entities.Chip> Chip { get; set; }
        public DbSet<Domain.Entities.GuncelBilgiYonetimi> GuncelBilgiYonetimi { get; set; }
        public DbSet<Domain.Entities.HamMadde> HamMadde { get; set; }
        public DbSet<Domain.Entities.KesitTipi> KesitTipi { get; set; }
        public DbSet<Domain.Entities.Numuneler> Numuneler { get; set; }
        public DbSet<Domain.Entities.PersonelListesi> PersonelListesi { get; set; }
        public DbSet<Domain.Entities.ProjeDenemeIstegi> ProjeDenemeIstegi { get; set; }
        public DbSet<Domain.Entities.ProjeDenemeleri> ProjeDenemeleri { get; set; }

        public DbSet<Domain.Entities.ProjeGuncelBilgileri> ProjeGuncelBilgileri { get; set; }
        public DbSet<Domain.Entities.ProjeSorumlusu> ProjeSorumlusu { get; set; }


    }
}
