using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Calc;

namespace Calculator.Test
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            ICalculator sut = new Calculatorr();
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
            ICalculator sut = new Calculatorr();
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }
    }
}
