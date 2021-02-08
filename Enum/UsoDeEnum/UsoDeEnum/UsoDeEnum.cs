using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeEnum
{
    class UsoDeEnum
    {
        public enum TiposPessoa
        {
            Ana=1,
            Ronaldo=2,
            Otavio=3,
            Catarina=4
        }

        enum Estacao : byte
        {
            Verao,
            Inverno,
            Outono,
            Primavera
        }
        enum Align : int
        {
            Esquerda,
            Direita,
            Centro
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Lista Enum Pessoas\n");
            String[] names = Enum.GetNames(typeof(TiposPessoa));
            var Posicao_Ana = (byte)TiposPessoa.Ana;
            foreach (String n in names) 
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nPosição onde a Ana está:{0}", Posicao_Ana);
            Console.ReadKey();
            Console.WriteLine("\n-------------------\n");

            Console.WriteLine("\nLista Enum Estações\n");
            var inverno = Estacao.Inverno;
            var baseValue = (int)inverno;
            var baseOutono = (byte)Estacao.Outono;
            Console.WriteLine("\nA primeira posição é ocupada pela estação: {0},\nIndice em que ela se encontra:{1},"
                +"\nA estação outono em byte é: {2}",inverno,baseValue,baseOutono);
            Console.WriteLine("\nA Lista Completa é:\n");
            String[] estacoes = Enum.GetNames(typeof(Estacao));
            foreach (String est in estacoes)
            {
                Console.WriteLine(est);
            }
            Console.ReadKey();
            Console.WriteLine("\n-------------------\n");


            Console.ReadKey();
            Console.WriteLine("Lista Enum Align\n");
            var baseCenter = (int)Align.Centro;
            Console.WriteLine("Alinhamento ao Centro: {0}", baseCenter);
            Console.WriteLine("\nA Lista Completa é:\n");
            String[] alinhamentos = Enum.GetNames(typeof(Align));
            foreach (String align in alinhamentos)
            {
                Console.WriteLine(align);
            }
            Console.ReadKey();
        }
    }
}
