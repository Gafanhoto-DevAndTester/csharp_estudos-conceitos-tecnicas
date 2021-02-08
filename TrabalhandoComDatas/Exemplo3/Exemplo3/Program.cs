using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite uma data Completa:");
            string dateInput = ReadLine();
            var parsedDate = DateTime.Parse(dateInput);
            int intParsedDate = Int32.Parse(parsedDate.Year.ToString());

            WriteLine(parsedDate.ToString("yy"+"\n"));//.ToString("yy") ou .Year

           

            WriteLine("Digite a Data Atual:");
            string dateInput2 = ReadLine();
            var parsedDate2 = DateTime.Parse(dateInput2);
            int intParsedDate2 = Int32.Parse(parsedDate2.Year.ToString());

            WriteLine(parsedDate2.ToString("yy" + "\n"));

            WriteLine($"Já se passaram então: {intParsedDate2 - intParsedDate}");


            ReadKey();
        }
    }
}
