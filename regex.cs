//1
using System;
using System.Text.RegularExpressions;

public class UsernameValidator
{
    public static bool IsValidUsername(string username)
    {
        // Regular expression pattern to validate the username
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        
        // Match the username against the pattern
        return Regex.IsMatch(username, pattern);
    }

    public static void Main(string[] args)
    {
        // Example inputs
        string[] usernames = { "user_123", "123user", "us", "Valid_User123" };

        // Validate each username and print the result
        foreach (string username in usernames)
        {
            bool isValid = IsValidUsername(username);
            Console.WriteLine($"{username} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}


//2
using System;
using System.Text.RegularExpressions;

public class LicensePlateValidator
{
    public static bool IsValidLicensePlate(string licensePlate)
    {
        // Regular expression pattern to validate the license plate number
        string pattern = @"^[A-Z]{2}\d{4}$";
        
        // Match the license plate number against the pattern
        return Regex.IsMatch(licensePlate, pattern);
    }

    public static void Main(string[] args)
    {
        // Example inputs
        string[] licensePlates = { "AB1234", "A12345", "XY6789", "ZZ1111" };

        // Validate each license plate number and print the result
        foreach (string licensePlate in licensePlates)
        {
            bool isValid = IsValidLicensePlate(licensePlate);
            Console.WriteLine($"{licensePlate} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}


//3
using System;
using System.Text.RegularExpressions;

public class HexColorValidator
{
    public static bool IsValidHexColor(string hexColor)
    {
        // Regular expression pattern to validate the hex color code
        string pattern = @"^#([0-9a-fA-F]{6})$";
        
        // Match the hex color code against the pattern
        return Regex.IsMatch(hexColor, pattern);
    }

    public static void Main(string[] args)
    {
        // Example inputs
        string[] hexColors = { "#FFA500", "#ff4500", "#123", "#abcdef" };

        // Validate each hex color code and print the result
        foreach (string hexColor in hexColors)
        {
            bool isValid = IsValidHexColor(hexColor);
            Console.WriteLine($"{hexColor} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}


//4
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class EmailExtractor
{
    public static List<string> ExtractEmails(string text)
    {
        // Regular expression pattern to match email addresses
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        
        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern);
        
        // Find matches in the text
        MatchCollection matches = regex.Matches(text);
        
        // Create a list to store the extracted email addresses
        List<string> emailAddresses = new List<string>();
        
        // Loop through the matches and add them to the list
        foreach (Match match in matches)
        {
            emailAddresses.Add(match.Value);
        }
        
        return emailAddresses;
    }

    public static void Main(string[] args)
    {
        // Example text
        string text = "Contact us at support@example.com and info@company.org";
        
        // Extract email addresses from the text
        List<string> emails = ExtractEmails(text);
        
        // Print the extracted email addresses
        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }
    }
}


//5
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CapitalizedWordsExtractor
{
    public static List<string> ExtractCapitalizedWords(string text)
    {
        // Regular expression pattern to match capitalized words
        string pattern = @"\b[A-Z][a-z]*\b";
        
        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern);
        
        // Find matches in the text
        MatchCollection matches = regex.Matches(text);
        
        // Create a list to store the extracted capitalized words
        List<string> capitalizedWords = new List<string>();
        
        // Loop through the matches and add them to the list
        foreach (Match match in matches)
        {
            capitalizedWords.Add(match.Value);
        }
        
        return capitalizedWords;
    }

    public static void Main(string[] args)
    {
        // Example text
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        
        // Extract capitalized words from the text
        List<string> capitalizedWords = ExtractCapitalizedWords(text);
        
        // Print the extracted capitalized words
        Console.WriteLine(string.Join(", ", capitalizedWords));
    }
}


//6
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public static List<string> ExtractDates(string text)
    {
        // Regular expression pattern to match dates in dd/mm/yyyy format
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";
        
        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern);
        
        // Find matches in the text
        MatchCollection matches = regex.Matches(text);
        
        // Create a list to store the extracted dates
        List<string> dates = new List<string>();
        
        // Loop through the matches and add them to the list
        foreach (Match match in matches)
        {
            dates.Add(match.Value);
        }
        
        return dates;
    }

    public static void Main(string[] args)
    {
        // Example text
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        
        // Extract dates from the text
        List<string> dates = ExtractDates(text);
        
        // Print the extracted dates
        Console.WriteLine(string.Join(", ", dates));
    }
}


//7
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class LinkExtractor
{
    public static List<string> ExtractLinks(string text)
    {
        // Regular expression pattern to match links
        string pattern = @"(http|https)://[^\s/$.?#].[^\s]*";
        
        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern);
        
        // Find matches in the text
        MatchCollection matches = regex.Matches(text);
        
        // Create a list to store the extracted links
        List<string> links = new List<string>();
        
        // Loop through the matches and add them to the list
        foreach (Match match in matches)
        {
            links.Add(match.Value);
        }
        
        return links;
    }

    public static void Main(string[] args)
    {
        // Example text
        string text = "Visit https://www.google.com and http://example.org for more info.";
        
        // Extract links from the text
        List<string> links = ExtractLinks(text);
        
        // Print the extracted links
        Console.WriteLine(string.Join(", ", links));
    }
}


//8
using System;

public class StringModifier
{
    public static string ReplaceMultipleSpaces(string input)
    {
        // Use the regular expression to replace multiple spaces with a single space
        string result = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ");
        return result;
    }

    public static void Main(string[] args)
    {
        // Example input
        string input = "This    is  an    example   with multiple    spaces.";
        
        // Replace multiple spaces with a single space
        string output = ReplaceMultipleSpaces(input);
        
        // Print the result
        Console.WriteLine(output);
    }
}


//9
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class BadWordCensor
{
    public static string CensorBadWords(string input, List<string> badWords)
    {
        foreach (string badWord in badWords)
        {
            // Use regular expression to find and replace each bad word with ****
            string pattern = $@"\b{Regex.Escape(badWord)}\b";
            input = Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);
        }
        return input;
    }

    public static void Main(string[] args)
    {
        // Example input
        string input = "This is a damn bad example with some stupid words.";
        
        // List of bad words to censor
        List<string> badWords = new List<string> { "damn", "stupid" };
        
        // Censor the bad words in the input
        string output = CensorBadWords(input, badWords);
        
        // Print the result
        Console.WriteLine(output);
    }
}


//10
using System;
using System.Text.RegularExpressions;

public class IPAddressValidator
{
    public static bool IsValidIPAddress(string ipAddress)
    {
        // Regular expression pattern to validate the IPv4 address
        string pattern = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
        
        // Match the IP address against the pattern
        return Regex.IsMatch(ipAddress, pattern);
    }

    public static void Main(string[] args)
    {
        // Example inputs
        string[] ipAddresses = { "192.168.1.1", "256.256.256.256", "172.16.0.1", "10.0.0.1", "123.456.78.90" };

        // Validate each IP address and print the result
        foreach (string ipAddress in ipAddresses)
        {
            bool isValid = IsValidIPAddress(ipAddress);
            Console.WriteLine($"{ipAddress} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}


//11
using System;
using System.Text.RegularExpressions;

public class CreditCardValidator
{
    public static bool IsValidCreditCard(string cardNumber)
    {
        // Regular expression pattern to validate Visa and MasterCard numbers
        string pattern = @"^(4[0-9]{15}|5[1-5][0-9]{14})$";
        
        // Match the card number against the pattern
        return Regex.IsMatch(cardNumber, pattern);
    }

    public static void Main(string[] args)
    {
        // Example inputs
        string[] cardNumbers = { "4123456789012345", "5123456789012345", "6123456789012345", "4111111111111111", "5111111111111111" };

        // Validate each card number and print the result
        foreach (string cardNumber in cardNumbers)
        {
            bool isValid = IsValidCreditCard(cardNumber);
            Console.WriteLine($"{cardNumber} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}


//12
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ProgrammingLanguageExtractor
{
    public static List<string> ExtractProgrammingLanguages(string text, List<string> languages)
    {
        List<string> foundLanguages = new List<string>();
        
        foreach (string language in languages)
        {
            // Create a regex pattern to match the programming language name
            string pattern = $@"\b{Regex.Escape(language)}\b";
            
            // Find matches in the text
            if (Regex.IsMatch(text, pattern))
            {
                foundLanguages.Add(language);
            }
        }

        return foundLanguages;
    }

    public static void Main(string[] args)
    {
        // Example text
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        
        // List of programming languages to extract
        List<string> languages = new List<string> { "Java", "Python", "JavaScript", "Go", "C#", "C++", "Ruby", "Swift" };

        // Extract programming languages from the text
        List<string> foundLanguages = ExtractProgrammingLanguages(text, languages);

        // Print the extracted programming languages
        Console.WriteLine(string.Join(", ", foundLanguages));
    }
}


//13
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CurrencyExtractor
{
    public static List<string> ExtractCurrencyValues(string text)
    {
        // Regular expression pattern to match currency values
        string pattern = @"\$\s?\d+(\.\d{2})?";
        
        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern);
        
        // Find matches in the text
        MatchCollection matches = regex.Matches(text);
        
        // Create a list to store the extracted currency values
        List<string> currencyValues = new List<string>();
        
        // Loop through the matches and add them to the list
        foreach (Match match in matches)
        {
            // Extract the matched value and trim any leading spaces
            currencyValues.Add(match.Value.Trim());
        }
        
        return currencyValues;
    }

    public static void Main(string[] args)
    {
        // Example text
        string text = "The price is $45.99, and the discount is $ 10.50.";
        
        // Extract currency values from the text
        List<string> currencyValues = ExtractCurrencyValues(text);
        
        // Print the extracted currency values
        Console.WriteLine(string.Join(", ", currencyValues));
    }
}


//14
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class RepeatingWordsFinder
{
    public static List<string> FindRepeatingWords(string input)
    {
        // Regular expression pattern to match repeating words
        string pattern = @"\b(\w+)\b(?:\s+\b\1\b)+";
        
        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        
        // Find matches in the input text
        MatchCollection matches = regex.Matches(input);
        
        // Create a list to store the repeating words
        List<string> repeatingWords = new List<string>();
        
        // Loop through the matches and add the repeating words to the list
        foreach (Match match in matches)
        {
            repeatingWords.Add(match.Groups[1].Value);
        }
        
        return repeatingWords;
    }

    public static void Main(string[] args)
    {
        // Example input
        string input = "This is is a repeated repeated word test.";
        
        // Find repeating words in the input text
        List<string> repeatingWords = FindRepeatingWords(input);
        
        // Print the repeating words
        Console.WriteLine(string.Join(", ", repeatingWords));
    }
}


//15
using System;
using System.Text.RegularExpressions;

public class SSNValidator
{
    public static bool IsValidSSN(string ssn)
    {
        // Regular expression pattern to validate the SSN
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        
        // Match the SSN against the pattern
        return Regex.IsMatch(ssn, pattern);
    }

    public static void Main(string[] args)
    {
        // Example inputs
        string[] ssns = { "123-45-6789", "123456789", "987-65-4321", "111-11-1111" };

        // Validate each SSN and print the result
        foreach (string ssn in ssns)
        {
            bool isValid = IsValidSSN(ssn);
            Console.WriteLine($"{ssn} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
