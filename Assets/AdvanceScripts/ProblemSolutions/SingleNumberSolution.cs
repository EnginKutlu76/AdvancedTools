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
    // 2D matrix solution
    public class Solution1
    {
        public int[] FindDegrees(int[][] matrix)
        {
            int[] totalMatrix = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    totalMatrix[i] += matrix[i][j];
                }
            }
            return totalMatrix;
        }
    }
}
