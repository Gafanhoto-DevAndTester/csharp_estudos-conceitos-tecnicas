using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCPF
{
    public class GeradorDeCPF { 
    public static String GerarCpf()
    {
        
        int soma = 0, resto = 0;
        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        Random rnd = new Random();

        string partes = rnd.Next(100000000,999999999).ToString();

        for (int i = 0; i < 9; i++)
            soma += int.Parse(partes[i].ToString()) * multiplicador1[i];

        resto = soma % 11;

        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        partes = partes + resto; //obtemos o  10º algorismo
            soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(partes[i].ToString()) * multiplicador2[i];

        resto = soma % 11;

        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        partes = partes + resto; //obtemos o 11º algorismo  completando 11 digitos 
        return partes;
     }
    }
}

//https://www.somatematica.com.br/faq/cpf.php