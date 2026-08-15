using System;
using UnityEngine;

public class MirrorDistanceSolution : MonoBehaviour
{
    public int MirrorDistance(int n)
    {
        int original = n;
        int reverse = 0;

        while (n > 0)
        {
            int digit = n % 10;
            reverse = reverse * 10 + digit;
            n /= 10;
        }

        return Math.Abs(reverse - original);
    }
}
