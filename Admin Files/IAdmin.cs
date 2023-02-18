namespace File_reader
{
    public  interface Admin
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
    public  interface AdminTools
    {
        internal bool Update();
        internal bool Edite();
        internal bool Insert();
        internal bool Delete();
        internal bool DeleteAll();
        internal bool Find(string name);
    }
}