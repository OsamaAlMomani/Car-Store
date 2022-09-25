namespace File_reader.UI.Scripts
{
    internal class UserInterface : Car
    {
        bool Global_value = false;
        string namefromstep2;
        void intro()
        {

            string user_enter;
            bool user_value;
            string intro1 = "Hello Customer. Please enter your name : ";
            string intro2 = "It seems like you are not from Car's membership, you can become one of them, it comes with benefits : \n 1) 20% discount on maximum 4 years old.\n 2) Get more notifections on new cars and if there more discounts (Keeps you up-to-date).\n3) you become one of the firstest customer get updates on software.";
            string Subintro2 = "Perfect!, You can complete your operation.";
            string intro3 = "How I Can Serve You? \n";
            string intro4_options = "search for a car (1)\nView list of cars (2)\nExit (3)";


            Console.WriteLine(intro1);

            user_enter = Console.ReadLine();

            Console.WriteLine("Nice to meet you mr." + user_enter + "\n");


            var member_or_not = ismember(user_enter);

            if (!member_or_not)
            {
                throw new Exception("not complete...");
                Environment.Exit(0);
                Console.WriteLine("----------------------------------------\n" + intro2);
                //*******************
                Console.WriteLine(Subintro2);
                Console.WriteLine(intro4_options);
                int Value_ = int.Parse(Console.ReadLine());
                options(Value_, true);
            }
            else
            {
                Console.WriteLine(intro3);
                Console.WriteLine(intro4_options);
                int Value_ = int.Parse(Console.ReadLine());
                options(Value_, true);
            }


        }



        // (2)
        void search(string query)
        {
            print(query);
        }

        bool ismember(string member)
        {
            var cus = new Customers();
            return cus.finder(member);
        }

        void options(int number, bool value)
        {
            switch (number)
            {

                case 1:
                    step1(Global_value);
                    break;

                case 2:
                    step2(Global_value);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    if (value)
                    {
                        int Second_try = int.Parse(Console.ReadLine());
                        options(Second_try, false);
                    }
                    else Environment.Exit(0); break;
            }
        }

        private void step2(bool local_value)
        {

            print_All();
            Console.WriteLine("Are you looking for spicific car ???");
            Console.Write("yes[1]  No[2] : ");
            int value = int.Parse(Console.ReadLine());
            if (value == 1)
            {
                Console.Write("Enter the name :"); namefromstep2 = Console.ReadLine();
                step1(!local_value);
            }
            else
            {
                Environment.Exit(0);
            }

        }

        private void step1(bool local_value)
        {
            List<int> IDs = new List<int>();
            if (local_value)
            {
                Console.Clear();
                search(namefromstep2);
                Console.WriteLine("How much cars do you want? ");
                var value = int.Parse(Console.ReadLine());
               
                Console.WriteLine("Enter the ID\\ \'s : ");
                
                for (int i = 1; i <= value; i++)
                {
                    Console.Write(i + "- ");
                    IDs.Add(int.Parse(Console.ReadLine()));
                }
                SetPayment(IDs);
            }
            else
            {
                Console.Clear();
                string Carsname = Console.ReadLine();
                search(Carsname);

                Console.WriteLine("How much cars do you want? ");
                var value = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the ID\\ \'s : ");
                for (int i = 1; i <= value; i++)
                {
                    Console.Write(i + "- ");
                    IDs.Add(int.Parse(Console.ReadLine()));
                }
                SetPayment(IDs);
            }
        }

        private void SetPayment(List<int> payment)
        {
            Console.WriteLine("Total amount: " + SetBasket(payment));
            Console.WriteLine("Thanks for visited our store <3");
        }

        public UserInterface()
        {
            Customers customers = new Customers();
            intro();
        }

    }
}
