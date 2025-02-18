1. Welcome to Bridgelabz!
using System;
 
class Program
{
	static void Main()
	{
    	Console.WriteLine("Welcome to Bridgelabz!");
	}
}
 
2. Add Two Numbers
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the first number: ");
    	double num1 = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the second number: ");
    	double num2 = Convert.ToDouble(Console.ReadLine());
    	Console.WriteLine($"The sum is: {num1 + num2}");
	}
}
 
3. Celsius to Fahrenheit Conversion
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the temperature in Celsius: ");
    	double celsius = Convert.ToDouble(Console.ReadLine());
    	double fahrenheit = (celsius * 9 / 5) + 32;
    	Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}");
	}
}
 
4. Area of a Circle
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the radius of the circle: ");
    	double radius = Convert.ToDouble(Console.ReadLine());
    	double area = Math.PI * Math.Pow(radius, 2);
    	Console.WriteLine($"The area of the circle is: {area}");
	}
}
 
 
5. Volume of a Cylinder
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the radius of the cylinder: ");
    	double radius = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the height of the cylinder: ");
    	double height = Convert.ToDouble(Console.ReadLine());
    	double volume = Math.PI * Math.Pow(radius, 2) * height;
    	Console.WriteLine($"The volume of the cylinder is: {volume}");
	}
}
 
6. Calculate Simple Interest
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the principal amount: ");
    	double principal = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the rate of interest: ");
    	double rate = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the time in years: ");
    	double time = Convert.ToDouble(Console.ReadLine());
    	double simpleInterest = (principal * rate * time) / 100;
    	Console.WriteLine($"The simple interest is: {simpleInterest}");
	}
}
 
7. Perimeter of a Rectangle
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the length of the rectangle: ");
    	double length = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the width of the rectangle: ");
    	double width = Convert.ToDouble(Console.ReadLine());
    	double perimeter = 2 * (length + width);
    	Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
	}
}
 
8. Power Calculation
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the base number: ");
    	double baseNum = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the exponent: ");
    	double exponent = Convert.ToDouble(Console.ReadLine());
    	double power = Math.Pow(baseNum, exponent);
    	Console.WriteLine($"The result is: {power}");
	}
}
 
9. Calculate Average of Three Numbers
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the first number: ");
    	double num1 = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the second number: ");
    	double num2 = Convert.ToDouble(Console.ReadLine());
    	Console.Write("Enter the third number: ");
    	double num3 = Convert.ToDouble(Console.ReadLine());
    	double average = (num1 + num2 + num3) / 3;
    	Console.WriteLine($"The average is: {average}");
	}
}
 
10. Convert Kilometers to Miles
using System;
 
class Program
{
	static void Main()
	{
    	Console.Write("Enter the distance in kilometers: ");
    	double kilometers = Convert.ToDouble(Console.ReadLine());
    	double miles = kilometers * 0.621371;
    	Console.WriteLine($"The distance in miles is: {miles}");
	}
}

