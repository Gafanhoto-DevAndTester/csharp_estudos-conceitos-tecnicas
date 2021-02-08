using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysECollections2
{
    class ArraysECollections2
    {
        static void Main(string[] args)
        {

            string[] a1 = new string[3];
            a1[0] = "teste1";
            a1[1]="teste2";
            a1[2]="teste3";

            int size = a1.Length;

            if (Array.Exists(a1, e => e == "teste2"))
            {
                Console.WriteLine("\n teste2 existe \n");
            }
            List<string> a = new List<string>();
            a.Add("star");
            a.Add("moon");
            a.Add("sun");
            a.Add("sky");

            Console.WriteLine(a[3]);
            foreach (string nome in a)
            {
                Console.Write("\n"+nome+"\n");
            }

            if (a.Exists(e=>e=="star"))
            {
                Console.WriteLine("Encontrei star no meu collection");
            }

            int size_list = a.Count;

            Console.Read();
        }
    }
}
