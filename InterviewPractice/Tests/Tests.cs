using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewPractice.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void MultiplierTests()
        {
            // Since testing this functionality is so straightforward,
            // I am abandoning the typical Arrange/Act/Assert pattern
            // and simply using several Assert statements.

            // basic test
            MultiplierTester(2, 4);

            // x is 1
            MultiplierTester(1, 4);

            // y is 1
            MultiplierTester(5, 1);

            // both are 1
            MultiplierTester(1, 1);

            // x is 0
            MultiplierTester(0, 4);

            // y is 0
            MultiplierTester(2, 0);

            // both are 0
            MultiplierTester(0, 0);

            // x is negative
            MultiplierTester(-4, 2);

            // y is negative
            MultiplierTester(8, -3);

            // both are negative
            MultiplierTester(-2, -1);

            // Larger numbers
            // Note: since this is recursion, performance takes a huge hit
            // with larger numbers.
            MultiplierTester(4353535, 321);
        }

        private void MultiplierTester(long x, long y)
        {
            Assert.AreEqual(Multiplier.Multiply(x, y), x * y);
        }
    }
}
 