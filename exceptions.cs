//1
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "data.txt";
        try
        {
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine(fileContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
    }
}


//2
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = number1 / number2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}

//3
using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class Program
{
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        }
    }
}


//4
using System;

class Program
{
    static void Main()
    {
        int[] array = null;

        try
        {
            // Uncomment the following line to initialize the array
            // array = new int[] { 10, 20, 30, 40, 50 };

            Console.Write("Enter the index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (array == null)
            {
                throw new NullReferenceException();
            }

            int value = array[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        }
    }
}


//5
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "info.txt";

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}


//6
using System;

class Program
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Invalid input: Amount and rate must be positive");
        }

        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine($"Calculated Interest: {interest}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}


//7
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 / number2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }
}



//8
using System;

class Program
{
    static void Method1()
    {
        throw new ArithmeticException("ArithmeticException occurred: Division by zero.");
    }

    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine($"Handled exception in Main: {ex.Message}");
        }
    }
}


//9
using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter the index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                int value = array[index];

                try
                {
                    Console.Write("Enter the divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    int result = value / divisor;
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}


//10
using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount: Amount must be positive.");
        }
        if (amount > Balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000); // Initial balance of 1000

        try
        {
            Console.Write("Enter the amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        }
    }
}
