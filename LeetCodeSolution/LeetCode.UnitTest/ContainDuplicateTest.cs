using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class ContainDuplicateTest
    {
        [TestMethod]
        public void TestMethodIsDuplicate()
        {
            int[] arr = { 1, 1, 3, 4, 5, 2 };
            bool result = ContainsDuplicate.IsDuplicate(arr);
            Assert.AreEqual(result, true);
        }
    }
}
