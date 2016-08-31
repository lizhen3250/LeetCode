using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BestTimeToBuyAndSellStockII
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            for(int i = 1; i<prices.Length; i++)
            {
                int diff = prices[i] - prices[i - 1];
                if (diff > 0)
                    max += diff;
            }
            return max;
        }
    }
}
