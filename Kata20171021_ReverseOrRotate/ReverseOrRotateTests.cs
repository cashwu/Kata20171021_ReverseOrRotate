using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171021_ReverseOrRotate
{
    [TestClass]
    public class ReverseOrRotateTests
    {
        [TestMethod]
        public void input_empty_string_and_0_sz()
        {
            var revrot = new Revrot();
            var result = revrot.RevRot("", 0);
            Assert.AreEqual("", result);
        }
    }

    public class Revrot
    {
        public string RevRot(string strng, int i)
        {
            return strng;
        }
    }
}
