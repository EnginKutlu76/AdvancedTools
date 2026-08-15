using System.Collections.Generic;
using UnityEngine;

public class DigitFrequency : MonoBehaviour
{
    public class Solution
    {
        public int DigitFrequencyScore(int n)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i <= 9; i++)
            {
                map[i] = 0;
            }
            while (n >= 1)
            {
                int digit = n % 10;
                n /= 10;
                map[digit]++;
            }
            int ans = 0;
            for (int i = 0; i <= 9; i++)
            {
                ans += i * map[i];
            }
            return ans;
        }
    }
}
