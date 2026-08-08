using System;
using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    public static int BinarySearch1(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;

            if (target < array[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;

        ///Kullanýmý///
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int index = BinarySearch1(numbers, 11);
        Console.WriteLine(index);
    }

    public static int RecursiveBinarySearch(int[] array, int left, int right, int target)
    {
        if (left > right)
            return -1;

        int mid = left + (right - left) / 2;

        if (array[mid] == target)
            return mid;

        if (target < array[mid])
            return RecursiveBinarySearch(array, left, mid - 1, target);

        return RecursiveBinarySearch(array, mid + 1, right, target);

        ///Kullanýmý///
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int index = RecursiveBinarySearch(numbers, 0, numbers.Length - 1, 13);
    }
}
