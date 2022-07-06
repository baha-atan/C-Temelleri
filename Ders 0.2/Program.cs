using System;

namespace Ders_0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma","Karpuz"};

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
            }
            Console.WriteLine("------Metotlar------");

            //instance - örnek 
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma", "Kırmızı Elmaa", 12,15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 20,25);
        }
    }
}
