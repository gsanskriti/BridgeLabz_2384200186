//1

using System;

namespace BookLibrary
{
    public class Book
    {
        // Attributes of the Book class
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0.0;
        }

        // Parameterized constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        // Method to display book details
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}



//2

using System;

namespace ShapeLibrary
{
    public class Circle
    {
        // Attribute of the Circle class
        public double Radius { get; set; }

        // Default constructor
        public Circle() : this(0.0) // Calls the parameterized constructor with default value
        {
        }

        // Parameterized constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Method to calculate the area of the circle
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Method to calculate the circumference of the circle
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        // Method to display circle details
        public void DisplayCircleInfo()
        {
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Circumference: {CalculateCircumference()}");
        }
    }
}


//3

using System;

namespace PersonLibrary
{
    public class Person
    {
        // Attributes of the Person class
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Address = "Unknown";
        }

        // Parameterized constructor
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        // Copy constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            Address = other.Address;
        }

        // Method to display person details
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}


//4

using System;

namespace HotelBookingSystem
{
    public class HotelBooking
    {
        // Attributes of the HotelBooking class
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public int Nights { get; set; }

        // Default constructor
        public HotelBooking()
        {
            GuestName = "Unknown";
            RoomType = "Standard";
            Nights = 0;
        }

        // Parameterized constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }

        // Copy constructor
        public HotelBooking(HotelBooking other)
        {
            GuestName = other.GuestName;
            RoomType = other.RoomType;
            Nights = other.Nights;
        }

        // Method to display booking details
        public void DisplayBookingInfo()
        {
            Console.WriteLine($"Guest Name: {GuestName}");
            Console.WriteLine($"Room Type: {RoomType}");
            Console.WriteLine($"Nights: {Nights}");
        }
    }
}




//5

using System;

namespace LibrarySystem
{
    public class Book
    {
        // Attributes of the Book class
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0.0;
            IsAvailable = true;
        }

        // Parameterized constructor
        public Book(string title, string author, double price, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = isAvailable;
        }

        // Copy constructor
        public Book(Book other)
        {
            Title = other.Title;
            Author = other.Author;
            Price = other.Price;
            IsAvailable = other.IsAvailable;
        }

        // Method to borrow the book
        public bool BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to display book details
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
        }
    }
}


//6

using System;

namespace CarRentalSystem
{
    public class CarRental
    {
        // Attributes of the CarRental class
        public string CustomerName { get; set; }
        public string CarModel { get; set; }
        public int RentalDays { get; set; }
        private const double DailyRate = 50.0; 
        // Default constructor
        public CarRental()
        {
            CustomerName = "Unknown";
            CarModel = "Unknown";
            RentalDays = 0;
        }

        // Parameterized constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
        }

        // Copy constructor
        public CarRental(CarRental other)
        {
            CustomerName = other.CustomerName;
            CarModel = other.CarModel;
            RentalDays = other.RentalDays;
        }

        // Method to calculate the total cost
        public double CalculateTotalCost()
        {
            return RentalDays * DailyRate;
        }

        // Method to display rental details
        public void DisplayRentalInfo()
        {
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Car Model: {CarModel}");
            Console.WriteLine($"Rental Days: {RentalDays}");
            Console.WriteLine($"Total Cost: {CalculateTotalCost()}");
        }
    }
}



//instances and class variable
//1

using System;

namespace InventorySystem
{
    public class Product
    {
        // Instance variables
        public string ProductName { get; set; }
        public double Price { get; set; }

        // Class variable shared among all products
        private static int totalProducts = 0;

        // Default constructor
        public Product()
        {
            ProductName = "Unknown";
            Price = 0.0;
            totalProducts++;
        }

        // Parameterized constructor
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            totalProducts++;
        }

        // Instance method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
        }

        // Class method to display total number of products
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {totalProducts}");
        }
    }
}


//2

using System;

namespace CourseManagementSystem
{
    public class Course
    {
        // Instance variables
        public string CourseName { get; set; }
        public int Duration { get; set; } // Duration in weeks
        public double Fee { get; set; }

        // Class variable common for all courses
        private static string instituteName = "Default Institute";

        // Default constructor
        public Course()
        {
            CourseName = "Unknown";
            Duration = 0;
            Fee = 0.0;
        }

        // Parameterized constructor
        public Course(string courseName, int duration, double fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }

        // Instance method to display course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Institute Name: {instituteName}");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration} weeks");
            Console.WriteLine($"Fee: {Fee}");
        }

        // Class method to update the institute name
        public static void UpdateInstituteName(string newInstituteName)
        {
            instituteName = newInstituteName;
        }
    }
}


//3

using System;

namespace VehicleRegistrationSystem
{
    public class Vehicle
    {
        // Instance variables
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }

        // Class variable shared among all vehicles
        private static double registrationFee = 100.0; // Example registration fee

        // Default constructor
        public Vehicle()
        {
            OwnerName = "Unknown";
            VehicleType = "Unknown";
        }

        // Parameterized constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }

        // Instance method to display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Registration Fee: {registrationFee}");
        }

        // Class method to update the registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }
    }
}

//access modifier
//2

using System;

namespace UniversityManagementSystem
{
    public class Student
    {
        // Public member
        public int RollNumber { get; set; }

        // Protected member
        protected string Name { get; set; }

        // Private member
        private double CGPA { get; set; }

        // Default constructor
        public Student()
        {
            RollNumber = 0;
            Name = "Unknown";
            CGPA = 0.0;
        }

        // Parameterized constructor
        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }

        // Public method to access CGPA
        public double GetCGPA()
        {
            return CGPA;
        }

        // Public method to modify CGPA
        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0.0 && cgpa <= 10.0) // Assuming CGPA is on a scale of 0 to 10
            {
                CGPA = cgpa;
            }
            else
            {
                throw new ArgumentException("Invalid CGPA value.");
            }
        }

        // Method to display student details
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CGPA: {CGPA}");
        }
    }

    public class PostgraduateStudent : Student
    {
        // Additional attribute for postgraduate student
        public string ResearchTopic { get; set; }

        // Default constructor
        public PostgraduateStudent() : base()
        {
            ResearchTopic = "Unknown";
        }

        // Parameterized constructor
        public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic) : base(rollNumber, name, cgpa)
        {
            ResearchTopic = researchTopic;
        }

        // Method to display postgraduate student details
        public void DisplayPostgraduateStudentDetails()
        {
            DisplayStudentDetails();
            Console.WriteLine($"Research Topic: {ResearchTopic}");
        }
    }
}

//2

using System;

namespace BookLibrarySystem
{
    public class Book
    {
        // Public member
        public string ISBN { get; set; }

        // Protected member
        protected string Title { get; set; }

        // Private member
        private string Author { get; set; }

        // Default constructor
        public Book()
        {
            ISBN = "Unknown";
            Title = "Unknown";
            Author = "Unknown";
        }

        // Parameterized constructor
        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        // Method to set the author name
        public void SetAuthor(string author)
        {
            Author = author;
        }

        // Method to get the author name
        public string GetAuthor()
        {
            return Author;
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }

    public class EBook : Book
    {
        // Additional attribute for EBook
        public string FileFormat { get; set; }

        // Default constructor
        public EBook() : base()
        {
            FileFormat = "Unknown";
        }

        // Parameterized constructor
        public EBook(string isbn, string title, string author, string fileFormat) : base(isbn, title, author)
        {
            FileFormat = fileFormat;
        }

        // Method to display ebook details
        public void DisplayEBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}"); // Accessing public member
            Console.WriteLine($"Title: {Title}"); // Accessing protected member
            Console.WriteLine($"Author: {GetAuthor()}"); // Accessing private member via public method
            Console.WriteLine($"File Format: {FileFormat}");
        }
    }
}


//3

using System;

namespace BankAccountManagement
{
    public class BankAccount
    {
        // Public member
        public int AccountNumber { get; set; }

        // Protected member
        protected string AccountHolder { get; set; }

        // Private member
        private double Balance { get; set; }

        // Default constructor
        public BankAccount()
        {
            AccountNumber = 0;
            AccountHolder = "Unknown";
            Balance = 0.0;
        }

        // Parameterized constructor
        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Method to get the balance
        public double GetBalance()
        {
            return Balance;
        }

        // Method to set the balance
        public void SetBalance(double balance)
        {
            if (balance >= 0.0)
            {
                Balance = balance;
            }
            else
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }

    public class SavingsAccount : BankAccount
    {
        // Additional attribute for SavingsAccount
        public double InterestRate { get; set; }

        // Default constructor
        public SavingsAccount() : base()
        {
            InterestRate = 0.0;
        }

        // Parameterized constructor
        public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate) : base(accountNumber, accountHolder, balance)
        {
            InterestRate = interestRate;
        }

        // Method to display savings account details
        public void DisplaySavingsAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}"); // Accessing public member
            Console.WriteLine($"Account Holder: {AccountHolder}"); // Accessing protected member
            Console.WriteLine($"Balance: {GetBalance()}"); // Accessing private member via public method
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }
}


//4

using System;

namespace EmployeeRecords
{
    public class Employee
    {
        // Public member
        public int EmployeeID { get; set; }

        // Protected member
        protected string Department { get; set; }

        // Private member
        private double Salary { get; set; }

        // Default constructor
        public Employee()
        {
            EmployeeID = 0;
            Department = "Unknown";
            Salary = 0.0;
        }

        // Parameterized constructor
        public Employee(int employeeID, string department, double salary)
        {
            EmployeeID = employeeID;
            Department = department;
            Salary = salary;
        }

        // Method to get the salary
        public double GetSalary()
        {
            return Salary;
        }

        // Method to set the salary
        public void SetSalary(double salary)
        {
            if (salary >= 0.0)
            {
                Salary = salary;
            }
            else
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    public class Manager : Employee
    {
        // Additional attribute for Manager
        public string Team { get; set; }

        // Default constructor
        public Manager() : base()
        {
            Team = "Unknown";
        }

        // Parameterized constructor
        public Manager(int employeeID, string department, double salary, string team) : base(employeeID, department, salary)
        {
            Team = team;
        }

        // Method to display manager details
        public void DisplayManagerDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}"); // Accessing public member
            Console.WriteLine($"Department: {Department}"); // Accessing protected member
            Console.WriteLine($"Salary: {GetSalary()}"); // Accessing private member via public method
            Console.WriteLine($"Team: {Team}");
        }
    }
}

