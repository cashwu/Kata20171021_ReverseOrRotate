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

        [TestMethod]
        public void input_12_string_and_0_sz()
        {
            var revrot = new Revrot();
            var result = revrot.RevRot("12", 0);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void input_12_string_and_3_sz()
        {
            var revrot = new Revrot();
            var result = revrot.RevRot("12", 3);
            Assert.AreEqual("", result);
        }
    }

    public class Revrot
    {
        public string RevRot(string strng, int sz)
        {
            if (strng == "" || sz == 0 || strng.Length < sz)
            {
                return "";
            }
            return string.Concat(strng.Reverse());
        }
    }
}
