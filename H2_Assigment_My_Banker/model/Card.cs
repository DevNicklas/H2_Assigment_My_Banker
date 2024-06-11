using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model
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


		public Card(BankAccount account, string cardHolderName, string cardNumber, DateTime expirationDate, string accountNumber, decimal withdrawalLimit, decimal creditLimit)
		{
			_account = account;
			_cardHolderName = cardHolderName;
			_cardNumber = cardNumber;
			_expirationDate = expirationDate;
			_accountNumber = accountNumber;
			_withdrawalLimit = withdrawalLimit;
			_creditLimit = creditLimit;
		}

		#region Properties
		public BankAccount Account
		{
			get
			{
				return _account;
			}
			set
			{
				_account = value;
			}
		}

		public string CardHolderName
		{
			get
			{
				return _cardHolderName;
			}
			set
			{
				_cardHolderName = value;
			}
		}

		public string CardNumber
		{
			get
			{
				return _cardNumber;
			}
			set
			{
				_cardNumber = value;
			}
		}

		public DateTime ExpirationDate
		{
			get
			{
				return _expirationDate;
			}
			set
			{
				_expirationDate = value;
			}
		}

		public string AccountNumber
		{
			get
			{
				return _accountNumber;
			}
			set
			{
				_accountNumber = value;
			}
		}

		public decimal WithdrawalLimit
		{
			get
			{
				return _withdrawalLimit;
			}
			set
			{
				_withdrawalLimit = value;
			}
		}

		public decimal CreditLimit
		{
			get
			{
				return _creditLimit;
			}
			set
			{
				_creditLimit = value;
			}
		}
		#endregion
	}
}
