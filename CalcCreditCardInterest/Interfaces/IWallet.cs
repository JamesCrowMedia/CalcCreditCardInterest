using CalcCreditCardInterest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Interfaces
{
    public interface IWallet
    {
        string Name { get; set; }
        IList<Card> Cards { get; set; }

        void AddCard(Card card);

    }
}
