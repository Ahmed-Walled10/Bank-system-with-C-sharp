using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oop_project__bank_system
{

    public class making_account
    {
        public static List<making_account> Clients = new List<making_account>();

        private static int s_DatabaseIndex = 0;
        public static int s_GlopalId = 10001000;
        private readonly int _MaxWithdraw = 1000;

        internal string _FirstName;
        public string Firstname
        {
            get { return _FirstName; }

        }
        internal string _LastName { get; set; }
        internal int _Password { get; set; }
        internal int _Age { get; set; }
        internal string _Address { get; set; }
        internal int _Id { get; set; }
        internal decimal _Balance = 0;


        making_account the_client;
        public void TakeData()//(string FirstName, string LastName, int Password, int Age, string Address)
        {
            the_client = new making_account();
            Clients.Add(the_client);

            Console.WriteLine($"Please enter you'r information\n");

            while (true)
            {
                Console.WriteLine("First Name:");
                string FirstName = Console.ReadLine();
                if (String.IsNullOrEmpty(FirstName) || FirstName.Any(char.IsDigit))
                {
                    Console.WriteLine("Please enter a valid name\n");
                }
                else
                {
                    _FirstName = FirstName;
                    Clients[s_DatabaseIndex]._FirstName = FirstName;
                    break;
                }
            }//first name
            while (true)
            {
                Console.WriteLine("Last Name:");
                string LastName = Console.ReadLine();
                if (String.IsNullOrEmpty(LastName) || LastName.Any(char.IsDigit))
                {
                    Console.WriteLine("Please enter a valid name\n");
                }
                else
                {
                    _LastName = LastName;
                    Clients[s_DatabaseIndex]._LastName = LastName;
                    break;
                }
            }//last name
            while (true)
            {
                Console.WriteLine("Account Password:");
                string Password = Console.ReadLine();
                if (String.IsNullOrEmpty(Password) || !int.TryParse(Password, out int input) || Password.Length > 8 || Password.Length < 8)
                {
                    Console.WriteLine("Please enter a valid password from 8 digits\n");
                }
                else
                {
                    _Password = int.Parse(Password);
                    Clients[s_DatabaseIndex]._Password = _Password;
                    break;
                }
            }// password
            while (true)
            {
                Console.WriteLine("Age:");
                string Age = Console.ReadLine();
                if (String.IsNullOrEmpty(Age) || !int.TryParse(Age, out int input))
                {
                    Console.WriteLine("Please enter a valid age\n");
                }
                else if (int.Parse(Age) < 14 || int.Parse(Age) > 100)
                {
                    Console.WriteLine("the age limit is from 14 to 100");
                }
                else
                {
                    _Age = int.Parse(Age);
                    Clients[s_DatabaseIndex]._Age = int.Parse(Age);
                    break;
                }
            }//age
            while (true)
            {
                Console.WriteLine("Address:");
                string Address = Console.ReadLine();
                if (String.IsNullOrEmpty(Address))
                {
                    Console.WriteLine("Please enter a valid Address\n");
                }
                else
                {
                    _Address = Address;
                    Clients[s_DatabaseIndex]._Address = _Address;
                    break;
                }
            }//address
            _Id = s_GlopalId;
            Clients[s_DatabaseIndex]._Id = _Id;
            s_GlopalId++;
            Console.WriteLine($"You'r account number is {Clients[s_DatabaseIndex]._Id}\n");
            Clients[s_DatabaseIndex]._Balance = _Balance;
            s_DatabaseIndex++;

        }
        making_account The_client;
        public string Find_Client(int account_ID, int password)
        {
            The_client = Clients.Find(c => c._Id == account_ID);
            if (The_client != null)
            {
                if (The_client._Password == password)
                {
                    return The_client._FirstName;
                }
                else
                {
                    return "-1";
                }
            }
            else
            {
                return "-1";
            }
        }
        public void Withdraw()
        {

            Console.WriteLine("How much do you want to withdraw\n");
            string wanted_money = Console.ReadLine();
            if (String.IsNullOrEmpty(wanted_money) || !int.TryParse(wanted_money, out int input))
            {
                Console.WriteLine("please put valid number");
            }
            else if (int.Parse(wanted_money) <= 0 || int.Parse(wanted_money) > _MaxWithdraw)
            {
                Console.WriteLine($"sorry but the withdraw is from 0 to {_MaxWithdraw}");
            }
            else if (int.Parse(wanted_money) > The_client._Balance)
            {
                Console.WriteLine("the account dose not have enought balance\n");
            }
            else
            {
                The_client._Balance -= int.Parse(wanted_money);
                Console.WriteLine($"[{DateTime.Now}] successful withdrawing\n" +
                                  $"you'r current balance is {The_client._Balance}\n");
            }
        }

        public void Deposit()
        {
            Console.WriteLine("How much do you want to deposit");
            string amount = Console.ReadLine();
            if (String.IsNullOrEmpty(amount) || !int.TryParse(amount, out int input) || int.Parse(amount)<=0)
            {
                Console.WriteLine("please put valid number");
            }
            else
            {
                The_client._Balance += int.Parse(amount);
                Console.WriteLine($"[{DateTime.Now}]the balance has been updated\n" +
                                  $"you'r current balance is {The_client._Balance}\n");
            }
        }

        public void Check_account()
        {
            Console.WriteLine($"Name:{The_client._FirstName} {The_client._LastName}\n" +
                              $"Age:{The_client._Age}\n" +
                              $"Address:{The_client._Address}\n" +
                              $"Account number{The_client._Id}\n" +
                              $"Current balance:{The_client._Balance}\n");
        }

        public void SendMoney()
        {
            Console.WriteLine("please enter account number you want to send money to");
            string Account_num = Console.ReadLine();
            if (String.IsNullOrEmpty(Account_num) || !int.TryParse(Account_num, out int input))
            {
                Console.WriteLine("please put valid number");
            }
            else
            {
                making_account transferclient = Clients.Find(c => c._Id == int.Parse(Account_num));
                if (transferclient == null)
                {
                    Console.WriteLine("There is no account at that number please try again");
                }
                else
                {
                    Console.WriteLine("please enter the amount you want to send");
                    string theamount = Console.ReadLine();
                    if (int.Parse(theamount) > The_client._Balance)
                    {
                        Console.WriteLine("the account dose not have enough balance\n");
                    }
                    else if (int.Parse(theamount) == The_client._Id)
                    {
                        Console.WriteLine("you can't send money to yourself");
                    }
                    else
                    {
                        The_client._Balance -= int.Parse(theamount);
                        transferclient._Balance += int.Parse(theamount);
                        Console.WriteLine($"[{DateTime.Now}] successful transfer\n" +
                                          $"you'r current balance is {The_client._Balance}\n");
                    }
                }
            }
        }

        private static Dictionary<string, string> weekappoiments = new Dictionary<string, string>();
        private static bool  AppoimentFlag=false;
        void theappoiments()
        {
            for (int i = 1; i <= 7; i++)
            {
                string day = DateTime.Today.AddDays(i).DayOfWeek.ToString();
                weekappoiments[day]= "empty" ;
            }
            AppoimentFlag = true;
        }
        
        public void MakeAppoiment()
        {
            if (!AppoimentFlag)
            {
                theappoiments();
            }
            Console.WriteLine("the avalibale days for appoiments is:");
            int i = 1;
            foreach (var entry in weekappoiments)
            {
                Console.WriteLine($"{i}-{entry.Key}: {entry.Value}");
                i++;
            }
            Console.WriteLine("\n which day do you want(1-7)");
            string theday = Console.ReadLine();
            if (weekappoiments[theday] == "busy")
            {
                Console.WriteLine("it's taken please select another day");
            }
            else
            {
                weekappoiments[theday] = "busy";
                Console.WriteLine("the appoiment has been reserved \n");
            }
        }

    }


}
