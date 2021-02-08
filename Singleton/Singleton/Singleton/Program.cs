using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Email.Instancia.Corpo="blá blá blá";
            Email.Instancia.Titulo = "Titulo do Email";
            Email.Instancia.Destino = "email@algumEmail.com";
            Email.Instancia.Origin = "jos@gmail.com";

            Email.Instancia.EnviarEmail();
        }
    }
}
