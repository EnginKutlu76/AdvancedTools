using UnityEngine;

public class HammingWeightSolution : MonoBehaviour
{
    public class Solution
    {
        public int HammingWeight(int n)
        {
            int bitwiseNum = 0;
            while (n != 0)
            {
                bitwiseNum += n & 1;
                n >>= 1;
            }

            return bitwiseNum;
        }
    }
}
