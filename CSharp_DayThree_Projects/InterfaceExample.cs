using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    interface IManageAccount
    {
        void Deposit(float amount); // By default, Interfaces are Public and Abstract
        void Withdraw(float amount);
        void Balance(float amount);
    }

    interface IBankAccount
    {
        void Deposit(float amount); // By default, Interfaces are Public and Abstract
        void Withdraw(float amount);
        void Balance(float amount);
    }

    class SavingAccount : IManageAccount, IBankAccount
    {
        public void Deposit(float amount)
        {
            Console.WriteLine("Deposit in Saving Account.");
        }

        public void Withdraw(float amount)
        {
            Console.WriteLine("Withdraw from Saving Account.");
        }

        public void Balance(float amount)
        {
            Console.WriteLine("Balance in Saving Account.");
        }
    }
    class InterfaceExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Example");
            //Console.WriteLine("**********************************");
            //SavingAccount savingAccount = new SavingAccount();
            //savingAccount.Deposit(10000);
            //savingAccount.Withdraw(5000);
            //savingAccount.Balance(1000);
            //Console.WriteLine("**********************************");
            int i;
            do
            {
                Console.Write("Select the account\n 1. Savings Account \n 2. Current Account");
                i = int.Parse(Console.ReadLine());
                Console.Write("Select the account\n 1. Deposit \n 2. Withdraw \n3. Balance");


            } while (i < 3);
        }
    }
}
