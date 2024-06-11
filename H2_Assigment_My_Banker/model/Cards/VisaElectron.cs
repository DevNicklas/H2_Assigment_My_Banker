using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model.Cards
{
    internal class VisaElectron : Card
    {
        public readonly List<string> _prefixes = new List<string>()
        {
            "4026", "417500", "4508", "4844", "4913", "4917"
        };

        public VisaElectron(BankAccount account, string cardHolderName, string cardNumber, DateTime expirationDate, string accountNumber, decimal withdrawalLimit, decimal creditLimit) : base(account, cardHolderName, cardNumber, expirationDate, accountNumber, withdrawalLimit, creditLimit)
        {

        }
    }
}
