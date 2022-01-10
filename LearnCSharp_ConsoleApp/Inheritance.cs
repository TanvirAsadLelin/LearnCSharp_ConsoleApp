using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Inheritance
    {
        public void inheritenceMethod()
        {
            double balance;
            SavingAccount savingAccountObj = new SavingAccount();
            savingAccountObj.InterestAmount = 500;
            savingAccountObj.AccountNO = "SV-01";
            savingAccountObj.CustomerName = "Lelin";
            savingAccountObj.Deposit(1000);
            savingAccountObj.Withdraw(500);
            balance = savingAccountObj.Balance;
            Console.WriteLine("Saving account balance is : " + balance);

            BankAccount bankAccountObj = new BankAccount();
            CheckingAccount checkingAccountObj = new CheckingAccount();

            checkingAccountObj.ServiceCharge = 1000;
            checkingAccountObj.AccountNO = "CH_AC-01";
            checkingAccountObj.CustomerName = "Israt";
            checkingAccountObj.Deposit(2000);
            checkingAccountObj.Withdraw(300);
            balance = checkingAccountObj.Balance;
            Console.WriteLine("Checking account balance is : " + balance);


        }
    }

    public class BankAccount
    {
        public string AccountNO { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }


        public string Deposit (double amount)
        {
            Balance += amount;
            return "Deposited";
        }

        public string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }

    } 

    public class SavingAccount : BankAccount   //Here use inheritance. SavingAccount is a child class of BankAcount class.
    {
        public double InterestAmount { get; set; }

    }

    public class CheckingAccount:BankAccount
    {
        public double ServiceCharge { get; set; }

    }

}
