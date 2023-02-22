using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Adi);
        }

        public void Ekle(int Id, string UrunAd, double Fiyat, string Aciklama, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + UrunAd);
        }
    }
}
