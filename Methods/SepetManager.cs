using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention
        //syntax - sözdizimi
        // Product - Ürün
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler, sepete eklendi" + " : " +  product.Name);
        }

        public void Add2(string productName, string detail, double price, int stockQuantity)
        {
            Console.WriteLine("Tebrikler, sepete eklendi : " + productName);
        }
    }
}
