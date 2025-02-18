//1
using System;

class FactorOfNumber
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Find the factors of the number
        int[] factors = FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors:");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        // Calculate and display the sum of the factors
        int sum = CalculateSum(factors);
        Console.WriteLine($"Sum of factors: {sum}");

        // Calculate and display the product of the factors
        int product = CalculateProduct(factors);
        Console.WriteLine($"Product of factors: {product}");

        // Calculate and display the sum of squares of the factors
        double sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine($"Sum of squares of factors: {sumOfSquares}");
    }

    // Method to find the factors of a given number
    public static int[] FindFactors(int number)
    {
        int count = 0;
        // First loop to count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Initialize the array with the count of factors
        int[] factors = new int[count];
        int index = 0;
        // Second loop to save the factors into the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to calculate the sum of the factors
    public static int CalculateSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to calculate the product of the factors
    public static int CalculateProduct(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to calculate the sum of squares of the factors
    public static double CalculateSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
}



//2
using System;

class NaturalNumber
{
    static void Main()
    {
        // Prompt the user to enter a natural number
        Console.WriteLine("Enter a natural number:");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a natural number (greater than 0)
        if (number <= 0)
        {
            Console.WriteLine("The number is not a natural number.");
            return;
        }

        // Calculate the sum of natural numbers using recursion
        int sumRecursive = SumOfNaturalNumbersRecursive(number);
        
        // Calculate the sum of natural numbers using the formula n*(n+1)/2
        int sumFormula = SumOfNaturalNumbersFormula(number);

        // Display the results
        Console.WriteLine($"Sum of {number} natural numbers (recursive): {sumRecursive}");
        Console.WriteLine($"Sum of {number} natural numbers (formula): {sumFormula}");

        // Compare the results and print the comparison result
        if (sumRecursive == sumFormula)
        {
            Console.WriteLine("Both computations yield the same result.");
        }
        else
        {
            Console.WriteLine("There is a discrepancy between the results.");
        }
    }

    // Method to find the sum of n natural numbers using recursion
    public static int SumOfNaturalNumbersRecursive(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n + SumOfNaturalNumbersRecursive(n - 1);
    }

    // Method to find the sum of n natural numbers using the formula n*(n+1)/2
    public static int SumOfNaturalNumbersFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}


//3
using System;

class LeapYearCheck
{
    static void Main()
    {
        // Prompt the user to enter a year
        Console.WriteLine("Enter a year (>= 1582):");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is valid (greater than or equal to 1582)
        if (year < 1582)
        {
            Console.WriteLine("The year is not valid for the Gregorian calendar.");
            return;
        }

        // Determine if the year is a leap year
        bool isLeap = IsLeapYear(year);

        // Display the result
        if (isLeap)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        // A leap year is divisible by 4 and not divisible by 100 or divisible by 400
        if (year % 4 == 0)
        {
            if (year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
        }
        return false;
    }
}


//4
using System;

public static class UnitConverter
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Unit Conversion Utility");

        // Convert kilometers to miles
        double km = 10;
        double miles = UnitConverter.ConvertKmToMiles(km);
        Console.WriteLine($"{km} kilometers is {miles} miles");

        // Convert miles to kilometers
        double milesToConvert = 6.2;
        double kilometers = UnitConverter.ConvertMilesToKm(milesToConvert);
        Console.WriteLine($"{milesToConvert} miles is {kilometers} kilometers");

        // Convert meters to feet
        double meters = 3;
        double feet = UnitConverter.ConvertMetersToFeet(meters);
        Console.WriteLine($"{meters} meters is {feet} feet");

        // Convert feet to meters
        double feetToConvert = 10;
        double metersConverted = UnitConverter.ConvertFeetToMeters(feetToConvert);
        Console.WriteLine($"{feetToConvert} feet is {metersConverted} meters");
    }
}



//5
using System;

public static class UnitConverter
{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Unit Conversion Utility");

        // Convert yards to feet
        double yards = 10;
        double feet = UnitConverter.ConvertYardsToFeet(yards);
        Console.WriteLine($"{yards} yards is {feet} feet");

        // Convert feet to yards
        double feetToConvert = 30;
        double yardsConverted = UnitConverter.ConvertFeetToYards(feetToConvert);
        Console.WriteLine($"{feetToConvert} feet is {yardsConverted} yards");

        // Convert meters to inches
        double meters = 2;
        double inches = UnitConverter.ConvertMetersToInches(meters);
        Console.WriteLine($"{meters} meters is {inches} inches");

        // Convert inches to meters
        double inchesToConvert = 25;
        double metersConverted = UnitConverter.ConvertInchesToMeters(inchesToConvert);
        Console.WriteLine($"{inchesToConvert} inches is {metersConverted} meters");

        // Convert inches to centimeters
        double inchesToCm = 10;
        double centimeters = UnitConverter.ConvertInchesToCentimeters(inchesToCm);
        Console.WriteLine($"{inchesToCm} inches is {centimeters} centimeters");
    }
}


//6
using System;

public static class UnitConverter
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Unit Conversion Utility");

        // Convert Fahrenheit to Celsius
        double fahrenheit = 98.6;
        double celsius = UnitConverter.ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius:F2} Celsius");

        // Convert Celsius to Fahrenheit
        double celsiusToConvert = 37;
        double fahrenheitConverted = UnitConverter.ConvertCelsiusToFahrenheit(celsiusToConvert);
        Console.WriteLine($"{celsiusToConvert} Celsius is {fahrenheitConverted:F2} Fahrenheit");

        // Convert pounds to kilograms
        double pounds = 150;
        double kilograms = UnitConverter.ConvertPoundsToKilograms(pounds);
        Console.WriteLine($"{pounds} pounds is {kilograms:F2} kilograms");

        // Convert kilograms to pounds
        double kilogramsToConvert = 68;
        double poundsConverted = UnitConverter.ConvertKilogramsToPounds(kilogramsToConvert);
        Console.WriteLine($"{kilogramsToConvert} kilograms is {poundsConverted:F2} pounds");

        // Convert gallons to liters
        double gallons = 5;
        double liters = UnitConverter.ConvertGallonsToLiters(gallons);
        Console.WriteLine($"{gallons} gallons is {liters:F2} liters");

        // Convert liters to gallons
        double litersToConvert = 20;
        double gallonsConverted = UnitConverter.ConvertLitersToGallons(litersToConvert);
        Console.WriteLine($"{litersToConvert} liters is {gallonsConverted:F2} gallons");
    }
}



//7
using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote based on their age
    public static bool CanStudentVote(int age)
    {
        // Validate the age for a negative number
        if (age < 0)
        {
            return false;
        }

        // Check if the age is 18 or above
        return age >= 18;
    }
}

class Program
{
    static void Main()
    {
        // Define an array to store the ages of 10 students
        int[] studentAges = new int[10];

        // Loop through the array and take user input for each student's age
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.WriteLine($"Enter the age of student {i + 1}:");
            studentAges[i] = int.Parse(Console.ReadLine());
        }

        // Check if each student can vote and display the result
        for (int i = 0; i < studentAges.Length; i++)
        {
            bool canVote = StudentVoteChecker.CanStudentVote(studentAges[i]);
            if (canVote)
            {
                Console.WriteLine($"Student {i + 1} (age {studentAges[i]}) can vote.");
            }
            else
            {
                Console.WriteLine($"Student {i + 1} (age {studentAges[i]}) cannot vote.");
            }
        }
    }
}



//8
using System;

class YoungestFriend
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take user input for ages and heights of the friends
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Enter the age of {names[i]}:");
            ages[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the height (in cm) of {names[i]}:");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest friend
        int youngestIndex = FindYoungest(ages);
        Console.WriteLine($"The youngest friend is {names[youngestIndex]} with age {ages[youngestIndex]}.");

        // Find the tallest friend
        int tallestIndex = FindTallest(heights);
        Console.WriteLine($"The tallest friend is {names[tallestIndex]} with height {heights[tallestIndex]} cm.");
    }

    // Method to find the index of the youngest friend
    public static int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }
        return youngestIndex;
    }

    // Method to find the index of the tallest friend
    public static int FindTallest(double[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        return tallestIndex;
    }
}



//9
using System;

public class NumberChecker
{
    // Method to check if a number is positive
    public static bool IsPositive(int number)
    {
        return number >= 0;
    }

    // Method to check if a positive number is even
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1;
        }
        else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        // Take user input for 5 numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Enter number {i + 1}:");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Loop through the array and check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (NumberChecker.IsPositive(numbers[i]))
            {
                if (NumberChecker.IsEven(numbers[i]))
                {
                    Console.WriteLine($"Number {numbers[i]} is positive and even.");
                }
                else
                {
                    Console.WriteLine($"Number {numbers[i]} is positive and odd.");
                }
            }
            else
            {
                Console.WriteLine($"Number {numbers[i]} is negative.");
            }
        }

        // Compare the first and last elements of the array
        int comparisonResult = NumberChecker.Compare(numbers[0], numbers[numbers.Length - 1]);
        if (comparisonResult == 1)
        {
            Console.WriteLine($"The first element ({numbers[0]}) is greater than the last element ({numbers[numbers.Length - 1]}).");
        }
        else if (comparisonResult == 0)
        {
            Console.WriteLine($"The first element ({numbers[0]}) is equal to the last element ({numbers[numbers.Length - 1]}).");
        }
        else
        {
            Console.WriteLine($"The first element ({numbers[0]}) is less than the last element ({numbers[numbers.Length - 1]}).");
        }
    }
}



//10
using System;

public class BMICalculator
{
    public static void Main()
    {
        double[,] data = new double[10, 3];
        string[] statuses = new string[10];

        // Take user input for weight and height
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter weight (kg) for person {i + 1}:");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter height (cm) for person {i + 1}:");
            data[i, 1] = double.Parse(Console.ReadLine());
        }

        // Calculate BMI and determine status for each person
        for (int i = 0; i < 10; i++)
        {
            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            statuses[i] = DetermineBMIStatus(data[i, 2]);
        }

        // Display the results
        Console.WriteLine("\nResults:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1}: Weight = {data[i, 0]} kg, Height = {data[i, 1]} cm, BMI = {data[i, 2]:F2}, Status = {statuses[i]}");
        }
    }

    // Method to calculate BMI
    public static double CalculateBMI(double weight, double height)
    {
        height = height / 100; // Convert cm to meters
        return weight / (height * height);
    }

    // Method to determine BMI status
    public static string DetermineBMIStatus(double bmi)
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            return "Normal weight";
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            return "Overweight";
        }
        else
        {
            return "Obese";
        }
    }
}


//11
using System;

public class QuadraticEquation
{
    public static void Main()
    {
        Console.WriteLine("Enter the coefficient a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coefficient b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coefficient c:");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The equation has one real root: x = {roots[0]}");
        }
        else
        {
            Console.WriteLine($"The equation has two real roots: x1 = {roots[0]}, x2 = {roots[1]}");
        }
    }

    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return new double[0];
        }
    }
}


//12
using System;
using System.Linq;

public class RandomNumberProcessor
{
    // Method to generate an array of 4-digit random numbers given the size as a parameter
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); // 4-digit random number
        }
        
        return randomNumbers;
    }

    // Method to find the average, min, and max value of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        double average = numbers.Average();
        int min = numbers.Min();
        int max = numbers.Max();
        
        return new double[] { average, min, max };
    }
    
    public static void Main(string[] args)
    {
        RandomNumberProcessor processor = new RandomNumberProcessor();
        
        // Generate an array of 5 random 4-digit numbers
        int[] randomNumbers = processor.Generate4DigitRandomArray(5);
        
        // Find the average, min, and max value of the generated array
        double[] results = processor.FindAverageMinMax(randomNumbers);
        
        // Display the results
        Console.WriteLine("Random Numbers: " + string.Join(", ", randomNumbers));
        Console.WriteLine("Average: " + results[0]);
        Console.WriteLine("Minimum: " + results[1]);
        Console.WriteLine("Maximum: " + results[2]);
    }
}

