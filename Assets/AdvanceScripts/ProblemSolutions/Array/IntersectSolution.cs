using UnityEngine;

public class IntersectSolution : MonoBehaviour
{
    public class Solution
    {
        public int[] ConcatWithReverse(int[] nums)
        {
            int[] answer = new int[nums.Length * 2];
            int reverse = answer.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = nums[i];
                answer[reverse] = nums[i];
                reverse--;
            }
            return answer;
        }
    }
}
