//1
using System;
using System.Diagnostics;

class SearchComparison
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        foreach (int size in sizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next(0, 1000000);
            }

            int target = data[random.Next(0, size)];

            // Linear Search
            Stopwatch stopwatch = Stopwatch.StartNew();
            LinearSearch(data, target);
            stopwatch.Stop();
            Console.WriteLine($"Linear Search for size {size}: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Binary Search
            Array.Sort(data);
            stopwatch.Restart();
            BinarySearch(data, target);
            stopwatch.Stop();
            Console.WriteLine($"Binary Search for size {size}: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
    }

    static int LinearSearch(int[] data, int target)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static int BinarySearch(int[] data, int target)
    {
        int left = 0;
        int right = data.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (data[mid] == target)
            {
                return mid;
            }
            else if (data[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}

//2
using System;
using System.Diagnostics;

class SortingComparison
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        foreach (int size in sizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next(0, 1000000);
            }

            Console.WriteLine($"\nDataset Size: {size}");

            // Bubble Sort
            int[] bubbleData = (int[])data.Clone();
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSort(bubbleData);
            stopwatch.Stop();
            Console.WriteLine($"Bubble Sort: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Merge Sort
            int[] mergeData = (int[])data.Clone();
            stopwatch.Restart();
            MergeSort(mergeData, 0, mergeData.Length - 1);
            stopwatch.Stop();
            Console.WriteLine($"Merge Sort: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Quick Sort
            int[] quickData = (int[])data.Clone();
            stopwatch.Restart();
            QuickSort(quickData, 0, quickData.Length - 1);
            stopwatch.Stop();
            Console.WriteLine($"Quick Sort: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
    }

    static void BubbleSort(int[] data)
    {
        int n = data.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (data[j] > data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }

    static void MergeSort(int[] data, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSort(data, left, mid);
            MergeSort(data, mid + 1, right);

            Merge(data, left, mid, right);
        }
    }

    static void Merge(int[] data, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        Array.Copy(data, left, leftArray, 0, n1);
        Array.Copy(data, mid + 1, rightArray, 0, n2);

        int i = 0, j = 0;
        int k = left;

        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                data[k] = leftArray[i];
                i++;
            }
            else
            {
                data[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            data[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            data[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void QuickSort(int[] data, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(data, low, high);

            QuickSort(data, low, pi - 1);
            QuickSort(data, pi + 1, high);
        }
    }

    static int Partition(int[] data, int low, int high)
    {
        int pivot = data[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (data[j] <= pivot)
            {
                i++;

                int temp = data[i];
                data[i] = data[j];
                data[j] = temp;
            }
        }

        int temp1 = data[i + 1];
        data[i + 1] = data[high];
        data[high] = temp1;

        return i + 1;
    }
}



//3
using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationPerformance
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        string appendString = "x";

        foreach (int size in sizes)
        {
            Console.WriteLine($"\nOperations Count: {size}");

            // Using string
            Stopwatch stopwatch = Stopwatch.StartNew();
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result += appendString;
            }
            stopwatch.Stop();
            Console.WriteLine($"String Concatenation: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Using StringBuilder
            stopwatch.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                sb.Append(appendString);
            }
            stopwatch.Stop();
            Console.WriteLine($"StringBuilder: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Using Custom StringBuffer (Simple Implementation)
            stopwatch.Restart();
            StringBuffer stringBuffer = new StringBuffer(size);
            for (int i = 0; i < size; i++)
            {
                stringBuffer.Append(appendString);
            }
            stopwatch.Stop();
            Console.WriteLine($"StringBuffer: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
    }
}

class StringBuffer
{
    private char[] buffer;
    private int position;

    public StringBuffer(int capacity)
    {
        buffer = new char[capacity];
        position = 0;
    }

    public void Append(string str)
    {
        foreach (char c in str)
        {
            if (position < buffer.Length)
            {
                buffer[position++] = c;
            }
        }
    }

    public override string ToString()
    {
        return new string(buffer, 0, position);
    }
}


//4
using System;
using System.Diagnostics;
using System.IO;

class FileReadingEfficiency
{
    static void Main()
    {
        string filePath = "largefile.txt"; // Path to your large file

        Console.WriteLine($"File Size: {new FileInfo(filePath).Length / (1024 * 1024)} MB");

        // Using StreamReader
        Stopwatch stopwatch = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1) { }
        }
        stopwatch.Stop();
        Console.WriteLine($"StreamReader Time: {stopwatch.Elapsed.TotalMilliseconds} ms");

        // Using FileStream
        stopwatch.Restart();
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            int byteRead;
            while ((byteRead = fileStream.ReadByte()) != -1) { }
        }
        stopwatch.Stop();
        Console.WriteLine($"FileStream Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
}


//5
using System;
using System.Diagnostics;

class FibonacciComparison
{
    static void Main()
    {
        int[] testValues = { 10, 30, 50 };

        foreach (int n in testValues)
        {
            Console.WriteLine($"\nFibonacci({n}):");

            // Recursive Fibonacci
            Stopwatch stopwatch = Stopwatch.StartNew();
            long recursiveResult = FibonacciRecursive(n);
            stopwatch.Stop();
            Console.WriteLine($"Recursive Result: {recursiveResult}, Time: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Iterative Fibonacci
            stopwatch.Restart();
            long iterativeResult = FibonacciIterative(n);
            stopwatch.Stop();
            Console.WriteLine($"Iterative Result: {iterativeResult}, Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
    }

    public static long FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static long FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1, sum = 0;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}

