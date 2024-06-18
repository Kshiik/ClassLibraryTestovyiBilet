using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryTestovyiBilet;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string creditCardNumber = "";

            bool result = AbonentClass.Abonets(1, "", "", "",  creditCardNumber, 0);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string creditCardNumber = "1234-1111-1111-1111";

            bool result = AbonentClass.Abonets(1, "a", "b", "c", creditCardNumber, 10);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string creditCardNumber = "1234-1111-1111";

            bool result = AbonentClass.Abonets(1, "a", "b", "c", creditCardNumber, 10);

            Assert.IsFalse(result);
        }
    }
}
