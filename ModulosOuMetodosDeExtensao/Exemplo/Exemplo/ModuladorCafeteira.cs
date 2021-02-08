using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exemplo de Método de Extensão
//O this nos mostra que a propria cafeteira está chamando o método
namespace Exemplo
{
    public static class ModuladorCafeteira
    {
       
        public static string PrepararCafeComLeite(this Cafeteira cafeteira)
        {
            
            return "Preparando Café com Leite... "+ cafeteira.PrepararCafe();
        }

        public static string PrepararUmCappucino(this Cafeteira cafeteira)
        {
            return "Preparando um Cappucino... " + cafeteira.PrepararCafe();
        }
    }
}
