using DevoteamFizzBuzz;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeveteamFizzBuzzTests
{
    [TestFixture]
    class FizzBuzzTest
    {
        FizzBuzz fizzBuzz;

        [SetUp]
        public void InitializeTest()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ShouldReturn1When1()
        { 
            Assert.That("1".Equals(fizzBuzz.GetTextFromNumber(1)));
        }

        [Test]
        public void ShouldReturn2When2()
        { 
            Assert.That("2".Equals(fizzBuzz.GetTextFromNumber(2)));
        }

        [Test]
        public void ShouldReturnFizzWhen3()
        {
            Assert.That("Fizz".Equals(fizzBuzz.GetTextFromNumber(3)));
        }

        [Test]
        public void ShouldReturnFizzWhen6()
        {
            Assert.That("Fizz".Equals(fizzBuzz.GetTextFromNumber(6)));
        }
    }
} 