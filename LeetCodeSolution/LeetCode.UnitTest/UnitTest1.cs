using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTwoSumII()
        {
            int[] arr = { 2,2,6 };
            int[] res = TwoSumII.TwoSum(arr, 8);
            CollectionAssert.AreEqual(res, new int[] { 1, 3 });
        }
    }
}
