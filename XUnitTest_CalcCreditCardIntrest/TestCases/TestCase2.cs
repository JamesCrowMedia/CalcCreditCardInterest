using CalcCreditCardInterest.Interfaces;
using CalcCreditCardInterest.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTests.TestCases
{
    public class TestCase2
    {
        [Fact]
        public void TestCase()
        {
            /*
             * 1 person has 2 wallets  Wallet 1 has a Visa and Discover, 
             * wallet 2 a MC -  each card has $100 balance - calculate 
             * the total interest(simple interest) for this person and 
             * interest per wallet
             */

            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Card mastercard = new Card("Master Card", 100m, 5m);
            Card discover = new Card("Discover", 100m, 1m);

            Wallet wallet1 = new Wallet("Wallet1");
            wallet1.AddCard(visa);
            wallet1.AddCard(discover);

            Wallet wallet2 = new Wallet("Wallet1");
            wallet2.AddCard(mastercard);

            Person person1 = new Person("Person1");
            person1.AddWallet(wallet1);
            person1.AddWallet(wallet2);

            // ----- Tests -----
            IList<Wallet> wallets = person1.Wallets;
            decimal wallet0Intrest = wallets[0].TotalIntrest();
            decimal wallet1Intrest = wallets[1].TotalIntrest();
            Assert.Equal(11m, wallet0Intrest);   // Total Intrest of Wallet 0
            Assert.Equal(5m, wallet1Intrest);    // Total Intrest of Wallet 1

            decimal intrest = person1.TotalIntrest();
            Assert.Equal(16m, intrest);          // Total intrest of Person
        }
    }
}
