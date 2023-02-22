namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip günevliği
            // Do not repeat yourself  - Kendini tekrarlama
            string kategoriEtiketi = "kategori";
            int ogrenciSayısı = 32000;
            double katılımOranı = 75.6;
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.05;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu ");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmısMı)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}