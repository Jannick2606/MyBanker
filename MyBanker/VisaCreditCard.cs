using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaCreditCard: CreditCard, ISetMonthlyLimit, IExpire
    {
        public VisaCreditCard(string cardType, double balance, string[] usablePrefixes, string accountNumber, string cardHolderName) : base(cardType, balance, usablePrefixes, accountNumber, cardHolderName)
        {
            monthlyOverdraftAllowed = 20000;
        }

        public void GenerateExpirationDate()
        {
            
        }
    }
}
