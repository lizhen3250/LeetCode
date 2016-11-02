using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int position = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                if (nums[i] == target)
                    position = i;
                else if (nums[i] < target)
                    position = i - 1;
                else if(nums[i] > target)
                    position = i + 1;
            }
            return position;
        }
    }
}
