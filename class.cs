//1
using System;

public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int id, decimal salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee1 = new Employee("Alice", 123, 50000m);
        employee1.DisplayDetails();
    }
}



//2
using System;

public class Circle
{
    // Property to store the radius of the circle
    public double Radius { get; set; }

    // Constructor to initialize the radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method to calculate the area of the circle
    public double CalculateArea()
    {
        // Area = π * radius^2
        return Math.PI * Math.Pow(Radius, 2);
    }

    // Method to calculate the circumference of the circle
    public double CalculateCircumference()
    {
        // Circumference = 2 * π * radius
        return 2 * Math.PI * Radius;
    }

    // Method to display the details of the circle
    public void DisplayDetails()
    {
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Circumference: {CalculateCircumference()}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Circle class
        Circle circle1 = new Circle(5.0);
        
        // Display the details of the circle
        circle1.DisplayDetails();
    }
}



//3
using System;

public class Book
{
    // Properties to store the title, author, and price of the book
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    // Constructor to initialize the title, author, and price
    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to display the details of the book
    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: {Price}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Book class
        Book book1 = new Book("1984", "George Orwell", 9.99m);
        
        // Display the details of the book
        book1.DisplayDetails();
    }
}


