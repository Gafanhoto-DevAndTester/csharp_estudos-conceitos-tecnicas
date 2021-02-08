using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDoReadOnlyCollection
{
    class ReadOnlyCollection
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(14);
            list.Add(5);
            list.Add(8);
            list.Add(9);

            ReadOnlyCollection<int> read = new ReadOnlyCollection<int>(list);
            foreach (int value in read)
            {
                Console.WriteLine($"Read: {value}");
            }
            Console.WriteLine();
            
            Console.WriteLine();
            int count = read.Count;
            bool contains = read.Contains(14);
            int index = read.IndexOf(9);
            Console.WriteLine();

            Console.WriteLine("Count \t Contains(14)\t index(9)");
            Console.WriteLine("{0}\t {1}\t\t {2} ",count,contains,index);
            Console.ReadKey();


        }
    }
}
