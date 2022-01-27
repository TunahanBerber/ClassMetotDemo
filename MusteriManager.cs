using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Eklendi " + musteriler.FirstName);
        }

        public void MusteriSil(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Silindi " + musteriler.FirstName);
        }

        public void MusteriListele(Musteri[] musteri)
        {
            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine("Müşteri Başarıyla Listelendi " + " => " + musteriler.Id + " " + musteriler.FirstName + " " + musteriler.LastName);

            }
        }

    }
}
