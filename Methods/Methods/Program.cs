namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Elma";
            product1.Fiyati = 10;
            product1.Aciklama = "Amasya elması";
            product1.StokAdedi = 15;


            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";
            product2.StokAdedi = 20;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine("Urun adı : " + product.Adi + "    Fiyatı : " + product.Fiyati + "    Açıklma : " + product.Aciklama);
            }


            Console.WriteLine("-----------------------Methods-----------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(3, "Yeşil elma", 20, "Yeşil elma!!!", 20);

        }
    }
}