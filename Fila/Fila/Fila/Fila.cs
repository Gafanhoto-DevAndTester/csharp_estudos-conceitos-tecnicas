using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    class Fila
    {
        static void Main(string[] args)
        {
            Queue<string> MinhaFila = new Queue<string>();

            MinhaFila.Enqueue("Primeiro Cliente");
            MinhaFila.Enqueue("Segundo Cliente");
            MinhaFila.Enqueue("Terceiro Cliente");
            MinhaFila.Enqueue("Quarto Cliente");
            MinhaFila.Enqueue("Quinto Cliente");

            int contador = MinhaFila.Count();

            foreach (string elemento in MinhaFila)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine();

            Console.WriteLine($"O Primeiro elemento da fila é: {MinhaFila.Peek()} \n");

            Console.WriteLine(contador);
            Console.WriteLine();

            MinhaFila.Dequeue();

            foreach (string elemento in MinhaFila)
            {
                Console.WriteLine(elemento);
            }

            int contador2 = MinhaFila.Count();
            Console.WriteLine();
            Console.WriteLine($"O primeiro elemento da fila agora é: {MinhaFila.Peek()} \n");

            Console.WriteLine(contador2);
            Console.WriteLine();
            Console.ReadLine();

            MinhaFila.Clear();
            Console.WriteLine("A Fila Chegou ao Fim");

        }
    }
}
