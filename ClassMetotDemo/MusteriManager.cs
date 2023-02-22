using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            if (musteri == null)
            {
                Console.WriteLine("Müşteri eklmede hata oluştu");
                return;
            }
            Console.WriteLine("Müşteri başarıyla eklende : " + musteri.AdSoyad);
        }

        public void Sil(Musteri musteri)
        {
            if (musteri == null)
            {
                Console.WriteLine("Müşteri silmede hata oluştu");
                return;
            }
            Console.WriteLine("Müşteri sistemden silindi : " + musteri.AdSoyad);
        }

        public void Listele(params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriId + " " + musteri.AdSoyad + " " + musteri.Meslek + " " + musteri.HesapNo);
            }
        }
    }
}
