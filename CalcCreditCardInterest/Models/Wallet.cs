using CalcCreditCardInterest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Models
{
    public class Wallet : IWallet, ITotalInterest
    {
        public string Name { get; set; }

        private IList<Card> cards = new List<Card>();
        public IList<Card> Cards {
            get { return cards; }
            set { cards = value; }
        }

        public void AddCard(Card card)
        {
            this.cards.Add(card);
        }

        public decimal TotalIntrest()
        {
            decimal total = 0;

            foreach (Card card in this.Cards)
            {
                total += card.TotalIntrest();
            }

            return total;
        }

        public Wallet(string name)
        {
            this.Name = name;
        }
    }
}
