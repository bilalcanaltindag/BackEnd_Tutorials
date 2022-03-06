using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Elma";
            product1.ProductPrice = 12;
            product1.ProductDescription = "Amasya Elması";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Karpuz";
            product2.ProductPrice = 80;
            product2.ProductDescription = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName + " " +product.ProductPrice + " " + product.ProductDescription);
            }

            BracketManager bracketManager = new BracketManager();
            bracketManager.Add(product1);
            bracketManager.Add(product2);

            bracketManager.Add2("Bilal", "Bilal Altındağ", 15);


        }
    }
}
