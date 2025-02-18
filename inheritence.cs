//1

// Define superclass Animal
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Define subclass Dog
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Define subclass Cat
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Define subclass Bird
public class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Rex", 5);
        Cat cat = new Cat("Whiskers", 3);
        Bird bird = new Bird("Tweety", 2);

        dog.MakeSound();  // Output: Dog barks
        cat.MakeSound();  // Output: Cat meows
        bird.MakeSound();  // Output: Bird chirps
    }
}


//2
// Define base class Employee
public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
    }
}

// Define subclass Manager
public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}

// Define subclass Developer
public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}

// Define subclass Intern
public class Intern : Employee
{
    public string InternshipDuration { get; set; }

    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration: {InternshipDuration}");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Alice", 101, 90000, 10);
        Developer developer = new Developer("Bob", 102, 80000, "C#");
        Intern intern = new Intern("Charlie", 103, 30000, "6 months");

        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}


//3
// Define superclass Vehicle
public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}");
    }
}

// Define subclass Car
public class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}

// Define subclass Truck
public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity}");
    }
}

// Define subclass Motorcycle
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}

// Test the classes and demonstrate polymorphism
class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(180, "Petrol", 5),
            new Truck(120, "Diesel", 10000),
            new Motorcycle(200, "Petrol", true)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}



//4

// Define superclass Book
public class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
    }
}

// Define subclass Author
public class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Name}, Bio: {Bio}");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        Author author = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald", "American fiction writer, widely regarded as one of the greatest American authors of the 20th century.");

        author.DisplayInfo();
    }
}

//5

// Define superclass Device
public class Device
{
    public string DeviceId { get; set; }
    public string Status { get; set; }

    public Device(string deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}

// Define subclass Thermostat
public class Thermostat : Device
{
    public int TemperatureSetting { get; set; }

    public Thermostat(string deviceId, string status, int temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        Thermostat thermostat = new Thermostat("T12345", "Online", 24);
        
        thermostat.DisplayStatus();
    }
}


//6

// Define base class Order
public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Order ID: {OrderId}, Order Date: {OrderDate.ToShortDateString()}");
    }
}

// Define subclass ShippedOrder
public class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Tracking Number: {TrackingNumber}");
    }
}

// Define subclass DeliveredOrder extending ShippedOrder
public class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Delivery Date: {DeliveryDate.ToShortDateString()}");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order(1, DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder(2, DateTime.Now.AddDays(-5), "TRACK12345");
        DeliveredOrder deliveredOrder = new DeliveredOrder(3, DateTime.Now.AddDays(-10), "TRACK67890", DateTime.Now.AddDays(-2));

        Order[] orders = new Order[] { order, shippedOrder, deliveredOrder };

        foreach (var ord in orders)
        {
            ord.DisplayInfo();
            Console.WriteLine($"Order Status: {ord.GetOrderStatus()}");
            Console.WriteLine();
        }
    }
}



//7

// Define base class Course
public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }  // Duration in hours

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Course Name: {CourseName}, Duration: {Duration} hours");
    }
}

// Define subclass OnlineCourse
public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Platform: {Platform}, Recorded: {IsRecorded}");
    }
}

// Define subclass PaidOnlineCourse extending OnlineCourse
public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fee: {Fee}, Discount: {Discount}%");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        Course basicCourse = new Course("Math 101", 40);
        OnlineCourse onlineCourse = new OnlineCourse("Advanced Algorithms", 30, "Coursera", true);
        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Machine Learning", 50, "Udacity", true, 299.99, 20);

        Course[] courses = new Course[] { basicCourse, onlineCourse, paidOnlineCourse };

        foreach (var course in courses)
        {
            course.DisplayInfo();
            Console.WriteLine();
        }
    }
}




//8

// Define superclass BankAccount
public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("General Bank Account");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
    }
}

// Define subclass SavingsAccount
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}

// Define subclass CheckingAccount
public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Withdrawal Limit: {WithdrawalLimit}");
    }
}

// Define subclass FixedDepositAccount
public class FixedDepositAccount : BankAccount
{
    public int DepositTerm { get; set; }

    public FixedDepositAccount(string accountNumber, double balance, int depositTerm)
        : base(accountNumber, balance)
    {
        DepositTerm = depositTerm;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Deposit Term: {DepositTerm} months");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        BankAccount[] accounts = new BankAccount[]
        {
            new SavingsAccount("SA123456", 1500.50, 3.5),
            new CheckingAccount("CA654321", 2500.75, 1000),
            new FixedDepositAccount("FDA789012", 5000.00, 12)
        };

        foreach (var account in accounts)
        {
            account.DisplayAccountType();
            account.DisplayInfo();
            Console.WriteLine();
        }
    }
}

//9

// Define superclass Person
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Define subclass Teacher
public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Teacher");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Subject: {Subject}");
    }
}

// Define subclass Student
public class Student : Person
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Student");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Grade: {Grade}");
    }
}

// Define subclass Staff
public class Staff : Person
{
    public string Department { get; set; }

    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Staff");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Department: {Department}");
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[]
        {
            new Teacher("Alice", 30, "Mathematics"),
            new Student("Bob", 16, "10th Grade"),
            new Staff("Charlie", 45, "Administration")
        };

        foreach (var person in people)
        {
            person.DisplayRole();
            person.DisplayInfo();
            Console.WriteLine();
        }
    }
}



//10

// Define superclass Person
public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}");
    }
}

// Define interface Worker
public interface Worker
{
    void PerformDuties();
}

// Define subclass Chef
public class Chef : Person, Worker
{
    public string Speciality { get; set; }

    public Chef(string name, int id, string speciality)
        : base(name, id)
    {
        Speciality = speciality;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"Chef {Name} is cooking {Speciality} dishes.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Speciality: {Speciality}");
    }
}

// Define subclass Waiter
public class Waiter : Person, Worker
{
    public int YearsOfExperience { get; set; }

    public Waiter(string name, int id, int yearsOfExperience)
        : base(name, id)
    {
        YearsOfExperience = yearsOfExperience;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"Waiter {Name} is serving customers with {YearsOfExperience} years of experience.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Years of Experience: {YearsOfExperience}");
    }
}

// Test the classes and interface
class Program
{
    static void Main(string[] args)
    {
        Chef chef = new Chef("Gordon Ramsay", 1, "Italian");
        Waiter waiter = new Waiter("John Doe", 2, 5);

        chef.DisplayInfo();
        chef.PerformDuties();
        Console.WriteLine();

        waiter.DisplayInfo();
        waiter.PerformDuties();
    }
}

//11

// Define superclass Vehicle
public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

// Define interface Refuelable
public interface Refuelable
{
    void Refuel();
}

// Define subclass ElectricVehicle
public class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }  // Battery capacity in kWh

    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
        : base(maxSpeed, model)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine($"{Model} is charging. Battery capacity: {BatteryCapacity} kWh.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }
}

// Define subclass PetrolVehicle
public class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelTankCapacity { get; set; }  // Fuel tank capacity in liters

    public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity)
        : base(maxSpeed, model)
    {
        FuelTankCapacity = fuelTankCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine($"{Model} is refueling. Fuel tank capacity: {FuelTankCapacity} liters.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fuel Tank Capacity: {FuelTankCapacity} liters");
    }
}

// Test the classes and interface
class Program
{
    static void Main(string[] args)
    {
        ElectricVehicle ev = new ElectricVehicle(150, "Tesla Model 3", 75);
        PetrolVehicle pv = new PetrolVehicle(200, "Ford Mustang", 60);

        ev.DisplayInfo();
        ev.Charge();
        Console.WriteLine();

        pv.DisplayInfo();
        pv.Refuel();
    }
}



