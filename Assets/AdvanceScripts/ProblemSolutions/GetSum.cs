using UnityEngine;

public class GetSum : MonoBehaviour
{
    public class Solution
    {
        public int GetSum1(int a, int b)
        {
            while (b != 0)
            {
                int temp = a ^ b;
                b = (a & b) << 1;
                a = temp;
            }
            return a;
        }
    }
}

