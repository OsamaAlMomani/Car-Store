using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace File_reader
{

    public class Car
    {
        bool value = true;
        string newLine = "*-------------------------------------------------------------------------------------------*";
        string Path_Cars_File = @"C:\Users\osama\source\repos\File reader\Cars Files\Cars.csv";

        //ID,Brand ,Price,Rating ,Review,Number of Cars,IsSoled
        List<int> Payments;
        List<int> ID;
        List<string> Brand;
        List<int> Price;
        List<int> Rating;
        List<string> Review;
        List<int> InStock;
        List<string> Soled;
        void insitialze ()
        {
            Payments = new List<int>(); 
            ID = new List<int> ();  
            Brand = new List<string> ();
            Price = new List<int>();
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
                        Fill(int.Parse(split_[0]), split_[1], int.Parse(split_[2]), int.Parse(split_[3]), split_[4], int.Parse(split_[5]), split_[6]);
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
        
        void Fill(int id,string brand,int price,int rating,string review,int instock, string soled)
        {
            ID.Add (id);
            Brand.Add (brand);
            Price.Add (price);
            Rating.Add (rating);
            Review.Add (review);
            InStock.Add (instock);
            Soled.Add (soled);
        }
        
        public List<int> print(string need) 
        {

            Payments = Enumerable.Range(0, Brand.Count).Where(i => Brand[i] == need).ToList();
            printByIndex(Payments);
            return Payments;
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
        public int SetBasket(List<int>_list)
        {
            int Amount =0;
            
            foreach (var item in _list)
            {
                int i = 0;
                foreach (var item1 in ID)
                {
                   
                    if (item == item1)
                    {
                        Amount += Price[i];
                        break;
                    }
                    i++;
                }
                
            }
            return Amount;
        }



    }
}
/*
 future work : make encription and decription + mac csv file for each user + 
*/