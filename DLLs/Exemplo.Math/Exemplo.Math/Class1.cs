using System;

namespace Exemplo.Math
{
    namespace Functions
    {
        /// <summary>
        /// Classe que calcula a Função sigmoid
        /// </summary>
        public class Sigmoid
        {

            public static double Calculate(double x)
            {
                return 1.0 /(1.0+System.Math.Exp(-x));
            }
        }
    }
    
}
