using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;
namespace ListaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add("Hello");
            al.Add("World");
            al.Add("this");
            al.Add("is");
            al.Add("a");
            al.Add("test");
            foreach ( var arr in al)
            {
                WriteLine(arr.ToString());
            }
            WriteLine("\n:A Seguir removeremos o item 'test' e inseriremos no indice 4 o item 'not' \n");
            al.Remove("test");
            al.Insert(4, "not");
            al.Sort();
            foreach (var arr in al)
            {
                WriteLine(arr.ToString());
            }

            ReadLine();
          
        }
    }
}
