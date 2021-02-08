using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("Hello");
            q.Enqueue("World");
            q.Enqueue("Just Testing");

           
            WriteLine("Demonstração de Fila:\n ");

            foreach (var elem in q)
            {
                WriteLine(elem);
            }


            WriteLine("\nSaída de elementos da Fila:\n ");
            for (int i = 0;i <=q.Count; i++)
            {
                
                WriteLine(q.Dequeue().ToString());
            }

            ReadLine();   
        }
    }
}
