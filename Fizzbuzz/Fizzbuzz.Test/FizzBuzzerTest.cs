using System;
using NUnit.Framework;

namespace Fizzbuzz.Test
{
    [TestFixture(), Category("Unit Tests"), Description("Unit Tests")]
    public class FizzbuzzerTest
    {
        private IFizzbuzzer _fizzbuzzer;

        [SetUp]
        public void Setup()
        {
            _fizzbuzzer = new Fizzbuzzer();
        }

        [Test]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(10, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(21, ExpectedResult = "Fizz")]
        [TestCase(30, ExpectedResult = "FizzBuzz")]
        public string GetFizzbuzzMultiplesOf35Test(int number)
        {
            return  _fizzbuzzer.GetFizzbuzz(number);           
        }

        [Test]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(7, ExpectedResult = "7")]
        [TestCase(8, ExpectedResult = "8")]
        [TestCase(11, ExpectedResult = "11")]
        public string GetFizzbuzzTest(int number)
        {
            return _fizzbuzzer.GetFizzbuzz(number);
        }

        [Test]        
        public void PrintFizzbuzzTest()
        {
            string expectedResult = @"1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";
  
            Assert.That(expectedResult, Is.EqualTo(_fizzbuzzer.PrintFizzbuzzSequence()));
        }

        [Test]
        public void PrintFizzbuzzNonNaturalTest()
        {
            Assert.Throws<ArgumentException>(()=> _fizzbuzzer.PrintFizzbuzzSequence(0));
        }

    }

}
