//1
using System;

public class CalculateAge
{
    public static void Main(string[] args)
    {
        //birth year
        int birthYear = 2000;
        //current year
        int currentYear = 2024;
        
        //caculating age
        int age = currentYear - birthYear;
        
        Console.WriteLine($"Harry's age in 2024 is {age}");
        
    }
}




//2
using System;

public class CalculateAverage
{
    public static void Main(string[] args)
    {
        //maths marks
        double maths = 94;
        //physics marks
        double physics = 95;
        //chemistry marks
        double chemistry = 96;
        
        // calculating sum 
        double sum = maths + physics + chemistry;
        //calculating average
        double averageMarks = sum / 3;
        
        Console.WriteLine("Sam's average marks in PCM is " + averageMarks);
    }
}


//3
using System;

public class CalculateDistance
{
    public static void Main(string[] args)
    {
        
        double kilometers = 10.8;
         
         // calculate in miles
         double mile = 1.6 * kilometers;

         Console.WriteLine($"the distance {kilometers} km in miles is {mile}");
    }
}


//4
using System;

class Program
{
    static void Main()
    {
        // Define the cost price and selling price
        double costPrice = 129;
        double sellingPrice = 191;

        // Calculate profit and profit percentage
        double profit = sellingPrice - costPrice;
   
        double profitPercentage = (profit / costPrice) * 100;

        Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\n" +
                          $"The Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%.");
    }
}





//5
using System;

public class CalculateDistance
{
    public static void Main(string[] args)
    {
        // number of pen
        int noOfPen = 14;
        // number of students
        int noOfStudents = 3;
         
        //equally distributed pen
        int pen = noOfPen / noOfStudents;
        //remaining pen
        int remainingPen = noOfPen % noOfStudents;

        Console.WriteLine($"The Pen Per Student is {pen} and the remaining pen not distributed is {remainingPen}");
    }
}




//6
using System;

public class CalculateDistance
{
    public static void Main(string[] args)
    {
        // fee amount
        float fee = 125000 ;
        // discount percent
        float discountPercent = 10;
        
        //compute discounted ammount
        float discount = (fee * discountPercent)/100;
        
        //compute final amount to fee
        float finalFee = fee - discount;
         
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}


//7
using System;
public class VolumeOfEarth
{
    public static void Main(string[] args)
    {
        //radius of earth
        double radius = 6378;
        
        //volume of earth in km cubic
        double volumeInKm = (4/3) * Math.PI * Math.Pow(radius, 3);
        
        //volume of earth in miles cubic
        double volumeInMiles = 1.6 * volumeInKm;
        
        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeInKm} and cubic miles is {volumeInMiles}");
        
    }
}


//8
using System;

class DistanceConverter
{
    static void Main()
    {
        // Declare a variable to hold the distance in kilometers
        double km;

        // Prompt the user to enter the distance in kilometers
        Console.Write("Enter the distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine()); // Read input and convert to double

        // Convert kilometers to miles using the formula: 1 mile = 1.6 km
        double miles = km / 1.6;

        // Print the result
        Console.WriteLine($"The total miles is {miles:F2} mile for the given {km:F2} km.");
    }
}



//9
using System;

public class CalculateDistance
{
    public static void Main(string[] args)
    {
        // fee amount
        Console.Write("Enter the student fee (INR): ");
        double fee = Convert.ToDouble(Console.ReadLine());

        // discount percent
        Console.Write("Enter the university discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        
        //compute discounted ammount
        double discount = (fee * discountPercent)/100;
        
        //compute final amount to fee
        double finalFee = fee - discount;
         
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}




//10
using System;

public class CalculateDistance
{
    public static void Main(string[] args)
    {
        // height in centimeter
        Console.Write("Enter the height in centimeter ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        //compute height in inches
        double heightInInch = heightInCm / 2.54; 
        
        //compute height in foot
        double heightInFoot = heightInInch / 12;
         
        Console.WriteLine($"Your Height in cm is {heightInCm} while in feet is {heightInFoot} and inches is {heightInInch}");
    }
}



//11
using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        // input variables
        Console.Write("Enter the number1: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the number2: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        //compute sum
        double addition = number1 + number2;
        
        //compute subtraction
        double subtraction = number1 - number2;
        
        //compute multiplication
        double multiplication = number1 * number2;
        
        //compute division
        double division = number1 / number2;
        
        Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1} and {number2} is {addition}, {subtraction}, {multiplication}, and {division}");
    }
}


//12
using System;

public class Triangle
{
    public static void Main(string[] args)
    {
        const double cmPerInch = 2.54;
        const int inchesPerFoot = 12;
        
        // Input for Base and Height in inches
        Console.Write("Enter the base of the triangle (in inches): ");
        double baseInches = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle (in inches): ");
        double heightInches = Convert.ToDouble(Console.ReadLine());

        // Calculate area in square inches
        double areaInSquareInches = 0.5 * baseInches * heightInches;

        // Convert area to square centimeters (
        double areaInSquareCm = areaInSquareInches * 6.4516;

        // Convert base and height to centimeters
        double baseCm = baseInches * cmPerInch;
        double heightCm = heightInches * cmPerInch;

        // Convert base and height to feet and inches
        int baseFeet = (int)(baseInches / inchesPerFoot);
        double baseRemainingInches = baseInches % inchesPerFoot;

        int heightFeet = (int)(heightInches / inchesPerFoot);
        double heightRemainingInches = heightInches % inchesPerFoot;


        Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {heightFeet} and inches is {heightInches}");
    }
}

//13
using System;

public class square
{
    public static void Main(string[] args)
    {
        //perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the length of the side
        double side = perimeter / 4;

        // Print the result
        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}.");
    }
}


//14
using System;

public class sqaure
{
    public static void Main(string[] args)
    {
        //  distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Convert feet to yards and miles
        double distanceInYards = distanceInFeet / 3; 
        double distanceInMiles = distanceInYards / 1760; 

        
        Console.WriteLine($"The distance in yards is {distanceInYards} and in miles is {distanceInMiles:}");
    }
}


//15
using System;

public class PriceCalculate
{
    public static void Main(string[] args)
    {
        //  per unit price
        Console.Write("Enter the per unit price : ");
        double perUnitPrice = Convert.ToDouble(Console.ReadLine());
        
        //  quantity bought
        Console.Write("Enter the quantity bought : ");
        double quantity = Convert.ToDouble(Console.ReadLine());

        // Calculate total price
        double price = quantity * perUnitPrice;

        
        Console.WriteLine($"The total purchase price is INR {price} if the quantity {quantity} and unit price is INR {perUnitPrice}");
    }
}


//16
using System;

class HandshakeCalculator
{
    static void Main()
    {
        // the number of students
        Console.Write("Enter the number of students: ");
        double numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the formula: (n * (n - 1)) / 2
        double maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Display the result
        Console.WriteLine($"The maximum number of possible handshakes among {numberOfStudents} students is {maxHandshakes}.");
    }
}



