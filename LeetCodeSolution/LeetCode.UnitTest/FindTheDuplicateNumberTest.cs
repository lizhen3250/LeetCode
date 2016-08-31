using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class FindTheDuplicateNumberTest
    {
        [TestMethod]
        public void TestMethodFindDuplicate()
        {
            int[] arr = { 1, 2, 2, 3, 4, 5 };
            int result = FindTheDuplicateNumber.FindDuplicateNumber(arr);
            Assert.AreEqual(2, result);
        }
    }
}
