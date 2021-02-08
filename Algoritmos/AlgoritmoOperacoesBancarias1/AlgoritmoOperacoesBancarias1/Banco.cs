using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoOperacoesBancarias1
{
    class Banco
    {
        public double dinheiro;

        public void Sacar(double valor)
        {
            dinheiro -= valor;
        }

        public void Depositar(double valor)
        {
            dinheiro += valor;
        }

        public void Transferir(Banco conta, double valor)
        {
            Sacar(valor);
            conta.Depositar(valor);
        }

    }
}
