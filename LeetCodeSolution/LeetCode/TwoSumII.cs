using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumII
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > target)
                    break;

                int index2 = BinarySearch(numbers, i + 1, target - numbers[i]);

                if (index2 != -1)
                {
                    result[0] = i + 1;
                    result[1] = index2 + 1;
                    break;
                }
            }
            return result;
        }

        private static int BinarySearch(int[] numbers, int index1, int value)
        {
            int index2 = numbers.Length - 1;
            while (index1 <= index2)
            {
                int mid = (index2 - index1) / 2 + index1;

                if (value < numbers[mid])
                    index2 = mid - 1;
                else if (value > numbers[mid])
                    index1 = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
