using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace iTextSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document(PageSize.A6);

            PdfWriter.GetInstance(doc,new FileStream(@"C:\projetos-cs\EstudosConceitosTecnicas\UtilizandoOiTextSharp\iTextSharp\dir\meuarquivo.pdf", FileMode.Create));

            doc.Open();

            doc.Add(new Paragraph("Hello World!"));
            doc.NewPage();

            doc.Add(new Paragraph("Hello World 2 "));
            doc.NewPage();

            doc.Add(new Chunk("Minha Terceira página", new Font(Font.FontFamily.TIMES_ROMAN,30.5F)));

            doc.Close();
        }
    }
}
