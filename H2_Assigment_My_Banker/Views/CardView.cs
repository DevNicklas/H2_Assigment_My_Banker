using H2_Assigment_My_Banker.Models;
using H2_Assigment_My_Banker.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Views
{
    public class CardView
    {
        public void ShowCardDetails(Card card)
        {
            if(card == null)
            {
                Console.WriteLine("Kortet findes ikke..");
                return;
            }

            Console.WriteLine($"Korttype: {card.GetType()}");
            Console.WriteLine($"Kortnummer: {card.CardNumber}");
            Console.WriteLine($"Kontonummer: {card.AccountNumber}");
            Console.WriteLine($"Udløbsdato: {card.ExpirationDate}");
            Console.WriteLine($"Kortholder: {card.CardHolderName}");
            Console.WriteLine($"Hævebegrænsning: {card.WithdrawalLimit}");
            Console.WriteLine($"Kreditbegrænsning: {card.CreditLimit}");
        }
    }
}
