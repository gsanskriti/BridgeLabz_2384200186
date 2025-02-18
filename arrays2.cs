//1

using System;

class EmployeeBonus
{
    static void Main()
    {
        const int numberOfEmployees = 10; 

        double[] salaries = new double[numberOfEmployees]; // Array to store salaries
        double[] yearsOfService = new double[numberOfEmployees]; // Array to store years of service
        double[] bonuses = new double[numberOfEmployees]; // Array to store bonuses
        double[] newSalaries = new double[numberOfEmployees]; // Array to store new salaries

        double totalBonus = 0.0; // Variable to store total bonus
        double totalOldSalary = 0.0; // Variable to store total old salary
        double totalNewSalary = 0.0; // Variable to store total new salary

        // Loop to take input from the user
        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Enter details for employee {i + 1}:");

            // Input for salary
            Console.Write("Enter salary: ");
            while (!double.TryParse(Console.ReadLine(), out salaries[i]) || salaries[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive salary.");
                Console.Write("Enter salary: ");
            }

            // Input for years of service
            Console.Write("Enter years of service: ");
            while (!double.TryParse(Console.ReadLine(), out yearsOfService[i]) || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number for years of service.");
                Console.Write("Enter years of service: ");
            }
        }

        // Loop to calculate bonuses and new salaries
        for (int i = 0; i < numberOfEmployees; i++)
        {
            // Calculate bonus based on years of service
            if (yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05; // 5% bonus
            }
            else
            {
                bonuses[i] = salaries[i] * 0.02; // 2% bonus
            }

            // Calculate new salary
            newSalaries[i] = salaries[i] + bonuses[i];

            // Update total values
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Print total bonus payout and total salaries
        Console.WriteLine($"\nTotal Bonus Payout: {totalBonus:F2}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:F2}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:F2}");
    }
}


//2

using System;

class YoungestFriend
{
    static void Main()
    {
        // Define arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take user input for ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of friend {i + 1} (Amar, Akbar, Anthony): ");
            while (!int.TryParse(Console.ReadLine(), out ages[i]) || ages[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive age.");
                Console.Write($"Enter the age of friend {i + 1} (Amar, Akbar, Anthony): ");
            }

            Console.Write($"Enter the height of friend {i + 1} (in cm): ");
            while (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive height.");
                Console.Write($"Enter the height of friend {i + 1} (in cm): ");
            }
        }

        // Find the youngest friend
        int youngestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i; // Update index of the youngest friend
            }
        }

        // Find the tallest friend
        int tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i; // Update index of the tallest friend
            }
        }

        // Display the results
        string[] friends = { "Amar", "Akbar", "Anthony" };
        Console.WriteLine($"\nThe youngest friend is {friends[youngestIndex]} with age {ages[youngestIndex]} years.");
        Console.WriteLine($"The tallest friend is {friends[tallestIndex]} with height {heights[tallestIndex]} cm.");
    }
}


//3

using System;

class DigitOfNumber
{
    static void Main()
    {
        // Take user input for a number
        Console.Write("Enter a number: ");
        int number;
        
        // Validate input
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
            Console.Write("Enter a number: ");
        }

        // Define an array to store the digits
        const int maxDigit = 10; // Maximum number of digits
        int[] digits = new int[maxDigit];
        int index = 0; // Index variable

        // Extract digits and store them in the array
        while (number != 0)
        {
            if (index >= maxDigit) // Check if we reached the maximum size
            {
                break; // Exit the loop if max size is reached
            }

            digits[index] = number % 10; // Get the last digit
            number /= 10; // Remove the last digit from the number
            index++; // Increment the index
        }

        // Variables to store the largest and second largest digits
        int largest = -1; // Initialize to -1 to handle cases where all digits are negative
        int secondLargest = -1; // Initialize to -1

        // Loop through the array to find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second largest
                largest = digits[i]; // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second largest
            }
        }

        // Display the results
        if (largest != -1)
        {
            Console.WriteLine($"Largest digit: {largest}");
            if (secondLargest != -1)
            {
                Console.WriteLine($"Second largest digit: {secondLargest}");
            }
            else
            {
                Console.WriteLine("There is no second largest digit.");
            }
        }
        else
        {
            Console.WriteLine("No digits were found.");
        }
    }
}


//4

using System;
using System.Linq;

class MaxDigit
{
    static void Main(string[] args)
    {
        // Step 1: Declare arrays for names, ages, and heights
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input ages and heights for the three friends
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of {names[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write($"Enter the height of {names[i]} (in cm): ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest and tallest friends
        int youngestIndex = 0, tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;

            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        // Display youngest and tallest
        Console.WriteLine($"\nThe youngest friend is {names[youngestIndex]} with age {ages[youngestIndex




//5

using System;

class ReverseProgram
{
    static void Main()
    {
        // Take user input for a number
        Console.Write("Enter a number: ");
        int number;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
            Console.Write("Enter a number: ");
        }

        // Count the number of digits
        int temp = number;
        int digitCount = 0;
        while (temp > 0)
        {
            temp /= 10; // Remove the last digit
            digitCount++; // Increment the digit count
        }

        // Create an array to store the digits
        int[] digits = new int[digitCount];

        // Extract digits and store them in the array
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10; // Get the last digit
            number /= 10; // Remove the last digit from the number
        }

        // Create an array to store the reversed digits
        int[] reversedDigits = new int[digitCount];

        // Store the digits in reverse order
        for (int i = 0; i < digitCount; i++)
        {
            reversedDigits[i] = digits[digitCount - 1 - i]; // Reverse the order
        }

        // Display the reversed digits
        Console.WriteLine("The digits in reverse order are:");
        for (int i = 0; i < reversedDigits.Length; i++)
        {
            Console.Write(reversedDigits[i] + " ");
        }
        Console.WriteLine(); // New line for better formatting
    }
}


//6
using System;

class Bmi
{
    static void Main()
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            Console.Write("Enter the number of persons: ");
        }

        // Create arrays to store weight, height, BMI, and weight status
        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] weightStatuses = new string[numberOfPersons];

        // Take input for weight and height of each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}:");
            Console.Write("Enter weight (in kg): ");
            while (!double.TryParse(Console.ReadLine(), out weights[i]) || weights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive weight.");
                Console.Write("Enter weight (in kg): ");
            }

            Console.Write("Enter height (in meters): ");
            while (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive height.");
                Console.Write("Enter height (in meters): ");
            }

            // Calculate BMI
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            // Determine weight status
            if (bmis[i] < 18.5)
            {
                weightStatuses[i] = "Underweight";
            }
            else if (bmis[i] < 24.9)
            {
                weightStatuses[i] = "Normal weight";
            }
            else if (bmis[i] < 29.9)
            {
                weightStatuses[i] = "Overweight";
            }
            else
            {
                weightStatuses[i] = "Obesity";
            }
        }

        // Display the results
        Console.WriteLine("\nBMI Report:");
        
        Console.WriteLine("Person | Weight (kg) | Height (m) | BMI    | Status");
        
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1, -6} | {weights[i], -12} | {heights[i], -11} | {bmis[i]:F2} | {weightStatuses[i]}");
        }
        
    }
}

//7

using System;

class HeightWeight
{
    static void Main()
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons;

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            Console.Write("Enter the number of persons: ");
        }

        // Create a multi-dimensional array to store weight, height, and BMI
        double[,] personData = new double[numberOfPersons, 3]; // Columns: 0 - weight, 1 - height, 2 - BMI
        string[] weightStatus = new string[numberOfPersons];

        // Take input for weight and height of each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}:");
            
            // Input for weight
            Console.Write("Enter weight (in kg): ");
            while (!double.TryParse(Console.ReadLine(), out personData[i, 0]) || personData[i, 0] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive weight.");
                Console.Write("Enter weight (in kg): ");
            }

            // Input for height
            Console.Write("Enter height (in meters): ");
            while (!double.TryParse(Console.ReadLine(), out personData[i, 1]) || personData[i, 1] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive height.");
                Console.Write("Enter height (in meters): ");
            }

            // Calculate BMI
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

            // Determine weight status
            if (personData[i, 2] < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i, 2] < 24.9)
            {
                weightStatus[i] = "Normal weight";
            }
            else if (personData[i, 2] < 29.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obesity";
            }
        }

        // Display the results
        Console.WriteLine("\nBMI Report:");
       
        Console.WriteLine("Person | Weight (kg) | Height (m) | BMI    | Status");
        
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1, -6} | {personData[i, 0], -12} | {personData[i, 1], -11} | {personData[i, 2]:F2} | {weightStatus[i]}");
        }
       
    }
}


//8

using System;

class StudentMarks
{
    static void Main(string[] args)
    {
        // Step 1: Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Step 2: Declare arrays to store marks, percentages, and grades
        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Step 3: Take input for marks in Physics, Chemistry, and Maths
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            physicsMarks[i] = GetValidMarks("Physics");
            chemistryMarks[i] = GetValidMarks("Chemistry");
            mathsMarks[i] = GetValidMarks("Maths");

            // Step 4: Calculate percentage
            int totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
            percentages[i] = totalMarks / 3.0;

            // Step 5: Assign grade based on percentage
            grades[i] = GetGrade(percentages[i]);
        }

        // Step 6: Display marks, percentages, and grades for each student
        Console.WriteLine("\nStudent Results:");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
       
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{physicsMarks[i]}\t{chemistryMarks[i]}\t\t{mathsMarks[i]}\t{percentages[i]:F2}%\t\t{grades[i]}");
        }
    }

    // Function to get valid marks (positive values only)
    static int GetValidMarks(string subject)
    {
        int marks;
        while (true)
        {
            Console.Write($"Enter marks for {subject} (0-100): ");
            marks = int.Parse(Console.ReadLine());
            if (marks >= 0 && marks <= 100)
                break;
            Console.WriteLine("Invalid input! Marks should be between 0 and 100.");
        }
        return marks;
    }

    // Function to determine the grade based on percentage
    static string GetGrade(double percentage)
    {
        if (percentage >= 80)
            return "A";
        else if (percentage >= 70)
            return "B";
        else if (percentage >= 60)
            return "C";
        else if (percentage >= 50)
            return "D";
        else if (percentage >= 40)
            return "E";
        else
            return "R";
    }
}


//9
using System;

class StudentMarks
{
    static void Main(string[] args)
    {
        // Step 1: Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Step 2: Declare a 2D array to store marks and 1D arrays for percentages and grades
        int[,] marks = new int[numStudents, 3]; // Rows: Students, Columns: Subjects
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Step 3: Input marks for each student in Physics, Chemistry, and Maths
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            for (int j = 0; j < 3; j++)
            {
                string subject = j switch
                {
                    0 => "Physics",
                    1 => "Chemistry",
                    2 => "Maths",
                    _ => throw new InvalidOperationException()
                };

                marks[i, j] = GetValidMarks(subject);
            }

            // Step 4: Calculate percentage for the student
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = totalMarks / 3.0;

            // Step 5: Assign grade based on percentage
            grades[i] = GetGrade(percentages[i]);
        }

        // Step 6: Display marks, percentages, and grades for each student
        Console.WriteLine("\nStudent Results:");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        Console.WriteLine("-----------------------------------------------------");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{marks[i, 0]}\t{marks[i, 1]}\t\t{marks[i, 2]}\t{percentages[i]:F2}%\t\t{grades[i]}");
        }
    }

    // Function to get valid marks (positive values only)
    static int GetValidMarks(string subject)
    {
        int marks;
        while (true)
        {
            Console.Write($"Enter marks for {subject} (0-100): ");
            marks = int.Parse(Console.ReadLine());
            if (marks >= 0 && marks <= 100)
                break;
            Console.WriteLine("Invalid input! Marks should be between 0 and 100.");
        }
        return marks;
    }

    // Function to determine the grade based on percentage
    static string GetGrade(double percentage)
    {
        if (percentage >= 80)
            return "A";
        else if (percentage >= 70)
            return "B";
        else if (percentage >= 60)
            return "C";
        else if (percentage >= 50)
            return "D";
        else if (percentage >= 40)
            return "E";
        else
            return "R";
    }
}


//10
using System;

class Frequency
{
    static void Main()
    {
        // Take user input for a number
        Console.Write("Enter a number: ");
        long number;

        // Validate input
        while (!long.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
            Console.Write("Enter a number: ");
        }

        // Count the number of digits
        int digitCount = 0;
        long temp = number;
        while (temp > 0)
        {
            temp /= 10; // Remove the last digit
            digitCount++; // Increment the digit count
        }

        // Create an array to store the digits
        int[] digits = new int[digitCount];

        // Extract digits and store them in the array
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = (int)(number % 10); // Get the last digit
            number /= 10; // Remove the last digit from the number
        }

        // Create a frequency array to count occurrences of each digit (0-9)
        int[] frequency = new int[10];

        // Calculate the frequency of each digit
        for (int i = 0; i < digits.Length; i++)
        {
            frequency[digits[i]]++; // Increment the frequency of the digit
        }

        // Display the frequency of each digit
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0) // Only display digits that appear in the number
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
            }
        }
    }
}



