using System;
using static System.Console;

namespace UsoDeEnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsMovimentos mov = new ClsMovimentos();
            mov.ValidaMov(ClsMovimentos.movimentos.Cima);

            ReadKey();
        }
    }
}
