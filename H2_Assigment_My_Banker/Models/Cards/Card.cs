using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Models.Cards
{
    public class Card
    {
        private BankAccount _account;
        private string _cardHolderName;
        private string _cardNumber;
        private DateTime _expirationDate;
        private string _accountNumber;
        private decimal _withdrawalLimit;
        private decimal _creditLimit;
        private int _ageRestriction;


        public Card(BankAccount account, string cardHolderName, string cardNumber, DateTime expirationDate, string accountNumber, decimal withdrawalLimit, decimal creditLimit, int ageRestriction)
        {
            _account = account;
            _cardHolderName = cardHolderName;
            _cardNumber = cardNumber;
            _expirationDate = expirationDate;
            _accountNumber = accountNumber;
            _withdrawalLimit = withdrawalLimit;
            _creditLimit = creditLimit;
            _ageRestriction = ageRestriction;
        }

        #region Properties
        public BankAccount Account { get { return _account; } }

        public string CardHolderName { get { return _cardHolderName; } }

        public string CardNumber { get { return _cardNumber; } }

        public DateTime ExpirationDate { get { return _expirationDate; } }

        public string AccountNumber { get { return _accountNumber; } }

        public decimal WithdrawalLimit { get { return _withdrawalLimit; } }

        public decimal CreditLimit { get { return _creditLimit; } }

        public int AgeRestriction { get { return _ageRestriction; } }
        #endregion
    }
}
