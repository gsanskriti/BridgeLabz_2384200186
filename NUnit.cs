//1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
   public class Calculator
   {
        // Adds two integers
           public int Add(int a, int b)
           {
               return a + b;
           }

           // Subtracts the second integer from the first
           public int Subtract(int a, int b)
           {
               return a - b;
           }

           // Multiplies two integers
           public int Multiply(int a, int b)
           {
               return a * b;
           }

           // Divides the first integer by the second
           public double Divide(int a, int b)
           {
               if (b == 0)
               {
                   throw new DivideByZeroException("Cannot divide by zero.");
               }
               return (double)a / b; // Cast to double for accurate result
           }
     
   }
}

using System;
using NUnit.Framework;
using CalculatorApp;

namespace CalculatorTest
{
   [TestFixture] // Indicates that this class contains NUnit tests
   public class Class1
   {
       private Calculator _calculator;

       [SetUp] // This method runs before each test
       public void Setup()
       {
           _calculator = new Calculator(); // Initialize the Calculator instance
       }

       [Test] // Marks this method as a test
       public void Add_TwoNumbers_ReturnsSum()
       {
           // Test that adding 2 and 3 returns 5
           Assert.That(_calculator.Add(2, 3), Is.EqualTo(5));
       }

       [Test] // Marks this method as a test
       public void Subtract_TwoNumbers_ReturnsDifference()
       {
           // Test that subtracting 3 from 5 returns 2
           Assert.That(_calculator.Subtract(5, 3), Is.EqualTo(2));
       }

       [Test] // Marks this method as a test
       public void Multiply_TwoNumbers_ReturnsProduct()
       {
           // Test that multiplying 5 and 3 returns 15
           Assert.That(_calculator.Multiply(5, 3), Is.EqualTo(15));
       }

       [Test] // Marks this method as a test
       public void Divide_TwoNumbers_ReturnsQuotient()
       {
           // Test that dividing 6 by 3 returns 2
           Assert.That(_calculator.Divide(6, 3), Is.EqualTo(2));
       }

       [Test] // Marks this method as a test
       public void Divide_ByZero_ThrowsException()
       {
           // Test that dividing by zero throws a DivideByZeroException
           Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
       }
   }
}


//2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilsProject
{
   public class StringUtils
   {
       // Reverses the given string.
       public string Reverse(string str)
       {
           char[] charArray = str.ToCharArray();
           Array.Reverse(charArray);
           return new string(charArray);
       }

       // Checks if the given string is a palindrome.
       public bool IsPalindrome(string str)
       {
           string reversed = Reverse(str);
           return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
       }

       // Converts the given string to uppercase.
       public string ToUpperCase(string str) => str.ToUpper();
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringUtilsProject;

namespace StringUtilsTests
{
   [TestFixture]
   public class Class1
   {
       private StringUtils _stringUtils;

       [SetUp]
       public void Setup()
       {
           _stringUtils = new StringUtils();
       }

       [Test]
       public void Reverse_GivenString_ReturnsReversedString()
       {
           Assert.That(_stringUtils.Reverse("hello"), Is.EqualTo("olleh"));
       }

       [Test]
       public void IsPalindrome_GivenPalindrome_ReturnsTrue()
       {
           Assert.That(_stringUtils.IsPalindrome("madam"), Is.True);
       }

       [Test]
       public void IsPalindrome_GivenNonPalindrome_ReturnsFalse()
       {
           Assert.That(_stringUtils.IsPalindrome("hello"), Is.False);
       }

       [Test]
       public void ToUpperCase_GivenString_ReturnsUppercaseString()
       {
           Assert.That(_stringUtils.ToUpperCase("hello"), Is.EqualTo("HELLO"));
       }
   }
}


//3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManagerProject
{
   public class ListManager
   {
       // Adds an element to the list.
       public void AddElement(List<int> list, int element)
       {
           list.Add(element);
       }

       // Removes an element from the list if it exists.
       public void RemoveElement(List<int> list, int element)
       {
           list.Remove(element);
       }

       // Returns the size of the list.
       public int GetSize(List<int> list)
       {
           return list.Count;
       }
   }
}
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListManagerProject;

namespace ListManagerTests
{
   public class Class1
   {
       private ListManager _listManager;
       private List<int> _testList;

       [SetUp]
       public void Setup()
       {
           _listManager = new ListManager();
           _testList = new List<int>();
       }

       [Test]
       public void AddElement_GivenElement_IsAddedToList()
       {
           _listManager.AddElement(_testList, 5);
           Assert.That(_testList.Contains(5), Is.True);
       }

       [Test]
       public void RemoveElement_GivenExistingElement_IsRemovedFromList()
       {
           _testList.Add(10);
           _listManager.RemoveElement(_testList, 10);
           Assert.That(_testList.Contains(10), Is.False);
       }

       [Test]
       public void GetSize_GivenList_ReturnsCorrectSize()
       {
           _listManager.AddElement(_testList, 1);
           _listManager.AddElement(_testList, 2);
           Assert.That(_listManager.GetSize(_testList), Is.EqualTo(2));
       }
   }
}
 


//4
using System;

namespace CalculatorApp
{
   public class Calculator
   {
       // Other methods...

       // Divides the first integer by the second
       public double Divide(int a, int b)
       {
           if (b == 0)
           {
               throw new ArithmeticException("Cannot divide by zero.");
           }
           return (double)a / b; // Cast to double for accurate result
       }
   }
}
using System;
using NUnit.Framework;
using CalculatorApp;

namespace CalculatorTest
{
   [TestFixture]
   public class CalculatorTests
   {
       private Calculator _calculator;

       [SetUp]
       public void Setup()
       {
           _calculator = new Calculator(); // Initialize the Calculator instance
       }

       [Test] // Test for division by zero
       public void Divide_ByZero_ThrowsArithmeticException()
       {
           // Assert that an ArithmeticException is thrown when dividing by zero
           var ex = Assert.Throws<ArithmeticException>(() => _calculator.Divide(6, 0));
           Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero.")); // Verify the exception message
       }
   }
}
 


//5
using System;

namespace DatabaseApp
{
   public class DatabaseConnection
   {
       private bool _isConnected;

       // Connects to the database
       public void Connect()
       {
           // Simulate connecting to a database
           _isConnected = true;
           Console.WriteLine("Database connected.");
       }

       // Disconnects from the database
       public void Disconnect()
       {
           // Simulate disconnecting from a database
           _isConnected = false;
           Console.WriteLine("Database disconnected.");
       }

       // Checks if the connection is established
       public bool IsConnected()
       {
           return _isConnected;
       }
   }
}

using NUnit.Framework;
using DatabaseApp;

namespace DatabaseTest
{
   [TestFixture]
   public class DatabaseConnectionTests
   {
       private DatabaseConnection _dbConnection;

       [SetUp] // This method runs before each test
       public void Setup()
       {
           _dbConnection = new DatabaseConnection(); // Initialize the DatabaseConnection instance
           _dbConnection.Connect(); // Establish the connection before each test
       }

       [TearDown] // This method runs after each test
       public void TearDown()
       {
           _dbConnection.Disconnect(); // Close the connection after each test
       }

       [Test] // Test to verify that the connection is established
       public void Connect_ShouldEstablishConnection()
       {
           Assert.IsTrue(_dbConnection.IsConnected(), "The database connection should be established.");
       }

       [Test] // Test to verify that the connection is closed
       public void Disconnect_ShouldCloseConnection()
       {
           _dbConnection.Disconnect(); // Explicitly disconnect
           Assert.IsFalse(_dbConnection.IsConnected(), "The database connection should be closed.");
       }
   }
}

//6
using System;
namespace NumberApp
{
   public class NumberUtils
   {
       // Returns true if the number is even, false otherwise
       public bool IsEven(int number)
       {
           return number % 2 == 0;
       }
   }
}
using NUnit.Framework;
using NumberApp;

namespace NumberTest
{
   [TestFixture]
   public class NumberUtilsTests
   {
       private NumberUtils _numberUtils;

       [SetUp]
       public void Setup()
       {
           _numberUtils = new NumberUtils(); // Initialize the NumberUtils instance
       }

       // Parameterized test for IsEven method
       [TestCase(2, ExpectedResult = true)] // 2 is even
       [TestCase(4, ExpectedResult = true)] // 4 is even
       [TestCase(6, ExpectedResult = true)] // 6 is even
       [TestCase(7, ExpectedResult = false)] // 7 is odd
       [TestCase(9, ExpectedResult = false)] // 9 is odd
       public bool IsEven_TestCases(int number)
       {
           return _numberUtils.IsEven(number); // Call the IsEven method
       }
   }
}

//7
using System;
using System.Threading;

namespace TaskApp
{
   public class TaskRunner
   {
       // Simulates a long-running task by sleeping for 3 seconds
       public string LongRunningTask()
       {
           Thread.Sleep(3000); // Sleep for 3 seconds
           return "Task Completed";
       }
   }
}
using NUnit.Framework;
using TaskApp;

namespace TaskTest
{
   [TestFixture]
   public class TaskRunnerTests
   {
       private TaskRunner _taskRunner;

       [SetUp]
       public void Setup()
       {
           _taskRunner = new TaskRunner(); // Initialize the TaskRunner instance
       }

       // Test that LongRunningTask fails if it takes longer than 2 seconds
       [Test, Timeout(2000)] // This test should fail if it takes longer than 2 seconds
       public void LongRunningTask_ShouldFail_WhenTakesTooLong()
       {
           _taskRunner.LongRunningTask(); // Call the long-running task
       }
   }
}

//8
using System;
using System.IO;

namespace FileApp
{
   public class FileProcessor
   {
       // Writes content to a file
       public void WriteToFile(string filename, string content)
       {
           File.WriteAllText(filename, content);
       }

       // Reads content from a file
       public string ReadFromFile(string filename)
       {
           if (!File.Exists(filename))
           {
               throw new FileNotFoundException("The specified file does not exist.", filename);
           }
           return File.ReadAllText(filename);
       }
   }
}
using System;
using System.IO;
using NUnit.Framework;
using FileApp;

namespace FileTest
{
   [TestFixture]
   public class FileProcessorTests
   {
       private FileProcessor _fileProcessor;
       private string _testFileName = "testfile.txt";
       private string _testContent = "Hello, World!";

       [SetUp]
       public void Setup()
       {
           _fileProcessor = new FileProcessor(); // Initialize the FileProcessor instance
       }

       [TearDown]
       public void TearDown()
       {
           // Clean up the test file if it exists
           if (File.Exists(_testFileName))
           {
               File.Delete(_testFileName);
           }
       }

       [Test]
       public void WriteToFile_ShouldWriteContentToFile()
       {
           _fileProcessor.WriteToFile(_testFileName, _testContent); // Write content to the file

           // Verify that the file exists and contains the correct content
           Assert.IsTrue(File.Exists(_testFileName), "The file should exist after writing.");
           Assert.AreEqual(_testContent, File.ReadAllText(_testFileName), "The content read from the file should match the written content.");
       }

       [Test]
       public void ReadFromFile_ShouldThrowFileNotFoundException_WhenFileDoesNotExist()
       {
           // Assert that reading from a non-existent file throws a FileNotFoundException
           var ex = Assert.Throws<FileNotFoundException>(() => _fileProcessor.ReadFromFile("nonexistentfile.txt"));
           Assert.That(ex.Message, Is.EqualTo("The specified file does not exist. (nonexistentfile.txt)"));
       }

       [Test]
       public void ReadFromFile_ShouldReturnContent_WhenFileExists()
       {
           _fileProcessor.WriteToFile(_testFileName, _testContent); // Write content to the file

           // Read the content from the file and verify it
           string content = _fileProcessor.ReadFromFile(_testFileName);
           Assert.AreEqual(_testContent, content, "The content read from the file should match the written content.");
       }
   }
}


//Advanced C# Unit Testing Practice Problems

//1
using System;

namespace BankingApp
{
   public class BankAccount
   {
       private double _balance;

       // Constructor to initialize the account with an initial balance
       public BankAccount(double initialBalance = 0)
       {
           _balance = initialBalance;
       }

       // Deposits money into the account
       public void Deposit(double amount)
       {
           if (amount <= 0)
           {
               throw new ArgumentException("Deposit amount must be positive.");
           }
           _balance += amount;
       }

       // Withdraws money from the account
       public void Withdraw(double amount)
       {
           if (amount <= 0)
           {
               throw new ArgumentException("Withdrawal amount must be positive.");
           }
           if (amount > _balance)
           {
               throw new InvalidOperationException("Insufficient funds.");
           }
           _balance -= amount;
       }

       // Returns the current balance
       public double GetBalance()
       {
           return _balance;
       }
   }
}
using NUnit.Framework;
using BankingApp;

namespace BankingTests
{
   [TestFixture]
   public class BankAccountTests
   {
       private BankAccount _bankAccount;

       [SetUp]
       public void Setup()
       {
           _bankAccount = new BankAccount(100); // Initialize the account with a balance of 100
       }

       [Test]
       public void Deposit_ShouldIncreaseBalance_WhenAmountIsPositive()
       {
           _bankAccount.Deposit(50); // Deposit 50
           Assert.AreEqual(150, _bankAccount.GetBalance(), "Balance should be 150 after deposit.");
       }

       [Test]
       public void Deposit_ShouldThrowException_WhenAmountIsNegative()
       {
           var ex = Assert.Throws<ArgumentException>(() => _bankAccount.Deposit(-50));
           Assert.That(ex.Message, Is.EqualTo("Deposit amount must be positive."));
       }

       [Test]
       public void Withdraw_ShouldDecreaseBalance_WhenSufficientFunds()
       {
           _bankAccount.Withdraw(30); // Withdraw 30
           Assert.AreEqual(70, _bankAccount.GetBalance(), "Balance should be 70 after withdrawal.");
       }

       [Test]
       public void Withdraw_ShouldThrowException_WhenInsufficientFunds()
       {
           var ex = Assert.Throws<InvalidOperationException>(() => _bankAccount.Withdraw(150));
           Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
       }

       [Test]
       public void Withdraw_ShouldThrowException_WhenAmountIsNegative()
       {
           var ex = Assert.Throws<ArgumentException>(() => _bankAccount.Withdraw(-20));
           Assert.That(ex.Message, Is.EqualTo("Withdrawal amount must be positive."));
       }

       [Test]
       public void GetBalance_ShouldReturnCurrentBalance()
       {
           Assert.AreEqual(100, _bankAccount.GetBalance(), "Initial balance should be 100.");
       }
   }
}


//2
using System;
using System.Text.RegularExpressions;

namespace SecurityApp
{
   public class PasswordValidator
   {
       // Validates the password based on specified criteria
       public bool IsValid(string password)
       {
           if (string.IsNullOrEmpty(password))
           {
               return false; // Password cannot be null or empty
           }

           // Check for at least 8 characters, one uppercase letter, and one digit
           return password.Length >= 8 &&
                  Regex.IsMatch(password, @"[A-Z]") && // At least one uppercase letter
                  Regex.IsMatch(password, @"\d");      // At least one digit
       }
   }
}
using NUnit.Framework;
using SecurityApp;

namespace SecurityTests
{
   [TestFixture]
   public class PasswordValidatorTests
   {
       private PasswordValidator _passwordValidator;

       [SetUp]
       public void Setup()
       {
           _passwordValidator = new PasswordValidator(); // Initialize the PasswordValidator instance
       }

       [Test]
       [TestCase("Password1", ExpectedResult = true)] // Valid password
       [TestCase("StrongPass2", ExpectedResult = true)] // Valid password
       [TestCase("weakpass", ExpectedResult = false)] // No uppercase and no digit
       [TestCase("WeakPass", ExpectedResult = false)] // No digit
       [TestCase("12345678", ExpectedResult = false)] // No uppercase
       [TestCase("Short1", ExpectedResult = false)] // Less than 8 characters
       [TestCase("", ExpectedResult = false)] // Empty password
       [TestCase(null, ExpectedResult = false)] // Null password
       public bool IsValid_TestCases(string password)
       {
           return _passwordValidator.IsValid(password); // Call the IsValid method
       }
   }
}

//3
using System;
namespace TemperatureApp
{
   public class TemperatureConverter
   {
       // Converts Celsius to Fahrenheit
       public double CelsiusToFahrenheit(double celsius)
       {
           return (celsius * 9 / 5) + 32;
       }

       // Converts Fahrenheit to Celsius
       public double FahrenheitToCelsius(double fahrenheit)
       {
           return (fahrenheit - 32) * 5 / 9;
       }
   }
}
using NUnit.Framework;
using TemperatureApp;

namespace TemperatureTests
{
   [TestFixture]
   public class TemperatureConverterTests
   {
       private TemperatureConverter _temperatureConverter;

       [SetUp]
       public void Setup()
       {
           _temperatureConverter = new TemperatureConverter(); // Initialize the TemperatureConverter instance
       }

       [Test]
       [TestCase(0, ExpectedResult = 32)] // 0°C = 32°F
       [TestCase(100, ExpectedResult = 212)] // 100°C = 212°F
       [TestCase(-40, ExpectedResult = -40)] // -40°C = -40°F
       [TestCase(37, ExpectedResult = 98.6)] // 37°C = 98.6°F (approx)
       public double CelsiusToFahrenheit_TestCases(double celsius)
       {
           return _temperatureConverter.CelsiusToFahrenheit(celsius); // Call the CelsiusToFahrenheit method
       }

       [Test]
       [TestCase(32, ExpectedResult = 0)] // 32°F = 0°C
       [TestCase(212, ExpectedResult = 100)] // 212°F = 100°C
       [TestCase(-40, ExpectedResult = -40)] // -40°F = -40°C
       [TestCase(98.6, ExpectedResult = 37)] // 98.6°F = 37°C (approx)
       public double FahrenheitToCelsius_TestCases(double fahrenheit)
       {
           return _temperatureConverter.FahrenheitToCelsius(fahrenheit); // Call the FahrenheitToCelsius method
       }
   }
}

//4
using System;
using System.Globalization;

namespace DateApp
{
   public class DateFormatter
   {
       // Converts a date from yyyy-MM-dd format to dd-MM-yyyy format
       public string FormatDate(string inputDate)
       {
           if (string.IsNullOrWhiteSpace(inputDate))
           {
               throw new ArgumentException("Input date cannot be null or empty.");
           }

           DateTime parsedDate;
           if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
           {
               throw new FormatException("Input date is not in the correct format (yyyy-MM-dd).");
           }

           return parsedDate.ToString("dd-MM-yyyy");
       }
   }
}
using NUnit.Framework;
using DateApp;

namespace DateTests
{
   [TestFixture]
   public class DateFormatterTests
   {
       private DateFormatter _dateFormatter;

       [SetUp]
       public void Setup()
       {
           _dateFormatter = new DateFormatter(); // Initialize the DateFormatter instance
       }

       [Test]
       [TestCase("2023-01-01", ExpectedResult = "01-01-2023")] // Valid date
       [TestCase("2022-12-31", ExpectedResult = "31-12-2022")] // Valid date
       [TestCase("2000-02-29", ExpectedResult = "29-02-2000")] // Valid leap year date
       public string FormatDate_ValidDates(string inputDate)
       {
           return _dateFormatter.FormatDate(inputDate); // Call the FormatDate method
       }

       [Test]
       public void FormatDate_EmptyString_ThrowsArgumentException()
       {
           var ex = Assert.Throws<ArgumentException>(() => _dateFormatter.FormatDate(""));
           Assert.That(ex.Message, Is.EqualTo("Input date cannot be null or empty."));
       }

       [Test]
       public void FormatDate_NullString_ThrowsArgumentException()
       {
           var ex = Assert.Throws<ArgumentException>(() => _dateFormatter.FormatDate(null));
           Assert.That(ex.Message, Is.EqualTo("Input date cannot be null or empty."));
       }

       [Test]
       [TestCase("01-01-2023")] // Invalid format
       [TestCase("2023/01/01")] // Invalid format
       [TestCase("2023-13-01")] // Invalid month
       [TestCase("2023-01-32")] // Invalid day
       public void FormatDate_InvalidFormat_ThrowsFormatException(string inputDate)
       {
           var ex = Assert.Throws<FormatException>(() => _dateFormatter.FormatDate(inputDate));
           Assert.That(ex.Message, Is.EqualTo("Input date is not in the correct format (yyyy-MM-dd)."));
       }
   }
}

//5
using System;
using System.Text.RegularExpressions;

namespace UserApp
{
   public class UserRegistration
   {
       // Registers a user with the provided username, email, and password
       public void RegisterUser (string username, string email, string password)
       {
           if (string.IsNullOrWhiteSpace(username))
           {
               throw new ArgumentException("Username cannot be null or empty.");
           }

           if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
           {
               throw new ArgumentException("Invalid email address.");
           }

           if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
           {
               throw new ArgumentException("Password must be at least 6 characters long.");
           }

           // Registration logic would go here (e.g., saving to a database)
       }

       // Validates the email format
       private bool IsValidEmail(string email)
       {
           // Simple regex for email validation
           var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
           return Regex.IsMatch(email, emailPattern);
       }
   }
}
using NUnit.Framework;
using UserApp;

namespace UserTests
{
   [TestFixture]
   public class UserRegistrationTests
   {
       private UserRegistration _userRegistration;

       [SetUp]
       public void Setup()
       {
           _userRegistration = new UserRegistration(); // Initialize the UserRegistration instance
       }

       [Test]
       public void RegisterUser _ValidInputs_ShouldNotThrowException()
       {
           // Valid inputs
           Assert.DoesNotThrow(() => _userRegistration.RegisterUser ("validUser ", "user@example.com", "password123"));
       }

       [Test]
       public void RegisterUser _EmptyUsername_ThrowsArgumentException()
       {
           var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser ("", "user@example.com", "password123"));
           Assert.That(ex.Message, Is.EqualTo("Username cannot be null or empty."));
       }

       [Test]
       public void RegisterUser _EmptyEmail_ThrowsArgumentException()
       {
           var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser ("validUser ", "", "password123"));
           Assert.That(ex.Message, Is.EqualTo("Invalid email address."));
       }

       [Test]
       public void RegisterUser _InvalidEmailFormat_ThrowsArgumentException()
       {
           var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser ("validUser ", "invalidEmail", "password123"));
           Assert.That(ex.Message, Is.EqualTo("Invalid email address."));
       }

       [Test]
       public void RegisterUser _EmptyPassword_ThrowsArgumentException()
       {
           var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser ("validUser ", "user@example.com", ""));
           Assert.That(ex.Message, Is.EqualTo("Password must be at least 6 characters long."));
       }

       [Test]
       public void RegisterUser _ShortPassword_ThrowsArgumentException()
       {
           var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser ("validUser ", "user@example.com", "12345"));
           Assert.That(ex.Message, Is.EqualTo("Password must be at least 6 characters long."));
       }
   }
}