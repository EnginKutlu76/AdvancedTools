using UnityEngine;

public class FirstUniqCharSolution : MonoBehaviour
{
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
