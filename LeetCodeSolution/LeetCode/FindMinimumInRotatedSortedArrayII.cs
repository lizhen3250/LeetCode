using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindMinimumInRotatedSortedArrayII
    {
        public int FindMinimum(int[] nums)
        {
            int min = nums[0];
            for(int i = 1; i<nums.Length; i++)
            {
                if (nums[i] <= min)
                    min = nums[i];
            }
            return min;
        }
    }
}
