using UnityEngine;

public class MajorityElementSolution : MonoBehaviour
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count++;
                }
                else if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return candidate;
        }
    }
}
