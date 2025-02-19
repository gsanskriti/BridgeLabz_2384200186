//1

using System;

public class BubbleSortExample
{
    public static void Main()
    {
        int[] marks = { 78, 95, 66, 88, 71, 82, 93, 60 };
        BubbleSort(marks);

        Console.WriteLine("Sorted student marks:");
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
    }

    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap adjacent elements if they are in the wrong order
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no swaps were made, the array is already sorted
            if (!swapped)
                break;
        }
    }
}


//2

using System;

public class InsertionSortExample
{
    public static void Main()
    {
        int[] employeeIds = { 1023, 1001, 1045, 1012, 1034, 1050, 1005 };
        InsertionSort(employeeIds);

        Console.WriteLine("Sorted employee IDs:");
        foreach (int id in employeeIds)
        {
            Console.Write(id + " ");
        }
    }

    public static void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            // Move elements of array[0..i-1] that are greater than key
            // to one position ahead of their current position
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}


//3

using System;

public class MergeSortExample
{
    public static void Main()
    {
        decimal[] bookPrices = { 19.99m, 5.99m, 29.99m, 15.49m, 12.99m, 24.99m, 7.49m };
        MergeSort(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("Sorted book prices:");
        foreach (decimal price in bookPrices)
        {
            Console.Write(price + " ");
        }
    }

    public static void MergeSort(decimal[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Sort first and second halves
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            // Merge the sorted halves
            Merge(array, left, mid, right);
        }
    }

    public static void Merge(decimal[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        decimal[] leftArray = new decimal[n1];
        decimal[] rightArray = new decimal[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[mid + 1 + j];

        int iIndex = 0, jIndex = 0;
        int k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                array[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                array[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            array[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            array[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }
}


//4

using System;

public class QuickSortExample
{
    public static void Main()
    {
        decimal[] productPrices = { 199.99m, 49.99m, 299.99m, 149.49m, 89.99m, 249.99m, 129.49m };
        QuickSort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted product prices:");
        foreach (decimal price in productPrices)
        {
            Console.Write(price + " ");
        }
    }

    public static void QuickSort(decimal[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            // Recursively apply Quick Sort to left and right partitions
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    public static int Partition(decimal[] array, int low, int high)
    {
        decimal pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    public static void Swap(decimal[] array, int i, int j)
    {
        decimal temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

//5

using System;

public class SelectionSortExample
{
    public static void Main()
    {
        int[] examScores = { 85, 70, 95, 60, 90, 75, 80 };
        SelectionSort(examScores);

        Console.WriteLine("Sorted exam scores:");
        foreach (int score in examScores)
        {
            Console.Write(score + " ");
        }
    }

    public static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            // Find the minimum element in the remaining unsorted array
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first unsorted element
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}


//6

using System;
public class HeapSortExample
{
    public static void Main()
    {
        int[] salaryDemands = { 55000, 75000, 68000, 48000, 62000, 85000, 70000 };
        HeapSort(salaryDemands);

        Console.WriteLine("Sorted salary demands:");
        foreach (int salary in salaryDemands)
        {
            Console.Write(salary + " ");
        }
    }

    public static void HeapSort(int[] array)
    {
        int n = array.Length;

        // Build a max heap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(array, n, i);

        // One by one extract elements from heap
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            Swap(array, 0, i);

            // Call max heapify on the reduced heap
            Heapify(array, i, 0);
        }
    }

    public static void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        // If left child is larger than root
        if (left < n && array[left] > array[largest])
            largest = left;

        // If right child is larger than the largest so far
        if (right < n && array[right] > array[largest])
            largest = right;

        // If largest is not root
        if (largest != i)
        {
            Swap(array, i, largest);

            // Recursively heapify the affected sub-tree
            Heapify(array, n, largest);
        }
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}


//7
using System;

class CountingSortAges
{
    public static void CountingSort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        // Step 1: Count frequencies
        foreach (int age in ages)
        {
            count[age - minAge]++;
        }

        // Step 2: Compute cumulative count
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        // Step 3: Place elements in correct positions
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        // Copy sorted elements back to original array
        Array.Copy(output, ages, ages.Length);
    }

    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 18, 14, 17, 11, 13, 15, 16, 10, 18 };
        Console.WriteLine("Original ages: " + string.Join(", ", studentAges));

        CountingSort(studentAges, 10, 18);

        Console.WriteLine("Sorted ages: " + string.Join(", ", studentAges));
    }
}
