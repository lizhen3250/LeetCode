using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode.UnitTest
{
    [TestClass]
    public class MoveZeroesTest
    {
        [TestMethod]
        public void TestMethodMoveZeroesInArray()
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes.MoveZeoresInArray(nums);
            CollectionAssert.AreEqual(nums, new int[] { 1, 3, 12, 0, 0 });
        }
    }
}
