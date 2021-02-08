using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime data1, data2;
            TimeSpan result;

            data1 = DateTime.Parse("11/02/1981");
            data2 = DateTime.Parse("16/01/2021");

            result = data2 - data1;
            Console.WriteLine($"Você já viveu {result.Days} dias");
            Console.WriteLine($"Você tem {result.Days/30/12} anos");

            Console.ReadKey();



        }
    }
}
