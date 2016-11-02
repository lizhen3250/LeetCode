using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int max = 0, i = 0, area = 0, j = height.Length - 1;

            while(i != j)
            {
                if(height[i] < height[j])
                {
                    area = height[i] * (j - i);
                    ++i;
                }
                else
                {
                    area = height[j] * (j - i);
                    --j;
                }
                max = Math.Max(max, area);
            }
            return max;
        }
    }
}
