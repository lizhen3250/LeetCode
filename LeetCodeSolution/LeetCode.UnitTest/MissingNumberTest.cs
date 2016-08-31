using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class MissingNumberTest
    {
        [TestMethod]
        public void TestMethodFindMissingNumber()
        {
            int[] arr = { 0, 1, 3 };
            int result = MissingNumber.FindMissingNumber(arr);
            Assert.AreEqual(2, result);
        }
    }
}
