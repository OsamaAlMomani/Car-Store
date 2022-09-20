using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace File_reader
{
    internal class Customers
    {
        string Path_Customer_File = @"C:\Users\osama\source\repos\File reader\Customer Files\Customer.csv";
        //Customer,Age,Budget,Brand
        List<string> Name_Of_Customer = new List<string>();
        List<int> Age = new List<int>();
        List<float> Budget = new List<float>();
        List<string> Brand = new List<string>();
        // Insert all data inside List To manage them...
        public Customers()
        {
            try
            {
                
                List<string> Line = File.ReadAllLines(Path_Customer_File).ToList();
                bool value = false;

                foreach (var item in Line)
                {
                    string[] DataFile = item.Split(',');
                    if (value)
                        fill(DataFile[0], int.Parse(DataFile[1]), float.Parse(DataFile[2]), DataFile[3]);
                    else
                        value = true;
                }

            }
            catch (IOException e)
            {
                Console.Error.WriteLine("Customer's File Access Error : " + e.Message);
            }
        }
        void fill(string name, int age, float money, string cars_name)
        {
            try
            {
                Name_Of_Customer.Add(name);
                Age.Add(age);
                Budget.Add(money);
                Brand.Add(cars_name);
            }
            catch (InvalidDataException ex)
            {
                Console.Error.WriteLine("Inide Class//Customer//Fill Function// Data Type Error "+ex.Message);
            }
        }
        public void print (string Column)
        {
            switch (Column)
            {       
                case "name":
                    for (int i = 0; i < Name_Of_Customer.Count; i++)
                    {
                        Console.WriteLine(Name_Of_Customer[i]);
                    }
                    break;
                case "age":
                    for (int i = 0; i < Age.Count; i++)
                    {
                        Console.WriteLine(Age[i]);
                    }
                    break;
                case "budget":
                    for (int i = 0; i < Budget.Count; i++)
                    {
                        Console.WriteLine(Budget[i]);
                    }
                    break;
                case "brand":
                    for (int i = 0; i < Brand.Count; i++)
                    {
                        Console.WriteLine(Brand[i]);
                    }
                    break;
                
                default:
                    throw new Exception(Column + "Unexist");
                    break;
            }
        }

        public bool finder (string name)
        {
            for (int i = 0; i < Name_Of_Customer.Count; i++)
                if (Name_Of_Customer[i] == name)    
                    return true;
            return false;
        }
        //
        void printByIndex(int i) { throw new Exception("\"printByIndex\" function in Customer Class is not Implemented ..."); }


        // Delete Everything Unnecessary
        ~Customers()
        {

        }


    }
}
