using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mWrapper;
using System.Collections.Generic;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //static void Main(string[] args)
        public void MethodTest1()
        {
            WrapperMap wm = new WrapperMap();
            List<int> tab = wm.CreateMapWrapper(3);
            Assert.AreEqual(tab[2], 0);
        }
    }
}