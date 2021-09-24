using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    interface IManageAccount
    {
        void Deposit(); // By default, Interfaces are Public and Abstract
        void Withdraw();
        void Balance();
    }

    interface IBankAccount
    {
        void Deposit(); // By default, Interfaces are Public and Abstract
        void Withdraw();
        void Balance();
    }

    class SavingAccount : IManageAccount, IBankAccount
    {
        public void Deposit()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account.");
        }

        public void Balance()
        {
            Console.WriteLine("Balance in Saving Account.");
        }

        //public void OpenAccount()
        //{
        //    Console.WriteLine("Open Saving Account.");
        //}

        //public void CloseAccount()
        //{
        //    Console.WriteLine("Close Saving Account.");
        //}
    }
    class InterfaceExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Example");
            Console.WriteLine("**********************************");
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.Deposit();
            savingAccount.Withdraw();
            savingAccount.Balance();
            Console.WriteLine("**********************************");            
        }
    }
}
