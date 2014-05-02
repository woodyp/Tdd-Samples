using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Samples_Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Add_1plus1_Expect2()
        {
            TDD_Samples.Calc c = new TDD_Samples.Calc();

            long r = c.Add(1, 1);

            Assert.AreEqual(r, 2);
        }

        [TestMethod]
        public void Add_4plus4_Expect8()
        {
            TDD_Samples.Calc c = new TDD_Samples.Calc();

            long r = c.Add(4, 4);

            Assert.AreEqual(r, 8);
        }

        [TestMethod]
        public void Div_4Divided2_Expect2()
        {
            TDD_Samples.Calc c = new TDD_Samples.Calc();

            double r = c.Div(4, 2);

            Assert.AreEqual(r, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void Div_DividedBy0_ExpectException()
        {
            TDD_Samples.Calc c = new TDD_Samples.Calc();

            int r = c.Div(2, 0);          
        }

        [TestMethod]
        public void Divd_DividedBy0_ExpectInfinity()
        {
            TDD_Samples.Calc c = new TDD_Samples.Calc();

            double r = c.Divd(2, 0);

            Assert.IsTrue(double.IsInfinity(r));
        }

    }
}
