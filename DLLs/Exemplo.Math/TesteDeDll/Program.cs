using System;
using Exemplo.Math.Functions;
using static System.Console;

namespace TesteDeDll
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Sigmoid.Calculate(56.9));
            ReadKey();
        }
    }
}
