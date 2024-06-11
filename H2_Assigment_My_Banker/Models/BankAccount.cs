using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Models
{
	public class BankAccount
	{
		private Bank _bank;
		private decimal _saldo;
		private string _accountNumber;

		public BankAccount(Bank bank, decimal saldo, string accountNumber)
		{
			_bank = bank;
			_saldo = saldo;
			_accountNumber = accountNumber;
		}

		public decimal Saldo { get { return _saldo; } }

		public string AccountNumber { get { return _accountNumber; } }
	}
}
