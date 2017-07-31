using CalcCreditCardInterest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Models
{
    public class Card : ICard, ITotalInterest
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public decimal TotalIntrest()
        {
            return Decimal.Multiply(this.Balance, this.InterestRate);
        }

        public Card(string name, decimal balance, decimal intrestRate)
        {
            this.Name = name;
            this.Balance = balance;
            this.InterestRate = Decimal.Multiply(0.01m, intrestRate);
        }
    }
}
