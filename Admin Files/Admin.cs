using System.Data;

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
        internal bool Update();
        internal bool Edite();
        internal bool Insert();
        internal bool Delete();
        internal bool DeleteAll();
        internal bool Find(string name);
    }

    public class adminTools : AdminTools
    {
        public adminTools()
        {
           
        }

        bool AdminTools.Delete()
        {
            throw new NotImplementedException();
        }

        bool AdminTools.DeleteAll()
        {
            throw new NotImplementedException();
        }

        bool AdminTools.Edite()
        {
            throw new NotImplementedException();
        }

        bool AdminTools.Find(string name)
        {
            throw new NotImplementedException();
        }

        bool AdminTools.Insert()
        {
            throw new NotImplementedException();
        }

        bool AdminTools.Update()
        {
            throw new NotImplementedException();
        }
    }

    public class _admin : adminTools, Admin
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
