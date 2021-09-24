using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    abstract class ManageAccount
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to ABC account.");
        }
        public abstract void OpenAccount();
        public abstract void CloseAccount();
    }

    abstract class BankAccount: ManageAccount
    {
        public static void ShowMessage()
        {
            Console.WriteLine("Transactions in Account.");
        }
        public abstract void Deposit();
        public abstract void Withdraw();
        public abstract void Balance();

    }

    class AbstractSavingAccount : BankAccount
    {
        public override void Deposit()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account.");
        }

        public override void Balance()
        {
            Console.WriteLine("Balance in Saving Account.");
        }

        public override void OpenAccount()
        {
            Console.WriteLine("Open Saving Account.");
        }

        public override void CloseAccount()
        {
            Console.WriteLine("Close Saving Account.");
        }
    }

    class AbstractCurrentAccount : BankAccount
    {
        public override void Deposit()
        {
            Console.WriteLine("Deposit in Current Account.");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Withdraw from Current Account.");
        }

        public override void Balance()
        {
            Console.WriteLine("Balance in Current Account.");
        }

        public override void OpenAccount()
        {
            Console.WriteLine("Open Current Account.");
        }

        public override void CloseAccount()
        {
            Console.WriteLine("Close Current Account.");
        }
    }
    class AbstractExample
    {
        static void MainMethod(string[] args)
        {
            Console.WriteLine("Abstract Class Example");
            Console.WriteLine("**********************************");
            AbstractSavingAccount savingAccount = new AbstractSavingAccount();
            savingAccount.DisplayMessage();
            AbstractSavingAccount.ShowMessage();
            savingAccount.OpenAccount();
            savingAccount.Deposit();
            savingAccount.Withdraw();
            savingAccount.Balance();
            savingAccount.CloseAccount();
            Console.WriteLine("**********************************");

            AbstractCurrentAccount currentAccount = new AbstractCurrentAccount();
            currentAccount.DisplayMessage();
            AbstractCurrentAccount.ShowMessage();
            currentAccount.OpenAccount();
            currentAccount.Deposit();
            currentAccount.Withdraw();
            currentAccount.Balance();
            currentAccount.CloseAccount();
            Console.WriteLine("**********************************");

            Console.ReadKey();
        }
    }
}
