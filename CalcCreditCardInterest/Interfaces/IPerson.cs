using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        IList<IWallet> Wallets { get; }

        void AddWallet(IWallet wallet);
    }
}
