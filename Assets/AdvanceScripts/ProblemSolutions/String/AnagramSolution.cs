using System;
using UnityEngine;

public class AnagramSolution : MonoBehaviour
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] first = s.ToCharArray();
            char[] second = t.ToCharArray();

            Array.Sort(first);
            Array.Sort(second);

            return new string(first) == new string(second);
        }
    }
}
