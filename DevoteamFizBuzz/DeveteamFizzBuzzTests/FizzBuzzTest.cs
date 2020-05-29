using DevoteamFizBuzz;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeveteamFizzBuzzTests
{
    [TestFixture]
    class FizzBuzzTest
    {
        [Test]
        public void ShouldReturn1When1()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.That("1".Equals(fizzBuzz.GetTextFromNumber(1)));
        }
    }
}
