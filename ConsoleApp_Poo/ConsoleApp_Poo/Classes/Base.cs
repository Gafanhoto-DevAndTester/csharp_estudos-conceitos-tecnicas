using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Classes
{
   public class Base : IPessoa
    {
        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar(){}
    }
}
