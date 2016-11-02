using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PlusOne
    {
        public int[] plusOne(int[] digits)
        {
            for(int i = digits.Length - 1; i>=0; i--)
            {
                if (digits[i] == 9)
                    digits[i] = 0;
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }
    }
}
