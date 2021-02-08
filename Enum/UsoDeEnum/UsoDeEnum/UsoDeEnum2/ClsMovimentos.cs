using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeEnum2
{
    class ClsMovimentos
    {
        public enum movimentos
        { Cima, Baixo, Esquerda, Direita, Diagonal }

        public void ValidaMov(movimentos direcao)
        {
            if (direcao == movimentos.Diagonal)
            {
                Console.WriteLine("Este Movimento não será aceito!");//cw + dois tabs
            }
            else
            {
                Console.WriteLine("O movimento selecionado foi: "+direcao);
            }
        }
    }
}
