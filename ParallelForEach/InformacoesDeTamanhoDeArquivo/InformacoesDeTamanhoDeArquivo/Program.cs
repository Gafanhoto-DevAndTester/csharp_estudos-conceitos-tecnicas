using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CodeBits;
using static System.Console;

namespace InformacoesDeTamanhoDeArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //para filtrar os arquivos 
            //se atente ao método GetFiles("*")
            //mude o parametro para por exemplo: GetFiles("*.png") 
            //com isso o sistema irá fazer o search em todos os arquivos com extensão .png
            try
            {
                new DirectoryInfo(@"C:\Users\Roberto\Desktop\Wallpapers").GetFiles("*", SearchOption.AllDirectories).ToList().ForEach((i) =>
                {
                    WriteLine(string.Format("Arquivo: {0} - Tamanho: {1}", i.FullName, ByteSizeFriendlyName.Build(i.Length)));
                });
            } catch (Exception erro)
            {
                throw new Exception("Erro ao processar os arquivos: "+erro.Message);
            }


           
            ReadKey();
        }
    }
}
