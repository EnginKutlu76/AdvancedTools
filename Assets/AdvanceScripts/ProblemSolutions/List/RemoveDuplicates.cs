using System.Collections.Generic;
using UnityEngine;

public class RemoveDuplicates : MonoBehaviour
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!result.Contains(nums[i]))
                {
                    result.Add(nums[i]);
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                nums[i] = result[i];
            }
            return result.Count;
        }
    }
}
