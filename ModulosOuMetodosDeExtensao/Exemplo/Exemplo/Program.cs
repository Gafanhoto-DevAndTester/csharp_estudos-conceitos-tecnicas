using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exemplo
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaquinaDeCafe mqn = new MaquinaDeCafe();
            WriteLine(mqn.ServirCappucino());
            ReadKey();
        }
    }
}
