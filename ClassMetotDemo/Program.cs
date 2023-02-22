namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.AdSoyad = "Zehra ARSLAN";
            musteri1.Meslek = "Yazılımcı";
            musteri1.HesapNo = "145956";
            musteri1.KrediTuru = "Ev kredisi";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.AdSoyad = "Ali DENİZ";
            musteri2.Meslek = "Mühendis";
            musteri2.HesapNo = "26564";
            musteri2.KrediTuru = "Araba kredisi";


            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.AdSoyad = "Derya KÖK";
            musteri3.Meslek = "Doktor";
            musteri3.HesapNo = "785757";
            musteri3.KrediTuru = "İhtiyaç kredisi";




            Console.WriteLine("------------------Ekleme İşlemi------------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("------------------Listeleme İşlemi------------------");
            musteriManager.Listele(musteri1, musteri2, musteri3);

            Console.WriteLine("------------------Silme İşlemi------------------");
            musteriManager.Sil(musteri2);

        }
    }
}