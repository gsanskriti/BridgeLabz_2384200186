//1
using System;
using System.Collections.Generic;

// Abstract class Employee
abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal BaseSalary { get; set; }

    public Employee(int employeeId, string name, decimal baseSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract decimal CalculateSalary();

    public virtual string DisplayDetails()
    {
        return $"Employee ID: {EmployeeId}, Name: {Name}, Base Salary: {BaseSalary:C}";
    }
}

// Subclass FullTimeEmployee
class FullTimeEmployee : Employee
{
    public decimal FixedSalary { get; set; }

    public FullTimeEmployee(int employeeId, string name, decimal baseSalary, decimal fixedSalary)
        : base(employeeId, name, baseSalary)
    {
        FixedSalary = fixedSalary;
    }

    public override decimal CalculateSalary()
    {
        return FixedSalary;
    }

    public override string DisplayDetails()
    {
        return $"{base.DisplayDetails()}, Fixed Salary: {FixedSalary:C}";
    }
}

// Subclass PartTimeEmployee
class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public PartTimeEmployee(int employeeId, string name, decimal baseSalary, decimal hourlyRate, int hoursWorked)
        : base(employeeId, name, baseSalary)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override string DisplayDetails()
    {
        return $"{base.DisplayDetails()}, Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}";
    }
}

// Interface IDepartment
interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

// Concrete class Department implementing IDepartment
class Department : IDepartment
{
    public string DepartmentName { get; private set; }

    public void AssignDepartment(string departmentName)
    {
        DepartmentName = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {DepartmentName}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Alice", 50000, 70000),
            new PartTimeEmployee(2, "Bob", 30000, 200, 40)
        };

        foreach (var emp in employees)
        {
            Console.WriteLine(emp.DisplayDetails());
            Console.WriteLine($"Salary: {emp.CalculateSalary():C}\n");
        }
    }
}


//2
using System;
using System.Collections.Generic;

// Abstract class Product
abstract class Product
{
    protected int productId;
    protected string name;
    protected double price;

    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    // Abstract method for calculating discount
    public abstract double CalculateDiscount();
}

// Concrete class Electronics
class Electronics : Product, ITaxable
{
    public Electronics(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.10; // 10% discount
    }

    public double CalculateTax()
    {
        return price * 0.18; // 18% GST
    }

    public string GetTaxDetails()
    {
        return "18% GST applied to Electronics.";
    }
}

// Concrete class Clothing
class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.15; // 15% discount
    }

    public double CalculateTax()
    {
        return price * 0.05; // 5% GST
    }

    public string GetTaxDetails()
    {
        return "5% GST applied to Clothing.";
    }
}

// Concrete class Groceries
class Groceries : Product
{
    public Groceries(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.05; // 5% discount
    }
}

// ITaxable interface
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Method to calculate and print final price
void PrintFinalPrice(List<Product> products)
{
    foreach (var product in products)
    {
        double discount = product.CalculateDiscount();
        double tax = 0;

        if (product is ITaxable taxableProduct)
        {
            tax = taxableProduct.CalculateTax();
        }

        double finalPrice = product.Price + tax - discount;
        Console.WriteLine($"Product: {product.Name}, Final Price: {finalPrice}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Electronics(1, "Laptop", 1000),
            new Clothing(2, "Jeans", 50),
            new Groceries(3, "Apple", 1)
        };

        PrintFinalPrice(products);
    }
}


//3
using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;

    public string VehicleNumber { get; set; }
    public string Type { get; set; }
    public double RentalRate { get; set; }

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    // Abstract method for calculating rental cost
    public abstract double CalculateRentalCost(int days);
}

// Concrete class Car
class Car : Vehicle, IInsurable
{
    public Car(string vehicleNumber, string type, double rentalRate)
        : base(vehicleNumber, type, rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.05; // 5% of rental rate as insurance
    }

    public string GetInsuranceDetails()
    {
        return "5% insurance applied to Car.";
    }
}

// Concrete class Bike
class Bike : Vehicle, IInsurable
{
    public Bike(string vehicleNumber, string type, double rentalRate)
        : base(vehicleNumber, type, rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.02; // 2% of rental rate as insurance
    }

    public string GetInsuranceDetails()
    {
        return "2% insurance applied to Bike.";
    }
}

// Concrete class Truck
class Truck : Vehicle
{
    public Truck(string vehicleNumber, string type, double rentalRate)
        : base(vehicleNumber, type, rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days * 1.2; // 20% surcharge for trucks
    }
}

// IInsurable interface
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Method to calculate and print rental and insurance costs
void PrintRentalAndInsuranceCosts(List<Vehicle> vehicles, int days)
{
    foreach (var vehicle in vehicles)
    {
        double rentalCost = vehicle.CalculateRentalCost(days);
        double insuranceCost = 0;

        if (vehicle is IInsurable insurableVehicle)
        {
            insuranceCost = insurableVehicle.CalculateInsurance();
        }

        double totalCost = rentalCost + insuranceCost;
        Console.WriteLine($"Vehicle: {vehicle.Type}, Rental Cost: {rentalCost}, Insurance Cost: {insuranceCost}, Total Cost: {totalCost}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", "Car", 100),
            new Bike("BIKE123", "Bike", 50),
            new Truck("TRUCK123", "Truck", 200)
        };

        int rentalDays = 5;
        PrintRentalAndInsuranceCosts(vehicles, rentalDays);
    }
}



//4

using System;
using System.Collections.Generic;

// Abstract class BankAccount
abstract class BankAccount
{
    protected string accountNumber;
    protected string holderName;
    protected double balance;

    public string AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        balance += amount;
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    // Abstract method to calculate interest
    public abstract double CalculateInterest();
}

// Concrete class SavingsAccount
class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate = 0.04; // 4% interest rate

    public SavingsAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * interestRate;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for Savings Account.");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 0.5; // Eligible for a loan up to 50% of the balance
    }
}

// Concrete class CurrentAccount
class CurrentAccount : BankAccount, ILoanable
{
    private double interestRate = 0.02; // 2% interest rate

    public CurrentAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * interestRate;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for Current Account.");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 0.3; // Eligible for a loan up to 30% of the balance
    }
}

// ILoanable interface
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

// Method to process accounts and calculate interest
void ProcessAccounts(List<BankAccount> accounts)
{
    foreach (var account in accounts)
    {
        double interest = account.CalculateInterest();
        Console.WriteLine($"Account: {account.HolderName}, Interest: {interest}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("SAV123", "John Doe", 1000),
            new CurrentAccount("CUR123", "Jane Smith", 2000)
        };

        ProcessAccounts(accounts);
    }
}



//5
using System;
using System.Collections.Generic;

// Abstract class LibraryItem
abstract class LibraryItem
{
    protected string itemId;
    protected string title;
    protected string author;

    public string ItemId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public LibraryItem(string itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    // Abstract method to get loan duration
    public abstract int GetLoanDuration();

    // Concrete method to get item details
    public string GetItemDetails()
    {
        return $"ID: {itemId}, Title: {title}, Author: {author}";
    }
}

// Concrete class Book
class Book : LibraryItem, IReservable
{
    public Book(string itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 21; // 21 days loan duration for books
    }

    public void ReserveItem()
    {
        Console.WriteLine($"Book '{title}' has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true; // Assuming the book is available
    }
}

// Concrete class Magazine
class Magazine : LibraryItem, IReservable
{
    public Magazine(string itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 7 days loan duration for magazines
    }

    public void ReserveItem()
    {
        Console.WriteLine($"Magazine '{title}' has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true; // Assuming the magazine is available
    }
}

// Concrete class DVD
class DVD : LibraryItem, IReservable
{
    public DVD(string itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // 14 days loan duration for DVDs
    }

    public void ReserveItem()
    {
        Console.WriteLine($"DVD '{title}' has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true; // Assuming the DVD is available
    }
}

// IReservable interface
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Method to process library items
void ProcessLibraryItems(List<LibraryItem> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item.GetItemDetails());
        Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");
        
        if (item is IReservable reservableItem)
        {
            reservableItem.ReserveItem();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book("BOOK123", "The Great Gatsby", "F. Scott Fitzgerald"),
            new Magazine("MAG123", "National Geographic", "Various Authors"),
            new DVD("DVD123", "Inception", "Christopher Nolan")
        };

        ProcessLibraryItems(items);
    }
}


//6

using System;
using System.Collections.Generic;

// Abstract class FoodItem
abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    public string ItemName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    // Abstract method to calculate total price
    public abstract double CalculateTotalPrice();

    // Concrete method to get item details
    public string GetItemDetails()
    {
        return $"Item: {itemName}, Price: {price}, Quantity: {quantity}";
    }
}

// Concrete class VegItem
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (price * quantity) + (price * quantity * 0.05); // 5% additional charge
    }

    public double ApplyDiscount()
    {
        return price * quantity * 0.10; // 10% discount
    }

    public string GetDiscountDetails()
    {
        return "10% discount applied to Veg Item.";
    }
}

// Concrete class NonVegItem
class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (price * quantity) + (price * quantity * 0.10); // 10% additional charge
    }

    public double ApplyDiscount()
    {
        return price * quantity * 0.15; // 15% discount
    }

    public string GetDiscountDetails()
    {
        return "15% discount applied to Non-Veg Item.";
    }
}

// IDiscountable interface
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// Method to process food items
void ProcessFoodItems(List<FoodItem> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item.GetItemDetails());
        Console.WriteLine($"Total Price (with charges): {item.CalculateTotalPrice()}");

        if (item is IDiscountable discountableItem)
        {
            Console.WriteLine(discountableItem.GetDiscountDetails());
            Console.WriteLine($"Discount: {discountableItem.ApplyDiscount()}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<FoodItem> items = new List<FoodItem>
        {
            new VegItem("Veg Burger", 5, 2),
            new NonVegItem("Chicken Burger", 7, 3)
        };

        ProcessFoodItems(items);
    }
}


//7
using System;
using System.Collections.Generic;

// Abstract class Patient
abstract class Patient
{
    protected int patientId;
    protected string name;
    protected int age;
    protected string diagnosis;

    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Patient(int patientId, string name, int age, string diagnosis)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        this.diagnosis = diagnosis;
    }

    // Abstract method to calculate bill
    public abstract double CalculateBill();

    // Concrete method to get patient details
    public string GetPatientDetails()
    {
        return $"ID: {patientId}, Name: {name}, Age: {age}";
    }
}

// Concrete class InPatient
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyRate;

    public InPatient(int patientId, string name, int age, string diagnosis, int daysAdmitted, double dailyRate)
        : base(patientId, name, age, diagnosis)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyRate = dailyRate;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyRate;
    }

    public void AddRecord(string record)
    {
        Console.WriteLine($"Added record for InPatient '{name}': {record}");
    }

    public void ViewRecords()
    {
        Console.WriteLine($"Viewing records for InPatient '{name}'.");
    }
}

// Concrete class OutPatient
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(int patientId, string name, int age, string diagnosis, double consultationFee)
        : base(patientId, name, age, diagnosis)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        Console.WriteLine($"Added record for OutPatient '{name}': {record}");
    }

    public void ViewRecords()
    {
        Console.WriteLine($"Viewing records for OutPatient '{name}'.");
    }
}

// IMedicalRecord interface
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// Method to process patients and calculate billing details
void ProcessPatients(List<Patient> patients)
{
    foreach (var patient in patients)
    {
        Console.WriteLine(patient.GetPatientDetails());
        Console.WriteLine($"Bill: {patient.CalculateBill()}");

        if (patient is IMedicalRecord medicalRecord)
        {
            medicalRecord.AddRecord("Sample medical record.");
            medicalRecord.ViewRecords();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient(1, "John Doe", 35, "Diagnosis A", 5, 1000),
            new OutPatient(2, "Jane Smith", 28, "Diagnosis B", 500)
        };

        ProcessPatients(patients);
    }
}


//8

using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    protected string vehicleId;
    protected string driverName;
    protected double ratePerKm;

    public string VehicleId { get; set; }
    public string DriverName { get; set; }
    public double RatePerKm { get; set; }

    public Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    // Abstract method to calculate fare
    public abstract double CalculateFare(double distance);

    // Concrete method to get vehicle details
    public string GetVehicleDetails()
    {
        return $"Vehicle ID: {vehicleId}, Driver: {driverName}, Rate per km: {ratePerKm}";
    }
}

// Concrete class Car
class Car : Vehicle, IGPS
{
    public Car(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string GetCurrentLocation()
    {
        return "Car is at Location A.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine($"Car location updated to {newLocation}.");
    }
}

// Concrete class Bike
class Bike : Vehicle, IGPS
{
    public Bike(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm * 0.9; // 10% discount for bikes
    }

    public string GetCurrentLocation()
    {
        return "Bike is at Location B.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine($"Bike location updated to {newLocation}.");
    }
}

// Concrete class Auto
class Auto : Vehicle, IGPS
{
    public Auto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm * 0.8; // 20% discount for autos
    }

    public string GetCurrentLocation()
    {
        return "Auto is at Location C.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine($"Auto location updated to {newLocation}.");
    }
}

// IGPS interface
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Method to process vehicles and calculate fares
void ProcessVehicles(List<Vehicle> vehicles, double distance)
{
    foreach (var vehicle in vehicles)
    {
        Console.WriteLine(vehicle.GetVehicleDetails());
        Console.WriteLine($"Fare for {distance} km: {vehicle.CalculateFare(distance)}");

        if (vehicle is IGPS gpsVehicle)
        {
            Console.WriteLine(gpsVehicle.GetCurrentLocation());
            gpsVehicle.UpdateLocation("New Location");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", "John Doe", 10),
            new Bike("BIKE123", "Jane Smith", 8),
            new Auto("AUTO123", "Raj Kumar", 6)
        };

        double distance = 15;
        ProcessVehicles(vehicles, distance);
    }
}



