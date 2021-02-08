using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class LinkedList_1
    {
        static void Main(string[] args)
        {
            var Notebooks = new LinkedList<string>();

            Notebooks.AddLast("DELL");
            Notebooks.AddLast("ASUS");
            Notebooks.AddLast("ACER");
            Notebooks.AddLast("COMPACT");
            Notebooks.AddLast("HP");
            Notebooks.AddLast("LENOVO");

            Console.WriteLine("LinkedList Elements: \n");

            foreach (var item in Notebooks)
            {
                Console.WriteLine($" {item} ");
            }

            Notebooks.AddFirst("MACBOOK");
            Notebooks.AddFirst("SAMSUNG");
            Console.WriteLine("\n LinkedList Elements after AddFirst: \n");

            foreach (var item in Notebooks)
            {
                Console.WriteLine($" {item} ");
            }

            Notebooks.Remove("SAMSUNG");
            Console.WriteLine("\n LinkedList Elements after Remove('SAMSUNG'): \n");

            foreach (var item in Notebooks)
            {
                Console.WriteLine($" {item} ");
            }

            Notebooks.RemoveLast();
            Console.WriteLine("\n LinkedList Elements after RemoveLast: \n");

            foreach (var item in Notebooks)
            {
                Console.WriteLine($" {item} ");
            }

            Notebooks.RemoveFirst();
            Console.WriteLine("\n LinkedList Elements after RemoveFirst: \n");

            foreach (var item in Notebooks)
            {
                Console.WriteLine($" {item} ");
            }

            Console.ReadKey(true);

        }
    }
}
