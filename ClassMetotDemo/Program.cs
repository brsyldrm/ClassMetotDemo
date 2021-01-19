using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri müsteri1 = new Musteri() { ID = 123456789, AdSoyad = "Barış Yıldırım", Bakıye = 4000 };
            Musteri müsteri2 = new Musteri() { ID = 159357456, AdSoyad = "Salih Müneccimoğlu", Bakıye = 8000 };
            Musteri müsteri3 = new Musteri() { ID = 987456123, AdSoyad = "Ayyüce Kaya", Bakıye = 2000 };

            Musteri[] müsteri = new Musteri[] { müsteri1, müsteri2, müsteri3 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Yeni Müşteri");
            musteriManager.Ekle(müsteri1);
            musteriManager.Ekle(müsteri2);
            musteriManager.Ekle(müsteri3);
            Console.WriteLine("Müşteri Listesi");
            musteriManager.Liste(müsteri);
            Console.WriteLine("Müşteri Silme");
            musteriManager.Sil(müsteri1);
            musteriManager.Sil(müsteri2);
            musteriManager.Sil(müsteri3);


        }
    }
}
