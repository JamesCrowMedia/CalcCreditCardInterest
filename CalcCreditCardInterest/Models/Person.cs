using CalcCreditCardInterest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Models
{
    public class Person : IPerson, ITotalInterest
    {
        public string Name { get; set; }
        private IList<Wallet> wallets = new List<Wallet>();
        public IList<Wallet> Wallets {
            get { return wallets; }
            set { wallets = value; }
        }


        public void AddWallet(Wallet wallet)
        {
            this.wallets.Add(wallet);
        }

        public decimal TotalIntrest()
        {
            decimal total = 0;

            foreach (Wallet wallet in this.Wallets)
            {
                total += wallet.TotalIntrest();
            }

            return total;
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
