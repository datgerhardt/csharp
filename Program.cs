using System;
using System.Numerics;

namespace Momo
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string x = Console.ReadLine();
            if (x  == "*170#") {

                Console.WriteLine("Menu");
                Console.WriteLine("1) Transfer Money");
                Console.WriteLine("2) MoMo Pay & Pay Bill");
                Console.WriteLine("3) Airtime & Bundle");
                Console.WriteLine("4) Allow Cash Out");
                Console.WriteLine("5) Financial Services");
                Console.WriteLine("6) My Wallet");

                int sel = Convert.ToInt32(Console.ReadLine());

                switch (sel) {
                    case 1:
                
                        Console.WriteLine("Transfer Money");
                        Console.WriteLine("1) MoMo User");
                        Console.WriteLine("2) Non MoMo User");
                        Console.WriteLine("3) Send with Care");
                        Console.WriteLine("4) Favorite");
                        Console.WriteLine("5) Other Networks");
                        Console.WriteLine("6) Bank Account");
                        Console.WriteLine("0) Back");
                    break;

                    case 2:  
                        
                        Console.WriteLine("MoMoPay & PayBill");
                        Console.WriteLine("1) MoMoPay");
                        Console.WriteLine("2) Pay Bill");
                        Console.WriteLine("0) Back");
                    break;

                    case 3:
                
                        Console.WriteLine("Airtime & Bundle");
                        Console.WriteLine("1) Airtime");
                        Console.WriteLine("2) Internet Bundle");
                        Console.WriteLine("3) Fixed Broadband ");
                        Console.WriteLine("0) Back");
                    break;

                    case 4:
                        
                        Console.WriteLine("Allow Cash Out");
                        Console.WriteLine("1) Yes");
                        Console.WriteLine("2) No");
                        Console.WriteLine("0) Back");
                    break;

                    case 5:
                
                        Console.WriteLine("Financial Services");
                        Console.WriteLine("1) Bank Service");
                        Console.WriteLine("2) Savings");
                        Console.WriteLine("3) Loans");
                        Console.WriteLine("4) Pensions and Investments");
                        Console.WriteLine("5) Insurance");
                        Console.WriteLine("6) Trade Share");
                        Console.WriteLine("0) Back");
                    break;

                    case 6:
               
                        Console.WriteLine("My Wallet");
                        Console.WriteLine("1) Check Balance");
                        Console.WriteLine("2) Allows Cash Out");
                        Console.WriteLine("3) My Approvals");
                        Console.WriteLine("4) Report Fraud");
                        Console.WriteLine("5) Statments");
                        Console.WriteLine("6) Change & Reset PIN");
                        Console.WriteLine("7) Airtime");
                        Console.WriteLine("# for next");
                    break;

                   default:

                      Console.WriteLine("Wrong Input");
                    break;

                }





            }


        }
    }
}
