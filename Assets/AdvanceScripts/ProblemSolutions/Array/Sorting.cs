using UnityEngine;

public class Sorting : MonoBehaviour
{
    private void Start()
    {
        /*
        /*******Bubble Sort******
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                    swap(arr[j], arr[j + 1]);
            }
        }


        /*******Selection Sort******
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min])
                    min = j;
            }

            swap(arr[i], arr[min]);
        }


        /*******Shell Sort******
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }
        }


        /*******Merge Sort******
        void mergeSort(arr)
        {
            split(left);

            split(right);

            merge();
        }
        */
    }


    ///Heap Sort///
    public static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        // Max Heap oluþtur
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // Tek tek en büyüðü sona taþý
        for (int i = n - 1; i > 0; i--)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            Heapify(arr, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}
