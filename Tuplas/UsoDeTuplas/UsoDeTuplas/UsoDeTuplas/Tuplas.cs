using System;
using System.Tuples;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeTuplas
{
    /*Para utilizar os Tuples
     * é necessario instalar via Nuget o: TupleExtensions.VictorGavrish 
     * e o System.Tuples 
     */
    class Tuplas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Exemplo 1-----");
            (int, int) ParValores = (7, 29);
            Console.WriteLine($"Valor = {ParValores.Item1}\n"+
                $"Valor = {ParValores.Item2}");

            Console.WriteLine("\n-----Exemplo 2-----");
            (string, string) Nomes = ("Roberto", "Fernanda");
            Console.WriteLine($"Nome da 1ª pessoa: {Nomes.Item1}\nNome da 2ª pessoa: {Nomes.Item2}  ");

            Console.WriteLine("\n-----Exemplo 3-----");
            (int,int, int) Dezenas = (10,20,30);
            Console.WriteLine($"Valor 1: {Dezenas.Item1}\n"+
                $"Valor 2: {Dezenas.Item2}\n"+
                $"Valor 3: {Dezenas.Item3}");

            Console.WriteLine("\n-----Exemplo 4-----");
            var coordenadas = (latitude: "23.54545", longitude: "43432525");
            Console.WriteLine($"São Paulo -"
                +$"Latitude = {coordenadas.latitude} - "
                +$"Longitude = {coordenadas.longitude}");

            Console.ReadKey(true);

        }
    }
}
