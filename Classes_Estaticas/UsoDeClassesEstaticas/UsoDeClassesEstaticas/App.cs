using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeClassesEstaticas
{
    class App
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Pressione CTRL+C para sair dessa execução");

            Console.WriteLine("Digite um numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Soma = {Calc.Somar(num1,num2).ToString()}");
            Console.WriteLine($"Subtrair = {Calc.Subtrair(num1,num2).ToString()}");
            Console.WriteLine($"Multiplicar = {Calc.Multiplicar(num1,num2).ToString()}");
            Console.WriteLine($"Dividir = {Calc.Dividir(num1,num2)}");
            
            Console.Read();

        }
    }
}
