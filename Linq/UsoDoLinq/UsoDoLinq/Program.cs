using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UsoDoLinq
{
   public class Product { 
        public string Name;
        public decimal Price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 1, 2, 3 };
            int[] ar2 = { 3, 5, 7 };

            Product produto1 = new Product("Monitor", 210);
            WriteLine(produto1.Name+" "+produto1.Price);

            var result = ar1.Concat(ar2);
            var result2 = ar1.Union(ar2);
            WriteLine($"\n {result} , {result2} ");

            ReadKey();

        }
    }
}
