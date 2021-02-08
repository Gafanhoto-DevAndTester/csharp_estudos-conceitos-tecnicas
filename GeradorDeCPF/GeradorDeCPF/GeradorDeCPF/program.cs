using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeCPF;

namespace GeradorDeCPF
{
   public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GeradorDeCPF.GerarCpf());
            Console.ReadLine();
        }
    }
}
