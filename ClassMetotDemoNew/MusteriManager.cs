using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoNew
{
    class MusteriManager
    {
        public void Liste(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " "+ "Id numaralı"+ " " + musteri.Adi + " " +musteri.Soyadi );

        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Id numaralı"+ " " + musteri.Adi + " " + musteri.Soyadi+ " " + "Listeye Eklendi" );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+ "Id numaralı"+" " +musteri.Adi+" " +musteri.Soyadi+" "+ "Listeden Silindi");
        }

        public void İslem(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Id numaralı" + " " + musteri.Adi + " " + musteri.Soyadi);
        }



    }
}
