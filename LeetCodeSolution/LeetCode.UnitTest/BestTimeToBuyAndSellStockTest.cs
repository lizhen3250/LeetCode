using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class BestTimeToBuyAndSellStockTest
    {
        [TestMethod]
        public void TestMethodMaxProfit()
        {
            int[] arr = { 1, 2, 3, 5, -3, 5 };
            int max = BestTimeToBuyAndSellStockII.MaxProfit(arr);
            Assert.AreEqual(12, max);
        }
    }
}
