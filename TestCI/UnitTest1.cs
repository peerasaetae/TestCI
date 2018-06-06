using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = "Peera";
            string name2 = "xxxx";

            Assert.AreEqual(name, name2);
        }
    }
}
