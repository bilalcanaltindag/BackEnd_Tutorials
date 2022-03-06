using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BracketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.ProductName);
        }

        public void Add2(string ProductName, string ProductDescription, double ProductPrice) 
        {
            Console.WriteLine("sepet tamam : " + ProductName);
        }
    }
}
