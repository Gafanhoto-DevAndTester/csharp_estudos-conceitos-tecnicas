using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Caixa
    {
        private double lado;
        public double Volume(double valor)
        {
            lado = valor;
            return lado * lado * lado;
        }
    }
}
