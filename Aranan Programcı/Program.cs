using System;

namespace Aranan_Programcı
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adı = "Deri Ayakkabı";
            urun1.Fiyat = 2000;

            Product urun2 = new Product();
            urun2.Adı = "Bot";
            urun2.Fiyat = 2500;

            Product[] products = new Product[]
            {
                urun1,urun2
            };

            foreach (Product product in products)
            {
                
                Console.WriteLine(product.Adı);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine("----Leopar By Bronzeface-----");

            }

            Console.WriteLine("--------Metotlar----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
        }
    }
}
