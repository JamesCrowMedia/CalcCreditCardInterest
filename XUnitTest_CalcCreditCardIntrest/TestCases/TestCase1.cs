using CalcCreditCardInterest.Interfaces;
using CalcCreditCardInterest.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTests.TestCases
{
    public class TestCase1
    {
        [Fact]
        public void TestCase()
        {
            /*
             * 1 person has 1 wallet and 3 cards (1 Visa, 1 MC 1 Discover) – 
             * Each Card has a balance of $100 – calculate the total interest 
             * (simple interest) for this person and per card.
             */

            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Card mastercard = new Card("Master Card", 100m, 5m);
            Card discover = new Card("Discover", 100m, 1m);

            Wallet wallet1 = new Wallet("Wallet1");
            wallet1.AddCard(visa);
            wallet1.AddCard(mastercard);
            wallet1.AddCard(discover);

            Person person1 = new Person("Person1");
            person1.AddWallet(wallet1);

            // ----- Tests -----
            IList<Card> cards = person1.Wallets[0].Cards;
            decimal card0Intrest = cards[0].TotalIntrest();
            decimal card1Intrest = cards[1].TotalIntrest();
            decimal card2Intrest = cards[2].TotalIntrest();
            Assert.Equal(10m, card0Intrest);     // Total intrest of Card 0
            Assert.Equal(5m, card1Intrest);      // Total intrest of Card 1
            Assert.Equal(1m, card2Intrest);      // Total intrest of Card 2

            decimal intrest = person1.TotalIntrest();
            Assert.Equal(16m, intrest);          // Total intrest of Person
        }
    }
}
