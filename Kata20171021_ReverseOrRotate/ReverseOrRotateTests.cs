using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void input_1241_string_and_3_sz()
        {
            var revrot = new Revrot();
            var result = revrot.RevRot("1241", 3);
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
            var subFreq = strng.Length / sz;
            var result = new List<string>();
            for (var i = 0; i < subFreq; i++)
            {
                var subStr = string.Concat(strng.Skip(i * sz).Take(sz));
                var sumOfCubesIsDivBy2 = subStr.Sum(a => Math.Pow(Convert.ToInt32(a), 3)) % 2 == 0;
                var newSubStr = sumOfCubesIsDivBy2
                    ? string.Concat(subStr.Reverse())
                    : $"{subStr.Substring(1)}{subStr[0]}";
                result.Add(newSubStr);
            }

            return string.Concat(result);
        }
    }
}

