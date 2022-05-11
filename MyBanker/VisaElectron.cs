using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectron: BankCard, ISetMonthlyLimit, IExpire
    {
        public VisaElectron(string cardType, double balance, string[] usablePrefixes, string accountNumber, string cardHolderName) : base(cardType, balance, usablePrefixes, accountNumber, cardHolderName)
        {
            
        }

        public void GenerateExpirationDate()
        {
            
        }
    }
}
