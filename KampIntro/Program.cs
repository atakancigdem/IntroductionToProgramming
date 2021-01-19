using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Atakan";
            int ogrenciSayisi = 32; // Tam Sayı
            double faizOrani = 1.45; // Virgülü sayılar için kullanırız
            bool sistemeGirisYapmisMi = true; // false-ture olmak üzere iki tipi vardır.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //Şart blokları if-else-else if

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            Console.WriteLine("--------------------------------");

            if (sistemeGirisYapmisMi = true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            } 
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine(kategoriEtiketi);
           
        }
    }
}
