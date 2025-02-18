//1
using System;

class remainder
{
    static void Main()
    {
        // enter the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // enter the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        
        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}.");
    }
}


//2
using System;

class Operation
{
    static void Main()
    {
        // input for a, b, and c
        Console.Write("Enter the value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Compute the operations
        int result1 = a + (b * c); 
        int result2 = (a * b) + c; 
        int result3 = c + (a / b); 
        int result4 = (a % b) + c; 

    
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}.");
        
        
    }
}


//3
using System;

class Operation
{
    static void Main()
    {
        // input for a, b, and c
        Console.Write("Enter the value for a: ");
        double a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for b: ");
        double b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for c: ");
        double c = Convert.ToInt32(Console.ReadLine());

        // Compute the operations
        double result1 = a + (b * c); 
        double result2 = (a * b) + c; 
        double result3 = c + (a / b); 
        double result4 = (a % b) + c; 

    
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}.");
        
        
    }
}


//4
using System;

class TemperatureConversion
{
    static void Main()
    {
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Print the result
        Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit.");
        
        
    }
}


//5
using System;

class TemperatureConversion
{
    static void Main()
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius using the formula
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius.");
        
        
    }
}


//6
using System;

class Salary
{
    static void Main()
    {
        //enter the salary
        Console.Write("Enter the salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        // enter the bonus
        Console.Write("Enter the bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Compute total income
        double totalIncome = salary + bonus;

        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}.");
        
        
    }
}



//7
using System;

class SwappedNumber
{
    static void Main()
    {
        // enter the first number
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        //enter the second number
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Swap the numbers using a temporary variable
        double temp = number1;
        number1 = number2;
        number2 = temp;

        // swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}.");
    }
}


//8
using System;

class EricTravels
{
    static void Main()
    {
        // Declare variables
        string name, fromCity, viaCity, toCity;
        double fromToVia, viaToFinalCity;
        int hoursFromToVia, minutesFromToVia;
        int hoursViaToFinalCity, minutesViaToFinalCity;

        // user input for name and cities
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter the city you are traveling from: ");
        fromCity = Console.ReadLine();

        Console.Write("Enter the city you are traveling via: ");
        viaCity = Console.ReadLine();

        Console.Write("Enter the city you are traveling to: ");
        toCity = Console.ReadLine();

        //  user input for distances
        Console.Write($"Enter the distance from {fromCity} to {viaCity} (in miles): ");
        fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write($"Enter the distance from {viaCity} to {toCity} (in miles): ");
        viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // user input for time taken for each leg of the journey
        Console.Write($"Enter the time taken from {fromCity} to {viaCity} (hours minutes): ");
        string[] timeFromToVia = Console.ReadLine().Split(' ');
        hoursFromToVia = Convert.ToInt32(timeFromToVia[0]);
        minutesFromToVia = Convert.ToInt32(timeFromToVia[1]);

        Console.Write($"Enter the time taken from {viaCity} to {toCity} (hours minutes): ");
        string[] timeViaToFinalCity = Console.ReadLine().Split(' ');
        hoursViaToFinalCity = Convert.ToInt32(timeViaToFinalCity[0]);
        minutesViaToFinalCity = Convert.ToInt32(timeViaToFinalCity[1]);

        // Compute total distance and total time
        double totalDistance = fromToVia + viaToFinalCity;
        int totalHours = hoursFromToVia + hoursViaToFinalCity;
        int totalMinutes = minutesFromToVia + minutesViaToFinalCity;

        // Convert total minutes to hours if greater than 60
        if (totalMinutes >= 60)
        {
            totalHours += totalMinutes / 60;
            totalMinutes = totalMinutes % 60;
        }

       
        Console.WriteLine($"The results of the trip are: {name}, Total Distance: {totalDistance} miles, Total Time: {totalHours} hours and {totalMinutes} minutes.");
    }
}



//9
using System;

class AthleteRounds
{
    static void Main()
    {
       
        //input for the sides of the triangle
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Total distance to run in meters (5 km = 5000 meters)
        double totalDistance = 5000;

        // Calculate the number of rounds
        double rounds = totalDistance / perimeter;

        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km.");
    }
}



//10
using System;

class ChocolateDivision
{
    static void Main()
    {
        // the number of chocolates
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        // the number of children
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate the number of chocolates each child gets and the remaining chocolates
        int chocolatesPerChild = numberOfChildren > 0 ? numberOfChocolates / numberOfChildren : 0;
        int remainingChocolates = numberOfChildren > 0 ? numberOfChocolates % numberOfChildren : numberOfChocolates;

    
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");

    }
}


//11
using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        // Declare variables
        double principal, rate, time;

        Console.Write("Enter the Principal amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest (in %): ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine($"The Simple Interest is {simpleInterest:F2} for Principal {principal}, Rate of Interest {rate}, and Time {time}.");
    }
}


//12
using System;

class weight
{
    static void Main()
    {
        //enter the weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms using the conversion factor
        double weightInKilograms = weightInPounds / 2.2;

        
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKilograms}.");

    }
}

