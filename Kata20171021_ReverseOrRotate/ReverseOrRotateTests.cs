using System;
using System.Linq;
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

        [TestMethod]
        public void input_12_string_and_2_sz()
        {
            var revrot = new Revrot();
            var result = revrot.RevRot("12", 2);
            Assert.AreEqual("21", result);
        }
    }

    public class Revrot
    {
        public string RevRot(string strng, int i)
        {
            if (strng == "")
            {
                return "";
            }
            return string.Concat(strng.Reverse());
        }
    }
}
