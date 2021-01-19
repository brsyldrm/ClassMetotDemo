using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Müşteri eklendi."+ musteriler.ID + " " + musteriler.AdSoyad + " " + musteriler.Bakıye);
        }
        public void Liste(Musteri[] musteriler)
        {
            
            foreach (var müsteriler in musteriler)
            {
                Console.WriteLine(müsteriler.ID + " " + müsteriler.AdSoyad + " " + müsteriler.Bakıye);
            }
            Console.WriteLine("Müşteriler Listelendi.");
        }
        public void Sil(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Silindi."+ musteriler.ID + " " + musteriler.AdSoyad + " " + musteriler.Bakıye);
        }
    }
}
