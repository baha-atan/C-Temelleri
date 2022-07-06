using System;

namespace C_Sharp_Temelleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safrety - tip güvenliği
            //Do not your self

            string katagoriEtiketi = "Kategori";
          //  int ogrenciSayisi = 30000;
          //  double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayaları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(katagoriEtiketi);



        }
    }
}
