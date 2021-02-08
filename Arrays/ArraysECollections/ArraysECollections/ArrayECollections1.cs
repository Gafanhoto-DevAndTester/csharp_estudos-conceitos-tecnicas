using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysECollections1
{
    class ArrayECollections1
    {
        static void Main(string[] args)
        {

            string[] a = new string[4];
            a[0] = "Roberto";
            a[1] = "Fernanda";
            a[2] = "José";
            a[3] = "Noemia";

            Array.Sort(a);
            
            foreach (string nome in a)
            {
                Console.WriteLine(nome);
            }
            Console.ReadLine();
        }
    }
}
