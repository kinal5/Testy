using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zadanie.UnitTestGeneratePrimes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalc()
        {
            
            Class1 class1 = new Class1();
             // Expected values
            int expected2 = 2;
            int expected3 = 6;
            int expected5 = 60;
            int expected7 = 420;
            int expected10 = 2520;
            int expected20 = 232792560;

            // Results
            int result2 = class1.Calc(2);
            int result3 = class1.Calc(3);
            int result5 = class1.Calc(5);
            int result7 = class1.Calc(7);
            int result10 = class1.Calc(10);
            int result20 = class1.Calc(20);
            // Asserts
            Assert.AreEqual(expected2, result2, "Error with argument 2");
            Assert.AreEqual(expected3, result3, "Error with argument 3");
            Assert.AreEqual(expected5, result5, "Error with argument 5");
            Assert.AreEqual(expected7, result7, "Error with argument 7");
            Assert.AreEqual(expected10, result10, "Error with argument 10");
            Assert.AreEqual(expected20, result20, "Error with argument 20");

        }
    }
}
