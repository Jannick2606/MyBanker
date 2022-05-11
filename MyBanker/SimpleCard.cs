using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class SimpleCard : BankCard
    {
        public SimpleCard(string cardType, double balance, string[] usablePrefixes, string accountNumber, string cardHolderName) : base(cardType, balance, usablePrefixes, accountNumber, cardHolderName)
        {

        }
    }
}
