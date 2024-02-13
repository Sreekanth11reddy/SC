using NUnit.Framework;
using CalcApp;
using System.ComponentModel;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ICalc cal = new Add();
           int result= cal.calculate(1, 2);
            //Assert.Equals(result, 3);
            //Assert.AreEqual(result, 3);
        }
    }
}