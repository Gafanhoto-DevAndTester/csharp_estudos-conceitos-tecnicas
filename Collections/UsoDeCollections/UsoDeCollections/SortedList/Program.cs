using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;
namespace ListaOrdenada
{
    class Program
    {
        static void Main(string[] args)
        {
            var sl = new SortedList();
            sl.Add("Vitor", "Meu nome é Vitor");
            sl.Add("Igor", "Meu nome é Igor");
            sl.Add("Jorge", "Meu nome é Jorge");

            foreach (DictionaryEntry de in sl)
            {
                WriteLine(de.Value);
            }
            ReadKey();
        }
    }
}
