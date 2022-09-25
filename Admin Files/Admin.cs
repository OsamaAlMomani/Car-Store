using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_reader
{
    internal interface Admin
    {

        internal bool age(int _age);
        internal bool brand(string _brand);
        internal bool name(string _name);
        internal bool Register();
        internal bool Login();
        internal bool carname(string carname_);
        internal bool carrating(int rating);
        internal bool carId(int id);
        internal bool carprice(int price);
        internal bool carreview(string review);
        internal bool NOcar(int number);
        internal bool carhere(bool here);
    }
    internal interface AdminTools
    {

    }
    
    public class adminTools : AdminTools
    {
        public adminTools()
            {

            }    
    }

    public class _admin : adminTools,Admin
    {
        string Path_Customer_File = @"C:\Users\osama\source\repos\File reader\Customer Files\Customer.csv";
        string Path_Cars_File = @"C:\Users\osama\source\repos\File reader\Cars Files\Cars.csv";

        bool Admin.age(int _age)
        {
            throw new NotImplementedException();
        }

        bool Admin.brand(string _brand)
        {
            throw new NotImplementedException();
        }

        bool Admin.carhere(bool here)
        {
            throw new NotImplementedException();
        }

        bool Admin.carId(int id)
        {
            throw new NotImplementedException();
        }

        bool Admin.carname(string carname_)
        {
            throw new NotImplementedException();
        }

        bool Admin.carprice(int price)
        {
            throw new NotImplementedException();
        }

        bool Admin.carrating(int rating)
        {
            throw new NotImplementedException();
        }

        bool Admin.carreview(string review)
        {
            throw new NotImplementedException();
        }

        bool Admin.Login()
        {
            throw new NotImplementedException();
        }

        bool Admin.name(string _name)
        {
            throw new NotImplementedException();
        }

        bool Admin.NOcar(int number)
        {
            throw new NotImplementedException();
        }

        bool Admin.Register()
        {
            throw new NotImplementedException();
        }
        public _admin()
        {

        }
    }
}
