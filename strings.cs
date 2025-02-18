//1
using System;
public class VowelConsonantCounter
{
public static void Main(string[] args)
{
// Input string
string input = &quot;Hello World!&quot;;
// Convert input string to lowercase
string lowerCaseInput = ConvertToLower(input);
// Initialize counters for vowels and consonants
int vowelCount = 0;
int consonantCount = 0;
// Iterate through each character in the input string
for (int i = 0; i &lt; lowerCaseInput.Length; i++)
{
// Check if the character is a letter
if (IsLetter(lowerCaseInput[i]))
{
// Check if the character is a vowel
if (IsVowel(lowerCaseInput[i]))
{
vowelCount++;
}
else
{
consonantCount++;
}

}
}
// Output the results
Console.WriteLine(&quot;Number of vowels: &quot; + vowelCount);
Console.WriteLine(&quot;Number of consonants: &quot; + consonantCount);
}
// Function to convert a string to lowercase
public static string ConvertToLower(string input)
{
char[] result = new char[input.Length];
for (int i = 0; i &lt; input.Length; i++)
{
if (input[i] &gt;= &#39;A&#39; &amp;&amp; input[i] &lt;= &#39;Z&#39;)
{
// Convert uppercase letter to lowercase by adding 32
result[i] = (char)(input[i] + 32);
}
else
{
result[i] = input[i];
}
}
return new string(result);
}
// Function to check if a character is a letter
public static bool IsLetter(char c)
{
return (c &gt;= &#39;a&#39; &amp;&amp; c &lt;= &#39;z&#39;) || (c &gt;= &#39;A&#39; &amp;&amp; c &lt;= &#39;Z&#39;);
}
// Function to check if a character is a vowel
public static bool IsVowel(char c)
{
// List of vowels
char[] vowels = {&#39;a&#39;, &#39;e&#39;, &#39;i&#39;, &#39;o&#39;, &#39;u&#39;};

for (int i = 0; i &lt; vowels.Length; i++)
{
if (c == vowels[i])
{
return true;
}
}
return false;
}
}

//2
using System;
public class StringReverser
{
public static void Main(string[] args)
{
// Input string
string input = &quot;Hello World!&quot;;
// Initialize an array to hold the reversed characters
char[] reversed = new char[input.Length];
// Iterate through the input string in reverse order and copy
characters
for (int i = 0; i &lt; input.Length; i++)
{
reversed[i] = input[input.Length - 1 - i];
}
// Convert the character array back to a string
string reversedString = new string(reversed);

// Output the reversed string
Console.WriteLine(&quot;Reversed string: &quot; + reversedString);
}
}


//3
using System;
public class PalindromeChecker
{
public static void Main(string[] args)
{
// Input string
string input = &quot;madam&quot;;
// Convert input string to lowercase
string lowerCaseInput = ConvertToLower(input);
// Initialize a boolean to keep track of whether the string is a
palindrome
bool isPalindrome = true;
// Iterate through half of the string
for (int i = 0; i &lt; lowerCaseInput.Length / 2; i++)
{
// Compare characters from the start and end
if (lowerCaseInput[i] != lowerCaseInput[lowerCaseInput.Length -
1 - i])
{
isPalindrome = false;
break;
}

}
// Output the result
if (isPalindrome)
{
Console.WriteLine(&quot;The string is a palindrome.&quot;);
}
else
{
Console.WriteLine(&quot;The string is not a palindrome.&quot;);
}
}
// Function to convert a string to lowercase
public static string ConvertToLower(string input)
{
char[] result = new char[input.Length];
for (int i = 0; i &lt; input.Length; i++)
{
if (input[i] &gt;= &#39;A&#39; &amp;&amp; input[i] &lt;= &#39;Z&#39;)
{
// Convert uppercase letter to lowercase by adding 32
result[i] = (char)(input[i] + 32);
}
else
{
result[i] = input[i];
}
}
return new string(result);
}
}


//4
using System;
public class DuplicateRemover
{
public static void Main(string[] args)
{
// Input string
string input = &quot;Hello World!&quot;;
// Initialize a boolean array
bool[] seen = new bool[256]; // ASCII has 256 characters
// Initialize an array to hold the result characters
char[] result = new char[input.Length];
int resultIndex = 0;
// Iterate through each character in the input string
for (int i = 0; i &lt; input.Length; i++)
{
// Check if the character has been seen before
if (!seen[input[i]])
{
// If not, add it to the result and mark it as seen
result[resultIndex++] = input[i];
seen[input[i]] = true;
}
}
// Convert the result character array to a string
string resultString = new string(result, 0, resultIndex);
// Output the result
Console.WriteLine(&quot;String after removing duplicates: &quot; +
resultString);
}
}

//5
using System;
public class LongestWordFinder
{
public static void Main(string[] args)
{
// enter the sentence
Console.WriteLine(&quot;Enter a sentence:&quot;);
string sentence = Console.ReadLine();
// Split the sentence into words
string[] words = SplitSentence(sentence);
// Initialize variables
string longestWord = &quot;&quot;;
int maxLength = 0;
// Iterate through each word in the sentence
for (int i = 0; i &lt; words.Length; i++)
{
// Check if the current word is longer than the longest word
found so far
if (words[i].Length &gt; maxLength)
{
longestWord = words[i];
maxLength = words[i].Length;
}
}
// Output the longest word
Console.WriteLine(&quot;The longest word is: &quot; + longestWord);
}
// Function to split a sentence into words without using built-in

functions
public static string[] SplitSentence(string sentence)
{
// Count the number of words
int wordCount = 1;
for (int i = 0; i &lt; sentence.Length; i++)
{
if (sentence[i] == &#39; &#39;)
{
wordCount++;
}
}
// Initialize an array to hold the words
string[] words = new string[wordCount];
int wordIndex = 0;
string currentWord = &quot;&quot;;
// Iterate through the sentence and split it into words
for (int i = 0; i &lt; sentence.Length; i++)
{
if (sentence[i] == &#39; &#39;)
{
words[wordIndex++] = currentWord;
currentWord = &quot;&quot;;
}
else
{
currentWord += sentence[i];
}
}
// Add the last word to the array
words[wordIndex] = currentWord;
return words;
}
}


//6
using System;
public class SubstringCounter
{
public static void Main(string[] args)
{
// Prompt the user for input string
Console.WriteLine(&quot;Enter the main string:&quot;);
string input = Console.ReadLine();
// Prompt the user for substring
Console.WriteLine(&quot;Enter the substring to search for:&quot;);
string substring = Console.ReadLine();
// Initialize the count of occurrences
int count = 0;
// Iterate through the input string to find occurrences of the
substring
for (int i = 0; i &lt;= input.Length - substring.Length; i++)
{
// Check if the substring matches at the current position
bool match = true;
for (int j = 0; j &lt; substring.Length; j++)
{
if (input[i + j] != substring[j])
{
match = false;
break;
}
}
// If a match is found, increment the count
if (match)
{

count++;
}
}
// Output the result
Console.WriteLine(&quot;The substring &#39;&quot; + substring + &quot;&#39; occurs &quot; +
count + &quot; times in the string.&quot;);
}
}

//7
using System;
public class CaseToggler
{
public static void Main(string[] args)
{
// input string
Console.WriteLine(&quot;Enter a string:&quot;);
string input = Console.ReadLine();
// Initialize an array to hold the toggled characters
char[] toggled = new char[input.Length];
// Iterate through each character in the input string
for (int i = 0; i &lt; input.Length; i++)
{
// Check if the character is uppercase
if (input[i] &gt;= &#39;A&#39; &amp;&amp; input[i] &lt;= &#39;Z&#39;)
{
// Convert to lowercase by adding 32
toggled[i] = (char)(input[i] + 32);
}
// Check if the character is lowercase
else if (input[i] &gt;= &#39;a&#39; &amp;&amp; input[i] &lt;= &#39;z&#39;)

{
// Convert to uppercase by subtracting 32
toggled[i] = (char)(input[i] - 32);
}
else
{
// Keep the character as is (non-alphabetic characters)
toggled[i] = input[i];
}
}
// Convert the toggled character array back to a string
string toggledString = new string(toggled);
// Output the result
Console.WriteLine(&quot;Toggled case string: &quot; + toggledString);
}
}


//8
using System;
public class StringComparer
{
public static void Main(string[] args)

{
// Prompt the user for the first string
Console.WriteLine(&quot;Enter the first string:&quot;);
string string1 = Console.ReadLine();
// Prompt the user for the second string
Console.WriteLine(&quot;Enter the second string:&quot;);
string string2 = Console.ReadLine();
// Compare the two strings lexicographically
int comparisonResult = CompareStringsLexicographically(string1,
string2);
// Output the result
if (comparisonResult &lt; 0)
{
Console.WriteLine($&quot;\&quot;{string1}\&quot; comes before \&quot;{string2}\&quot; in
lexicographical order&quot;);
}
else if (comparisonResult &gt; 0)
{
Console.WriteLine($&quot;\&quot;{string1}\&quot; comes after \&quot;{string2}\&quot; in
lexicographical order&quot;);
}
else
{
Console.WriteLine($&quot;\&quot;{string1}\&quot; is equal to \&quot;{string2}\&quot; in
lexicographical order&quot;);
}
}
// Function to compare two strings lexicographically without using
built-in functions
public static int CompareStringsLexicographically(string str1, string
str2)
{
// Determine the length of the shorter string
int minLength = str1.Length &lt; str2.Length ? str1.Length :
str2.Length;

// Iterate through each character in both strings
for (int i = 0; i &lt; minLength; i++)
{
if (str1[i] &lt; str2[i])
{
return -1; // str1 comes before str2
}
else if (str1[i] &gt; str2[i])
{
return 1; // str1 comes after str2
}
}
// If all characters are the same up to the length of the shorter
string,
// compare the lengths of the strings
if (str1.Length &lt; str2.Length)
{
return -1; // str1 comes before str2
}
else if (str1.Length &gt; str2.Length)
{
return 1; // str1 comes after str2
}
else
{
return 0; // str1 is equal to str2
}
}
}


//9
using System;
Class FrequentCharacter
{
static void Main()
{
string input = &quot;success&quot;; // Input string
var mostFrequentChar = FindMostFrequentChar(input); // Find the most
frequent character
Console.WriteLine($&quot;Most Frequent Character: &#39;{mostFrequentChar}&#39;&quot;);
// Output the result
}
static char FindMostFrequentChar(string input)
{
int[] charCount = new int[256]; // Array to store the count of each
character (assuming ASCII)
int maxCount = 0; // Variable to keep track of the maximum count of
a character
char mostFrequent = &#39;\0&#39;; // Variable to store the most frequent
character
// Loop through each character in the input string
for (int i = 0; i &lt; input.Length; i++)
{
charCount[input[i]]++; // Increment the count of the character
// If the current character&#39;s count is greater than maxCount,
update maxCount and mostFrequent
if (charCount[input[i]] &gt; maxCount)
{
maxCount = charCount[input[i]];
mostFrequent = input[i];
}

}
return mostFrequent; // Return the most frequent character
}
}

//10
using System;
class SpecificCharacter
{
static void Main()
{
string input = &quot;Hello World&quot;; // Input string
char charToRemove = &#39;l&#39;; // Character to remove
string result = RemoveCharacter(input, charToRemove); // Call the
function to remove the character
Console.WriteLine($&quot;Modified String: \&quot;{result}\&quot;&quot;); // Output the
modified string
}
static string RemoveCharacter(string input, char charToRemove)
{
char[] resultArray = new char[input.Length]; // Array to store the
result
int index = 0; // Index to track the position in the result array

// Loop through each character in the input string
for (int i = 0; i &lt; input.Length; i++)
{
// If the current character is not the character to remove, add
it to the result array
if (input[i] != charToRemove)
{
resultArray[index] = input[i];
index++;
}
}
// Create a new string from the result array, excluding the extra
characters at the end
string result = new string(resultArray, 0, index);
return result; // Return the modified string
}
}


//11
using System;
class Anagram
{
static void Main()
{
Console.WriteLine(&quot;Enter the first string:&quot;);
string firstString = Console.ReadLine(); // Accept the first string
from the user
Console.WriteLine(&quot;Enter the second string:&quot;);
string secondString = Console.ReadLine(); // Accept the second
string from the user
bool areAnagrams = AreAnagrams(firstString, secondString); // Check
if the strings are anagrams

if (areAnagrams)
{
Console.WriteLine(&quot;The strings are anagrams of each other.&quot;);
}
else
{
Console.WriteLine(&quot;The strings are not anagrams of each
other.&quot;);
}
}
static bool AreAnagrams(string str1, string str2)
{
if (str1.Length != str2.Length) // If the lengths of the strings are
not equal, they cannot be anagrams
{
return false;
}
int[] charCount = new int[256]; // Array to store the count of each
character (assuming ASCII)
// Loop through the first string and increment the count of each
character
for (int i = 0; i &lt; str1.Length; i++)
{
charCount[str1[i]]++;
}
// Loop through the second string and decrement the count of each
character
for (int i = 0; i &lt; str2.Length; i++)
{
charCount[str2[i]]--;
}
// If any count is not zero, the strings are not anagrams
for (int i = 0; i &lt; charCount.Length; i++)
{
if (charCount[i] != 0)

{
return false;
}
}
return true; // If all counts are zero, the strings are anagrams
}
}


//12
using System;
class ReplaceMethod
{
static void Main()
{
Console.WriteLine(&quot;Enter the sentence:&quot;);
string sentence = Console.ReadLine(); // Accept the sentence from
the user
Console.WriteLine(&quot;Enter the word to replace:&quot;);
string wordToReplace = Console.ReadLine(); // Accept the word to
replace from the user
Console.WriteLine(&quot;Enter the replacement word:&quot;);
string replacementWord = Console.ReadLine(); // Accept the
replacement word from the user
string result = ReplaceWord(sentence, wordToReplace,
replacementWord); // Call the function to replace the word
Console.WriteLine($&quot;Modified Sentence: \&quot;{result}\&quot;&quot;); // Output the
modified sentence
}
static string ReplaceWord(string sentence, string wordToReplace, string

replacementWord)
{
// Split the sentence into words
string[] words = SplitSentence(sentence);
string result = &quot;&quot;;
// Iterate through the words and replace the target word
for (int i = 0; i &lt; words.Length; i++)
{
if (words[i] == wordToReplace)
{
words[i] = replacementWord;
}
result += words[i] + &quot; &quot;;
}
// Trim the trailing space and return the modified sentence
return result.TrimEnd();
}
static string[] SplitSentence(string sentence)
{
// Split the sentence into words based on spaces
int wordCount = 0;
for (int i = 0; i &lt; sentence.Length; i++)
{
if (sentence[i] == &#39; &#39;)
{
wordCount++;
}
}
string[] words = new string[wordCount + 1];
int wordIndex = 0;
string currentWord = &quot;&quot;;
for (int i = 0; i &lt; sentence.Length; i++)
{
if (sentence[i] == &#39; &#39;)
{

words[wordIndex] = currentWord;
wordIndex++;
currentWord = &quot;&quot;;
}
else
{
currentWord += sentence[i];
}
}
words[wordIndex] = currentWord;
return words;
}
}