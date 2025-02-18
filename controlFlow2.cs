//0
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a year
        Console.Write("Enter a year (>= 1582): ");
        if (int.TryParse(Console.ReadLine(), out int year) && year >= 1582)
        {
            Console.WriteLine("\nUsing multiple if-else statements:");
            // Method 1: Using multiple if-else statements
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine($"{year} is a Leap Year.");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is not a Leap Year.");
                    }
                }
                else
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }

            Console.WriteLine("\nUsing a single if statement with logical operators:");
            // Method 2: Using a single if statement with logical operators
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a year >= 1582.");
        }
    }
}


//1

using System;
class Program
{
    static void Main()
    {
        // Prompt the user to enter a year
        Console.Write("Enter a year (>= 1582): ");
        if (int.TryParse(Console.ReadLine(), out int year) && year >= 1582)
        {
            // Single if condition using logical operators
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a year >= 1582.");
        }
    }
}


//2
using System;

class Program
{
    static void Main()
    {
        // Input marks for Physics, Chemistry, and Maths
        Console.Write("Enter marks for Physics (out of 100): ");
        float physics = float.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry (out of 100): ");
        float chemistry = float.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths (out of 100): ");
        float maths = float.Parse(Console.ReadLine());

        // Validate marks are in the range 0-100
        if (physics < 0 || physics > 100 || chemistry < 0 || chemistry > 100 || maths < 0 || maths > 100)
        {
            Console.WriteLine("Invalid marks entered! Please enter marks between 0 and 100.");
            return;
        }

        // Calculate total, percentage, and average
        float total = physics + chemistry + maths;
        float percentage = (total / 300) * 100;
        float average = total / 3;

        // Determine grade and remarks
        string grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below, but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        // Display results
        Console.WriteLine($"\nResults:");
        Console.WriteLine($"Average Marks: {average:F2}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}


//3

using System;

class PrimeNumberChecker
{
    static void Main()
    {
        // Enter number
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        // Variable to store if the number is prime
        bool isPrime = true;

        // Check if number is less than or equal to 1, then it's not prime
        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            // to check divisibility
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)  // If divisible, number is not prime
                {
                    isPrime = false;
                    break; // No need to continue checking further
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{num} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a prime number.");
        }
    }
}


//4

using System;

class FizzBuzz
{
    static void Main()
    {
        // Get user input
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (num <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Loop through numbers from 1 to the given number
            for (int i = 1; i <= num; i++)
            {
                // Check for multiples of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check for multiples of 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check for multiples of 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Print the number if none of the conditions are met
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}




//5

using System;

class FizzBuzz
{
    static void Main()
    {
        // Get user input
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (num <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Initialize counter variable
            int i = 1;

            // Loop from 1 to the given number using while loop
            while (i <= num)
            {
                // Check for multiples of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check for multiples of 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check for multiples of 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Print the number if none of the conditions are met
                else
                {
                    Console.WriteLine(i);
                }

                // Increment the counter
                i++;
            }
        }
    }
}


//6

using System;

class YoungestAndTallest
{
    static void Main()
    {
        // Declare variables for age and height for each friend
        int ageAmar, ageAkbar, ageAnthony;
        double heightAmar, heightAkbar, heightAnthony;

        //  Get input for ages and heights of the friends
        Console.Write("Enter the age of Amar: ");
        ageAmar = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of Amar (in cm): ");
        heightAmar = double.Parse(Console.ReadLine());

        Console.Write("Enter the age of Akbar: ");
        ageAkbar = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of Akbar (in cm): ");
        heightAkbar = double.Parse(Console.ReadLine());

        Console.Write("Enter the age of Anthony: ");
        ageAnthony = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of Anthony (in cm): ");
        heightAnthony = double.Parse(Console.ReadLine());

        // Find the youngest friend by finding the smallest age
        int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        string youngestFriend = (youngestAge == ageAmar) ? "Amar" : (youngestAge == ageAkbar) ? "Akbar" : "Anthony";
        
        // Find the tallest friend by finding the largest height
        double tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
        string tallestFriend = (tallestHeight == heightAmar) ? "Amar" : (tallestHeight == heightAkbar) ? "Akbar" : "Anthony";

        // Display the results
        Console.WriteLine($"{youngestFriend} is the youngest friend with an age of {youngestAge}.");
        Console.WriteLine($"{tallestFriend} is the tallest friend with a height of {tallestHeight} cm.");
    }
}


//7
using System;

class GreatestFactor
{
    static void Main()
    {
        // Get input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //Define the greatestFactor variable and initialize it to 1
        int greatestFactor = 1;

        //Use a for loop to find the greatest factor
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)  // Check if i is a divisor of the number
            {
                greatestFactor = i;  // Assign i to greatestFactor
                break;  // Exit the loop once the greatest factor is found
            }
        }

        // Display the greatest factor
        Console.WriteLine($"The greatest factor of {number} (beside itself) is {greatestFactor}.");
    }
}



//8

using System;

class PowerOfNumber
{
    static void Main()
    {
        // Step 1: Get input for the number and power
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());

        // Step 2: Initialize the result variable to 1
        int result = 1;

        // Step 3: Use a for loop to calculate the power
        for (int i = 1; i <= power; i++)
        {
            result *= number;  // Multiply result by number in each iteration
        }

        // Step 4: Display the result
        Console.WriteLine($"The result of {number} raised to the power of {power} is: {result}");
    }
}



//9
using System;

class FindFactors
{
    static void Main()
    {
        // Step 1: Get the input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Step 2: Loop to find factors
        Console.WriteLine($"Factors of {number} are:");

        for (int i = 1; i < number; i++)  // Loop from 1 to number - 1
        {
            if (number % i == 0)  // Check if i is a divisor of number
            {
                Console.WriteLine(i);  // Print the factor
            }
        }
    }
}



//10
using System;

class MultiplesBelow100
{
    static void Main()
    {
        // Step 1: Get the input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Step 2: Loop backward from 100 to 1
        Console.WriteLine($"Multiples of {number} below 100 are:");

        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)  // Check if i is a multiple of the number
            {
                Console.WriteLine(i);  // Print the multiple
            }
        }
    }
}

