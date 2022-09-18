using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace File_reader
{

    public class Car
    {
        string newLine = "*-------------------------------------------------------------------------------------------*";
        string Path_Cars_File = @"C:\Users\osama\source\repos\File reader\Cars.csv";

        //ID,Brand ,Price,Rating ,Review,Number of Cars,IsSoled

        List<decimal> ID;
        List<string> Brand;
        List<decimal> Price;
        List<int> Rating;
        List<string> Review;
        List<int> InStock;
        List<string> Soled;
        void insitialze ()
        {
            ID = new List<decimal> ();  
            Brand = new List<string> ();
            Price = new List<decimal>();
            Rating = new List<int> ();
            Review = new List<string> ();
            InStock = new List<int> ();
            Soled = new List<string> ();
        }
        public Car ()
        {
            insitialze ();
            try
            {
                List<string> Line = File.ReadAllLines(Path_Cars_File).ToList();
                bool valeu = false;

                foreach (var item in Line)
                {
                    string[] split_ = item.Split(",");
                    if (valeu)
                    {
                        Fill(decimal.Parse(split_[0]), split_[1], decimal.Parse(split_[2]), int.Parse(split_[3]), split_[4], int.Parse(split_[5]), split_[6]);
                    }
                    else
                        valeu = true;
                }

            }
            catch (IOException e)
            {
                Console.Error.WriteLine("Car's File Access Error : " + e.Message);
            }
        }
        
        void Fill(decimal id,string brand,decimal price,int rating,string review,int instock, string soled)
        {
            ID.Add (id);
            Brand.Add (brand);
            Price.Add (price);
            Rating.Add (rating);
            Review.Add (review);
            InStock.Add (instock);
            Soled.Add (soled);
        }
        
        public void print(string need) 
        {

            var result = Enumerable.Range(0, Brand.Count).Where(i => Brand[i] == need).ToList();
            printByIndex(result);
        }

        void printByIndex(List<int> i) 
        {
            //throw new Exception("\"printByIndex\" function in Car Class is not Implemented ...");
            foreach (var item in i)
            {
                //ID,Brand ,Price,Rating ,Review,Number of Cars,IsSoled

                Console.WriteLine(newLine+"\n"+"ID: " + ID[item] + "   Brand: " + Brand[item] + "   Price: " + Price[item] + "   Rating: " + Rating[item] + "   Review: " + Review[item] + "   Number of Cars: " + InStock[item]);
            }
        }
        
    
        
    }
}
/*
 future work : make encription and decription + mac csv file for each user + 
 */