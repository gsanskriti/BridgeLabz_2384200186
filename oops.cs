//1
using System;
using System.Collections.Generic;
class Book
{
public string title;
public string author;
// Constructor
public Book(string title, string author)
{
this.title = title;
this.author = author;
}
// Method to display book details
public void DisplayBook()
{
Console.WriteLine(&quot;this.title: {0}, this.author: {1}&quot; , this.title ,
this.author);
}
}
// Library class
class Library
{
// List to hold books

private readonly List&lt;Book&gt; books;
public string libraryName;
// Constructor
public Library(string name)
{
libraryName = name;
books = new List&lt;Book&gt;();
}
// Method to add a book
public void AddBook(Book book)
{
books.Add(book);
}
// Method to display all books
public void DisplayLibraryBooks()
{
Console.WriteLine(&quot;Library: {0} contains the following books:&quot; ,
libraryName);
if (books.Count == 0)
{
Console.WriteLine(&quot;No books available in the library.&quot;);
return;
}
foreach (var book in books)
{
book.DisplayBook();
}
}
}
// Main class (aggregation)
class Program
{
static void Main()
{
// Creating Book objects
Book book1 = new Book(&quot;The Last Kingdom&quot;, &quot;Rohit&quot;);
Book book2 = new Book(&quot;The Last Kingdom: Revolution&quot;, &quot;Atul&quot;);
Book book3 = new Book(&quot;Falling Kingdom&quot;, &quot;Aman&quot;);
// Creating Library objects
Library library1 = new Library(&quot;GLA Central Library&quot;);
Library library2 = new Library(&quot;GLA MBA Library&quot;);

// Adding books to different libraries
library1.AddBook(book1);
library1.AddBook(book2);
library2.AddBook(book2);
library2.AddBook(book3);
// Display books in each library
library1.DisplayLibraryBooks();
library2.DisplayLibraryBooks();
}
}

//2
using System;
using System.Collections.Generic;
// Bank class
class Bank
{
public string bankName;
private List&lt;Customer&gt; customers;
// Constructor
public Bank(string bankName)
{
this.bankName = bankName;
customers = new List&lt;Customer&gt;();

}
// Method to open an account
public void OpenAccount(Customer customer, decimal deposit)
{
Account newAccount = new Account(this, deposit);
customer.AddAccount(newAccount);
customers.Add(customer);
}
// Method to display customers
public void DisplayCustomers()
{
Console.WriteLine(&quot;Bank: {0} - Customer Accounts:&quot; , bankName);
foreach (var customer in customers)
{
customer.ViewAccounts();
}
}
}
class Customer
{
public string name;
private List&lt;Account&gt; accounts;
// Constructor
public Customer(string name)
{
this.name = name;
accounts = new List&lt;Account&gt;();
}
// Method to add an account
public void AddAccount(Account account)
{
accounts.Add(account);
}
// Method to view all accounts
public void ViewAccounts()
{
Console.WriteLine(&quot;Customer: {0}&quot; , Name);
foreach (var account in accounts)
{
account.DisplayAccountInfo();
}
}

}
class Account
{
private static int accountNumberSeed = 1000;
public int accountNumber;
public Bank bank;
public decimal balance;
// Constructor
public Account(Bank bank, decimal deposit)
{
this.bank = bank;
this.balance = deposit;
this.accountNumber = accountNumberSeed++;
}
// Method to display account details
public void DisplayAccountInfo()
{
Console.WriteLine(&quot;Account Number: {0}, Bank: {1}, balance: {2}&quot; ,
accountNumber , Bank.bankName , balance);
}
}
// Main class (association)
class Program
{
static void Main()
{
// Creating a bank
Bank bank1 = new Bank(&quot;INDIAN BANK&quot;);
// Creating customers
Customer customer1 = new Customer(&quot;Rohit Dixit&quot;);
Customer customer2 = new Customer(&quot;Rahul Dixit&quot;);
// Opening accounts for customers
bank1.OpenAccount(customer1, 1000);
bank1.OpenAccount(customer2, 1500);
// Display all customers
bank1.DisplayCustomers();
}
}

//3
using System;
using System.Collections.Generic;
// Employee class
class Employee
{
public string name;
public string position;
// Constructor
public Employee(string name, string position)
{
this.name = name;
this.position = position;
}
// Method to display details
public void DisplayEmployee()
{
Console.WriteLine(&quot;Employee: {0}, position: {1}&quot;, this.name ,
this.position);
}
}
// Department class
class Department
{
public string departmentName;
private List&lt;Employee&gt; employees;
// Constructor

public Department(string departmentName)
{
this.departmentName = departmentName;
this.employees = new List&lt;Employee&gt;();
}
// Method to add an employee
public void AddEmployee(string name, string position)
{
employees.Add(new Employee(name, position));
}
// Method to display all employees
public void DisplayDepartment()
{
Console.WriteLine(&quot;Department: {0}&quot;, departmentName);
if (employees.Count == 0)
{
Console.WriteLine(&quot;No employees in this department.&quot;);
return;
}
foreach (var employee in employees)
{
employee.DisplayEmployee();
}
}
}
// Company class
class Company
{
public string companyName;
private List&lt;Department&gt; departments;
// Constructor
public Company(string companyName)
{
this.companyName = companyName;
this.departments = new List&lt;Department&gt;();
}
// Method to add a department
public void AddDepartment(string departmentName)
{
departments.Add(new Department(departmentName));
}
// Method to get a department

public Department GetDepartment(string departmentName)
{
foreach (var dept in departments)
{
if (dept.departmentName == departmentName)
return dept;
}
return null;
}
// Method to display all information
public void DisplayCompany()
{
Console.WriteLine(&quot;Company: {0}&quot; , companyName);
if (departments.Count == 0)
{
Console.WriteLine(&quot;No departments in the company.&quot;);
return;
}
foreach (var department in departments)
{
department.DisplayDepartment();
}
}
}
// Main class (composition)
class Program
{
public static void Main()
{
// Creating company
Company company = new Company(&quot;X-park Technologies&quot;);
// Adding departments
company.AddDepartment(&quot;Technical&quot;);
company.AddDepartment(&quot;Human Resources&quot;);
// Adding employees to departments
Department technical = company.GetDepartment(&quot;Technical&quot;);
technical.AddEmployee(&quot;Vansh Saxena&quot;, &quot;Software Analyst&quot;);
technical.AddEmployee(&quot;Krishana&quot;, &quot;CTO&quot;);

Department hr = company.GetDepartment(&quot;Human Resources&quot;);
hr.AddEmployee(&quot;Rahul Kumar&quot;, &quot;HR Manager&quot;);

// Displaying Company info
company.DisplayCompany();
}
}


//self program
//1
using System;
using System.Collections.Generic;

// Course class
class Course
{
public string courseName;
private List&lt;Student&gt; students;

// Constructor
public Course(string courseName)
{

this.courseName = courseName;
this.students = new List&lt;Student&gt;();
}

// Method to enroll a student
public void EnrollStudent(Student student)
{
students.Add(student);
}

// Method to display enrolled students
public void DisplayStudents()
{
Console.WriteLine(&quot;Course: {0}&quot;, courseName);
if (students.Count == 0)
{
Console.WriteLine(&quot;No students enrolled in this course.&quot;);
return;
}
foreach (var student in students)
{
Console.WriteLine(&quot;Student: {0}&quot;, student.studentName);
}
}
}

// Student class
class Student

{
public string studentName;
private List&lt;Course&gt; courses;

// Constructor
public Student(string studentName)
{
this.studentName = studentName;
this.courses = new List&lt;Course&gt;();
}

// Method to enroll in a course
public void EnrollInCourse(Course course)
{
courses.Add(course);
course.EnrollStudent(this);
}

// Method to display enrolled courses
public void DisplayCourses()
{
Console.WriteLine(&quot;Student: {0}&quot;, studentName);
if (courses.Count == 0)
{
Console.WriteLine(&quot;No courses enrolled.&quot;);
return;
}
foreach (var course in courses)

{
Console.WriteLine(&quot;Course: {0}&quot;, course.courseName);
}
}
}

// School class
class School
{
public string schoolName;
private List&lt;Student&gt; students;

// Constructor
public School(string schoolName)
{
this.schoolName = schoolName;
this.students = new List&lt;Student&gt;();
}

// Method to add a student
public void AddStudent(Student student)
{
students.Add(student);
}

// Method to display all students
public void DisplayStudents()
{

Console.WriteLine(&quot;School: {0}&quot;, schoolName);
if (students.Count == 0)
{
Console.WriteLine(&quot;No students in the school.&quot;);
return;
}
foreach (var student in students)
{
student.DisplayCourses();
}
}
}

// Main class
class Program
{
static void Main()
{
// Creating school
School school = new School(&quot;Kendriya Vidyalaya&quot;);

// Creating students
Student rohit = new Student(&quot;Rohti&quot;);
Student mohit = new Student(&quot;Mohit&quot;);

// Creating courses
Course math = new Course(&quot;Mathematics&quot;);
Course science = new Course(&quot;Science&quot;);

// Enrolling students in courses
rohit.EnrollInCourse(math);
rohit.EnrollInCourse(science);
mohit.EnrollInCourse(math);

// Adding students to the school
school.AddStudent(rohit);
school.AddStudent(mohit);

// Displaying school details
school.DisplayStudents();

// Displaying course details
math.DisplayStudents();
science.DisplayStudents();
}
}

//2
using System;
using System.Collections.Generic;
// Faculty class
class Faculty
{
public string name;
public string designation;
// Constructor
public Faculty(string name, string designation)
{
this.name = name;
this.designation = designation;
}
// Display Faculty details
public void DisplayFaculty()
{
Console.WriteLine(&quot;Faculty: {0}, designation: {1}&quot;, this.name,
this.designation);
}
}
// Department class
class Department
{
public string departmentName ;
private List&lt;Faculty&gt; facultyMembers;
// Constructor
public Department(string departmentName)
{
this.departmentName = departmentName;
this.facultyMembers = new List&lt;Faculty&gt;();
}
// Method to add a Faculty
public void AddFaculty(Faculty faculty)
{
facultyMembers.Add(faculty);
}

// Display department
public void DisplayDepartment()
{
Console.WriteLine(&quot;Department: {0}&quot;, this.departmentName);
if (facultyMembers.Count == 0)
{
Console.WriteLine(&quot;No faculty members in this department&quot;);
return;
}
foreach (var faculty in facultyMembers)
{
faculty.DisplayFaculty();
}
}
}
// University class
class University
{
public string universityName;
private List&lt;Department&gt; departments;
// Constructor
public University(string universityName)
{
this.universityName = universityName;
this. departments = new List&lt;Department&gt;();
}
// Method to add a department
public void AddDepartment(string departmentName)
{
departments.Add(new Department(departmentName));
}
// Method to get a department
public Department GetDepartment(string departmentName)
{
foreach (var dept in departments)
{
if (dept.departmentName == departmentName)
return dept;
}
return null;
}
// Display university details
public void DisplayUniversity()

{
Console.WriteLine(&quot;University: {0}&quot;, this.universityName);
if (departments.Count == 0)
{
Console.WriteLine(&quot;No departments in the university&quot;);
return;
}
foreach (var department in departments)
{
department.DisplayDepartment();
}
}
}
// Main class
class Program
{
static void Main()
{
// Creating university
University university = new University(&quot;GLA University&quot;);
// Adding departments
university.AddDepartment(&quot;Computer Science&quot;);
university.AddDepartment(&quot;Physics&quot;);
// Creating faculty members
Faculty prof1 = new Faculty(&quot;Rohit Dixit&quot;, &quot;Professor&quot;);
Faculty prof2 = new Faculty(&quot;Mohit Singh&quot;, &quot;Assistant Professor&quot;);
// Assigning faculty to departments
Department cs = university.GetDepartment(&quot;Computer Science&quot;);
cs.AddFaculty(prof1);
Department physics = university.GetDepartment(&quot;Physics&quot;);
physics.AddFaculty(prof2);
// Displaying info
university.DisplayUniversity();
}
}


//3
using System;
using System.Collections.Generic;
// Patient class
class Patient
{
public string name;
public int age;
public Patient(string name, int age)
{
this.name = name;
this.age = age;
}
public void DisplayPatient()
{
Console.WriteLine(&quot;Patient: {0}, age: {1}&quot;, this.name, this.age);
}
}
// Doctor class
class Doctor
{
public string name;
public string specialty;
private List&lt;Patient&gt; patients;
// constructor
public Doctor(string name, string specialty)

{
this.name = name;
this.specialty = specialty;
this.patients = new List&lt;Patient&gt;();
}
// method to add Patient
public void AddPatient(Patient patient)
{
patients.Add(patient);
}
public void Consult(Patient patient)
{
Console.WriteLine(&quot;Doctor {0} ({1}) is consulting with Patient {2}&quot;,
name, specialty, patient.name);
}
// Display Doctor Details
public void DisplayDoctor()
{
Console.WriteLine(&quot;Doctor: {0}, specialty: {1}&quot;, name, specialty);
Console.WriteLine(&quot;Patients:&quot;);
foreach (var patient in patients)
{
patient.DisplayPatient();
}
}
}
// Hospital class
class Hospital
{
public string name;
private List&lt;Doctor&gt; doctors;
private List&lt;Patient&gt; patients;
// constructor
public Hospital(string name)
{
this.name = name;
this.doctors = new List&lt;Doctor&gt;();
this.patients = new List&lt;Patient&gt;();
}
// method to add Doctor
public void AddDoctor(Doctor doctor)
{

doctors.Add(doctor);
}
// method to add Patient
public void AddPatient(Patient patient)
{
patients.Add(patient);
}
// Display Hospital Details
public void DisplayHospital()
{
Console.WriteLine(&quot;Hospital: {0}&quot;, name);
Console.WriteLine(&quot;Doctors:&quot;);
foreach (var doctor in doctors)
{
doctor.DisplayDoctor();
}
Console.WriteLine(&quot;Patients:&quot;);
foreach (var patient in patients)
{
patient.DisplayPatient();
}
}
}
// Main Class
class Program
{
public static void Main()
{
Hospital hospital = new Hospital(&quot;Maxx Hospital&quot;);
Doctor doctor1 = new Doctor(&quot;Dr. Abhay&quot;, &quot;Radiologist&quot;);
Doctor doctor2 = new Doctor(&quot;Dr. Shiv kumar&quot;, &quot;Dentist&quot;);
Patient patient = new Patient(&quot;Vansh&quot;, 25);
hospital.AddDoctor(doctor1);
hospital.AddDoctor(doctor2);
hospital.AddPatient(patient);
doctor1.AddPatient(patient);
doctor1.Consult(patient);
hospital.DisplayHospital();
}

}

//4
using System;
using System.Collections.Generic;
// Product class
class Product
{
public string productName;
public decimal price;
// constructor
public Product(string productName, decimal price)
{
this.productName = productName;
this.price = price;
}
// method to display product
public void DisplayProduct()
{
Console.WriteLine(&quot;Product: {0}, price: {1:C}&quot;, productName, price);
}
}
// Order class
class Order
{
public int orderId;
private List&lt;Product&gt; products;
// constructor
public Order(int orderId)
{
this.orderId = orderId;
this.products = new List&lt;Product&gt;();

}
// method to Add Product
public void AddProduct(Product product)
{
products.Add(product);
}
// method to Display Orders
public void DisplayOrder()
{
Console.WriteLine(&quot;Order ID: {0}&quot;, orderId);
foreach (var product in products)
{
product.DisplayProduct();
}
}
}
// Customer class placing orders
class Customer
{
public string customerName;
private List&lt;Order&gt; orders;
// customer
public Customer(string customerName)
{
this.customerName = customerName;
this. orders = new List&lt;Order&gt;();
}
// method to Place Order
public void PlaceOrder(Order order)
{
orders.Add(order);
}
// method to display All Customers Orders
public void DisplayCustomerOrders()
{
Console.WriteLine(&quot;Customer: {0}&quot;, this.customerName);
foreach (var order in orders)
{
order.DisplayOrder();
}
}
}

// Main class
class Program
{
static void Main()
{
// Creating products
Product product1 = new Product(&quot;Shoes&quot;, 800);
Product product2 = new Product(&quot;Smart and Handsome Cream&quot;, 50);
// Creating an order object
Order order = new Order(101);
order.AddProduct(product1);
order.AddProduct(product2);
// Creating a customer objectu
Customer customer = new Customer(&quot;Vansh Saxena&quot;);
customer.PlaceOrder(order);
// Displaying customer orders
customer.DisplayCustomerOrders();
}
}


//5
using System;
using System.Collections.Generic;
// Student class
class Student
{
public string name;
private List&lt;Course&gt; enrolledCourses;
// Constructor
public Student(string name)
{

this. name = name;
this.enrolledCourses = new List&lt;Course&gt;();
}
// Method to enroll a student
public void EnrollCourse(Course course)
{
enrolledCourses.Add(course);
course.AddStudent(this);
}
// Method to display all courses
public void DisplayCourses()
{
Console.WriteLine(&quot;Student: {0} is enrolled in:&quot;, name);
foreach (var course in enrolledCourses)
{
Console.WriteLine(&quot;- {0}&quot;, course.courseName);
}
}
}
// Professor class
class Professor
{
public string name;
// Constructor
public Professor(string name)
{
this.name = name;
}
}
// Course class
class Course
{
public string courseName;
private List&lt;Student&gt; students;
public Professor assignedProfessor;
// Constructor
public Course(string courseName)
{
this.courseName = courseName;
this.students = new List&lt;Student&gt;();
}

// Method to assign a professor
public void AssignProfessor(Professor professor)
{
assignedProfessor = professor;
}
// Method to add a student
public void AddStudent(Student student)
{
students.Add(student);
}
// Method to display course details
public void DisplayCourseInfo()
{
Console.WriteLine(&quot;Course: {0}&quot;, this.courseName);
Console.WriteLine(&quot;Professor: {0}&quot;, assignedProfessor.name);
Console.WriteLine(&quot;Enrolled Students:&quot;);
foreach (var student in students)
{
Console.WriteLine(&quot;{0}&quot;, student.name);
}
}
}
// Main Class
class Program
{
static void Main()
{
// Creating student object
Student student1 = new Student(&quot;Rohit&quot;);
Student student2 = new Student(&quot;Mohit&quot;);
// Creating professor object
Professor professor = new Professor(&quot;Dr. KashiNath&quot;);
// Creating course object
Course course = new Course(&quot;Data Structure&quot;);
course.AssignProfessor(professor);
// Enrolling students
student1.EnrollCourse(course);
student2.EnrollCourse(course);
// Displaying course information
course.DisplayCourseInfo();
}

}