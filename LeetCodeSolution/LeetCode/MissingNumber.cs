using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MissingNumber
    {
        public static int FindMissingNumber(int[] nums)
        {
            Array.Sort(nums);
            int left = 0, right = nums.Length;
            while(left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > mid)
                    right = mid;
                else
                    left = mid + 1;
            }
            return right;
        }
    }
}
