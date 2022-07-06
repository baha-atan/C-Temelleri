using System;

namespace Ders_0._4
{
    class Program
    {
        //Değer ve Referans Tipler 
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 15;
            sayi1 = sayi2;
            sayi2 = 40;
            //sayi1=? / 15

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=? / 999
        }
    }
}
