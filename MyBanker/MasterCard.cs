using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MasterCard: CreditCard, ISetMonthlyLimit, IExpire
    {
        public MasterCard(string cardType, double balance, string[] usablePrefixes, string accountNumber, string cardHolderName) : base(cardType, balance, usablePrefixes, accountNumber, cardHolderName)
        {
            monthlyOverdraftAllowed = 40000;
        }

        public void GenerateExpirationDate()
        {
            
        }
    }
}
