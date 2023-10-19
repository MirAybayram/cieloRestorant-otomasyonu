using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cielo.Models
{
    public partial class CieloContext : DbContext
    {
        public CieloContext()
            : base("name=CielooContext")
        {
        }

        public virtual DbSet<Adisyon> Adisyon { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Masa> Masa { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyon { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public string UrunAdi { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Satis>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Urun>()
                .Property(e => e.Fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.Satis)
                .WithOptional(e => e.Urun)
                .HasForeignKey(e => e.UrunID);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.Satis1)
                .WithOptional(e => e.Urun1)
                .HasForeignKey(e => e.UrunID);
        }
    }
}
