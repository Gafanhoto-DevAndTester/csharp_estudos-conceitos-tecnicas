using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    public class MaquinaDeCafe
    {
        private  Cafeteira cafeteira = new Cafeteira();

        public string ServirCafePuro()
        {
           
            return cafeteira.PrepararCafe();
        }

        public string ServirCafeComLeite()
        {
            
            return cafeteira.PrepararCafeComLeite();
        }
        public string ServirCappucino()
        {
            
            return cafeteira.PrepararUmCappucino();
        }

    }
}
