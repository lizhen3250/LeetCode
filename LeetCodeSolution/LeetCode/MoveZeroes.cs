﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MoveZeroes
    {
        public static void MoveZeoresInArray(int[] nums)
        {
            int index = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[index++] = nums[i];
            }

            for(int i=index; i<nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
