using CalcCreditCardInterest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        IList<Wallet> Wallets { get; set; }

        void AddWallet(Wallet wallet);
    }
}
