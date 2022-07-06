using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_0._2
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendin : " + product.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat ,int stokAdedi )
        {
            Console.WriteLine("Sepete Eklendin : " + urunAdi);
        }
    }
}
