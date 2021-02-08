using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class MinhaClasseLista
    {
        
        object[] data = new object[10];
        
        public int this[object o]
        {
            get {
                return Array.IndexOf(data, o);
            }
        }

        public object this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }
        //utilizando Matrix
        object[,] data2 = new object[10,10];

        public object this[int i,int j]
        {
            get { return data2[i, j]; }
            set { data2[i,j] = value; }
        }
    }
}
