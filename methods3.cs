//1
using System;

class FootballTeamHeights
{
    static void Main()
    {
        int[] heights = new int[11];
        Random random = new Random();
        
        // Generate random heights between 150 and 250 cm
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);
        }
        
        // Display heights
        Console.WriteLine("Heights of players in cm: " + string.Join(", ", heights));
        
        // Calculate the sum of all heights
        int sum = CalculateSum(heights);
        
        // Calculate the mean height
        double mean = CalculateMean(sum, heights.Length);
        
        // Find the shortest and tallest height
        int shortest = FindShortestHeight(heights);
        int tallest = FindTallestHeight(heights);
        
        // Display results
        Console.WriteLine("Sum of heights: " + sum + " cm");
        Console.WriteLine("Mean height: " + mean + " cm");
        Console.WriteLine("Shortest height: " + shortest + " cm");
        Console.WriteLine("Tallest height: " + tallest + " cm");
    }

    static int CalculateSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    static double CalculateMean(int sum, int numberOfElements)
    {
        return (double)sum / numberOfElements;
    }

    static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}



//2
using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true;
            }
        }
        return false;
    }

    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;
        int power = digits.Length;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, power);
        }
        return sum == number;
    }

    // Method to find the largest and second largest elements in the digits array
    public static void FindLargestAndSecondLargest(int[] digits, out int largest, out int secondLargest)
    {
        largest = Int32.MinValue;
        secondLargest = Int32.MinValue;
        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
    }

    // Method to find the smallest and second smallest elements in the digits array
    public static void FindSmallestAndSecondSmallest(int[] digits, out int smallest, out int secondSmallest)
    {
        smallest = Int32.MaxValue;
        secondSmallest = Int32.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int number = 153;

        // Display the number
        Console.WriteLine("Number: " + number);

        // Get the count of digits and display it
        int digitCount = NumberChecker.CountDigits(number);
        Console.WriteLine("Count of digits: " + digitCount);

        // Store the digits of the number in an array and display them
        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // Check if the number is a duck number and display the result
        bool isDuckNumber = NumberChecker.IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuckNumber);

        // Check if the number is an Armstrong number and display the result
        bool isArmstrongNumber = NumberChecker.IsArmstrongNumber(number);
        Console.WriteLine("Is Armstrong Number: " + isArmstrongNumber);

        // Find the largest and second largest digits and display the results
        NumberChecker.FindLargestAndSecondLargest(digits, out int largest, out int secondLargest);
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);

        // Find the smallest and second smallest digits and display the results
        NumberChecker.FindSmallestAndSecondSmallest(digits, out int smallest, out int secondSmallest);
        Console.WriteLine("Smallest digit: " + smallest);
        Console.WriteLine("Second smallest digit: " + secondSmallest);
    }
}



//3
using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the sum of the digits of a number using the digits array
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of the squares of the digits of a number using the digits array
    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sumOfSquares = 0;
        foreach (int digit in digits)
        {
            sumOfSquares += (int)Math.Pow(digit, 2);
        }
        return sumOfSquares;
    }

    // Method to check if a number is a Harshad number using the digits array
    public static bool IsHarshadNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    // Method to find the frequency of each digit in the number
    public static int[,] DigitFrequency(int number)
    {
        int[] digits = StoreDigits(number);
        int[,] frequency = new int[10, 2];

        // Initialize the first column with digit values
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0; // Initialize frequencies to 0
        }

        // Count the frequency of each digit
        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
}

class Program
{
    static void Main()
    {
        int number = 153;

        Console.WriteLine("Number: " + number);

        // Get the count of digits and display it
        int digitCount = NumberChecker.CountDigits(number);
        Console.WriteLine("Count of digits: " + digitCount);

        // Store the digits of the number in an array and display them
        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // Find the sum of the digits and display it
        int sumOfDigits = NumberChecker.SumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sumOfDigits);

        // Find the sum of the squares of the digits and display it
        int sumOfSquares = NumberChecker.SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);

        // Check if the number is a Harshad number and display the result
        bool isHarshadNumber = NumberChecker.IsHarshadNumber(number);
        Console.WriteLine("Is Harshad Number: " + isHarshadNumber);

        // Find the frequency of each digit and display the results
        int[,] digitFrequency = NumberChecker.DigitFrequency(number);
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (digitFrequency[i, 1] > 0)
            {
                Console.WriteLine($"Digit {digitFrequency[i, 0]}: {digitFrequency[i, 1]} times");
            }
        }
    }
}



//4
using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to reverse the digits array
    public static int[] ReverseDigitsArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0, j = digits.Length - 1; i < digits.Length; i++, j--)
        {
            reversed[i] = digits[j];
        }
        return reversed;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is a palindrome using the digits array
    public static bool IsPalindrome(int number)
    {
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigitsArray(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        int number = 153;

        Console.WriteLine("Number: " + number);

        // Get the count of digits and display it
        int digitCount = NumberChecker.CountDigits(number);
        Console.WriteLine("Count of digits: " + digitCount);

        // Store the digits of the number in an array and display them
        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // Reverse the digits array and display the result
        int[] reversedDigits = NumberChecker.ReverseDigitsArray(digits);
        Console.WriteLine("Reversed digits: " + string.Join(", ", reversedDigits));

        // Check if the number is a palindrome and display the result
        bool isPalindrome = NumberChecker.IsPalindrome(number);
        Console.WriteLine("Is Palindrome: " + isPalindrome);

        // Check if the number is a duck number and display the result
        bool isDuckNumber = NumberChecker.IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuckNumber);
    }
}



//5
using System;

class NumberChecker
{
    // Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sumOfDigits = SumOfDigits(StoreDigits(square));
        return sumOfDigits == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpyNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = SumOfDigits(digits);
        int product = ProductOfDigits(digits);
        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number.ToString().EndsWith("7");
    }

    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the sum of the digits of a number using the digits array
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the product of the digits of a number using the digits array
    public static int ProductOfDigits(int[] digits)
    {
        int product = 1;
        foreach (int digit in digits)
        {
            product *= digit;
        }
        return product;
    }
}

class Program
{
    static void Main()
    {
        int number = 153;

        Console.WriteLine("Number: " + number);

        // Check if the number is a prime number and display the result
        bool isPrime = NumberChecker.IsPrime(number);
        Console.WriteLine("Is Prime Number: " + isPrime);

        // Check if the number is a neon number and display the result
        bool isNeonNumber = NumberChecker.IsNeonNumber(number);
        Console.WriteLine("Is Neon Number: " + isNeonNumber);

        // Check if the number is a spy number and display the result
        bool isSpyNumber = NumberChecker.IsSpyNumber(number);
        Console.WriteLine("Is Spy Number: " + isSpyNumber);

        // Check if the number is an automorphic number and display the result
        bool isAutomorphicNumber = NumberChecker.IsAutomorphicNumber(number);
        Console.WriteLine("Is Automorphic Number: " + isAutomorphicNumber);

        // Check if the number is a buzz number and display the result
        bool isBuzzNumber = NumberChecker.IsBuzzNumber(number);
        Console.WriteLine("Is Buzz Number: " + isBuzzNumber);
    }
}



//6
using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int factorCount = 0;

        // First loop to count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factorCount++;
            }
        }

        int[] factors = new int[factorCount];
        int index = 0;

        // Second loop to find and store the factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int FindGreatestFactor(int[] factors)
    {
        int greatest = factors[0];
        foreach (int factor in factors)
        {
            if (factor > greatest)
            {
                greatest = factor;
            }
        }
        return greatest;
    }

    // Method to find the sum of the factors using the factors array and return the sum
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using the factors array and return the product
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find product of cube of the factors using the factors array
    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // Sum of proper divisors (excluding the number itself)
        return sum == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // Sum of proper divisors (excluding the number itself)
        return sum > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // Sum of proper divisors (excluding the number itself)
        return sum < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sumOfFactorials = 0;
        foreach (int digit in digits)
        {
            sumOfFactorials += Factorial(digit);
        }
        return sumOfFactorials == number;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Helper method to find the factorial of a digit
    public static int Factorial(int digit)
    {
        int factorial = 1;
        for (int i = 1; i <= digit; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

class Program
{
    static void Main()
    {
        int number = 28;

        Console.WriteLine("Number: " + number);

        // Find the factors of the number and display them
        int[] factors = NumberChecker.FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // Find the greatest factor and display it
        int greatestFactor = NumberChecker.FindGreatestFactor(factors);
        Console.WriteLine("Greatest Factor: " + greatestFactor);

        // Find the sum of the factors and display it
        int sumOfFactors = NumberChecker.SumOfFactors(factors);
        Console.WriteLine("Sum of Factors: " + sumOfFactors);

        // Find the product of the factors and display it
        int productOfFactors = NumberChecker.ProductOfFactors(factors);
        Console.WriteLine("Product of Factors: " + productOfFactors);

        // Find the product of the cube of the factors and display it
        double productOfCubeOfFactors = NumberChecker.ProductOfCubeOfFactors(factors);
        Console.WriteLine("Product of Cube of Factors: " + productOfCubeOfFactors);

        // Check if the number is a perfect number and display the result
        bool isPerfectNumber = NumberChecker.IsPerfectNumber(number);
        Console.WriteLine("Is Perfect Number: " + isPerfectNumber);

        // Check if the number is an abundant number and display the result
        bool isAbundantNumber = NumberChecker.IsAbundantNumber(number);
        Console.WriteLine("Is Abundant Number: " + isAbundantNumber);

        // Check if the number is a deficient number and display the result
        bool isDeficientNumber = NumberChecker.IsDeficientNumber(number);
        Console.WriteLine("Is Deficient Number: " + isDeficientNumber);

        // Check if the number is a strong number and display the result
        bool isStrongNumber = NumberChecker.IsStrongNumber(number);
        Console.WriteLine("Is Strong Number: " + isStrongNumber);
    }
}



//7
using System;

class OTPGenerator
{
    // Method to generate a 6-digit OTP number using Math.Random()
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // Generates a number between 100000 and 999999
    }

    // Method to ensure that the OTP numbers generated are unique
    public static bool AreUniqueOTPs(int[] otpArray)
    {
        for (int i = 0; i < otpArray.Length; i++)
        {
            for (int j = i + 1; j < otpArray.Length; j++)
            {
                if (otpArray[i] == otpArray[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main()
    {
        int[] otps = new int[10];

        // Generate 10 OTP numbers and save them in the array
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
        }

        // Display generated OTP numbers
        Console.WriteLine("Generated OTP numbers:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        // Check if the generated OTP numbers are unique
        bool areUnique = AreUniqueOTPs(otps);
        Console.WriteLine("Are all OTPs unique? " + areUnique);
    }
}


//8
using System;

class Calendar
{
    // Method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] months = {"January", "February", "March", "April", "May", "June", 
                           "July", "August", "September", "October", "November", "December"};
        return months[month - 1];
    }

    // Method to check for leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the number of days in the month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }
        return days[month - 1];
    }

    // Method to get the first day of the month using the Gregorian calendar algorithm
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int d = 1;
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int dayOfWeek = (d + x + 31 * m0 / 12) % 7;
        return dayOfWeek;
    }

    // Method to display the calendar for the given month and year
    public static void DisplayCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDayOfMonth = GetFirstDayOfMonth(month, year);

        Console.WriteLine("Calendar for " + monthName + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // First loop for proper indentation
        for (int i = 0; i < firstDayOfMonth; i++)
        {
            Console.Write("    ");
        }

        // Second loop to display the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write("{0,3} ", day);
            if ((day + firstDayOfMonth) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}



//9
using System;

class PointOperations
{
    // Method to find the Euclidean distance between two points
    public static double FindEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }



    // Method to find the slope and y-intercept of the line passing through two points
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1); // Slope
        double b = y1 - m * x1; // Y-intercept
        return new double[] { m, b };
    }

    static void Main()
    {
        // Take inputs for 2 points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate the Euclidean distance
        double distance = FindEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance: " + distance);

        // Find the equation of the line
        double[] lineEquation = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of the line: y = " + lineEquation[0] + " * x + " + lineEquation[1]);
    }
}


//10
using System;

class CollinearPoints
{
    // Method to check collinearity using slope formula
    static bool ArePointsCollinearBySlope(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double slopeAB = (double)(y2 - y1) / (x2 - x1);
        double slopeBC = (double)(y3 - y2) / (x3 - x2);
        double slopeAC = (double)(y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method to check collinearity using area formula
    static bool ArePointsCollinearByArea(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) < 1e-9; // Using a small threshold for precision errors
    }

    static void Main(string[] args)
    {
        // Input from the user for three points
        Console.Write("Enter x1, y1: ");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("Enter x2, y2: ");
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        Console.Write("Enter x3, y3: ");
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        // Check collinearity using slope formula
        bool collinearBySlope = ArePointsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Collinear by slope formula: " + (collinearBySlope ? "Yes" : "No"));

        // Check collinearity using area formula
        bool collinearByArea = ArePointsCollinearByArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Collinear by area formula: " + (collinearByArea ? "Yes" : "No"));

        // Example for given sample points A(2,4), B(4,6), C(6,8)
        Console.WriteLine("Sample Check for Points A(2,4), B(4,6), C(6,8):");
        Console.WriteLine("Collinear by slope formula: " + (ArePointsCollinearBySlope(2, 4, 4, 6, 6, 8) ? "Yes" : "No"));
        Console.WriteLine("Collinear by area formula: " + (ArePointsCollinearByArea(2, 4, 4, 6, 6, 8) ? "Yes" : "No"));
    }
}



//11
using System;

class EmployeeBonus
{
    // Method to determine the salary and years of service and return a 2D array
    public static int[,] GetEmployeeData(int employeeCount)
    {
        Random random = new Random();
        int[,] employeeData = new int[employeeCount, 2];

        for (int i = 0; i < employeeCount; i++)
        {
            employeeData[i, 0] = random.Next(10000, 100000); // 5-digit salary
            employeeData[i, 1] = random.Next(1, 11); // Years of service between 1 and 10
        }
        return employeeData;
    }

    // Method to calculate the new salary and bonus based on the logic defined
    public static double[,] CalculateNewSalaryAndBonus(int[,] employeeData)
    {
        int employeeCount = employeeData.GetLength(0);
        double[,] newSalaryAndBonus = new double[employeeCount, 3];

        for (int i = 0; i < employeeCount; i++)
        {
            int oldSalary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];
            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            double bonusAmount = oldSalary * bonusPercentage;
            double newSalary = oldSalary + bonusAmount;

            newSalaryAndBonus[i, 0] = oldSalary;
            newSalaryAndBonus[i, 1] = bonusAmount;
            newSalaryAndBonus[i, 2] = newSalary;
        }
        return newSalaryAndBonus;
    }

    // Method to calculate the sum of the old salary, the sum of the new salary, and the total bonus amount and display in a tabular format
    public static void DisplaySalaryAndBonusSummary(double[,] newSalaryAndBonus)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonusAmount = 0;

        Console.WriteLine("Employee | Old Salary | Bonus Amount | New Salary");
        
        for (int i = 0; i < newSalaryAndBonus.GetLength(0); i++)
        {
            double oldSalary = newSalaryAndBonus[i, 0];
            double bonusAmount = newSalaryAndBonus[i, 1];
            double newSalary = newSalaryAndBonus[i, 2];

            Console.WriteLine($"{i + 1,8} | {oldSalary,10:C} | {bonusAmount,12:C} | {newSalary,10:C}");

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonusAmount += bonusAmount;
        }

        
        Console.WriteLine($"Total   | {totalOldSalary,10:C} | {totalBonusAmount,12:C} | {totalNewSalary,10:C}");
    }

    static void Main()
    {
        int employeeCount = 10;

        // Get employee data
        int[,] employeeData = GetEmployeeData(employeeCount);

        // Calculate new salary and bonus
        double[,] newSalaryAndBonus = CalculateNewSalaryAndBonus(employeeData);

        // Display salary and bonus summary
        DisplaySalaryAndBonusSummary(newSalaryAndBonus);
    }
}


//12
using System;

class StudentScorecard
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Generate random scores for Physics, Chemistry, and Math
        int[,] pcmScores = GenerateRandomScores(numStudents);

        // Calculate total, average, and percentage for each student
        double[,] results = CalculateResults(pcmScores);

        // Display the scorecard in a tabular format
        DisplayScorecard(pcmScores, results);
    }

    // Method to generate random 2-digit scores for PCM
    static int[,] GenerateRandomScores(int numStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numStudents, 3];

        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = random.Next(40, 100); // Physics
            scores[i, 1] = random.Next(40, 100); // Chemistry
            scores[i, 2] = random.Next(40, 100); // Math
        }
        return scores;
    }

    // Method to calculate total, average, and percentage
    static double[,] CalculateResults(int[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 3];

        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2]; // Calculate total marks
            double average = total / 3.0; // Calculate average marks
            double percentage = (total / 300.0) * 100; // Calculate percentage

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2); // Round average to 2 decimal places
            results[i, 2] = Math.Round(percentage, 2); // Round percentage to 2 decimal places
        }
        return results;
    }

    // Method to display the scorecard in a tabular format
    static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("\nScorecard:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.Write($"{i + 1}\t\t");
            Console.Write($"{scores[i, 0]}\t\t{scores[i, 1]}\t\t{scores[i, 2]}\t");
            Console.Write($"{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}%\n");
        }
    }
}


//13
using System;

class Solution {
    // Create a random matrix with specified rows and columns
    public static double[,] CreateRandomMatrix(int rows, int cols) {
        Random rand = new Random();
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i, j] = rand.Next(1, 10); 
			}
		}
        return matrix;
    }

    // Add two matrices
    public static double[,] AddMatrices(double[,] A, double[,] B, int rows, int cols) {
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i, j] = A[i, j] + B[i, j];
			}
		}
        return result;
    }

    // Subtract two matrices
    public static double[,] SubtractMatrices(double[,] A, double[,] B, int rows, int cols) {
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i, j] = A[i, j] - B[i, j];
			}
		}
        return result;
    }

    // Multiply two matrices
    public static double[,] MultiplyMatrices(double[,] A, double[,] B, int rows, int colsA, int colsB) {
        double[,] result = new double[rows, colsB];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += A[i, k] * B[k, j];
        return result;
    }

    // Transpose a matrix
    public static double[,] TransposeMatrix(double[,] matrix, int rows, int cols) {
        double[,] result = new double[cols, rows];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[j, i] = matrix[i, j];
			}
		}
        return result;
    }

    // Determinant of a 2x2 matrix
    public static double Determinant2x2(double[,] matrix) {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Determinant of a 3x3 matrix
    public static double Determinant3x3(double[,] matrix) {
        double a = matrix[0, 0], b = matrix[0, 1], c = matrix[0, 2];
        double d = matrix[1, 0], e = matrix[1, 1], f = matrix[1, 2];
        double g = matrix[2, 0], h = matrix[2, 1], i = matrix[2, 2];

        return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
    }

    // Inverse of a 2x2 matrix
    public static double[,] Inverse2x2(double[,] matrix) {
        double det = Determinant2x2(matrix);
        if (det == 0) return null; 
        double[,] result = new double[2, 2];
        result[0, 0] = matrix[1, 1] / det;
        result[0, 1] = -matrix[0, 1] / det;
        result[1, 0] = -matrix[1, 0] / det;
        result[1, 1] = matrix[0, 0] / det;
        return result;
    }

    // Inverse of a 3x3 matrix
    public static double[,] Inverse3x3(double[,] matrix) {
        double det = Determinant3x3(matrix);
        if (det == 0) return null; 
        double[,] result = new double[3, 3];

        result[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / det;
        result[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / det;
        result[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / det;

        result[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / det;
        result[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / det;
        result[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / det;

        result[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / det;
        result[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / det;
        result[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / det;

        return result;
    }

    // Display matrix
    public static void DisplayMatrix(double[,] matrix, int rows, int cols, string label = "Matrix") {
        Console.WriteLine(label);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Main() {
        // Define matrix dimensions
        int rows = 3;
        int cols = 3;

        // Create random 3x3 matrices
        double[,] matrixA = CreateRandomMatrix(rows, cols);
        double[,] matrixB = CreateRandomMatrix(rows, cols);

        // Display matrices
        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA, rows, cols);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB, rows, cols);

        // Perform operations and display results
        DisplayMatrix(AddMatrices(matrixA, matrixB, rows, cols), rows, cols, "A + B");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB, rows, cols), rows, cols, "A - B");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB, rows, cols, cols), rows, cols, "A * B");
        DisplayMatrix(TransposeMatrix(matrixA, rows, cols), rows, cols, "Transpose of A");

        // For 3x3 matrices, calculate determinant and inverse
        Console.WriteLine("Determinant of A: " + Determinant3x3(matrixA));
        DisplayMatrix(Inverse3x3(matrixA), 3, 3, "Inverse of A");
    }
}
