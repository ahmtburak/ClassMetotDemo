using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " "+ musteri.Soyad +" artık yeni müşterimizsiniz.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Id'si " +musteri.Id + " olan kullanıcı silindi.");
        }
    }
}
