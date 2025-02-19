//1
using System;
using System.Collections.Generic;

public class QueueUsingStacks
{
    private Stack<int> stack1; // Stack for enqueue operations
    private Stack<int> stack2; // Stack for dequeue operations

    public QueueUsingStacks()
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }

    // Enqueue an element into the queue
    public void Enqueue(int x)
    {
        stack1.Push(x);
    }

    // Dequeue an element from the queue
    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        if (stack2.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return stack2.Pop();
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }

    // Get the front element of the queue without removing it
    public int Front()
    {
        if (stack2.Count > 0)
        {
            return stack2.Peek();
        }
        if (stack1.Count > 0)
        {
            // Need to transfer elements to get the front element
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Peek();
        }
        throw new InvalidOperationException("Queue is empty");
    }
}

// Example usage
class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine(queue.Dequeue());  // Output: 1
        Console.WriteLine(queue.Dequeue());  // Output: 2
        queue.Enqueue(4);
        Console.WriteLine(queue.Dequeue());  // Output: 3
        Console.WriteLine(queue.Dequeue());  // Output: 4
    }
}


//2

using System;
using System.Collections.Generic;

public class StackSorter
{
    // Function to sort the stack
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int top = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, top);
        }
    }

    // Helper function to insert an element in a sorted manner
    private static void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || element > stack.Peek())
        {
            stack.Push(element);
            return;
        }

        int top = stack.Pop();
        InsertSorted(stack, element);
        stack.Push(top);
    }

    // Helper function to print the stack elements
    public static void PrintStack(Stack<int> stack)
    {
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Example usage
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(34);
        stack.Push(3);
        stack.Push(31);
        stack.Push(98);
        stack.Push(92);
        stack.Push(23);

        Console.WriteLine("Original Stack:");
        PrintStack(stack);

        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        PrintStack(stack);
    }
}


//3
using System;
using System.Collections.Generic;

public class StockSpan
{
    // Function to calculate stock span values
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        // Calculate span values for each day
        for (int i = 0; i < n; i++)
        {
            // Pop elements from stack while stack is not empty and the top of stack is less than or equal to current price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // If stack is empty, then all elements on left are less than current price
            // Else the span is the difference between current index and index of last greater element
            span[i] = stack.Count == 0 ? (i + 1) : (i - stack.Peek());

            // Push this element to stack
            stack.Push(i);
        }

        return span;
    }

    // Helper function to print array elements
    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Example usage
    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(prices);

        Console.WriteLine("Stock prices:");
        PrintArray(prices);

        Console.WriteLine("Span values:");
        PrintArray(span);
    }
}


//4

using System;
using System.Collections.Generic;

public class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
        {
            return new int[0];
        }
        
        int n = nums.Length;
        int[] result = new int[n - k + 1];
        Deque<int> deque = new Deque<int>();

        for (int i = 0; i < n; i++)
        {
            // Remove elements not within the sliding window
            if (deque.Count > 0 && deque.PeekFirst() < i - k + 1)
            {
                deque.PopFirst();
            }
            
            // Remove elements smaller than the current element from the deque
            while (deque.Count > 0 && nums[deque.PeekLast()] < nums[i])
            {
                deque.PopLast();
            }
            
            // Add current element's index to the deque
            deque.PushLast(i);
            
            // The front element of the deque is the maximum element of the current window
            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque.PeekFirst()];
            }
        }
        
        return result;
    }

    // Helper function to print array elements
    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Example usage
    public static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = MaxSlidingWindow(nums, k);

        Console.WriteLine("Array elements:");
        PrintArray(nums);

        Console.WriteLine("Maximum elements in each sliding window:");
        PrintArray(result);
    }
}

// Implementation of a Deque (double-ended queue)
public class Deque<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void PushLast(T value)
    {
        list.AddLast(value);
    }

    public T PopFirst()
    {
        T value = list.First.Value;
        list.RemoveFirst();
        return value;
    }

    public T PeekFirst()
    {
        return list.First.Value;
    }

    public T PeekLast()
    {
        return list.Last.Value;
    }

    public int Count
    {
        get { return list.Count; }
    }
}


//5

using System;
using System.Collections.Generic;

public class PetrolPump
{
    public int Petrol { get; set; }
    public int Distance { get; set; }
    
    public PetrolPump(int petrol, int distance)
    {
        Petrol = petrol;
        Distance = distance;
    }
}

public class CircularTour
{
    public static int FindStartingPoint(List<PetrolPump> pumps)
    {
        int start = 0;
        int end = 1;
        int currentPetrol = pumps[start].Petrol - pumps[start].Distance;

        while (end != start || currentPetrol < 0)
        {
            // If current petrol is less than 0, then remove the starting pump
            while (currentPetrol < 0 && start != end)
            {
                currentPetrol -= pumps[start].Petrol - pumps[start].Distance;
                start = (start + 1) % pumps.Count;
                
                // If start equals 0, all pumps have been tried and no solution found
                if (start == 0)
                {
                    return -1;
                }
            }
            
            // Add petrol and distance of the current pump to currentPetrol
            currentPetrol += pumps[end].Petrol - pumps[end].Distance;
            end = (end + 1) % pumps.Count;
        }

        return start;
    }

    // Example usage
    public static void Main()
    {
        List<PetrolPump> pumps = new List<PetrolPump>
        {
            new PetrolPump(4, 6),
            new PetrolPump(6, 5),
            new PetrolPump(7, 3),
            new PetrolPump(4, 5)
        };

        int startPoint = FindStartingPoint(pumps);

        if (startPoint == -1)
        {
            Console.WriteLine("No solution exists");
        }
        else
        {
            Console.WriteLine("Start at petrol pump index: " + startPoint);
        }
    }
}


//6

using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    public static List<Tuple<int, int>> FindAllZeroSumSubarrays(int[] arr)
    {
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            cumulativeSum += arr[i];

            // If the cumulative sum is zero, we found a subarray from the start to the current index
            if (cumulativeSum == 0)
            {
                result.Add(Tuple.Create(0, i));
            }

            // If the cumulative sum has been seen before, it means there is a subarray with zero sum
            if (sumMap.ContainsKey(cumulativeSum))
            {
                foreach (int start in sumMap[cumulativeSum])
                {
                    result.Add(Tuple.Create(start + 1, i));
                }
            }

            // Add the current index to the list of indices for the current cumulative sum
            if (!sumMap.ContainsKey(cumulativeSum))
            {
                sumMap[cumulativeSum] = new List<int>();
            }
            sumMap[cumulativeSum].Add(i);
        }

        return result;
    }

    // Helper function to print subarray indices
    public static void PrintSubarrays(List<Tuple<int, int>> subarrays)
    {
        foreach (var subarray in subarrays)
        {
            Console.WriteLine($"Subarray found from index {subarray.Item1} to {subarray.Item2}");
        }
    }

    // Example usage
    public static void Main()
    {
        int[] arr = { 3, 4, -7, 1, 3, 3, 1, -4, -2, -2 };
        List<Tuple<int, int>> subarrays = FindAllZeroSumSubarrays(arr);

        PrintSubarrays(subarrays);
    }
}



//7

using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    public static bool CheckForPair(int[] arr, int target)
    {
        // Create a hash map to store visited numbers
        Dictionary<int, bool> map = new Dictionary<int, bool>();

        // Iterate through the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Calculate the complement of the current number
            int complement = target - arr[i];

            // Check if the complement exists in the hash map
            if (map.ContainsKey(complement))
            {
                Console.WriteLine($"Pair found: ({complement}, {arr[i]})");
                return true;
            }

            // Add the current number to the hash map
            if (!map.ContainsKey(arr[i]))
            {
                map[arr[i]] = true;
            }
        }

        // If no pair is found
        return false;
    }

    // Example usage
    public static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 17;

        if (!CheckForPair(arr, target))
        {
            Console.WriteLine("No pair found");
        }
    }
}


//8

using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    public static int FindLongestConsecutiveSequence(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // Check if 'num' is the start of a sequence
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Increment the sequence
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    // Example usage
    public static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        int longestStreak = FindLongestConsecutiveSequence(nums);
        Console.WriteLine("Length of the longest consecutive sequence: " + longestStreak);
    }
}


//9

using System;
using System.Collections.Generic;

// Node class for the linked list
public class HashNode<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
    public HashNode<K, V> Next { get; set; }

    public HashNode(K key, V value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

// HashMap class
public class HashMap<K, V>
{
    private readonly int capacity;
    private readonly LinkedList<HashNode<K, V>>[] buckets;

    public HashMap(int capacity)
    {
        this.capacity = capacity;
        buckets = new LinkedList<HashNode<K, V>>[capacity];
        for (int i = 0; i < capacity; i++)
        {
            buckets[i] = new LinkedList<HashNode<K, V>>();
        }
    }

    // Generate hash code for a key
    private int GetBucketIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % capacity;
    }

    // Insert a key-value pair into the hash map
    public void Insert(K key, V value)
    {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var node in bucket)
        {
            if (node.Key.Equals(key))
            {
                node.Value = value;
                return;
            }
        }
        var newNode = new HashNode<K, V>(key, value);
        bucket.AddLast(newNode);
    }

    // Retrieve the value for a given key
    public V Get(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var node in bucket)
        {
            if (node.Key.Equals(key))
            {
                return node.Value;
            }
        }
        throw new KeyNotFoundException("Key not found: " + key);
    }

    // Remove a key-value pair from the hash map
    public void Remove(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var node in bucket)
        {
            if (node.Key.Equals(key))
            {
                bucket.Remove(node);
                return;
            }
        }
        throw new KeyNotFoundException("Key not found: " + key);
    }

    // Check if the hash map contains a key
    public bool ContainsKey(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var node in bucket)
        {
            if (node.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        HashMap<string, int> hashMap = new HashMap<string, int>(10);
        hashMap.Insert("one", 1);
        hashMap.Insert("two", 2);
        hashMap.Insert("three", 3);

        Console.WriteLine("Value for 'two': " + hashMap.Get("two")); // Output: 2

        hashMap.Remove("two");

        Console.WriteLine("Contains 'two': " + hashMap.ContainsKey("two")); // Output: False
        Console.WriteLine("Contains 'three': " + hashMap.ContainsKey("three")); // Output: True
    }
}


//10

using System;
using System.Collections.Generic;

public class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution");
    }

    // Example usage
    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        try
        {
            int[] result = FindTwoSum(nums, target);
            Console.WriteLine($"Indices of elements that add up to {target}: {result[0]}, {result[1]}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

