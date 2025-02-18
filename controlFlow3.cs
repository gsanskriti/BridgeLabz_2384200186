//1
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



//2
using System;

class CountDigits
{
    static void Main()
    {
        //Get input from the user
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        //Initialize variables
        int count = 0;  // To store the count of digits

        // Use a while loop to count digits
        while (number != 0)
        {
            //Remove the last digit of the number
            number /= 10;

            //  Increase the count by 1
            count++;
        }

        // Display the count
        Console.WriteLine("The number of digits is: " + count);
    }
}



//3

using System;

class HarshadNumber
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize sum variable to store the sum of digits
        int sum = 0;
        int originalNumber = number; // Store the original number for division check

        //  Use a while loop to calculate the sum of digits
        while (number != 0)
        {
            // Get the last digit of the number
            int digit = number % 10;

            // Add the digit to the sum
            sum += digit;

            // Remove the last digit from the number
            number /= 10;
        }

        // Check if the number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            Console.WriteLine($"{originalNumber} is a Harshad Number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not a Harshad Number.");
        }
    }
}



//4
using System;

class AbundantNumber
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize variable sum to store the sum of divisors
        int sum = 0;

        //Run a for loop to find divisors and calculate the sum
        for (int i = 1; i < number; i++)
        {
            // Step 3a: Check if i is a divisor of the number
            if (number % i == 0)
            {
                // Step 3b: If i is a divisor, add it to sum
                sum += i;
            }
        }

        // Check if sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine($"{number} is an Abundant Number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Abundant Number.");
        }
    }
}



//5
using System;

class DayOfWeek
{
    static void Main()
    {
        // Take command-line arguments for month, day, and year
        Console.Write("Enter month (1-12): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter day: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());

        // Apply the given formula to calculate the day of the week
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        
        Console.WriteLine("Day of the week: " + d0);
    }
}

//6

using System;

class Calculator
{
    static void Main()
    {
        //Declare the variables
        double first, second, result = 0;
        string op;

        //Get input for the first and second numbers, and the operator
        Console.Write("Enter the first number: ");
        first = double.Parse(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        op = Console.ReadLine();

        Console.Write("Enter the second number: ");
        second = double.Parse(Console.ReadLine());

        // Use switch
        switch (op)
        {
            case "+":
                result = first + second;
                Console.WriteLine($"Result: {first} + {second} = {result}");
                break;
            case "-":
                result = first - second;
                Console.WriteLine($"Result: {first} - {second} = {result}");
                break;
            case "*":
                result = first * second;
                Console.WriteLine($"Result: {first} * {second} = {result}");
                break;
            case "/":
                if (second != 0)
                {
                    result = first / second;
                    Console.WriteLine($"Result: {first} / {second} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator.");
                break;
        }
    }
}




