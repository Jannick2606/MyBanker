using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class CreditCard: BankCard
    {
        protected double monthlyOverdraftAllowed;
        protected double monthlyOverdraftUsed;
        public CreditCard(string cardType, double balance, string[] usablePrefixes, string accountNumber, string cardHolderName): base(cardType, balance, usablePrefixes, accountNumber, cardHolderName)
        {

        }
        public override bool Deposit(double amount)
        {
            if (balance + amount > 0)
            {
                monthlyOverdraftUsed = 0;
            }
            else if( balance + amount < 0)
            {
                monthlyOverdraftUsed -= amount;
            }
            balance += amount;
            return true;
        }
        public override bool Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else if (monthlyOverdraftAllowed - monthlyOverdraftUsed >= amount)
            {
                balance -= amount;
                monthlyOverdraftUsed = balance;
                return true;
            }
            else return false;
        }
    }
}
