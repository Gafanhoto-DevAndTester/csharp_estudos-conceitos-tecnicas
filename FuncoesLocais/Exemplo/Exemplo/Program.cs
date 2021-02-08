using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            void DataHoraAtual()
            {
                WriteLine($"Data/Hora : {DateTime.Now.ToString()}");
            }
            string CaixaAlta(string texto)
            {
                return texto.ToUpper();
            }

            DataHoraAtual();

            WriteLine("Digite uma Frase:");
            string frase = ReadLine();
            WriteLine($"{frase} => {CaixaAlta(frase)}\n");

            Mensagem("Macetes aprendidos no Macoratti.net");

            ReadKey();
        }

        
        private static void Mensagem(string texto)
        {
            int contador = 5;
            ExibeTexto();

            void ExibeTexto()
            {
                for (int i = 0; i < contador; i++)
                {
                    WriteLine(texto);
                }
              
            }
        }

    }
}
