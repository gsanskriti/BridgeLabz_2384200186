//1
using System;
using System.Collections.Generic;

class ReverseList
{
    // Method to reverse a List
    public static List<int> ReverseListMethod(List<int> list)
    {
        List<int> reversedList = new List<int>();
        for (int i = list.Count - 1; i >= 0; i--)
        {
            reversedList.Add(list[i]);
        }
        return reversedList;
    }

    // Method to reverse a LinkedList
    public static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> reversedList = new LinkedList<int>();
        for (var node = list.Last; node != null; node = node.Previous)
        {
            reversedList.AddLast(node.Value);
        }
        return reversedList;
    }

    static void Main(string[] args)
    {
        // Example for List
        List<int> arrayList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> reversedArrayList = ReverseListMethod(arrayList);
        Console.WriteLine("Reversed List: " + string.Join(", ", reversedArrayList));

        // Example for LinkedList
        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
        Console.Write("Reversed LinkedList: ");
        foreach (var item in reversedLinkedList)
        {
            Console.Write(item + " ");
        }
    }
}

//2
using System;
using System.Collections.Generic;

class FrequencyCounter
{
    // Method to count the frequency of elements in a list
    public static Dictionary<string, int> CountFrequency(List<string> items)
    {
        Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

        foreach (var item in items)
        {
            if (frequencyDict.ContainsKey(item))
            {
                frequencyDict[item]++;
            }
            else
            {
                frequencyDict[item] = 1;
            }
        }

        return frequencyDict;
    }

    static void Main(string[] args)
    {
        // Example input
        List<string> inputList = new List<string> { "apple", "banana", "apple", "orange" };

        // Count frequency
        Dictionary<string, int> frequencyResult = CountFrequency(inputList);

        // Print the results
        Console.WriteLine("Frequency of elements:");
        foreach (var kvp in frequencyResult)
        {
            Console.WriteLine($"\"{kvp.Key}\": {kvp.Value}");
        }
    }
}


//3
using System;
using System.Collections.Generic;

class RotateList
{
    // Method to rotate the elements of a list
    public static List<int> Rotate(List<int> list, int positions)
    {
        int count = list.Count;
        // Normalize the number of positions
        positions = positions % count;

        // Create a new list to hold the rotated elements
        List<int> rotatedList = new List<int>();

        // Add the elements from the rotated position to the end of the new list
        for (int i = positions; i < count; i++)
        {
            rotatedList.Add(list[i]);
        }

        // Add the elements from the start of the original list to the new list
        for (int i = 0; i < positions; i++)
        {
            rotatedList.Add(list[i]);
        }

        return rotatedList;
    }

    static void Main(string[] args)
    {
        // Example input
        List<int> inputList = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;

        // Rotate the list
        List<int> rotatedList = Rotate(inputList, rotateBy);

        // Print the results
        Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
    }
}


//4
using System;
using System.Collections.Generic;

class RemoveDuplicates
{
    // Method to remove duplicates while preserving order
    public static List<int> RemoveDuplicatesFromList(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (var item in list)
        {
            // If the item has not been seen before, add it to the result
            if (seen.Add(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        // Example input
        List<int> inputList = new List<int> { 3, 1, 2, 2, 3, 4 };

        // Remove duplicates
        List<int> resultList = RemoveDuplicatesFromList(inputList);

        // Print the results
        Console.WriteLine("List after removing duplicates: " + string.Join(", ", resultList));
    }
}


//5
using System;
using System.Collections.Generic;

class Program
{
    // Method to find the Nth element from the end of a linked list
    public static T FindNthFromEnd<T>(LinkedList<T> linkedList, int n)
    {
        LinkedListNode<T> firstPointer = linkedList.First;
        LinkedListNode<T> secondPointer = linkedList.First;

        // Move the first pointer N nodes ahead
        for (int i = 0; i < n; i++)
        {
            if (firstPointer == null)
            {
                throw new ArgumentOutOfRangeException("N is larger than the size of the linked list.");
            }
            firstPointer = firstPointer.Next;
        }

        // Move both pointers until the first pointer reaches the end
        while (firstPointer != null)
        {
            firstPointer = firstPointer.Next;
            secondPointer = secondPointer.Next;
        }

        // The second pointer is now at the Nth node from the end
        return secondPointer.Value;
    }

    static void Main(string[] args)
    {
        // Create a linked list
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("A");
        linkedList.AddLast("B");
        linkedList.AddLast("C");
        linkedList.AddLast("D");
        linkedList.AddLast("E");

        // Specify N
        int N = 2;

        // Find the Nth element from the end
        try
        {
            string result = FindNthFromEnd(linkedList, N);
            Console.WriteLine($"The {N}th element from the end is: {result}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


//Set Interface Problems
//1
using System;
using System.Collections.Generic;

class Program
{
    // Method to check if two sets are equal
    public static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        // Check if both sets contain the same elements
        return set1.SetEquals(set2);
    }

    static void Main(string[] args)
    {
        // Example sets
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

        // Check if the sets are equal
        bool result = AreSetsEqual(set1, set2);

        // Print the result
        Console.WriteLine($"Are the two sets equal? {result}");
    }
}

//2
using System;
using System.Collections.Generic;

class Program
{
    // Method to compute the union of two sets
    public static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);
        return unionSet;
    }

    // Method to compute the intersection of two sets
    public static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2);
        return intersectionSet;
    }

    static void Main(string[] args)
    {
        // Example sets
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        // Compute union and intersection
        HashSet<int> unionResult = Union(set1, set2);
        HashSet<int> intersectionResult = Intersection(set1, set2);

        // Print the results
        Console.WriteLine($"Union: {{{string.Join(", ", unionResult)}}}");
        Console.WriteLine($"Intersection: {{{string.Join(", ", intersectionResult)}}}");
    }
}


//3
using System;
using System.Collections.Generic;

class Program
{
    // Method to compute the symmetric difference of two sets
    public static HashSet<int> SymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        // Create a new HashSet to hold the symmetric difference
        HashSet<int> symmetricDiff = new HashSet<int>(set1);
        
        // Add elements from set2 to the symmetric difference
        symmetricDiff.UnionWith(set2);
        
        // Remove elements that are in both sets (intersection)
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        
        symmetricDiff.ExceptWith(intersection);
        
        return symmetricDiff;
    }

    static void Main(string[] args)
    {
        // Example sets
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        // Compute symmetric difference
        HashSet<int> symmetricDiffResult = SymmetricDifference(set1, set2);

        // Print the result
        Console.WriteLine($"Symmetric Difference: {{{string.Join(", ", symmetricDiffResult)}}}");
    }
}


//4
using System;
using System.Collections.Generic;

class Program
{
    // Method to convert a HashSet to a sorted list
    public static List<int> ConvertSetToSortedList(HashSet<int> set)
    {
        // Create a list from the HashSet
        List<int> sortedList = new List<int>(set);
        
        // Sort the list in ascending order
        sortedList.Sort();
        
        return sortedList;
    }

    static void Main(string[] args)
    {
        // Example input
        HashSet<int> inputSet = new HashSet<int> { 5, 3, 9, 1 };

        // Convert to sorted list
        List<int> sortedList = ConvertSetToSortedList(inputSet);

        // Print the result
        Console.WriteLine($"Sorted List: [{string.Join(", ", sortedList)}]");
    }
}


//5
using System;
using System.Collections.Generic;

class Program
{
    // Method to check if set1 is a subset of set2
    public static bool IsSubset(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.IsSubsetOf(set2);
    }

    static void Main(string[] args)
    {
        // Example sets
        HashSet<int> set1 = new HashSet<int> { 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

        // Check if set1 is a subset of set2
        bool result = IsSubset(set1, set2);

        // Print the result
        Console.WriteLine($"Is set1 a subset of set2? {result}");
    }
}


//Queue Interface Problems
//1
using System;
using System.Collections.Generic;

class Program
{
    // Method to reverse the queue
    public static void ReverseQueue(Queue<int> queue)
    {
        // Base case: if the queue is empty, return
        if (queue.Count == 0)
        {
            return;
        }

        // Dequeue the front element
        int front = queue.Dequeue();

        // Recursively reverse the remaining queue
        ReverseQueue(queue);

        // Enqueue the front element back to the queue
        queue.Enqueue(front);
    }

    static void Main(string[] args)
    {
        // Example input
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Reverse the queue
        ReverseQueue(queue);

        // Print the reversed queue
        Console.WriteLine("Reversed Queue: [" + string.Join(", ", queue) + "]");
    }
}


//2
using System;
using System.Collections.Generic;

class Program
{
    // Method to generate the first N binary numbers
    public static List<string> GenerateBinaryNumbers(int n)
    {
        List<string> binaryNumbers = new List<string>();
        Queue<string> queue = new Queue<string>();

        // Start with the first binary number
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            // Dequeue the front element
            string current = queue.Dequeue();
            binaryNumbers.Add(current);

            // Generate the next binary numbers and enqueue them
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }

        return binaryNumbers;
    }

    static void Main(string[] args)
    {
        // Example input
        int N = 5;

        // Generate binary numbers
        List<string> binaryNumbers = GenerateBinaryNumbers(N);

        // Print the result
        Console.WriteLine("First " + N + " binary numbers: {" + string.Join(", ", binaryNumbers) + "}");
    }
}

//3

using System;
using System.Collections.Generic;

class Patient : IComparable<Patient>
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }

    // Compare patients based on severity (higher severity first)
    public int CompareTo(Patient other)
    {
        // Return negative if this patient has higher severity
        return other.Severity.CompareTo(this.Severity);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a priority queue for patients
        PriorityQueue<Patient, Patient> patientQueue = new PriorityQueue<Patient, Patient>();

        // Example patients
        patientQueue.Enqueue(new Patient("John", 3), new Patient("John", 3));
        patientQueue.Enqueue(new Patient("Alice", 5), new Patient("Alice", 5));
        patientQueue.Enqueue(new Patient("Bob", 2), new Patient("Bob", 2));

        // Process patients based on severity
        Console.WriteLine("Order of treatment:");
        while (patientQueue.Count > 0)
        {
            Patient nextPatient = patientQueue.Dequeue();
            Console.WriteLine(nextPatient.Name);
        }
    }
}



//Map Interface Problems
//1
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Specify the path to the text file
        string filePath = "input.txt"; // Change this to your file path

        // Read the file and count word frequencies
        Dictionary<string, int> wordFrequencies = CountWordFrequencies(filePath);

        // Print the results
        Console.WriteLine("Word Frequencies:");
        foreach (var kvp in wordFrequencies)
        {
            Console.WriteLine($"\"{kvp.Key}\": {kvp.Value}");
        }
    }

    static Dictionary<string, int> CountWordFrequencies(string filePath)
    {
        // Initialize a dictionary to hold word frequencies
        Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        // Read all text from the file
        string text = File.ReadAllText(filePath);

        // Normalize the text: convert to lowercase and remove punctuation
        string normalizedText = Regex.Replace(text.ToLower(), @"[^\w\s]", "");

        // Split the text into words
        string[] words = normalizedText.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Count the frequency of each word
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        return wordCount;
    }
}


//2
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Example input dictionary
        Dictionary<string, int> originalDict = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        // Invert the dictionary
        Dictionary<int, List<string>> invertedDict = InvertDictionary(originalDict);

        // Print the output
        Console.WriteLine("Inverted Dictionary:");
        foreach (var kvp in invertedDict)
        {
            Console.WriteLine($"{kvp.Key} = [{string.Join(", ", kvp.Value)}]");
        }
    }

    static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> original)
    {
        // Create a new dictionary to hold the inverted values
        Dictionary<V, List<K>> inverted = new Dictionary<V, List<K>>();

        // Iterate through the original dictionary
        foreach (var kvp in original)
        {
            // If the value is not already a key in the inverted dictionary, add it
            if (!inverted.ContainsKey(kvp.Value))
            {
                inverted[kvp.Value] = new List<K>();
            }

            // Add the key to the list of keys for this value
            inverted[kvp.Value].Add(kvp.Key);
        }

        return inverted;
    }
}


//Insurance Policy Management System
using System;
using System.Collections.Generic;
using System.Linq;

public class InsurancePolicy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override string ToString()
    {
        return $"PolicyNumber: {PolicyNumber}, CoverageType: {CoverageType}, ExpiryDate: {ExpiryDate.ToShortDateString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // HashSet for unique policies
        HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>(new PolicyComparer());

        // List to maintain the order of insertion (simulating LinkedHashSet)
        List<InsurancePolicy> orderedPolicies = new List<InsurancePolicy>();

        // SortedSet to maintain policies sorted by expiry date
        SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>(new PolicyExpiryComparer());

        // Sample policies
        AddPolicy(uniquePolicies, orderedPolicies, sortedPolicies, new InsurancePolicy("P001", "Health", DateTime.Now.AddDays(10)));
        AddPolicy(uniquePolicies, orderedPolicies, sortedPolicies, new InsurancePolicy("P002", "Auto", DateTime.Now.AddDays(40)));
        AddPolicy(uniquePolicies, orderedPolicies, sortedPolicies, new InsurancePolicy("P003", "Home", DateTime.Now.AddDays(20)));
        AddPolicy(uniquePolicies, orderedPolicies, sortedPolicies, new InsurancePolicy("P001", "Health", DateTime.Now.AddDays(10))); // Duplicate

        // Retrieve all unique policies
        Console.WriteLine("All Unique Policies:");
        foreach (var policy in uniquePolicies)
        {
            Console.WriteLine(policy);
        }

        // Retrieve policies expiring soon (within the next 30 days)
        Console.WriteLine("\nPolicies Expiring Soon (within 30 days):");
        var expiringSoon = uniquePolicies.Where(p => (p.ExpiryDate - DateTime.Now).TotalDays <= 30);
        foreach (var policy in expiringSoon)
        {
            Console.WriteLine(policy);
        }

        // Retrieve policies with a specific coverage type
        string coverageTypeToSearch = "Health";
        Console.WriteLine($"\nPolicies with Coverage Type '{coverageTypeToSearch}':");
        var specificCoveragePolicies = uniquePolicies.Where(p => p.CoverageType.Equals(coverageTypeToSearch, StringComparison.OrdinalIgnoreCase));
        foreach (var policy in specificCoveragePolicies)
        {
            Console.WriteLine(policy);
        }

        // Retrieve duplicate policies based on policy numbers
        Console.WriteLine("\nDuplicate Policies based on Policy Numbers:");
        var duplicatePolicies = uniquePolicies.GroupBy(p => p.PolicyNumber)
                                              .Where(g => g.Count() > 1)
                                              .SelectMany(g => g);
        foreach (var policy in duplicatePolicies)
        {
            Console.WriteLine(policy);
        }
    }

    static void AddPolicy(HashSet<InsurancePolicy> uniquePolicies, List<InsurancePolicy> orderedPolicies, SortedSet<InsurancePolicy> sortedPolicies, InsurancePolicy policy)
    {
        // Add to HashSet for uniqueness
        if (uniquePolicies.Add(policy))
        {
            // Add to ordered list
            orderedPolicies.Add(policy);
            // Add to sorted set
            sortedPolicies.Add(policy);
        }
    }
}

// Comparer for HashSet to ensure uniqueness based on PolicyNumber
public class PolicyComparer : IEqualityComparer<InsurancePolicy>
{
    public bool Equals(InsurancePolicy x, InsurancePolicy y)
    {
        return x.PolicyNumber == y.PolicyNumber;
    }

    public int GetHashCode(InsurancePolicy obj)
    {
        return obj.PolicyNumber.GetHashCode();
    }
}

// Comparer for SortedSet to sort by ExpiryDate
public class PolicyExpiryComparer : IComparer<InsurancePolicy>
{
    public int Compare(InsurancePolicy x, InsurancePolicy y)
    {
        return x.ExpiryDate.CompareTo(y.ExpiryDate);
    }
}



//Design a Voting System
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary to store votes
        Dictionary<string, int> votes = new Dictionary<string, int>();

        // List to maintain the order of votes (simulating LinkedHashMap)
        List<KeyValuePair<string, int>> orderedVotes = new List<KeyValuePair<string, int>>();

        // SortedDictionary to display results in order
        SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();

        // Simulate voting
        CastVote(votes, orderedVotes, sortedVotes, "Alice");
        CastVote(votes, orderedVotes, sortedVotes, "Bob");
        CastVote(votes, orderedVotes, sortedVotes, "Alice");
        CastVote(votes, orderedVotes, sortedVotes, "Charlie");
        CastVote(votes, orderedVotes, sortedVotes, "Bob");
        CastVote(votes, orderedVotes, sortedVotes, "Alice");

        // Display results
        Console.WriteLine("Voting Results:");
        DisplayResults(sortedVotes);

        // Display ordered votes
        Console.WriteLine("\nOrdered Votes:");
        foreach (var vote in orderedVotes)
        {
            Console.WriteLine($"{vote.Key}: {vote.Value}");
        }
    }

    static void CastVote(Dictionary<string, int> votes, List<KeyValuePair<string, int>> orderedVotes, SortedDictionary<string, int> sortedVotes, string candidate)
    {
        // Increment the vote count in the dictionary
        if (votes.ContainsKey(candidate))
        {
            votes[candidate]++;
        }
        else
        {
            votes[candidate] = 1;
        }

        // Update the ordered votes list
        orderedVotes.Add(new KeyValuePair<string, int>(candidate, votes[candidate]));

        // Update the sorted votes dictionary
        sortedVotes[candidate] = votes[candidate];
    }

    static void DisplayResults(SortedDictionary<string, int> sortedVotes)
    {
        foreach (var kvp in sortedVotes)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}


//Implement a Shopping Cart
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary to store product prices
        Dictionary<string, double> productPrices = new Dictionary<string, double>
        {
            { "Apple", 0.60 },
            { "Banana", 0.50 },
            { "Orange", 0.80 },
            { "Mango", 1.20 },
            { "Grapes", 2.00 }
        };

        // List to maintain the order of items (simulating LinkedDictionary)
        List<KeyValuePair<string, double>> orderedCart = new List<KeyValuePair<string, double>>();

        // SortedDictionary to display items sorted by price
        SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>();

        // Simulate adding items to the cart
        AddToCart(orderedCart, sortedCart, productPrices, "Apple", 3);
        AddToCart(orderedCart, sortedCart, productPrices, "Banana", 2);
        AddToCart(orderedCart, sortedCart, productPrices, "Orange", 1);
        AddToCart(orderedCart, sortedCart, productPrices, "Mango", 1);
        AddToCart(orderedCart, sortedCart, productPrices, "Grapes", 1);

        // Display the ordered cart
        Console.WriteLine("Shopping Cart (Ordered):");
        DisplayOrderedCart(orderedCart);

        // Display the sorted cart
        Console.WriteLine("\nShopping Cart (Sorted by Price):");
        DisplaySortedCart(sortedCart);
    }

    static void AddToCart(List<KeyValuePair<string, double>> orderedCart, SortedDictionary<string, double> sortedCart, Dictionary<string, double> productPrices, string product, int quantity)
    {
        if (productPrices.ContainsKey(product))
        {
            double price = productPrices[product] * quantity;

            // Add to ordered cart
            orderedCart.Add(new KeyValuePair<string, double>(product, price));

            // Add to sorted cart
            if (sortedCart.ContainsKey(product))
            {
                sortedCart[product] += price; // Update if already exists
            }
            else
            {
                sortedCart[product] = price; // Add new product
            }
        }
        else
        {
            Console.WriteLine($"Product '{product}' not found.");
        }
    }

    static void DisplayOrderedCart(List<KeyValuePair<string, double>> orderedCart)
    {
        foreach (var item in orderedCart)
        {
            Console.WriteLine($"{item.Key}: ${item.Value:F2}");
        }
    }

    static void DisplaySortedCart(SortedDictionary<string, double> sortedCart)
    {
        foreach (var item in sortedCart)
        {
            Console.WriteLine($"{item.Key}: ${item.Value:F2}");
        }
    }
}

//Implement a Banking System
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary to store account balances (Account ID -> Balance)
        Dictionary<int, double> accountBalances = new Dictionary<int, double>
        {
            { 101, 500.00 },
            { 102, 1500.50 },
            { 103, 250.75 },
            { 104, 1000.00 }
        };

        // SortedDictionary to sort customers by balance
        SortedDictionary<double, List<int>> sortedAccounts = new SortedDictionary<double, List<int>>();

        // Queue to process withdrawal requests (Account ID, Amount)
        Queue<Tuple<int, double>> withdrawalRequests = new Queue<Tuple<int, double>>();

        // Initialize sorted accounts
        InitializeSortedAccounts(accountBalances, sortedAccounts);

        // Process some withdrawal requests
        ProcessWithdrawal(withdrawalRequests, accountBalances, 101, 100.00);
        ProcessWithdrawal(withdrawalRequests, accountBalances, 102, 200.00);
        ProcessWithdrawal(withdrawalRequests, accountBalances, 103, 300.00); // Exceeds balance
        ProcessWithdrawal(withdrawalRequests, accountBalances, 104, 500.00);

        // Process all withdrawal requests
        Console.WriteLine("\nProcessing Withdrawal Requests:");
        while (withdrawalRequests.Count > 0)
        {
            var request = withdrawalRequests.Dequeue();
            ProcessWithdrawalRequest(request.Item1, request.Item2, accountBalances, sortedAccounts);
        }

        // Display final account balances
        Console.WriteLine("\nFinal Account Balances:");
        DisplayAccountBalances(accountBalances);
    }

    static void InitializeSortedAccounts(Dictionary<int, double> accountBalances, SortedDictionary<double, List<int>> sortedAccounts)
    {
        foreach (var account in accountBalances)
        {
            if (!sortedAccounts.ContainsKey(account.Value))
            {
                sortedAccounts[account.Value] = new List<int>();
            }
            sortedAccounts[account.Value].Add(account.Key);
        }
    }

    static void ProcessWithdrawal(Queue<Tuple<int, double>> withdrawalRequests, Dictionary<int, double> accountBalances, int accountId, double amount)
    {
        if (accountBalances.ContainsKey(accountId))
        {
            if (accountBalances[accountId] >= amount)
            {
                withdrawalRequests.Enqueue(new Tuple<int, double>(accountId, amount));
            }
            else
            {
                Console.WriteLine($"Withdrawal request for Account ID {accountId} of ${amount} denied: Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine($"Account ID {accountId} not found.");
        }
    }

    static void ProcessWithdrawalRequest(int accountId, double amount, Dictionary<int, double> accountBalances, SortedDictionary<double, List<int>> sortedAccounts)
    {
        // Update account balance
        accountBalances[accountId] -= amount;

        // Update sorted accounts
        UpdateSortedAccounts(accountId, amount, accountBalances, sortedAccounts);

        Console.WriteLine($"Withdrawal of ${amount} processed for Account ID {accountId}. New balance: ${accountBalances[accountId]:F2}");
    }

    static void UpdateSortedAccounts(int accountId, double amount, Dictionary<int, double> accountBalances, SortedDictionary<double, List<int>> sortedAccounts)
    {
        // Remove account from old balance
        double oldBalance = accountBalances[accountId] + amount; // Get the old balance before withdrawal
        sortedAccounts[oldBalance].Remove(accountId);
        if (sortedAccounts[oldBalance].Count == 0)
        {
            sortedAccounts.Remove(oldBalance);
        }

        // Add account to new balance
        double newBalance = accountBalances[accountId];
        if (!sortedAccounts.ContainsKey(newBalance))
        {
            sortedAccounts[newBalance] = new List<int>();
        }
        sortedAccounts[newBalance].Add(accountId);
    }

    static void DisplayAccountBalances(Dictionary<int, double> accountBalances)
    {
        foreach (var account in accountBalances)
        {
            Console.WriteLine($"Account ID {account.Key}: ${account.Value:F2}");
        }
    }
}