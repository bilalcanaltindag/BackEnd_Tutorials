using System;

namespace Product_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Mercimek";
            product1.ProductSort = "Bakliyat";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Laptop";
            product2.ProductSort = "Teknolojik Cihaz";

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Ayçiçek Yağı";
            product3.ProductSort = "Sıvı Yağ";

            Product product4 = new Product();
            product4.ProductId = 4;
            product4.ProductName = "Telefon";
            product4.ProductSort = "Teknolojik Cihaz";

            Product[] products = new Product[] { product1, product2, product3, product4 };

            foreach (var productList in products)
            {
                Console.WriteLine(" Ürün Id : " + productList.ProductId + " Ürün İsmi : " + productList.ProductName + " Ürün Türü : " + productList.ProductSort);
            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(" Ürün Id : " + products[i].ProductId + " Ürün İsmi : " + products[i].ProductName + " Ürün Türü : " + products[i].ProductSort);
            }

            int index = 0;
            while (products.Length > index)
            {
                Console.WriteLine(" Ürün Id : " + products[index].ProductId + " Ürün İsmi : " + products[index].ProductName + " Ürün Türü : " + products[index].ProductSort);
                index++;
            }
        }

        class Product 
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductSort { get; set; }
        }
    }
}
