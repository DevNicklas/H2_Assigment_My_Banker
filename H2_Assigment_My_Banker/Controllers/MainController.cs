using H2_Assigment_My_Banker.Model.Cards;
using H2_Assigment_My_Banker.Models;
using H2_Assigment_My_Banker.Models.Cards;
using H2_Assigment_My_Banker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Controllers
{
    public class MainController
    {
        public void Main()
        {
            Bank bank = new Bank("MinBank");
            VisaDankort visaDankort = new VisaDankort(new BankAccount(bank, 1000.0m), "John Doe", new DateTime(2029, 12, 31), 25000.0m, 20000.0m);
            Mastercard mastercard = new Mastercard(new BankAccount(bank, 1000.0m), "Jane Smith", new DateTime(2029, 12, 31), 5000.0m, 40000.0m);

            CardView CV = new CardView();

            CV.ShowCardDetails(visaDankort);
            Console.WriteLine();
            CV.ShowCardDetails(mastercard);
            Console.ReadLine();
        }
    }
}
