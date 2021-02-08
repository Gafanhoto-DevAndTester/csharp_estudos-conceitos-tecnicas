using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingACsvFile
{
    class Program
    {
        static void Main(string[] args)
        {
            addRecord("124","Mercy","20","Cake.txt");
            addRecord("123","Josy","11","Cake.txt");
            addRecord("122","Kelly","32","Cake.txt");
            addRecord("121","Joan","56","Cake.txt");
        }

        public static void addRecord(string ID,string name,string age,string filePath)
        {
            try {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath, true))
                {
                    file.WriteLine(ID+", "+name+", "+age);
                }
            } catch (Exception ex)
            {
                throw new ApplicationException("Program did an oopsie: ",ex);
            }
        }
    }
}
