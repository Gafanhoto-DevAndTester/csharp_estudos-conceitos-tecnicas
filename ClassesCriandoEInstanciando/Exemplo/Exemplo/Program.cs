using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa cx = new Caixa();
           double res =  cx.Volume(9.7);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
