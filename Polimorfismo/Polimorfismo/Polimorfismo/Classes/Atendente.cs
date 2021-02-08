using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Atendente:Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto do vale alimentação para o cargo de Atendente R$" + (salario * 0.12));
        }
    }
}
