using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleAppTest
{
    [TestClass]
    public class UnitTest1
    {
        SampleAppCalculator.Calculator obj = new SampleAppCalculator.Calculator();

       
        [TestMethod]
        public void TestMethod1()
        {
            int actual = obj.add(10, 12);
            int expected = 22;
            Assert.AreEqual(expected, actual);
        }
    }
}
