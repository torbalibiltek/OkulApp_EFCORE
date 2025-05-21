using Microsoft.EntityFrameworkCore;
using OkulApp.Modeller;

namespace OkulApp
{ 
    public class OkulDataContext : DbContext
    {
        //Tabloları bağla
        public DbSet<DbSinif> Siniflar { get; set; }
        public DbSet<DbOgrenci> Ogrenciler { get; set; }

        //Veritabanı bağlantı ayarları
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + Application.StartupPath + "\\okul.db;");
        }
        //Modellerin ilişkilerini belirle
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbSinif>()  //Bir sınıf için
                .HasMany(s => s.Ogrenciler) //çok öğrencisi vardır
                .WithOne(o => o.Sinif) //bir sınıfın
                .HasForeignKey(o => o.SinifId) //yabancı anahtar SinifId dir
                .HasPrincipalKey(s => s.Id); //Birincil anahtar Id dir
        }
    }
}
