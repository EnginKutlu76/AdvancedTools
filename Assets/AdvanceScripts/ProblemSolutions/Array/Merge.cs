using UnityEngine;

public class Merge : MonoBehaviour
{
    public class Solution
    {
        public void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;      // nums1'in son gerçek elemanı
            int j = n - 1;      // nums2'nin son elemanı
            int k = m + n - 1;  // nums1'in en son pozisyonu

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }

                k--;
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}
