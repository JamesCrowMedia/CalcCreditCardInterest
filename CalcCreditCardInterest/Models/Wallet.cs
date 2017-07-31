using CalcCreditCardInterest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Models
{
    public class Wallet : IWallet, ITotalInterest
    {
        public string Name { get; set; }
        public IList<ICard> Cards { get; }

        public void AddCard(ICard card)
        {
            this.Cards.Add(card);
        }

        public decimal TotalIntrest()
        {
            decimal total = 0;

            foreach (ICalculateInterest card in this.Cards)
            {
                total += card.GetIntrest();
            }

            return total;
        }

        public Wallet(string name)
        {
            this.Name = name;
        }
    }
}
