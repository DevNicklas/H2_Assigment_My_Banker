using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2_Assigment_My_Banker.Models;
using H2_Assigment_My_Banker.Models.Cards;

namespace H2_Assigment_My_Banker.Controllers
{
    internal class AccountController
    {
        private const string PREFIX = "3520";

        public BankAccount SetupBankAccount(Bank bank)
        {
            RandomGenerator RG = new RandomGenerator();
            return new BankAccount(bank, 0, PREFIX + RG.GenerateNumbers(14));
        }
    }
}
