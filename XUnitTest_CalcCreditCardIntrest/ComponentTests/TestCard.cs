using CalcCreditCardInterest.Interfaces;
using CalcCreditCardInterest.Models;
using System;
using Xunit;

namespace XUnitTests.ComponentTests
{
    public class TestCard
    {
        [Fact]
        public void TestCard1()
        {
            // ------ Generate Test Data ------
            Card visa = new Card("Visa", 100m, 10m);
            decimal intrest = visa.TotalIntrest();

            // ----- Tests -----
            Assert.Equal(10m, intrest);
        }

        [Fact]
        public void TestCard2()
        {
            // ------ Generate Test Data ------
            Card mastercard = new Card("Master Card", 100m, 5m);
            decimal intrest = mastercard.TotalIntrest();

            // ----- Tests -----
            Assert.Equal(5m, intrest);
        }

        [Fact]
        public void TestCard3()
        {
            // ------ Generate Test Data ------
            Card discover = new Card("Discover", 100m, 1m);
            decimal intrest = discover.TotalIntrest();

            // ----- Tests -----
            Assert.Equal(1m, intrest);
        }
    }
}
