using H2_Assigment_My_Banker.Controllers;
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
		private decimal _balance;
		private string _accountNumber;
        private const string Prefix = "3520";

        public BankAccount(Bank bank, decimal saldo)
		{
			_bank = bank;
            _balance = saldo;
            _accountNumber = GetNewAccountNumber();
		}

		public decimal Balance { get { return _balance; } }

		public string AccountNumber { get { return _accountNumber; } }




		private string GetNewAccountNumber()
		{
            RandomGenerator randomGenerator = new RandomGenerator();
            return $"{Prefix}{randomGenerator.GenerateNumbers(14)}";
        }



    }
}
