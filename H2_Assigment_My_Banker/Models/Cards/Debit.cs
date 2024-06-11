using H2_Assigment_My_Banker.Models;
using H2_Assigment_My_Banker.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model.Cards
{
    internal class Debit : Card
    {
        public readonly List<string> _prefixes = new List<string>()
        {
            "2400"
        };

        public Debit(BankAccount account, string cardHolderName, string cardNumber, DateTime expirationDate, string accountNumber, decimal withdrawalLimit, decimal creditLimit) : base(account, cardHolderName, cardNumber, expirationDate, accountNumber, withdrawalLimit, creditLimit)
        {

        }
    }
}
