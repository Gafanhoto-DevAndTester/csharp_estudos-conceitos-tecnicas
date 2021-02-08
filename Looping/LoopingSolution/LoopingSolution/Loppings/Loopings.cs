using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopings
{
    class Loopings
    {
        static void Main(string[] args)
        {

        Interromper_execucao:

            Console.WriteLine("Para interromper as execuções utilize CTRL+C \n");

            #region Do While
            Console.WriteLine("-----Do While-----\n");
            int i = 0;
            do
            {
                Console.WriteLine("\nVocê está em um loop Do While");
                Console.WriteLine("Aperte a tecla 1 para sair desse loop");

                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Você digitou o número: " + i);
            } while (i != 1);

            Console.WriteLine("\nVocê está fora do Loop");
            Console.ReadKey(true);

            Console.WriteLine("\n Você caiu em outro loop do while.");
            int valor = 1;
            do
            {
                Console.WriteLine(valor);
                valor++;
            } while (valor <= 10);

            Console.ReadKey(true);
            #endregion

            #region While
            Console.WriteLine("-----While-----\n");

            bool condicao = true;
            valor = 50;
            while (condicao)
            {
                if (valor == 60)
                    condicao = false;

                Console.WriteLine(valor++);
                Console.ReadKey(true);
            }
            #endregion

            #region Foreach
            Console.WriteLine("-----Foreach-----\n");

            string[] departamentos = { "TI", "RH", "CO", "FN" };

            foreach (var depto in departamentos)
            {
                Console.WriteLine(depto);
            }
            Console.ReadKey(true);

            Console.WriteLine("-----Exemplo Notas-----\n");

            List<int> notas = new List<int>();

            notas.Add(5);
            notas.Add(6);
            notas.Add(7);
            notas.Add(8);
            notas.Add(9);

            foreach (var n in notas)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey(true);
            #endregion

            #region For
            Console.WriteLine("-----For-----\n");

            for (int indice = 0; indice < 8; indice++)
            {
                
                Console.WriteLine(indice);
            }
            Console.ReadKey(true);
            #endregion

            goto Interromper_execucao;
        }
    }
}
