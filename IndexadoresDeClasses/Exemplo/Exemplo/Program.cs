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
        //indexador permite uma classe/objeto seja tratado como um array
        static void Main(string[] args)
        {
            object valorObj = 80;
          
            MinhaClasseLista lista = new MinhaClasseLista();
          
            lista[0] = 10;
            lista[5] = valorObj;
            WriteLine(lista[valorObj]);
            WriteLine(lista[5]);
            WriteLine(lista[0,0]=43);

            ReadKey();

            
        }
    }
}
