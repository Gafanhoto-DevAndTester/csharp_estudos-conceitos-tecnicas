using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeStringsAleatorias
{
    public class Program
    {
        static Random _random = new Random();

        public static void Shuffle<Tipo>(Tipo[] array)
        {
            var random = _random;

            for (int i = array.Length;i>1;i--)
            {
                int j = random.Next(i);
                Tipo tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
                Console.WriteLine(tmp);

            }
        }

     
        public static void Main()
        {
            string[] array =
            {
                "José",
                "Carlos",
                "João",
                "Miriam",
                "Estela"
            };
            //Embaralhamos a lista

            Shuffle(array);
          
            /*  foreach (string value in  array)
            {
                Console.WriteLine(value);
            }
            */ 

            Console.ReadLine();
        }
    }
}
