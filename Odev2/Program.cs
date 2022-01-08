using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Telefon";
            product1.ProductPrice = 3600;

            Product product2 = new Product();
            product2.ProductName = "Televizyon";
            product2.ProductPrice =4800;

            Product[] products = new Product[] { product1, product2 };


            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine(products[i].ProductName + "  : " + products[i].ProductPrice);
            //}

            //int i = 0;
            //while (i<products.Length)
            //{
            //    Console.WriteLine(products[i].ProductName + "  : " + products[i].ProductPrice);
            //    i++;

            //}

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice );
            }

        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
