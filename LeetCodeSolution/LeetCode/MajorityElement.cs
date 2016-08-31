using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MajorityElement
    {
        public static int FindMajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic[nums[i]] = 0;
            }

            foreach (KeyValuePair<int, int> pair in dic)
            {
                if (pair.Value >= nums.Length / 2)
                    return pair.Key;
            }

            return -1;
        }
    }
}
