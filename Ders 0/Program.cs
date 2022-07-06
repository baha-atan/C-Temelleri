using System;

namespace Ders_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım";
            string kurs2 = "Proglama";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array - dizi


            string[] kurslar = new string[] { "Yazılım","Proglama","Java"};


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("son");
        }
    }
}
