using CalcCreditCardInterest.Interfaces;
using CalcCreditCardInterest.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTests.ComponentTests
{
    public class TestPerson
    {
        [Fact]
        public void TestPerson1()
        {
            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Wallet wallet1 = new Wallet("Wallet1");
            wallet1.AddCard(visa);
            Person person1 = new Person("Person1");
            person1.AddWallet(wallet1);

            // ----- Tests -----
            decimal intrest = person1.TotalIntrest();
            Assert.Equal(10m, intrest);
        }

        [Fact]
        public void TestPerson2()
        {
            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Card mastercard = new Card("Master Card", 100m, 5m);

            Wallet wallet1 = new Wallet("Wallet1");
            wallet1.AddCard(visa);

            Wallet wallet2 = new Wallet("Wallet2");
            wallet1.AddCard(mastercard);


            Person person1 = new Person("Person1");
            person1.AddWallet(wallet1);
            person1.AddWallet(wallet2);

            // ----- Tests -----
            decimal intrest = person1.TotalIntrest();
            Assert.Equal(15m, intrest);
        }

        [Fact]
        public void TestPerson3()
        {
            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Card mastercard = new Card("Master Card", 100m, 5m);
            Card discover = new Card("Discover", 100m, 1m);

            Wallet wallet1 = new Wallet("Wallet1");
            wallet1.AddCard(visa);

            Wallet wallet2 = new Wallet("Wallet2");
            wallet2.AddCard(mastercard);
            wallet2.AddCard(discover);


            Person person1 = new Person("Person1");
            person1.AddWallet(wallet1);
            person1.AddWallet(wallet2);

            // ----- Tests -----
            Wallet testWallet1 = person1.Wallets[0];
            decimal w1TestIntrest = testWallet1.TotalIntrest();
            Assert.Equal(10m, w1TestIntrest);

            Wallet testWallet2 = person1.Wallets[1];
            decimal w2TestIntrest = testWallet2.TotalIntrest();
            Assert.Equal(6m, w2TestIntrest);

            decimal intrest = person1.TotalIntrest();
            Assert.Equal(16m, intrest);

        }
    }
}
