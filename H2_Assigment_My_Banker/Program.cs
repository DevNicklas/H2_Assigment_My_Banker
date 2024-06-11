using H2_Assigment_My_Banker.Controller;
using H2_Assigment_My_Banker.Model;
using H2_Assigment_My_Banker.Model.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("peter's bank");
            BankAccount ba = new BankAccount(bank, 10000, "12346789");
            RandomGenerator rn = new RandomGenerator();

			string cardHolderName = "John Doe";
			string cardNumber = "1234567890123456";
			DateTime expirationDate = new DateTime(2025, 12, 31);
			string accountNumber = "1234567890";
			decimal withdrawalLimit = 1000.00m;
			decimal creditLimit = 5000.00m;

			// Instantiate a Maestro object using the test data
			Maestro maestroCard = new Maestro(ba, cardHolderName, cardNumber, expirationDate, accountNumber, withdrawalLimit, creditLimit);

			
			Console.WriteLine( rn.GetRandomPrefix(maestroCard._prefixes));
            Console.ReadLine();
		}
    }
}
