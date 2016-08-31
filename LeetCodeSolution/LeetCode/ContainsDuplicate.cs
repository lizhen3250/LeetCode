using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainsDuplicate
    {
        public static bool IsDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i =0; i<nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic[nums[i]] = 0;
            }

            foreach(KeyValuePair<int, int> i in dic)
            {
                if (i.Value > 0)
                    return true;
            }
            return false;
        }
    }
}
