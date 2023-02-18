using System.Data;

namespace File_reader
{
    

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
