using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Name = "Elma";
            product1.Price = 15;
            product1.Detail= "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Detail = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            // type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine("Ürünün İsmi : " + product.Name);
                Console.WriteLine("Ürünün Fiyatı : " + product.Price);
                Console.WriteLine("Ürün Açıklaması : " + product.Detail);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("------------Methods------------");
            
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            Console.WriteLine("--------------2-------------");

            sepetManager.Add2("Armut", "Yeşil Armut", 13, 9);
            sepetManager.Add2("Elma", "Yeşil Elma", 14, 12);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 50, 7);
        }
    }
}


// Methods - Tekrar tekrar kullanılmaya yarayan programlardır.
//Don't repeat yourself. - DRY - Clean Code
//Product - Urun

