//1

using System;

class CalculateInterest
{
    // Method to calculate Simple Interest
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    static void Main(string[] args)
    {
        // Input for Principal
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Input for Rate
        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Input for Time
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        // Output the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time}.");
    }
}


//2
using System;

class MaxHandshakes
{
    // Method to calculate the maximum number of handshakes
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main(string[] args)
    {
        // Input for number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Validate input
        if (numberOfStudents < 0)
        {
            Console.WriteLine("The number of students cannot be negative.");
            return;
        }

        // Calculate maximum number of handshakes
        int handshakes = CalculateHandshakes(numberOfStudents);

        // Output the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}.");
    }
}



//3

using System;

class MaxHandshakes
{
    // Method to calculate the maximum number of handshakes
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main(string[] args)
    {
        // Input for number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Validate input
        if (numberOfStudents < 0)
        {
            Console.WriteLine("The number of students cannot be negative.");
            return;
        }

        // Calculate maximum number of handshakes
        int handshakes = CalculateHandshakes(numberOfStudents);

        // Output the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}.");
    }
}


//4

using System;

class CalcParimeter
{
    // Method to calculate the perimeter of the triangle
    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    // Method to calculate the number of rounds needed to complete 5 km
    static double CalculateRounds(double perimeter)
    {
        const double distanceToRun = 5000; // 5 km in meters
        return distanceToRun / perimeter;
    }

    static void Main(string[] args)
    {
        // Input for the sides of the triangle
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = CalculatePerimeter(side1, side2, side3);

        // Calculate the number of rounds needed to complete 5 km
        double rounds = CalculateRounds(perimeter);

        // Output the result
        Console.WriteLine($"The athlete needs to complete {Math.Ceiling(rounds)} rounds to cover 5 km.");
    }
}



//5
using System;

class CheckNumber
{
    // Method to check if the number is positive, negative, or zero
    static int CheckNumber(int number)
    {
        if (number < 0)
        {
            return -1; // Negative number
        }
        else if (number > 0)
        {
            return 1; // Positive number
        }
        else
        {
            return 0; // Zero
        }
    }

    static void Main(string[] args)
    {
        // Input from the user
        Console.Write("Enter an integer: ");
        int userInput;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Please enter a valid integer.");
        }

        // Check the number 
        int result = CheckNumber(userInput);

        // Output the result
        if (result == -1)
        {
            Console.WriteLine("The number is negative.");
        }
        else if (result == 1)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}



//6
using System;

class SpringSeason
{
    // Method to check if the date is in Spring season
    static bool IsSpringSeason(int month, int day)
    {
        // Check if the date is between March 20 and June 20
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true; // It's Spring season
        }
        return false; // Not Spring season
    }

    static void Main(string[] args)
    {
        // Check if the correct number of arguments is provided
        if (args.Length != 2)
        {
            Console.WriteLine("Please provide two integer values: month and day.");
            return;
        }

        // Parse the command line arguments
        if (int.TryParse(args[0], out int month) && int.TryParse(args[1], out int day))
        {
            // Check if the date is in Spring season
            if (IsSpringSeason(month, day))
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid integer values for month and day.");
        }
    }
}



//7
using System;

class Program
{
    // Method to calculate the sum of the first n natural numbers using a loop
    static int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i; // Add each natural number to the sum
        }
        return sum;
    }

    static void Main(string[] args)
    {
        // Input from the user
        Console.Write("Enter a positive integer (n): ");
        int n;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }

        // Calculate the sum of the first n natural numbers
        int sum = SumOfNaturalNumbers(n);

        // Output the result
        Console.WriteLine($"The sum of the first {n} natural numbers is {sum}.");
    }
}


//8
using System;

class SmallestLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int number3 = int.Parse(Console.ReadLine());

        int[] result = FindSmallestAndLargest(number1, number2, number3);

        Console.WriteLine($"Smallest number: {result[0]}");
        Console.WriteLine($"Largest number: {result[1]}");
    }

    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));

        return new int[] { smallest, largest };
    }
}



//9
using System;

class Number
{
    static void Main()
    {
        Console.WriteLine("Enter the first number (dividend):");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number (divisor):");
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number, divisor);

        Console.WriteLine($"Quotient: {result[0]}");
        Console.WriteLine($"Remainder: {result[1]}");
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }
}



//10
using System;
class Chocolate
{
    static void Main()
    {
        Console.WriteLine("Enter the number of chocolates:");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of children:");
        int numberOfChildren = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        Console.WriteLine($"Each child will get {result[0]} chocolates.");
        Console.WriteLine($"Remaining chocolates: {result[1]}");
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }
}



//11
using System;

class WindTemperature
{
    static void Main()
    {
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        double temperature = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the wind speed in miles per hour:");
        double windSpeed = double.Parse(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);

        Console.WriteLine($"The wind chill temperature is: {windChill:F2} °F");
    }

    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }
}



//12
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the angle in degrees:");
        double angle = double.Parse(Console.ReadLine());

        double[] results = calculateTrigonometricFunctions(angle);

        Console.WriteLine($"Sine: {results[0]:F4}");
        Console.WriteLine($"Cosine: {results[1]:F4}");
        Console.WriteLine($"Tangent: {results[2]:F4}");
    }

    public static double[] calculateTrigonometricFunctions(double angle)
    {
        double angleInRadians = angle * (Math.PI / 180);

        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);

        return new double[] { sine, cosine, tangent };
    }
}

