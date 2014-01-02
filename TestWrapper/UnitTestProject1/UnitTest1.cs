using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mWrapper;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WrapperMap wm = new WrapperMap();
            wm.CreateMapWrapper(3);
            Assert.AreNotEqual(wm, null);
        }
    }
}
