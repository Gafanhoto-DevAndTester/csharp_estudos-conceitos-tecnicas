using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UsoDePilhas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilha = new Stack();
            int menu = 0;
            while (menu != 1)
            {
                WriteLine("::::Menu::::");
                WriteLine("1 - Sair do Programa");
                WriteLine("2 - Verificar se Pilha está vazia");
                WriteLine("3 - Empilhar");
                WriteLine("4 - Desempilhar");
                WriteLine("5 - Tamanho da pilha");
                WriteLine("6 - Mostrar Topo");
                WriteLine("7 - Limpar Pilha");

                menu = Convert.ToInt32(ReadLine());

                switch (menu)
                {
                    case 2:
                        if (pilha.Count ==0)
                        {
                            WriteLine("Pilha Vazia!");
                        }
                        else
                        {
                            WriteLine("Pilha Não Vazia! ");
                        }
                        break;
                    case 3:
                        WriteLine("Digite o dado que deseja empilhar: ");
                        String dado = ReadLine();
                        pilha.Push(dado);
                        WriteLine(dado+"\n");
                        break;
                    case 4:
                        if (pilha.Count > 0)
                        {
                            String temp = pilha.Pop().ToString();
                            WriteLine(temp);
                        }
                        else
                        {
                            WriteLine("A pilha está vazia!");
                        }
                        break;
                     case 5:
                        int temp2 = pilha.Count;
                        WriteLine(temp2);
                        break;
                    case 6:
                        if (pilha.Count != 0) { 
                        WriteLine(pilha.Peek());
                        }
                        break;
                    case 7:
                        pilha.Clear();
                        WriteLine("A pilha foi limpa!");
                        break;    
                }
            }
        }
    }
}
