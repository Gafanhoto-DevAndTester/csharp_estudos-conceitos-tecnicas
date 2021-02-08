using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editing
{
    class Program
    {
        static void Main(string[] args)
        {
            addRecord("124", "Mercy", "20", "Cake.txt");
            addRecord("123", "Josy", "11", "Cake.txt");
            addRecord("122", "Kelly", "32", "Cake.txt");
            addRecord("121", "Joan", "56", "Cake.txt");
            
            Console.WriteLine(string.Join("", readRecord("122", "Cake.txt", 1)));

            editRecord("122", "Cake.txt", 1, "2011", "Katarina", "12");
            Console.WriteLine(string.Join("", readRecord("2011", "Cake.txt", 1)));

            deleteRecord("123","Cake.txt",1);

            Console.WriteLine(string.Join("",readRecord("123","Cake.txt",1)));

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

        public static string[] readRecord(string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = { "Record Not Found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');

                    if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("RecordFound");
                        return fields;
                    }
                }
                return recordNotFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine("This program did an oopsie");
                return recordNotFound;
                throw new ApplicationException("This program did an oopsie", ex);
            }
        }

        public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }
        public static void editRecord(string searchTerm,string filePath,int positionOfSearchTerm ,string fieldOne,string fieldTwo,string fieldThree)
        {
            positionOfSearchTerm--;
            string tempFile = "temp.txt";
            bool edited = false;

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                //find the record to be edited
                for (int i = 0; i<lines.Length;i++)
                {
                    string[] fields = lines[i].Split(',');

                    if (!(recordMatches(searchTerm, fields, positionOfSearchTerm)))
                    {
                        addRecord(fields[0], fields[1], fields[2], tempFile);
                    }
                    else
                    {
                        if (!edited)
                        {
                            addRecord(fieldOne,fieldTwo,fieldThree,tempFile);
                            Console.WriteLine("Edited Him");
                            edited = true;
                        }
                    }
                }
                //Delete old file
                File.Delete(filePath);

                //Rename new file
                System.IO.File.Move(tempFile, filePath);
                Console.WriteLine("Record edited");
            }
            catch(Exception e)
            {
                Console.WriteLine("This program did an oopsie");
                throw new ApplicationException("This program did an oopsie: ",e);
            }
        }

        public static void deleteRecord(string searchTerm,string filepath,int positionOfSearchterm)
        {
            positionOfSearchterm--;
            string tempFile = "temp.txt";
            bool deleted = false;

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (!(recordMatches(searchTerm, fields, positionOfSearchterm)) || deleted)
                    {
                        addRecord(fields[0], fields[1], fields[2], tempFile);
                    }
                    else
                    {
                        deleted = true;
                        Console.WriteLine("Got Him");
                    }
                }
                File.Delete(filepath);
                System.IO.File.Move(tempFile,filepath);
            }
            catch (Exception e)
            {
                Console.WriteLine("This program did an oopsie");
                throw new ApplicationException("This program did an oopsie: ",e);
            }
        }
    }
}
