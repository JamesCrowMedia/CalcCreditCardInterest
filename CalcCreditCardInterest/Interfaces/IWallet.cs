using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Interfaces
{
    public interface IWallet
    {
        string Name { get; set; }
        IList<ICard> Cards { get; }

        void AddCard(ICard card);

    }
}
