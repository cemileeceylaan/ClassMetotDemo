using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.id = 10;
            musteri1.AdSoyad = "Cemile Ceylan";
            musteri1.AlisverisSayisi = 100;
            musteri1.Cuzdan = 20.75;

            Musteri musteri2 = new Musteri();
            musteri2.id = 20;
            musteri2.AdSoyad = "Asli Kurt";
            musteri2.AlisverisSayisi = 25;
            musteri2.Cuzdan = 12.31;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            

            musteriManager.MusteriSil(musteri1);

            Console.WriteLine("Müşteri Listesi");
            musteriManager.MusteriListesi(musteriler);
        }
    }
}
