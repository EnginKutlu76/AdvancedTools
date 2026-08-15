using System.Collections.Generic;
using UnityEngine;

public class HappyNumber : MonoBehaviour
{
    public class Solution
    {

        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();

            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);

                int toplam = 0;

                while (n > 0)
                {
                    int digit = n % 10;
                    toplam += digit * digit;
                    n /= 10;
                }

                n = toplam;
            }

            return n == 1;
        }
    }
}
