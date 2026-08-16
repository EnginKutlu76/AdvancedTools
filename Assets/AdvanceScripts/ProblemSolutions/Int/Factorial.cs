using UnityEngine;

public class Factorial : MonoBehaviour
{
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            int zeros = 0;

            while (n > 0)
            {
                n /= 5;
                zeros += n;
            }

            return zeros;
        }
    }
}
