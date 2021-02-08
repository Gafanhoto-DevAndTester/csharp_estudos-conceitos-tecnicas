using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeCollections
{
    class HashSet
    {
        public static void Main(string[] args)
        {
            HashSet<string> paises = new HashSet<string>();

            paises.Add("Brasil");
            paises.Add("Polônia");
            paises.Add("EUA");
            paises.Add("Russia");
            paises.Add("Australia");
            paises.Add("Grécia");
            paises.Add("Africa do Sul");

            HashSet<int> populacao = new HashSet<int>();

            populacao.Add(20450090);
            populacao.Add(45970090);
            populacao.Add(13458399);
            populacao.Add(30452011);
            populacao.Add(990090);
            populacao.Add(11458890);
            populacao.Add(70750210);

            foreach (var pais in paises)
            {
                Console.WriteLine($"País - {pais}");
            }
            foreach (var pop in populacao)
            {
                Console.WriteLine($"População - {pop}");
            }


            Console.ReadKey();


        }
    }
}
