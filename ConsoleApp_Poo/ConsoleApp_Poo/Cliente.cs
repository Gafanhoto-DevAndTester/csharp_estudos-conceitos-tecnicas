using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Poo
{
    public class Cliente : Base
    {
        public static string Teste;

        public string Nome;
        public string Telefone;
        public string CPF;

        private string sobrenome = "Santos";

        /// <summary>
        /// Construtor com 3 parametros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        /// <summary>
        /// Construtor com 1 parametro
        /// </summary>
        /// <param name="telefone"></param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }
        /// <summary>
        /// Construtor sem parametro
        /// </summary>
        public Cliente() { }


        protected int CalcularUmMaisDois()=> 1 + 2;
        protected int CalcularUmMaisDois2() => 1 + 2;
        protected int CalcularUmMaisDois3() => 1 + 2;
        protected int CalcularUmMaisDois4() => 1 + 2;
        

        public void Gravar(){}

        
    }
}
/*static void Main(string[] args)
{
public virtual void Gravar() {
    var clientes  = Cliente.
}
}
*/

