using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Çetin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Betül";
            musteri2.Soyad = "Çetin";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID: " + musteri.Id);
                Console.WriteLine("Müşteri Ad: " + musteri.Ad);
                Console.WriteLine("Müşteri Soyad: " + musteri.Soyad);
                Console.WriteLine("*************");
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
        }
    }
}
