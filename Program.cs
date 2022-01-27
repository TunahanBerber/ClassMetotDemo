using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Tunahan";
            musteri1.LastName = "Berber";
            musteri1.NationalIdentity = 12345678966;
            musteri1.CardNumber = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 7;
            musteri2.FirstName = "Aybüke";
            musteri2.LastName = "Muratoğlu";
            musteri2.NationalIdentity = 987654321;
            musteri2.CardNumber = 987654321;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.FirstName = "Hayri";
            musteri3.LastName = "Berber";
            musteri3.NationalIdentity = 456789321;
            musteri3.CardNumber = 456321789;
            Convert.ToString(musteri1);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);

        }
    }
}
