using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterReaderStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Text file using a streamwriter and Write something to the text file
            using (StreamWriter sw = new StreamWriter(@"C:\projetos-cs\EstudosConceitosTecnicas\WriterReaderStream\ExampleTextFile.txt"))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("Kaixo Mundua");
                sw.WriteLine("Hej Verden");
                sw.WriteLine("Bonjour le monde");
                sw.WriteLine("Hello verden");
            }

            //Read the file using a StreamReader and display the contents
            using (StreamReader sr = new StreamReader(@"C:\projetos-cs\EstudosConceitosTecnicas\WriterReaderStream\ExampleTextFile.txt"))
            {
                string s;
                do {
                    s = sr.ReadLine();
                    Console.WriteLine(s);
                } while (s !=null);
            }
            Console.ReadLine();
        }
    }
}
