using H2_Assigment_My_Banker.Models;
using H2_Assigment_My_Banker.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model.Cards
{
    internal class Mastercard : Card
    {
        private const byte LENGTH = 16;
        private const byte AGE_RESTRICTION = 0;
        private static readonly List<string> _prefixes = new List<string>()
        {
            "51", "52", "53", "54", "55"
        };

        public Mastercard(BankAccount account, string cardHolderName, string cardNumber, DateTime expirationDate, decimal withdrawalLimit, decimal creditLimit) : base(account, cardHolderName, cardNumber, expirationDate, withdrawalLimit, creditLimit, _prefixes, LENGTH)
        {

        }
    }
}
