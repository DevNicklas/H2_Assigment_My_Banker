using H2_Assigment_My_Banker.Models;
using H2_Assigment_My_Banker.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model.Cards
{
	public class Maestro : Card
	{
		
		private const byte LENGTH = 19;
        private const byte AGE_RESTRICTION = 18;
        private static readonly List<string> _prefixes = new List<string>()
		{
			"5018", "5020", "5038", "5893", "6304",
			"6759", "6761", "6762", "6763"
		};

		public Maestro(BankAccount account, string cardHolderName, DateTime expirationDate, decimal withdrawalLimit, decimal creditLimit) : base(account, cardHolderName, expirationDate, withdrawalLimit, creditLimit, _prefixes, LENGTH)
        {

		}
	}
}
