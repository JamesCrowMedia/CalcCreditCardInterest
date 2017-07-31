using CalcCreditCardInterest.Interfaces;
using CalcCreditCardInterest.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTests.TestCases
{
    public class TestCase3
    {
        [Fact]
        public void TestCase()
        {
            /*
             * 2 people have 1 wallet each,  person 1 has 1 wallet , with 2 cards 
             * MC and visa person 2 has 1 wallet – 1 visa and 1 MC -  each card 
             * has $100 balance - calculate the total interest(simple interest) 
             * for each person and interest per wallet
             */

            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Card mastercard = new Card("Master Card", 100m, 5m);
            Card discover = new Card("Discover", 100m, 1m);

            Wallet wallet1 = new Wallet("Wallet1");
            wallet1.AddCard(mastercard);
            wallet1.AddCard(visa);

            Person person1 = new Person("Person1");
            person1.AddWallet(wallet1);

            Wallet wallet2 = new Wallet("Wallet1");
            wallet2.AddCard(visa);
            wallet2.AddCard(mastercard);

            Person person2 = new Person("Person1");
            person2.AddWallet(wallet2);


            // ----- Tests -----
            decimal wallet1intrest = person1.Wallets[0].TotalIntrest();
            Assert.Equal(15m, wallet1intrest);   // Total intrest of Person 1's Wallet

            decimal wallet2intrest = person2.Wallets[0].TotalIntrest();
            Assert.Equal(15m, wallet2intrest);   // Total intrest of Person 2's Wallet

            decimal person1intrest = person1.TotalIntrest();
            Assert.Equal(15m, person1intrest);   // Total intrest of Person 1

            decimal person2intrest = person2.TotalIntrest();
            Assert.Equal(15m, person2intrest);   // Total intrest of Person 2
        }
    }
}
