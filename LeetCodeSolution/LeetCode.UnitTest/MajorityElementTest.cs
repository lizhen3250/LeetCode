using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class MajorityElementTest
    {
        [TestMethod]
        public void TestMethodFindMajorityElement()
        {
            int[] arr = { 1, 2, 3, 2, 5, 2, 2 };
            int result = MajorityElement.FindMajorityElement(arr);
            Assert.AreEqual(2, result);
        }
    }
}
