using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RomanToIntSolution : MonoBehaviour
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int res = 0;
            Dictionary<char, int> roman = new Dictionary<char, int>();
            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (roman[s[i]] < roman[s[i + 1]])
                {
                    res -= roman[s[i]];
                }
                else
                {
                    res += roman[s[i]];
                }
            }
            return res + roman[s[s.Length - 1]];
        }
    }
    
    //Min Operations solution
    public class Solution2
    {
        public int MinOperations(int[] nums, int k)
        {
            int sum = nums.Sum();
            int value = 0;
            if(sum % k == 0)
            {
                return value;
            }
            else
            {
                value = sum % k;
            }
            return value;
        }
    }
}
