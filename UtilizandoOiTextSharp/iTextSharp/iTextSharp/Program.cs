using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;


namespace iTextSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string caminhoArquivo = @"C:\Users\Roberto\Documents\Livros da Temporada\Ascensao - Stephen King.pdf";


            PdfReader lendoArquivo;

            try
            {
                lendoArquivo = new PdfReader(caminhoArquivo);

                int numeroPaginas = lendoArquivo.NumberOfPages;

                Console.WriteLine($" Este arquivo possui: {numeroPaginas} página(s)");

            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro ao processar a quantidade de páginas: "+erro.Message);
            }
            finally
            {
                System.Diagnostics.Process.Start(caminhoArquivo);//Abrirá o arquivo para nós
            }
            Console.ReadKey();
        }
    }
}
