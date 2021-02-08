using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeConstrutores
{
    class Pessoa
    {

        /*Construtor Simples  */
        private string nome;
        public Pessoa(string nome)
        {
            this.nome = nome;
        }
      
        /*Construtor overload*/
        private string Nome { get; set; }
        private string Apelido { get; set; }
        private int Idade { get; set; }
        private string CEP { get; set; }
        private int Codigo_Vip{get;set;}
       

        public Pessoa(string _nome,string _apelido)
        {
            Nome = _nome;
            Apelido = _apelido;
        }

        public Pessoa(string _nome, string _apelido, int _idade, string _cep,int _codigo_vip)
        {
            Nome = _nome;
            Apelido = _apelido;
            Idade = _idade;
            CEP = _cep;
            Codigo_Vip = _codigo_vip;
            
        }

        public string FalarNome()
        {
            return $"Olá, {nome}. Bem Vindo!";
        }

        public string DefinirNickname()
        {
            Console.WriteLine();
            return $"{Nome}, seu Nickname foi definido e ele é: {Apelido}\n.";
        }

        public string InformacoesEssenciais()
        {
            Console.WriteLine();
            return $"Nome de Usuário: {Nome},\n" +
                $"Nickname: {Apelido},\n" +
                $"Idade: {Idade},\n" +
                $"CEP: {CEP},\n" +
                $"Código: {Codigo_Vip}";
        }

        static void Main(string[] args)
        {
            var pessoa = new Pessoa("Nataniel");
            Console.WriteLine(pessoa.FalarNome());

            var pessoa2 = new Pessoa("Roberto", "RobDino");
            Console.WriteLine(pessoa2.DefinirNickname());

            var pessoa3 = new Pessoa("Fernanda", "Linda", 24, "09231-900", 0111);
            Console.WriteLine(pessoa3.InformacoesEssenciais());

            Console.ReadKey();
            
        }
    }
}
