using UnityEngine;

public class SingleNumberSolution : MonoBehaviour
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int prev = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                prev = prev ^ nums[i];
            }
            return prev;
        }
    }
}
