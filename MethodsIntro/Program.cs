using System;

namespace MethodsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Banana";
            product1.Price = 12;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Pineapple";
            product2.Price = 20;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(
                    "Product Id : "+product.Id+"           "+
                    "Product Name : "+product.Name+ "           "+
                    "Product Price : "+product.Price);
            }

            Console.WriteLine("----------METOTLAR---------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            Console.ReadLine();
            
        }
    }
}
