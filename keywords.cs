//1
using System;

public class BankAccount
{
    // Static variable shared across all accounts
    private static string bankName = "AwesomeBank";
    private static int totalAccounts = 0;

    // Readonly variable for account number
    public readonly int AccountNumber;
    public string AccountHolderName { get; set; }
    public decimal Balance { get; set; }

    // Constructor to initialize AccountHolderName and AccountNumber
    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        totalAccounts++;
    }

    // Static method to get the total number of accounts
    public static int GetTotalAccounts()
    {
        return totalAccounts;
    }

    // Method to display account details
    public void DisplayDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine($"Bank Name: {bankName}");
            Console.WriteLine($"Account Holder: {this.AccountHolderName}");
            Console.WriteLine($"Account Number: {this.AccountNumber}");
            Console.WriteLine($"Balance: {this.Balance:C}");
        }
        else
        {
            Console.WriteLine("Object is not a BankAccount instance.");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Shubham", 123456);
        account1.Balance = 24000.0m;

        BankAccount account2 = new BankAccount("Sanskriti", 654321);
        account2.Balance = 26000.0m;

        account1.DisplayDetails();
        account2.DisplayDetails();

        Console.WriteLine($"Total Accounts: {BankAccount.GetTotalAccounts()}");
    }
}


//2
using System;

public class Book
{
    // Static variable shared across all books
    private static string libraryName = "City Library";

    // Readonly variable for ISBN
    public readonly string ISBN;
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize Title, Author, and ISBN
    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    // Static method to display the library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine($"Library Name: {libraryName}");
    }

    // Method to display book details
    public void DisplayDetails()
    {
        if (this is Book)
        {
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Author: {this.Author}");
            Console.WriteLine($"ISBN: {this.ISBN}");
        }
        else
        {
            Console.WriteLine("Object is not a Book instance.");
        }
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("1984", "rahul mishra", "123-4567890123");
        Book book2 = new Book("To Kill a Mockingbird", "aditi", "987-6543210987");

        Book.DisplayLibraryName();

        book1.DisplayDetails();
        book2.DisplayDetails();
    }
}


//3
using System;

public class Employee
{
    // Static variable shared across all employees
    private static string companyName = "TechCorp";
    private static int totalEmployees = 0;

    // Readonly variable for employee ID
    public readonly int Id;
    public string Name { get; set; }
    public string Designation { get; set; }

    // Constructor to initialize Name, Id, and Designation
    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }

    // Static method to display the total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees: {totalEmployees}");
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine($"Company Name: {companyName}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Employee ID: {this.Id}");
            Console.WriteLine($"Designation: {this.Designation}");
        }
        else
        {
            Console.WriteLine("Object is not an Employee instance.");
        }
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee("Sanskriti gupta", 101, "Software Engineer");
        Employee emp2 = new Employee("Rashi bansal", 102, "Project Manager");

        Employee.DisplayTotalEmployees();

        emp1.DisplayDetails();
        emp2.DisplayDetails();
    }
}


//4
using System;

public class Product
{
    // Static variable shared across all products
    private static double discount = 0.0;

    // Readonly variable for product ID
    public readonly int ProductID;
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Constructor to initialize ProductName, Price, and Quantity
    public Product(string productName, double price, int quantity, int productId)
    {
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = productId;
    }

    // Static method to update the discount percentage
    public static void UpdateDiscount(double newDiscount)
    {
        discount = newDiscount;
    }

    // Method to display product details
    public void DisplayDetails()
    {
        if (this is Product)
        {
            Console.WriteLine($"Product ID: {this.ProductID}");
            Console.WriteLine($"Product Name: {this.ProductName}");
            Console.WriteLine($"Price: {this.Price:C}");
            Console.WriteLine($"Quantity: {this.Quantity}");
            Console.WriteLine($"Discount: {discount}%");
        }
        else
        {
            Console.WriteLine("Object is not a Product instance.");
        }
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product("Laptop", 1500.0, 2, 101);
        Product product2 = new Product("Smartphone", 800.0, 5, 102);

        Product.UpdateDiscount(10.0);

        product1.DisplayDetails();
        product2.DisplayDetails();
    }
}


//5

using System;

public class Student
{
    // Static variable shared across all students
    private static string universityName = "Global University";
    private static int totalStudents = 0;

    // Readonly variable for roll number
    public readonly int RollNumber;
    public string Name { get; set; }
    public string Grade { get; set; }

    // Constructor to initialize Name, RollNumber, and Grade
    public Student(string name, int rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }

    // Static method to display the total number of students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"Total Students Enrolled: {totalStudents}");
    }

    // Method to display student details
    public void DisplayDetails()
    {
        if (this is Student)
        {
            Console.WriteLine($"University Name: {universityName}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Roll Number: {this.RollNumber}");
            Console.WriteLine($"Grade: {this.Grade}");
        }
        else
        {
            Console.WriteLine("Object is not a Student instance.");
        }
    }

    // Method to update student grade
    public void UpdateGrade(string newGrade)
    {
        if (this is Student)
        {
            this.Grade = newGrade;
        }
        else
        {
            Console.WriteLine("Object is not a Student instance.");
        }
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("akash singh", 101, "A");
        Student student2 = new Student("sanskriti bansal", 102, "B");

        Student.DisplayTotalStudents();

        student1.DisplayDetails();
        student2.DisplayDetails();

        student2.UpdateGrade("A+");
        student2.DisplayDetails();
    }
}


//6
using System;

public class Vehicle
{
    // Static variable common for all vehicles
    private static double registrationFee = 100.0;

    // Readonly variable for registration number
    public readonly string RegistrationNumber;
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }

    // Constructor to initialize OwnerName, VehicleType, and RegistrationNumber
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }

    // Static method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    // Method to display vehicle details
    public void DisplayDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine($"Owner Name: {this.OwnerName}");
            Console.WriteLine($"Vehicle Type: {this.VehicleType}");
            Console.WriteLine($"Registration Number: {this.RegistrationNumber}");
            Console.WriteLine($"Registration Fee: {registrationFee:C}");
        }
        else
        {
            Console.WriteLine("Object is not a Vehicle instance.");
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle("shivang ", "Car", "XYZ123");
        Vehicle vehicle2 = new Vehicle("sanskriti", "Motorbike", "ABC456");

        Vehicle.UpdateRegistrationFee(120.0);

        vehicle1.DisplayDetails();
        vehicle2.DisplayDetails();
    }
}


//7
using System;

public class Vehicle
{
    // Static variable common for all vehicles
    private static double registrationFee = 100.0;

    // Readonly variable for registration number
    public readonly string RegistrationNumber;
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }

    // Constructor to initialize OwnerName, VehicleType, and RegistrationNumber
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }

    // Static method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    // Method to display vehicle details
    public void DisplayDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine($"Owner Name: {this.OwnerName}");
            Console.WriteLine($"Vehicle Type: {this.VehicleType}");
            Console.WriteLine($"Registration Number: {this.RegistrationNumber}");
            Console.WriteLine($"Registration Fee: {registrationFee:C}");
        }
        else
        {
            Console.WriteLine("Object is not a Vehicle instance.");
        }
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle("rahul mittal", "Car", "XYZ123");
        Vehicle vehicle2 = new Vehicle("shiva singh", "Motorbike", "ABC456");

        Vehicle.UpdateRegistrationFee(120.0);

        vehicle1.DisplayDetails();
        vehicle2.DisplayDetails();
    }
}

