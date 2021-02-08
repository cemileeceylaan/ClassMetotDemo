using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad + " müşterisi başarıyla eklenmiştir.");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad + "müşterisi başarıyla silinmiştir.");
        }
        public void MusteriListesi(Musteri[] musteri)
        {
            foreach (var i in musteri)
            {
                Console.WriteLine("Numarası:" + i.id + "Müsterinin ismi soyismi: " + i.AdSoyad + "Alisveris Sayisi: " + i.AlisverisSayisi + "Cuzdandaki parasi: " + i.Cuzdan);
            }
        }
    }
}

    

