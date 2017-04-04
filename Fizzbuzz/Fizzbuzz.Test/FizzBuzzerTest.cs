using System;
using NUnit.Framework;

namespace Fizzbuzz.Test
{
    [SetUpFixture]
    public class FizzbuzzerTest
    {
        IFizzbuzzer _fizzbuzzer;

        [SetUp]
        public void setup()
        {
            _fizzbuzzer = new Fizzbuzzer();
        }
    }
}
