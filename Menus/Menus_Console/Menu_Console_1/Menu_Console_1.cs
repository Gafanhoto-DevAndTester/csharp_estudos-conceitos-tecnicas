using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus_Console
{
    class Menu_Console_1
    {
        static void Main(string[] args)
        {
            var index = 0;

            List<string> MenuItem = new List<string>()
            {
                "One",
                "Two",
                "Exit"
            };
            Console.CursorVisible = false;

            while (true)
            {
                for (int i =0;i < MenuItem.Count;i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(MenuItem[i]);
                    }
                    else
                    {
                        Console.WriteLine(MenuItem[i]);
                    }
                    Console.ResetColor();
                }

                ConsoleKeyInfo ckey = Console.ReadKey();

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (index == MenuItem.Count - 1)
                    {
                       index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    Console.Clear();
                }
                else if (ckey.Key == ConsoleKey.UpArrow) {
                    if (index <= 0)
                    {
                        index = MenuItem.Count - 1;
                    }
                    else
                    {
                        index--;
                    }
                    Console.Clear();
                    Console.ReadKey();
                }
            }


        }
    }
}
