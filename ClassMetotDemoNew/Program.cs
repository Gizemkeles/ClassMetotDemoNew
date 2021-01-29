using System;

namespace ClassMetotDemoNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "Yıldırım";
            musteri1.Yasi = 53;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Emine";
            musteri2.Soyadi = "Sarı";
            musteri2.Yasi = 34;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Mustafa";
            musteri3.Soyadi = "Kaya";
            musteri3.Yasi = 42;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            Console.WriteLine("Bankamıza Hoşgeldiniz!İşleminiz gerçekleştiriliyor.");

            Console.WriteLine("--Müşteriler Listeleniyor!--");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Liste(musteri1);
            musteriManager.Liste(musteri2);
            musteriManager.Liste(musteri3);

            Console.WriteLine("---------------------");

            Console.WriteLine("--Müşteriler Ekleniyor!--");
            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Betül";
            musteri4.Soyadi = "Kılıç";
            musteri4.Yasi = 28;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Ali";
            musteri5.Soyadi="Vural";
            musteri5.Yasi = 36;

            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);

            Console.WriteLine("--------------------");

            Console.WriteLine("--Müşteriler Siliniyor!--");

            musteriManager.Sil(musteri1);
            Console.WriteLine("--------------------");
            Console.WriteLine("İşlemi Gerçekleştirilen Müşteriler");
            musteriManager.İslem(musteri2);
            musteriManager.İslem(musteri3);
            musteriManager.İslem(musteri4);
            musteriManager.İslem(musteri5);


        }
    }
}
