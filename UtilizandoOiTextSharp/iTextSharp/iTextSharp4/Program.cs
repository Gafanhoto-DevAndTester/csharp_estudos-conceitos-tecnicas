using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Console;

namespace iTextSharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoDir = @"C:\Users\Roberto\Documents\Livros da Temporada";
            string[] arquivos = Directory.GetFiles(caminhoDir,"*.pdf",SearchOption.AllDirectories);

            int totalPaginas = 0;
            int paginasApuradas;

            PdfReader lendoArquivo;

            try
            {
                foreach (string arq in arquivos)
                {
                    lendoArquivo = new PdfReader(arq);

                    paginasApuradas = lendoArquivo.NumberOfPages;

                    totalPaginas = totalPaginas + paginasApuradas;

                    WriteLine($"Arquivo: {arq} e {lendoArquivo.NumberOfPages} página(s)");
                    
                }
                WriteLine($"\nEncontrei: {totalPaginas} páginas(s) e {arquivos.Length} arquivo(s).");
            }
            catch (Exception erro)
            {
                WriteLine($"Algo deu errad: {erro.Message}");
            }
            ReadKey();
        }
    }
}
