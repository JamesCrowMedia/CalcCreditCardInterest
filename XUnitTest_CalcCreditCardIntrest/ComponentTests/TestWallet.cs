using CalcCreditCardInterest.Interfaces;
using CalcCreditCardInterest.Models;
using System;
using Xunit;

namespace XUnitTests.ComponentTests
{
    public class TestWallet
    {
        [Fact]
        public void TestWallet1()
        {
            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);

            Wallet wallet1 = new Wallet("Wallet 1");
            wallet1.AddCard(visa);

            // ----- Tests -----
            decimal intrest = wallet1.TotalIntrest();
            Assert.Equal(10m, intrest);
        }

        [Fact]
        public void TestWallet2()
        {
            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Card mastercard = new Card("Master Card", 100m, 5m);
            
            Wallet wallet1 = new Wallet("Wallet 1");
            wallet1.AddCard(visa);
            wallet1.AddCard(mastercard);

            // ----- Tests -----
            decimal intrest = wallet1.TotalIntrest();
            Assert.Equal(15m, intrest);
        }

        [Fact]
        public void TestWallet3()
        {
            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            Card mastercard = new Card("Master Card", 100m, 5m);
            Card discover = new Card("Discover", 100m, 1m);

            Wallet wallet1 = new Wallet("Wallet 1");
            wallet1.AddCard(visa);
            wallet1.AddCard(mastercard);
            wallet1.AddCard(discover);

            // ----- Tests -----
            decimal intrest = wallet1.TotalIntrest();
            Assert.Equal(16m, intrest);
        }
    }
}
