using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Console;
using System.IO;

namespace iTextSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtracaoPDFMetodo();
            WriteLine("Terminado o processo!");
            ReadKey();
        }

        static void ExtracaoPDFMetodo()
        {
            PdfReader pdfReader = new PdfReader(@"C:\projetos-cs\EstudosConceitosTecnicas\UtilizandoOiTextSharp\iTextSharp\dir\Proposta De Projeto.pdf");
            Document document = new Document();

            if (pdfReader.NumberOfPages > 0)
            {
                for (int i = 1; i < pdfReader.NumberOfPages; i++)
                {
                    PdfCopy pdfCopy = new PdfCopy(document,new FileStream(Path.Combine(@"C:\projetos-cs\EstudosConceitosTecnicas\UtilizandoOiTextSharp\iTextSharp\dir\extraidos",string.Format("pagina_{0}.pdf",i)),FileMode.Create));

                    document.Open();

                    pdfCopy.AddPage(pdfCopy.GetImportedPage(pdfReader,i));
                }
                document.Close();
            }
            else
            {
                return;
            }
        }
    }
}

/*
 * Solução para a escolha de páginas que você quer extrair
 * 
 * 
 * 
    static void Main(string[] args)
    {
    ExtracaoPDFMetodo(new int[] {3,7,8,9,10,100,600})// <-passe as paginas que deseja extrair
    }        
 * 
 * 
  static void ExtracaoPDFMetodo(int[] paginas)// <-Adicione o parametro int[] paginas
        {
            PdfReader pdfReader = new PdfReader(@"C:\projetos-cs\EstudosConceitosTecnicas\UtilizandoOiTextSharp\iTextSharp\dir\Proposta De Projeto.pdf");
            Document document = new Document();

            if (pdfReader.NumberOfPages > 0)
            {

                foreach(var item in paginas)
                {
                PdfCopy pdfCopy = new PdfCopy(document,new FileStream(Path.Combine(@"C:\projetos-cs\EstudosConceitosTecnicas\UtilizandoOiTextSharp\iTextSharp\dir\extraidos",string.Format("pagina_{0}.pdf",item)),FileMode.Create));

                    document.Open();

                    pdfCopy.AddPage(pdfCopy.GetImportedPage(pdfReader,item));
                }

               
                document.Close();
            }
            else
            {
                return;
            }
        }
     */
