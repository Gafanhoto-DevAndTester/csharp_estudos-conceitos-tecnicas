using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    class SortedSet
    {
        static void Main(string[] args)
        {
            var countries = new SortedSet<string>();

            countries.Add("India");
            countries.Add("China");
            countries.Add("Japão");
            countries.Add("Israel");
            countries.Add("India"); //O sorted não armazenará duplicados


            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            Console.ReadKey(true);
        }
    }
}
