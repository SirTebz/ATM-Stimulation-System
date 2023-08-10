using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Introduction:

             *This Command-Line User Interface(CLI)-based ATM Stimulation System offers a clear and easy way to execute withdrawals, deposits, and check balances. C# is the programming language used to create it.The system includes a simple command line interface with a switch case for executing deposits, withdrawals, and balance checks.It also updates the current balance after each operation. Anyone who needs to quickly calculate deposits and withdrawals should use this system.So, sit back, make a cup of coffee, and start calculating the amount in the ATM Stimulation System.
             
             * Explanation:
              
             * This Command-Line User Interface (CLI)-based ATM Stimulation System offers a clear and easy way to execute withdrawals, deposits, and check balances. The system includes a simple command line interface with a switch case for executing deposits, withdrawals, and balance checks. It also updates the current balance after each operation.
             */

            //Declare and initialize balance, withdraw and deposit
            double balance = 5000, withdraw, deposit;

            while (true)
            {
                Console.WriteLine("...Automatic Teller Machine...\n");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance\n");
                

                Console.Write("Choose the operation you want to perform: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Get withdrawal amount from user
                        Console.Write("Enter amount to be withdrawn: ");
                        withdraw = double.Parse(Console.ReadLine());

                        if (balance >= withdraw)
                        {
                            //remove withdrawal amount from the total balance
                            balance = balance - withdraw;
                            Console.WriteLine("Please collect your amount.\n");
                        }
                        else
                        {
                            //insufficient error message
                            Console.WriteLine("Insufficient funds\n");
                        }
                        break;
                    case 2:
                        //Get the deposit from the user 
                        Console.Write("Enter amount to be deposited: ");
                        deposit = double.Parse(Console.ReadLine());

                        //add the deposited amount to the current/total balance
                        balance = balance + deposit;
                        Console.WriteLine("The amount has been deposited successfully.\n");
                        break;
                    case 3:
                        //Display current/total balance of the user
                        Console.WriteLine("Balance: " + balance);
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice\n");
                        break;
                }
            }

        }
    }
}
