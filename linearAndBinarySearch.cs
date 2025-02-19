//1
System;

public class ReverseString
{
    public static void Main(string[] args)
    {
        string input = "hello";
        StringBuilder stringBuilder = new StringBuilder(input);
        for (int i = stringBuilder.Length - 1; i >= 0; i--)
        {
            Console.Write(stringBuilder[i]);
        }
        Console.WriteLine();
    }
}


//2
using System;
using System.Text;
using System.Collections.Generic;

public class RemoveDuplicates
{
    public static void Main(string[] args)
    {
        string input = "programming";
        StringBuilder result = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                result.Append(c);
            }
        }

        Console.WriteLine(result.ToString());  // Output: "progamin"
    }
}



//3
using System;
using System.Text;

public class ConcatenateStrings
{
    public static void Main(string[] args)
    {
        string[] stringsArray = { "Hello", " ", "world", "!", " ", "Let's", " ", "concatenate", " ", "strings", "." };
        StringBuilder stringBuilder = new StringBuilder();

        foreach (string str in stringsArray)
        {
            stringBuilder.Append(str);
        }

        string result = stringBuilder.ToString();
        Console.WriteLine(result);  // Output: "Hello world! Let's concatenate strings."
    }
}


//4
using System;
using System.Text;
using System.Diagnostics;

public class PerformanceComparison
{
    public static void Main(string[] args)
    {
        int iterations = 10000;
        string[] stringsArray = { "This", "is", "a", "simple", "test", "string." };

        // Measure performance of simple string concatenation
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        string concatenatedString = "";
        for (int i = 0; i < iterations; i++)
        {
            foreach (string str in stringsArray)
            {
                concatenatedString += str;
            }
        }
        stopwatch1.Stop();
        Console.WriteLine("Simple concatenation time: " + stopwatch1.ElapsedMilliseconds + " ms");

        // Measure performance of StringBuilder concatenation
        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            foreach (string str in stringsArray)
            {
                stringBuilder.Append(str);
            }
        }
        stopwatch2.Stop();
        Console.WriteLine("StringBuilder concatenation time: " + stopwatch2.ElapsedMilliseconds + " ms");
    }
}


//5
using System;
using System.IO;

public class ReadFileLineByLine
{
    public static void Main(string[] args)
    {
        // Specify the file path
        string filePath = "path/to/your/file.txt";

        try
        {
            // Create a StreamReader to read the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                // Read the file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}


//6
using System;
using System.IO;
public class CountWordOccurrences
{
    public static void Main(string[] args)
    {
        // Specify the file path and the word to search for
        string filePath = "path/to/your/file.txt";
        string wordToFind = "specificWord";
        int wordCount = 0;

        try
        {
            // Create a StreamReader to read the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                // Read the file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into words
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                        {
                            wordCount++;
                        }
                    }
                }
            }
            
            Console.WriteLine($"The word '{wordToFind}' appears {wordCount} times in the file.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}


//7
using System;
using System.IO;
using System.Text;

public class ByteToCharStream
{
    public static void Main(string[] args)
    {
        // Specify the file path
        string filePath = "path/to/your/file.txt";
        
        try
        {
            // Open the file stream
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Create a StreamReader to read from the FileStream
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    // Read the file line by line and print each line as characters
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}


//8
using System;
using System.IO;

public class WriteUserInputToFile
{
    public static void Main(string[] args)
    {
        // Specify the file path
        string filePath = "path/to/your/output.txt";
        
        try
        {
            // Create a StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("Enter text (type 'exit' to stop):");

                string input;
                while ((input = Console.ReadLine()) != null)
                {
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    // Write the user input to the file
                    writer.WriteLine(input);
                }
            }

            Console.WriteLine("User input has been written to the file.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}


//9
using System;
public class FindFirstNegative
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 5, -2, 8, -7, 6, -1 };
        int result = FindFirstNegativeNumber(array);

        if (result != -1)
        {
            Console.WriteLine("The first negative number is: " + result);
        }
        else
        {
            Console.WriteLine("No negative numbers found in the array.");
        }
    }

    public static int FindFirstNegativeNumber(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                return array[i];
            }
        }
        return -1; // Return -1 if no negative number is found
    }
}


//10
using System;
public class FindSentenceContainingWord
{
    public static void Main(string[] args)
    {
        string[] sentences = {
            "The quick brown fox jumps over the lazy dog.",
            "Hello, how are you?",
            "This is a test sentence.",
            "Another example sentence."
        };

        string wordToFind = "test";
        string result = FindFirstSentenceWithWord(sentences, wordToFind);

        if (result != null)
        {
            Console.WriteLine("The first sentence containing the word '" + wordToFind + "' is: " + result);
        }
        else
        {
            Console.WriteLine("No sentence containing the word '" + wordToFind + "' was found.");
        }
    }

    public static string FindFirstSentenceWithWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return sentence;
            }
        }
        return null; // Return null if no sentence containing the word is found
    }
}


//11
using System;

public class FindRotationPoint
{
    public static void Main(string[] args)
    {
        int[] array = { 6, 7, 1, 2, 3, 4, 5 };
        int rotationPointIndex = FindRotationPointIndex(array);
        Console.WriteLine("The index of the smallest element is: " + rotationPointIndex);
    }

    public static int FindRotationPointIndex(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] > array[right])
            {
                // Rotation point is to the right of mid
                left = mid + 1;
            }
            else
            {
                // Rotation point is to the left of mid
                right = mid;
            }
        }

        return left; // or right, since left == right at the end
    }
}


//12
using System;

public class FindPeakElement
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 3, 20, 4, 1, 0 };
        int peakIndex = FindPeak(array);
        Console.WriteLine("A peak element is at index: " + peakIndex);
    }

    public static int FindPeak(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] > array[mid + 1])
            {
                // The peak is in the left half (including mid)
                right = mid;
            }
            else
            {
                // The peak is in the right half (excluding mid)
                left = mid + 1;
            }
        }

        // left and right converge to the peak element
        return left;
    }
}


//13
using System;

public class Search2DMatrix
{
    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 50 }
        };
        int target = 16;
        bool found = SearchMatrix(matrix, target);

        Console.WriteLine(found ? "Target found in the matrix." : "Target not found in the matrix.");
    }

    public static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int left = 0;
        int right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target)
            {
                return true;
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}


//14
using System;

public class FindFirstAndLastOccurrence
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 2, 2, 3, 4, 5 };
        int target = 2;
        int firstOccurrence = FindFirstOccurrence(array, target);
        int lastOccurrence = FindLastOccurrence(array, target);

        Console.WriteLine("First occurrence of " + target + " is at index: " + firstOccurrence);
        Console.WriteLine("Last occurrence of " + target + " is at index: " + lastOccurrence);
    }

    public static int FindFirstOccurrence(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                result = mid;
                right = mid - 1; // Continue to search in the left half
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    public static int FindLastOccurrence(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                result = mid;
                left = mid + 1; // Continue to search in the right half
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}



//15

using System;

public class FindMissingPositiveAndTarget
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 4, -1, 1 };
        int target = 4;

        int firstMissingPositive = FindFirstMissingPositive(array);
        Console.WriteLine("The first missing positive integer is: " + firstMissingPositive);

        Array.Sort(array);
        int targetIndex = BinarySearch(array, target);
        Console.WriteLine("The index of the target number " + target + " is: " + targetIndex);
    }

    public static int FindFirstMissingPositive(int[] array)
    {
        int n = array.Length;

        // Mark elements as visited by making them negative
        for (int i = 0; i < n; i++)
        {
            while (array[i] > 0 && array[i] <= n && array[array[i] - 1] != array[i])
            {
                int temp = array[array[i] - 1];
                array[array[i] - 1] = array[i];
                array[i] = temp;
            }
        }

        // Find the first positive element that is not at its correct position
        for (int i = 0; i < n; i++)
        {
            if (array[i] != i + 1)
            {
                return i + 1;
            }
        }

        return n + 1;
    }

    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Return -1 if the target is not found
    }
}

