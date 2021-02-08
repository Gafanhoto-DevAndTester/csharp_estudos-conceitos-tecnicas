using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_2
{
    class LinkedList_2
    {
        static void Main(string[] args)
        {
           

            LinkedList<int> lista = new LinkedList<int>();

            int i=0;

            do {
                Console.WriteLine("Insira um novo numero a lista: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.AddLast(numero);
                i++;
            } while (i <= 10);
            Console.WriteLine();

            foreach (var num in lista) {
                Console.WriteLine(num);
            }

            lista.RemoveLast();
            Console.WriteLine("\nO Último Número Adicionado Foi Removido. Veja A Nova Lista:");

            foreach (var num in lista)
            {
                Console.WriteLine(num);
            }




            Console.WriteLine("Nos diga o item que deseja filtrar: ");
            int itemIndicado = Convert.ToInt32(Console.ReadLine());
            LinkedListNode<int> item = lista.Find(itemIndicado);
            Console.WriteLine();
            if (item != null) {
                Console.WriteLine($"Valor anterior ao {itemIndicado} : "+item.Previous.Value);
                Console.WriteLine($"Valor seguinte ao {itemIndicado}: " + item.Next.Value);

            }
            Console.WriteLine("Cabeça da lista: "+lista.First.Value);
            Console.WriteLine("Cauda da lista: "+lista.Last.Value);
            Console.ReadKey();
        }
    }
}
