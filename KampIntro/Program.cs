using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Category = "Kategori";
            int StudentNumber = 3500;
            double BankRate = 1.45;
            bool SystemIn = false;

            double DolarDun = 7.35;
            double DolarBugun = 7.15;

            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Dolar Düşme İşareti");
            }
            else if (DolarDun < DolarBugun)
            {
                Console.WriteLine("Dolar Yükselme İşareti");
            }
            else
            {
                Console.WriteLine("Dolar Eşit İşareti");
            }

            if (SystemIn == true)
            {
                Console.WriteLine("Kullanıcı Ayarı Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(Category);
        }
    }
}
