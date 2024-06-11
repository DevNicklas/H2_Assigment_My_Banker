using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model.Cards
{
    internal class Mastercard : Card
    {
        public readonly List<string> _prefixes = new List<string>()
        {
            "51", "52", "53", "54", "55"
        };

        public Mastercard(BankAccount account, string cardHolderName, string cardNumber, DateTime expirationDate, string accountNumber, decimal withdrawalLimit, decimal creditLimit) : base(account, cardHolderName, cardNumber, expirationDate, accountNumber, withdrawalLimit, creditLimit)
        {

        }
    }
}
