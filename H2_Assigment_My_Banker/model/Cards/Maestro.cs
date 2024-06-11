using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model.Cards
{
	public class Maestro : Card
	{
		public readonly List<string> _prefixes = new List<string>()
		{
			"5018", "5020", "5038", "5893", "6304",
			"6759", "6761", "6762", "6763"
		};

		public Maestro(BankAccount account, string cardHolderName, string cardNumber, DateTime expirationDate, string accountNumber, decimal withdrawalLimit, decimal creditLimit) :base(account, cardHolderName, cardNumber, expirationDate, accountNumber, withdrawalLimit, creditLimit)
		{

		}
	}
}
