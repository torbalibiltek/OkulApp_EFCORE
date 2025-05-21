namespace OkulApp.Modeller
{
    public class DbOgrenci
    {
        public int Id { get; set; } //PK
        public int Numara { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? Cinsiyet { get; set; } // 0: Erkek, 1: Kız
        //int? Null olabilir anlamında
        public int SinifId { get; set; }//FK 
        //Navigation Property
        //*veritabanında kayıtlı değil
        //*sadece gezinti için
        public DbSinif Sinif { get; set; }
    }
}
