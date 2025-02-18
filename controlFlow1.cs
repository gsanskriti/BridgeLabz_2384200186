//1
using System;

public class DivisibilityCheck
{
    public static void Main(string[] args)
    {
        //ENTER THE NUMBER
        Console.WriteLine("enter the number for divisibilty check: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        //check divisibility
        if(number%5 == 0){
            Console.WriteLine("divisible");
        }else{
            Console.WriteLine("NOT divisible");
        }
    }
}



//2
using System;
public class LargestNumber
{
    public static void Main(string[] args)
    {
        string result;
        
        //enter number 1
        Console.WriteLine("enter the number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        //enter number 2
        Console.WriteLine("enter the number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        //enter number 3
        Console.WriteLine("enter the number3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        //check smallest number
        if (number1 < number2 && number1 < number3){
            result = "yes";
        }else{
            result = "no";
        }
        Console.WriteLine($"Is the first number the smallest? {result}");
        
    }
}



//3
using System;
public class LargestNumber
{
    public static void Main(string[] args)
    {
        string result1, result2, result3;
        
        //enter number 1
        Console.WriteLine("enter the number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        //enter number 2
        Console.WriteLine("enter the number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        //enter number 3
        Console.WriteLine("enter the number3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        //check if number1 is smallest number
        if (number1 > number2 && number1 > number3){
            result1 = "yes";
        }else{
            result1 = "no";
        }
        Console.WriteLine($"Is the first number the the largest? {result1}");
        
        //check if number2 is smallest number
        if (number2 > number1 && number2 > number3){
            result2 = "yes";
        }else{
            result2 = "no";
        }
        Console.WriteLine($"Is the second number the the largest? {result2}");
        
        //check if number3 is smallest number
        if (number3 > number2 && number1 < number3){
            result3 = "yes";
        }else{
            result3 = "no";
        }
        Console.WriteLine($"Is the third number the the largest? {result3}");
    }
}


//4
using System;
public class NaturalSum
{
    public static void Main(string[] args)
    {
        //enter number 
        Console.WriteLine("enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        //check if number is natural or not
        if(number>=0){
            double sum = number * (number + 1) / 2;
            Console.WriteLine($"The sum of {number} natural numbers is {sum}");
        }else{
            Console.WriteLine($"The number {number} is not a natural number");
        }
    }
}



//5
using System;
public class CanVote
{
    public static void Main(string[] args)
    {
        //enter age
        Console.WriteLine("enter the age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        //check if person can vote or not
        if(age>=18){
            
            Console.WriteLine($"The person's age is {age} and can vote");
        }else{
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}



//6
using System;
public class number
{
    public static void Main(string[] args)
    {
        //enter number
        Console.WriteLine("enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        //check whether a number is positive, negative, or zero.
        if(number >0){
            
            Console.WriteLine($"positive");
        }else if(number == 0){
            Console.WriteLine("zero");
        }
        else{
            Console.WriteLine($"negative");
        }
    }
}


//7

using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        // Prompt the user for month and day
        Console.WriteLine("Enter the month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());

        // Check if the input date is in the Spring Season
        if (IsSpringSeason(month, day))
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }

    static bool IsSpringSeason(int month, int day)
    {
        // Spring is from March 20 to June 20
        if ((month == 3 && day >= 20 && day <= 31) || // March 20-31
            (month == 4 && day >= 1 && day <= 30) ||  // April 1-30
            (month == 5 && day >= 1 && day <= 31) ||  // May 1-31
            (month == 6 && day >= 1 && day <= 20))    // June 1-20
        {
            return true;
        }

        return false;
    }
}


//8

using System;

class RocketLaunch
{
    static void Main(string[] args)
    {
        //user input for counter
        Console.WriteLine("enter the counter point: ");
        int counter = Convert.ToInt32(Console.ReadLine());
        
        //execute counter to 1 
        while(counter >= 1)
        {
            Console.WriteLine($"counter is {counter}");
            counter--;
        }
     
    }
}


//9
using System;

class RocketLaunch
{
    static void Main(string[] args)
    {
        //user input for counter
        Console.WriteLine("enter the counter point: ");
        
        //execute counter to 1 
        for(int counter = Convert.ToInt32(Console.ReadLine()); counter >=1; counter--)
        {
            Console.WriteLine($"counter is {counter}");
        }
    }
}


