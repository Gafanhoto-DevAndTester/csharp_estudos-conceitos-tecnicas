using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menu_Console_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;

            do
            {
                WriteLine("1 - Addition");
                WriteLine("2 - Subtraction");
                WriteLine("3 - Multiplication");
                WriteLine("4 - Division");

                Write("Choose: ");

                int option = int.Parse(ReadLine());
                int result = 0;

                Clear();

                WriteLine("First number: ");
                int n1 = int.Parse(ReadLine());
                WriteLine("Second number: ");
                int n2 = int.Parse(ReadLine());

                switch (option)
                {
                    case 1:
                        result = n1 + n2;
                        break;
                    case 2:
                        result = n1 - n2;
                        break;
                    case 3:
                        result = n1 * n2;
                        break;
                    case 4:
                        result = n1 / n2;
                        break;

                }
                Clear();
                WriteLine($"Result: {result}");
                Write("Restart (y/n)");

                char c = char.Parse(Console.ReadLine());

                if (c == 'y' || c == 'Y')
                {
                    finished = false;
                }
                else
                {
                    finished = true;
                }
            } while (!finished);
            
        }
    }
}
