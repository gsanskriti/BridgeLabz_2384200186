//1

using System;

class StudentAge
{
    static void Main()
    {
        // Age for 10 students
        int[] ages = new int[10];

        // Take user input for the ages of 10 students
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            // Read input and convert to integer
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                ages[i] = age;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--; // Decrement i to repeat the input for the same student
            }
        }

        // Loop through the array and check voting eligibility
        foreach (int age in ages)
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"The student with the age {age} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with the age {age} cannot vote.");
            }
        }
    }
}


//2.

using System;

class NumberCheck
{
    static void Main()
    {
        //Define an integer array of 5 elements
        int[] numbers = new int[5];

        //store input in the array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            // Read input and convert to integer
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write($"Enter number {i + 1}: ");
            }
        }

        // Loop through the array to check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                // Check if the number is even or odd
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"The number {numbers[i]} is positive and even.");
                }
                else
                {
                    Console.WriteLine($"The number {numbers[i]} is positive and odd.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine($"The number {numbers[i]} is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Compare the first and last elements of the array
        if (numbers[0] == numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (numbers[0] > numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }
}


//3

using System;

class MultipleTable
{
    static void Main()
    {
        // Get an integer input from the user
        Console.Write("Enter a number to print its multiplication table: ");
        int number;
        
        // Validate input
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Enter a number to print its multiplication table: ");
        }

        // Define an integer array to store the results of multiplication from 1 to 10
        int[] multiplicationTable = new int[10];

        // Run a loop from 1 to 10 and store the results in the multiplication table array
        for (int i = 1; i <= 10; i++)
        {
            multiplicationTable[i - 1] = number * i; // Store the result in the array
        }

        // Display the results from the array
        Console.WriteLine($"Multiplication table of {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationTable[i - 1]}");
        }
    }
}


//4

using System;

class SumOfNumber
{
    static void Main()
    {
        // Create an array of 10 elements of type double
        double[] numbers = new double[10];
        double total = 0.0; // Variable to store the total, initialized to 0.0
        int index = 0; // Index variable initialized to 0

        // Use an infinite while loop
        while (true)
        {
            // Take user input
            Console.Write("Enter a number (0 or negative to stop): ");
            double input;

            // Validate input
            if (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Skip to the next iteration of the loop
            }

            // Check if the user entered 0 or a negative number
            if (input <= 0)
            {
                break; // Exit the loop
            }

            // Check if the index has reached the maximum size of the array
            if (index >= 10)
            {
                Console.WriteLine("Maximum limit of 10 numbers reached.");
                break; // Exit the loop
            }

            // Assign the number to the array element and increment the index
            numbers[index] = input;
            index++;
        }

        // Calculate the total of the numbers entered
        for (int i = 0; i < index; i++)
        {
            total += numbers[i]; // Add each element to the total
        }

        // Display the numbers entered
        Console.WriteLine("Numbers entered:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Display the total value
        Console.WriteLine($"Total: {total}");
    }
}


//5
using System;

class MultiplicationTable
{
    static void Main()
    {
        // Get an integer input from the user
        Console.Write("Enter a number (6 to 9) to print its multiplication table: ");
        int number;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out number) || number < 6 || number > 9)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer between 6 and 9.");
            Console.Write("Enter a number (6 to 9) to print its multiplication table: ");
        }

        // Define an integer array to store the multiplication results
        int[] multiplicationResult = new int[10];
        for (int i = 1; i <= 10; i++)
        {
            multiplicationResult[i - 1] = number * i;         }

        Console.WriteLine($"Multiplication table of {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 1]}");
        }
    }
}



//6
using System;

class MeanHeight
{
    static void Main()
    {
        // Create a double array named heights of size 11
        double[] heights = new double[11];

        // Get input values from the user
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter the height of player {i + 1} (in cm): ");
            while (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive height.");
                Console.Write($"Enter the height of player {i + 1} (in cm): ");
            }
        }

        // Find the sum of all the elements present in the array
        double sum = 0.0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i]; // Add each height to the sum
        }

        // Calculate the mean height
        double meanHeight = sum / heights.Length;

        // Print the mean height of the football team
        Console.WriteLine($"The mean height of the football team is: {meanHeight:F2} cm");
    }
}


//7

using System;

class EvenOdd
{
    static void Main()
    {
        // Get an integer input from the user
        Console.Write("Enter a natural number: ");
        int number;

        // Validate input
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Error: Please enter a valid natural number greater than 0.");
            return;         }

        // Create integer arrays for even and odd numbers
        int[] evenNumbers = new int[number / 2 + 1]; // Size for even numbers
        int[] oddNumbers = new int[number / 2 + 1];  // Size for odd numbers

        // Initialize index variables for odd and even numbers
        int evenIndex = 0;
        int oddIndex = 0;

        // Using a for loop to iterate from 1 to the number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) // Check if the number is even
            {
                evenNumbers[evenIndex] = i; // Save the even number into the array
                evenIndex++;
            }
            else // The number is odd
            {
                oddNumbers[oddIndex] = i; 
                oddIndex++;
            }
        }

        // Print the even numbers array
        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine(); 
        // Print the odd numbers array
        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
        Console.WriteLine();     }
}


//8

using System;

class FactorNumber
{
    static void Main()
    {
        // Take input for a number
        Console.Write("Enter a number to find its factors: ");
        int number;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter a number to find its factors: ");
        }

        // Initialize variables
        int maxFactor = 10; // Initial size of the factors array
        int[] factors = new int[maxFactor]; // Array to store factors
        int index = 0; // Index variable to track the number of factors

        // Find factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // Check if i is a factor
            {
                // Store the factor in the array
                if (index >= maxFactor) // Check if we need to resize the array
                {
                    // Double the size of the factors array
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor]; // Create a new array with the new size
                    Array.Copy(factors, temp, factors.Length); // Copy old factors to the new array
                    factors = temp; // Assign the new array to factors
                }
                factors[index] = i; // Add the factor to the array
                index++; // Increment the index
            }
        }

        // Display the factors of the number
        Console.WriteLine($"Factors of {number}:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine(); // New line for better formatting
    }
}


//9

using System;

class MultidimensionalArray
{
    static void Main()
    {
        // Take user input for the number of rows and columns
        Console.Write("Enter the number of rows: ");
        int rows;
        while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for rows.");
            Console.Write("Enter the number of rows: ");
        }

        Console.Write("Enter the number of columns: ");
        int columns;
        while (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for columns.");
            Console.Write("Enter the number of columns: ");
        }

        // Create a 2D array (matrix)
        int[,] matrix = new int[rows, columns];

        // Take user input to fill the 2D array
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i}, {j}]: ");
                while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Element [{i}, {j}]: ");
                }
            }
        }

        // Create a 1D array to copy the elements of the 2D array
        int[] array = new int[rows * columns];
        int index = 0; // Index variable for the 1D array

        // Copy elements from the 2D array to the 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j]; // Copy element
                index++; // Increment index
            }
        }

        // Display the elements of the 1D array
        Console.WriteLine("Elements in the 1D array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(); // New line for better formatting
    }
}


//10
using System;

class FizzBuzz
{
    static void Main()
    {
        // Take user input for a positive integer
        Console.Write("Enter a positive integer: ");
        int number;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter a positive integer: ");
        }

        // Create a string array 
        string[] results = new string[number + 1]; // +1 to include the number itself

        // Loop from 0 to the number and save results
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz"; // For multiples of both 3 and 5
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz"; // For multiples of 3
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz"; // For multiples of 5
            }
            else
            {
                results[i] = i.ToString();             }
        }

        // Print the results in the specified format
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}


