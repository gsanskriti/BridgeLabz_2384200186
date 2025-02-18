//1
using System;
class GuessingGame
{
static void Main(string[] args)
{
// taking input from the user
Console.WriteLine(&quot;Enter the number between 1 and

100&quot;);

int number = Convert.ToInt32(Console.ReadLine());
// generating random number for the first time
Random random = new Random();

int high = 101;// to keep finding the highest closest
to that number
int low = 0;// to keep finding the lowest closest to
that number

int guessed = random.Next(low, high);
//Console.WriteLine(guess);
bool flag = true;//to check if correct and close the

game

// while loop to keep the game continuing while the

gussed is correct
while(flag)
{
Console.Write(&quot;Guessed number is :&quot; + guessed);
Console.WriteLine(&quot;Enter the feedback (High or

Low) : &quot;);

string feedback = Console.ReadLine();
//checks if the feedback is high and also changes

the closest high to the number

if(feedback == &quot;high&quot;)
{
int temp = guessed;
high = guessed;
guessed = rand.Next(low, temp);
}
//checks if the feedback is low and also changes

the closest low to the number

else if (feedback == &quot;low&quot;)
{
int temp = guessed;//11
low = guessed;//11
guessed = rand.Next(temp, high);
}
// end the game if the guess was correct
else if(feedback == &quot;correct&quot;)
{
Console.WriteLine(&quot;Guessed correctly ending

the game xoxo&quot;);

flag = false;
}
}
}
}


//2
using System;
class MaxOfThree
{

//declarimg properties of class
int numOne;
int numTwo;
int numThree;
//method to take input
public void input()
{
Console.WriteLine(&quot;Enter first number: &quot;);
numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(&quot;Enter second number: &quot;);
numTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(&quot;Enter third number: &quot;);
numThree = Convert.ToInt32(Console.ReadLine());
}
// method to find the maximum among 3 called by which
instance or object matters
public void CheckMaximum()
{
if(numOne &gt; numTwo &amp;&amp; numOne &gt; numThree)
{
Console.WriteLine(&quot;Maximum of {0} , {1} and {2}

is: {0}&quot;, numOne, numTwo, numThree);

}
else if(numTwo &gt; numOne &amp;&amp; numTwo &gt; numThree)
{
Console.WriteLine(&quot;Maximum of {0} , {1} and {2}

is: {1}&quot;, numOne, numTwo, numThree);

}
else
{
Console.WriteLine(&quot;Maximum of {0} , {1} and {2}

is: {2}&quot;, numOne, numTwo, numThree);

}
}
static void Main(string[] args)
{
MaxOfThree run = new MaxOfThree();

run.input();//calling method
run.CheckMaximum();// calling method
}
}


//3
using System;
class Prime
{
//method to check if the number is prime
public static string CheckPrime(int number)
{
// checks for zero and one and returning result

accordingly

if(number &lt; 2){
string result = number &lt; 2 &amp;&amp; number != 0 ?
(&quot;Number &quot; + number +&quot; is prime&quot;) : (&quot;Number &quot; + number +&quot; is not
prime&quot;);

return result;
}
// checks if the number is divisible by any upto that

number

for(int i = 2; i &lt; number; i++)
{
if(number % i == 0)
{
return &quot;Number &quot; + number +&quot; is not prime&quot;;
}
}
return &quot;Number &quot; + number +&quot; is prime&quot;;// returns

number is prime after completing for loop
}

static void Main(string[] args)
{
//taking input from the user
Console.WriteLine(&quot;Enter the number: &quot;);
int number = Convert.ToInt32(Console.ReadLine());
string result = CheckPrime(number);//method calling
Console.WriteLine(result);
}
}

//4
using System;
class Fibonacci
{
// method to print the fibonacci series taking the series
number input
public static void PrintFibonacciSeries(int number)
{
int numOne = 0;//checks the first number to sum the

third

int numTwo = 1;//checks the second number to sum the

third

if(num == 1)//handles if the input is 1
{
Console.Write(numOne + &quot; &quot;);
}
else if(num == 2)//handles if the input is 2
{

Console.Write(numOne + &quot; &quot; + numTwo);
}
else// if the series is more than basic to print
{
Console.Write(numOne + &quot; &quot; + numTwo + &quot; &quot;);
for(int i = 3; i &lt;= number; i++)
{
Console.Write((numOne + numTwo) + &quot; &quot;);
int temp = numOne;
numOne = numTwo;
numTwo = temp + numTwo;
}
}
}
static void Main(string[] args)
{
//taking input from the user
Console.WriteLine(&quot;Enter the number: &quot;);
int number = Convert.ToInt32(Console.ReadLine());
PrintFibonacciSeries(number);
}
}

//5
using System;
class Palindrome
{
// method to check if a string is palindrome
public static void CheckPalindrome(string str)
{
char[] charArray = str.ToCharArray();//converting to

char array to reverse

Array.Reverse(charArray);
bool flag = true;
for(int i = 0; i &lt; str.Length; i++)
{
if(charArray[i] != str[i])
{
Console.WriteLine(&quot;String {0} is not

palindrome&quot;, str);

flag = false;
break;
}
}
if(flag)
{
Console.WriteLine(&quot;String {0} is palindrome&quot;,

str);
}
}
static void Main(string[] args)
{
Console.WriteLine(&quot;Enter the string&quot;);
string str = Console.ReadLine();
CheckPalindrome(str);
}
}

//6
using System;
class FactorialProgram
{
// Calculating factorial using recursion
static int Factorial(int number)
{

if (number == 0) // Base case: factorial of 0 is 1
{
return 1;
}
return n * Factorial(number - 1); // Recursive call
}
// method to take user input and return the input
static int GetNumberFromUser()
{
//taking input from user

Console.Write(&quot;Enter a number: &quot;);

int number = Convert.ToInt32(Console.ReadLine());
return number;
}
// Function to display the resu;t
static void DisplayResult(int number, int fact)
{
Console.WriteLine(&quot;Factorial of &quot; + number + &quot; is: &quot; +
fact);
}
static void Main()
{
int num = GetNumberFromUser(); // Get number from user
int result = Factorial(num); // Call factorial function
DisplayResult(num, result); // Show result
}
}


//7
using System;
class GCD_LCM_Calculator
{
//method to calculate gcd it also be done using recursion
static int GCD(int a, int b)
{
while (b != 0)
{
int temp = b;
b = a % b;
a = temp;
}
return a;
}
// function to calculate lcm using the formula
static int LCM(int a, int b)
{
return (a * b) / GCD(a, b);// formula to calculate lcm
using gcd
}
//function to display result
static void DisplayResult(int gcd, int lcm)
{
Console.WriteLine(&quot;GCD: &quot; + gcd);
Console.WriteLine(&quot;LCM: &quot; + lcm);
}
static void Main()
{
Console.Write(&quot;Enter first number: &quot;);
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write(&quot;Enter second number: &quot;);
int numTwo = Convert.ToInt32(Console.ReadLine());
numOne = Math.Abs(numOne);//using absolute method to make
sure value is +ve
numTwo = Math.Abs(numTwo);

int gcd = GCD(numOne, numTwo);
int lcm = LCM(numOne, numTwo);
DisplayResult(gcd, lcm);
}
}


//8
using System;
class TemperatureConverter
{
// This function to convert Fahrenheit to Celsius
static double FahrenheitToCelsius(double fahrenheit)
{
return (fahrenheit - 32) * 5 / 9; // Formula: (F - 32) *
5/9
}
//This function to convert Celsius to Fahrenheit
static double CelsiusToFahrenheit(double celsius)
{
return (celsius * 9 / 5) + 32; // Formula: (C * 9/5) + 32
}
static void Main(string[] args)
{
Console.Write(&quot;Enter temperature in Fahrenheit: &quot;);

double fahrenheit =
Convert.ToDouble(Console.ReadLine());

double celsiusResult = FahrenheitToCelsius(fahrenheit);

// celsius to fahrenheit

Console.WriteLine(&quot;Temperature in Celsius: &quot; +

celsiusResult);
Console.Write(&quot;Enter temperature in Celsius: &quot;);

double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheitResult = CelsiusToFahrenheit(celsius); //
fahrenheit to celsius
Console.WriteLine(&quot;Temperature in Fahrenheit: &quot; +
fahrenheitResult);
}
}


//9
using System;
class BasicCalculator
{
// Function for addition
static double Add(double numOne, double numTwo)
{
return numOne + numTwo; // Return sum
}
// Function for subtraction
static double Subtract(double numOne, double numTwo)
{
return numOne - numTwo; // Return difference
}
// Function for multiplication
static double Multiply(double numOne, double numTwo)
{

return numOne * numTwo; // Return product
}
// This function for division
static double Divide(double numOne, double numTwo)
{
//Handeling zero division
if (numTwo == 0)

{
Console.WriteLine(&quot;Error: Division by zero is not
allowed!&quot;);
return 0;
}
return numOne / numTwo; // Return quotient
}
static void Main()
{
Console.WriteLine(&quot;Basic Calculator&quot;);
Console.WriteLine(&quot;1. Addition (+)&quot;);
Console.WriteLine(&quot;2. Subtraction (-)&quot;);
Console.WriteLine(&quot;3. Multiplication (*)&quot;);
Console.WriteLine(&quot;4. Division (/)&quot;);
Console.Write(&quot;Choose an operation (1-4): &quot;);
//Takinf user input and choice
int choice = Convert.ToInt32(Console.ReadLine());
Console.Write(&quot;Enter first number: &quot;);
double numOne = Convert.ToDouble(Console.ReadLine());
Console.Write(&quot;Enter second number: &quot;);
double numTwo = Convert.ToDouble(Console.ReadLine());
double result = 0; // variable yo store the result
// To check the choice and preform based on choice
if (choice == 1)
{
result = Add(numOne, numTwo);
Console.WriteLine(&quot;Result: &quot; + result);
}

else if (choice == 2)
{
result = Subtract(numOne, numTwo);
Console.WriteLine(&quot;Result: &quot; + result);
}
else if (choice == 3)
{
result = Multiply(numOne, numTwo);
Console.WriteLine(&quot;Result: &quot; + result);
}
else if (choice == 4)
{
result = Divide(numOne, numTwo);
Console.WriteLine(&quot;Result: &quot; + result);
}
else
{
Console.WriteLine(&quot;Invalid choice! Please select a
number between 1 and 4.&quot;);
}
}
}