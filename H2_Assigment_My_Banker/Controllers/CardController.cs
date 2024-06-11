using H2_Assigment_My_Banker.Models.Cards;
using H2_Assigment_My_Banker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Controllers
{
    internal class CardController
    {
        public Card CreateCard()
        {
            Card = new Card();
        }

        public void UpdateView(Card card, CardView cardView)
        {
            cardView.ShowCardDetails(card);
        }
    }
}
