using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SortColors
    {
        public void SortColor(int[] nums)
        {
            for(int i = 1; i<nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while(j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }
        }
    }
}
