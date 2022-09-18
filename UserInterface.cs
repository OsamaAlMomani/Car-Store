using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace File_reader
{
    internal class UserInterface
    {
        void intro() 
        {
            string user_enter;
            bool user_value;
            string intro1 = "Hello Customer. Please enter your name : ";
            string intro2 = "It seems like you are not from Car's membership, you can become one of them, it comes with benefits : \n 1) 20% discount on maximum 4 years old.\n 2) Get more notifections on new cars and if there more discounts (Keeps you up-to-date).\n3) you become one of the firstest customer get updates on software.";
            string Subintro2 = "Perfect!, You can complete your operation.";
            string intro3 = "How I Can Serve You? ";
            string intro4_options = "buy (1)\t search for a car (2)\n View list of cars (3) \t Exit (4)";
            Console.WriteLine(intro1);
            user_enter = Console.ReadLine();
            Console.WriteLine("Nice to meet you mr." + user_enter);


            var member_or_not = ismember(user_enter);
            
            if (member_or_not)
            {
                Console.WriteLine("----------------------------------------\n"+intro2);
                Register();
                Console.WriteLine(Subintro2);
                Console.WriteLine(intro4_options);
                int Value_ = int.Parse(Console.ReadLine());
                options(Value_,true);



            }
            else
            {
                Console.WriteLine(intro3);
                Console.WriteLine(intro4_options);
                int Value_ = int.Parse(Console.ReadLine());
                options(Value_, true);
            }


        }

        // (1)
        void buy() { Console.Write("Worked"); }
        

        // (2)
        void search(string query) 
        {
            Car car = new Car();
            car.print(query);

        }

        bool ismember(string member)
        {
            var cus = new Customers();
            return cus.finder(member);
        }

        void View_List(string Listname) { }
        
        void NewMember(string Membername) { }
        
        string choose() { return "1"; }
        
        void Register() { }
        
        void options(int number,bool value)
        {
            switch (number)
            {
                case 1:
                    buy();
                    break;
                
                case 2:
                    step2();
                    break;
                
                case 3:
                    Car car = new Car();
                    //car.print();
                    break;

               case 4:
                    Environment.Exit(0);
                    break;

                default:
                    if (value)
                    {
                        int Second_try = int.Parse (Console.ReadLine());
                       options(Second_try,false);
                    }
                    else
                    {
                        Environment.Exit (0);
                    }
                    break;
            }
        }

        private void step2()
        {
            List<int> IDs = new List<int>();
            string Carsname = Console.ReadLine();
            search(Carsname);
            Console.WriteLine("How much cars do you want? ");
            var value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ID/\'s : ");
            for (int i = 1; i <= value; i++)
            {
                Console.Write(i + "- ");
                IDs.Add(int.Parse(Console.ReadLine()));
            }
        }

        public UserInterface()
        {
            Car car = new Car();

            Customers customers = new Customers();

            intro(); 
        }

    }
}
