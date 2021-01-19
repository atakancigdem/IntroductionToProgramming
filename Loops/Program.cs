using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu hammalıktır.. Bunu yerie diziler (array) ile dinamik bir sistem yapabiliriz.
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıc için temel kurs";
            string kurs3 = "Java";

            //Array - Dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıc için temel kurs", "Java", "Python", "C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---------------------------");

            //Dizi temeli yapıları tek tek döndürmeye (dolaşmaya) yarıyor - foreach
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("-------END------");
            
        }
    }
}
 