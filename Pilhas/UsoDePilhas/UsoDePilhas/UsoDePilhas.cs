using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDePilhas
{
    class UsoDePilhas
    {
        static void Main(string[] args)
        {
            Stack<string> MinhaPilha = new Stack<string>();

            MinhaPilha.Push("Primeira Carta");
            MinhaPilha.Push("Segunda Carta");
            MinhaPilha.Push("Terceira Carta");
            MinhaPilha.Push("Quarta Carta");
            MinhaPilha.Push("Quinta Carta");
            MinhaPilha.Push("Sexta Carta");
            MinhaPilha.Push("Sétima Carta");
            MinhaPilha.Push("Oitava Carta");
            MinhaPilha.Push("Nona Carta");

            int contador = MinhaPilha.Count();

            Console.WriteLine("Pilha Antes da Remoção de Elementos...\n\n");

            foreach (string carta in MinhaPilha) {
                Console.WriteLine(carta);
            }
            Console.WriteLine();
            Console.WriteLine($"Numero de Cartas: {contador}\n");
            Console.WriteLine($"O primeiro elemento da pilha é: {MinhaPilha.Peek()} \n");
            MinhaPilha.Pop();

            int contador2 = MinhaPilha.Count();

            Console.WriteLine("Pilha após a remoção: \n");

            foreach (string carta in MinhaPilha)
            {
                Console.WriteLine(carta);
            }
            Console.WriteLine();
            Console.WriteLine($"\nNumero de Cartas: {contador2}");

            Console.ReadKey();
            MinhaPilha.Clear();
            Console.WriteLine($"\nSua Pilha Foi Desfeita! ");
            Console.ReadKey();
        }
    }
}
