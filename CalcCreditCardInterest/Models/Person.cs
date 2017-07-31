using CalcCreditCardInterest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Models
{
    public class Person : IPerson, ITotalInterest
    {
        public string Name { get; set; }
        public IList<IWallet> Wallets { get; }


        public void AddWallet(IWallet wallet)
        {
            this.Wallets.Add(wallet);
        }

        public decimal TotalIntrest()
        {
            decimal total = 0;

            foreach (ITotalInterest wallet in this.Wallets)
            {
                total += wallet.TotalIntrest();
            }

            return total;
        }
    }
}
