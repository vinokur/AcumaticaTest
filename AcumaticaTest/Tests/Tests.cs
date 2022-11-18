using NUnit.Framework;

namespace AcumaticaTest
{
    [TestFixture]
    [Category("AcumaticaTests")]
    public class Tests : FunctionAcumatica
    {
        #region PositiveTests

        [Test]
        [Description("Positive tests c=>0")]
        [Category("Positive")]
        // C = 0
        [TestCase(0, 14, 14, ExpectedResult = true)]
        [TestCase(0, 15, 15, ExpectedResult = true)]
        [TestCase(0, 14, 236, ExpectedResult = true)]
        [TestCase(0, 100500, 14, ExpectedResult = true)]
        [TestCase(0, 2147483647, 2147483647, ExpectedResult = true)]
        // c > 0
        [TestCase(2, 7, 7, ExpectedResult = true)]
        [TestCase(2, 8, 300, ExpectedResult = true)]
        public bool TestsPositive(int c, int b, int a)
        {
            bool result = Function(c, b, a);
            return result;
        }

        #endregion PositiveTests

        #region NegativeTests

        [Test]
        [Category("Negative")]
        // c = 0
        [TestCase(0, 14, 13, ExpectedResult = false)]
        [TestCase(0, 1, 14, ExpectedResult = false)]
        [TestCase(0, 16, -100, ExpectedResult = false)]
        [TestCase(0, -3, 14, ExpectedResult = false)]
        // c > 0
        [TestCase(2, 6, 6, ExpectedResult = false)]
        [TestCase(2, 6, 7, ExpectedResult = false)]
        [TestCase(2, 7, 6, ExpectedResult = false)]
        // c < 0
        [TestCase(-1, 6, 6, ExpectedResult = false)]
        public bool NegativeTests(int c, int b, int a)
        {
            bool result = Function(c, b, a);
            return result;
        }

        #endregion NegativeTests
    }
}

