using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFromACsvFileAndSearchingARecord
{
    class Program
    {
        static void Main(string[] args)
        {
            addRecord("124", "Mercy", "20", "Cake.txt");
            addRecord("123", "Josy", "11", "Cake.txt");
            addRecord("122", "Kelly", "32", "Cake.txt");
            addRecord("121", "Joan", "56", "Cake.txt");
            Console.WriteLine(string.Join("",readRecord("122","Cake.txt",1)));
            Console.ReadLine();
        }

        public static void addRecord(string ID, string name, string age, string filePath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath, true))
                {
                    file.WriteLine(ID + ", " + name + ", " + age);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Program did an oopsie: ", ex);
            }
        }

        public static string[] readRecord (string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = { "Record Not Found" };

            try {
                string[] lines = System.IO.File.ReadAllLines(filepath);
                for (int i = 0;i <lines.Length;i++)
                {
                    string[] fields = lines[i].Split(',');

                    if (recordMatches(searchTerm,fields,positionOfSearchTerm))
                    {
                        Console.WriteLine("RecordFound");
                        return fields;
                    }
                }
                return recordNotFound;
            } catch (Exception ex)
            {
                Console.WriteLine("This program did an oopsie");
                return recordNotFound;
                throw new ApplicationException("This program did an oopsie",ex);
            }
        }

        public static bool recordMatches(string searchTerm,string[]record,int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }
    }
}
