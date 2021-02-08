using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoOperacoesBancarias1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b1 = new Banco();
            b1.Depositar(3000);

            Banco b2 = new Banco();
            b2.Depositar(1233);

            b1.Transferir(b2, 500);
            Console.WriteLine($"B2 tem :{b2.dinheiro} e B1 agora tem:{b1.dinheiro}");

            Console.ReadKey();
        }
    }
}
