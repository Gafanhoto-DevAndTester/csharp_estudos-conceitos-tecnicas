using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilha = new Stack();
            pilha.Push("Hello");
            pilha.Push("World");
            pilha.Push("just testing");

            WriteLine("Demonstração de Pilha: ");

            for (int i =0;i<=pilha.Count;i++)
            {
                WriteLine(pilha.Pop().ToString());
            }
            ReadKey();
        }
    }
}
