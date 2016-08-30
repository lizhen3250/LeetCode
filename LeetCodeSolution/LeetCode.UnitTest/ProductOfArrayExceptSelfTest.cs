using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class ProductOfArrayExceptSelfTest
    {
        [TestMethod]
        public void TestProductOfArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] res = ProductOfArrayExcepSelf.ProductExceptSelf(arr);
            CollectionAssert.AreEqual(res, new int[] { 120, 60, 40, 30, 24 });
        }
    }
}
