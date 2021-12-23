using System;
using System.Collections.Generic;
using System.Text;

namespace Aranan_Programcı
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi : "+ product.Adı);

        }

        public void Ekle2(string urunAdi, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
