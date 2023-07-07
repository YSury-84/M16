using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void CalculatorAdditionalReturnValue()
        {
            var calc = new Calculator();
            int a = calc.Additional(2, 3);
            Assert.True(a == 5);
        }

        [Test]
        public void CalculatorSubtractionReturnValue()
        {
            var calc = new Calculator();
            int s = calc.Subtraction(2, 3);
            Assert.True(s == -1);
        }

        [Test]
        public void CalculatorMiltiplicationReturnValue()
        {
            var calc = new Calculator();
            int m = calc.Miltiplication(2, 3);
            Assert.True(m == 6);
        }

        [Test]
        public void CalculatorDivisionReturnValue()
        {
            var calc = new Calculator();
            int d = calc.Division(2, 3);
            Assert.True(d == 0);
        }
    }
}
