using UnityEngine;

public class MoveZeros : MonoBehaviour
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int slow = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int tmp = nums[slow];
                    nums[slow] = nums[i];
                    nums[i] = tmp;
                    slow++;
                }
            }
        }
    }
}
