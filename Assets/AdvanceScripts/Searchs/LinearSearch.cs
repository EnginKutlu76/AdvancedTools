using UnityEngine;

public static class LinearSearch
{
    public static int Search(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return i;
        }

        return -1;

        ///Kullanýmý///
        ///int index = LinearSearch.Search(numbers, 20);
    }
}