using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Virtuais
{
    /*
     
        Métodos virtuais são métodos de mesmo nome na classe base mas que podem ser sobrescritos nas derivadas
         */
    class Base
    {
        //A Classe base será utlizada apenas para herança
        public Base()
        {
            Console.WriteLine("Constructor da Classe Base");
        }
        virtual public void info(){}//Como o método info será sobrescrito faz mais sentido apenas declarar a assinatura do método
        //Dessa forma cada classe irá implementar o seu próprio méodo info
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Constructor da Classe Derivada 1");
        }
         override public void info()
        {
            Console.WriteLine("Derivada 1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Constructor da Classe Derivada 2");
        }
        override public void info()
        {
            Console.WriteLine("Derivada2");
        }
    }

    class MetodosVirtuais
    {
        static void Main()
        {
            Base Ref; //Ref- é um elemento de referencia que pode receber as classes derivadas da base
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();

            Ref = derivada2;// ou derivada1

            Ref.info();


            /*
            Base base1 = new Base();
            base1.info();
            Console.WriteLine();

            Derivada2 derivada2 = new Derivada2();
            derivada2.info();
            */
            Console.ReadLine();
        }
      
    }
}
