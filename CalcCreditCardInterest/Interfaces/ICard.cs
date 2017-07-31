using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCreditCardInterest.Interfaces
{
    public interface ICard
    {
        string Name { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
    }
}
