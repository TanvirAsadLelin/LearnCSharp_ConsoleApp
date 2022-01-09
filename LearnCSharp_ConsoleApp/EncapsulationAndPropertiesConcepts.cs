using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class EncapsulationAndPropertiesConcepts
    {   

        public void encapAndProMethod()
        {
            Console.WriteLine("Welcome to Encapsulation and Properties part. \n");
            Console.WriteLine("Encapsulation: \n");
            Account accountObj = new Account();
            accountObj.setBalance (5000);
            accountObj.getBalance();


        }
       

    }

    class Account
    {
        private int balance = 1000;

        public void setBalance(int balance)
        {   
            if(balance<0)
            {
                Console.WriteLine("You don't use negetive value. \n");
            }
            else
            {
                this.balance = balance;
            }
          
        }

        public void getBalance()
        {
            Console.WriteLine("My account balance is : " + balance);
        }
    }


}
