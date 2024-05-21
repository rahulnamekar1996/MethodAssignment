using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Account
    {
        private int acc_no;
        private string name;
        private float amount;

     
        public void Insert(int accNo, string name, float amount)
        {
            this.acc_no = accNo;
            this.name = name;
            this.amount = amount;
        }

      
        public void Display()
        {
            Console.WriteLine("Account Number: " + acc_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + amount);
        }

    
        public void Deposit(float depositAmount)
        {
            amount = amount+ depositAmount;
            Console.WriteLine("Deposit Successful. Current Balance: " + amount);
        }
     
        public void Withdraw(float withdrawAmount)
        {
            if (withdrawAmount > amount)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                amount = amount- withdrawAmount;
                Console.WriteLine("Withdrawal Successful. Current Balance: " + amount);
            }
        }

      
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: " + amount);
        }

    }
}
