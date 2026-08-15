using System;
using UnityEngine;

public class PowerOfNum : MonoBehaviour
{
    public class Solution
    {
        public bool IsPowerOfNum(int n)
        {
            if (n == 0) return false;
            int root = (int)Math.Round(Math.Pow(n, 1.0 / 3.0));
            bool isCube = root * root * root == n;
            return isCube;
        }
    }
}
