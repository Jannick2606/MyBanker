using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class BankCard
    {
        protected string cardType;
        protected double balance;
        protected bool usableOnline;
        protected string cardNumber;
        protected string prefix;
        protected string[] usablePrefixes;
        protected string accountNumber;
        protected string cardHolderName;
        protected DateTime expirationDate;

        public BankCard(string type, double bal, string[] pre, string accountNum, string cardHolder)
        {
            cardType = type;
            balance = bal;
            usablePrefixes = pre;
            accountNumber = accountNum;
            cardHolderName = cardHolder;
        }
        //I decided to make Deposit return a bool so I can send that bool somewhere that tells the user if the transaction went through
        //I haven't made anything for it though
        public virtual bool Deposit(double amount)
        {
            balance += amount;
            return true;
        }

        //Withdraw also returns a bool so they can be told if they don't have enough money on the card
        public virtual bool Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else return false;
        }

        //I originally thought that every card would have to override this method
        //But then I realized they can just use this one 
        public void GeneratePrefix()
        {
            Random r = new Random();
            prefix = usablePrefixes[r.Next(0, usablePrefixes.Length)];
            GenerateCardNumber();
        }

        //Same as with generatePrefix
        private void GenerateCardNumber()
        {
            Random r = new Random();
            cardNumber = prefix;
            if (cardType.Contains("Maestro"))
            {
                for (int i = 0; i < 19 - prefix.Length; i++)
                {
                    cardNumber += r.Next(0, 10).ToString();
                }
            }
            else
            {
                for (int i = 0; i < 16 - prefix.Length; i++)
                {
                    cardNumber += r.Next(0, 10).ToString();
                }
            }
            Console.WriteLine(cardNumber);
        }
    }
}
