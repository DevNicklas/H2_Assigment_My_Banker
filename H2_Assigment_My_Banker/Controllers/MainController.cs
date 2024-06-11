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

            CardHolder cardHolder = new CardHolder("John Doe", 99);
            cardHolder.Cards.Add(new VisaDankort(new BankAccount(bank, 1000.0m), cardHolder.Name, new DateTime(2029, 12, 31), 25000.0m, 20000.0m));
            cardHolder.Cards.Add(new Mastercard(new BankAccount(bank, 1000.0m), cardHolder.Name, new DateTime(2029, 12, 31), 5000.0m, 40000.0m));

            CardView CV = new CardView();

            foreach (Card card in cardHolder.Cards)
            {
                CV.ShowCardDetails(card);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
