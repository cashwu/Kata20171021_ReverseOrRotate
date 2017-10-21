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

        [TestMethod]
        public void input_123_string_and_3_sz()
        {
            var revrot = new Revrot();
            var result = revrot.RevRot("123", 3);
            Assert.AreEqual("321", result);
        }

        [TestMethod]
        public void input_124_string_and_3_sz()
        {
            var revrot = new Revrot();
            var result = revrot.RevRot("124", 3);
            Assert.AreEqual("241", result);
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
            
            var intArray = strng.Select(Convert.ToInt32);
            var isDivBy2 = intArray.Sum(i => Math.Pow(i, 3)) % 2 == 0;
            return isDivBy2 ? string.Concat(strng.Reverse()) : $"{strng.Substring(1)}{strng[0]}";
        }
    }
}
