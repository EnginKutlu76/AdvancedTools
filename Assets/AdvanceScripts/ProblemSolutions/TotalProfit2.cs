using UnityEngine;

public class TotalProfit2 : MonoBehaviour
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int totalProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    int temp = prices[i] - prices[i - 1];
                    totalProfit += temp;
                }
            }
            return totalProfit;
        }
    }
}
