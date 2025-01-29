using System;
using System.Collections.Specialized;
namespace oop_project__bank_system
{
     public class Start
    {
        public Start() 
        {

            making_account client1 = new making_account();
            making_account client2 = new making_account();
            making_account client3 = new making_account();
            client1._FirstName = "adham";
            client1._LastName = "saadi";
            client1._Password = 12341234;
            client1._Age = 21;
            client1._Address = "tanta 21 staad";
            client1._Balance = 0;
            client1._Id = making_account.s_GlopalId;
            making_account.s_GlopalId++;
            making_account.Clients.Add(client1);
            client2._FirstName = "wael";
            client2._LastName = "yousri";
            client2._Password = 12341234;
            client2._Age = 50;
            client2._Address = "manzala Main street";
            client2._Balance = 0;
            client2._Id = making_account.s_GlopalId;
            making_account.s_GlopalId++;
            making_account.Clients.Add(client2);
            client3._FirstName = "qassem";
            client3._LastName = "mohamed";
            client3._Password = 12341234;
            client3._Age = 21;
            client3._Address = "el rob3";
            client3._Balance = 0;
            client3._Id = making_account.s_GlopalId;
            making_account.s_GlopalId++;
            making_account.Clients.Add(client3);
            while (true)
            {


                Console.WriteLine("                                                  Welcome to our bank");
                Console.WriteLine("Please select if you are a new or old client");
                making_account N_A = new making_account();
                bool HaveAccountflag = false;
                //sign in or make account
                while (true)
                {
                    Console.WriteLine("1- New client ");
                    Console.WriteLine("2- Old client");
                    Console.WriteLine("please enter 1 or 2");
                    string answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        N_A.TakeData();
                        break;
                    }
                    else if (answer == "2")
                    {
                        HaveAccountflag = true;
                        break;
                    }
                    else if (!int.TryParse(answer, out int input) || answer != "2" || answer != "1")
                    {
                        Console.WriteLine("Invalid input please try again");
                    }

                }

                Console.WriteLine("Please enter your account number and password to sign in");
                // signing in
                string A_N;
                string A_P;
                string Cname;
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("account number(ID):");
                        A_N = Console.ReadLine();
                        if (String.IsNullOrEmpty(A_N) || !int.TryParse(A_N, out int input) || A_N.Length != 8)
                        {
                            Console.WriteLine("Please enter a valid ID\n");
                        }
                        else
                        { break; }
                    }

                    while (true)
                    {
                        Console.WriteLine("Password:");
                        A_P = Console.ReadLine();
                        if (String.IsNullOrEmpty(A_P) || !int.TryParse(A_P, out int input) || A_P.Length != 8)
                        {
                            Console.WriteLine("Please enter a valid password from 8 digits\n");
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (N_A.Find_Client(int.Parse(A_N), int.Parse(A_P)) != "-1")
                    {
                        Cname = N_A.Find_Client(int.Parse(A_N), int.Parse(A_P));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("account number or password maybe be wrong please try again");
                    }
                }

                //operations
                while (true)
                {
                    Console.WriteLine($"Welcome {Cname}, What do you want to do today");
                    Console.WriteLine("1- Withdraw\n" +
                                      "2- Deposit\n" +
                                      "3-Check the account\n" +
                                      "4-send money to another account\n" +
                                      "5-Book an appointment ar the branch\n" +
                                      "6-Log out");
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        N_A.Withdraw();
                    }
                    else if (ans == 2)
                    {
                        N_A.Deposit();
                    }
                    else if (ans == 3)
                    {
                        N_A.Check_account();
                    }
                    else if (ans == 4)
                    {
                        N_A.SendMoney();
                    }
                    else if(ans==5)
                    {
                        N_A.MakeAppoiment();
                    }
                    else if (ans == 6)
                    {
                        break;
                    }

                }
            }


        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var s1=new Start();

        }
    }
}