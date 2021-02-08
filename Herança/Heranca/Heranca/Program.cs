using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Cliente
    {
        public Cliente() { }

        public static string Teste;

        public string Nome;
        public string Telefone;
        public string CPF;

        private string sobrenome = "Santos";

        public void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if(File.Exists(caminhoBaseClientes()))
        }
    }
}
