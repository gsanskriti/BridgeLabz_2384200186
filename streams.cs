//1
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destinationPath = "destination.txt";

        try
        {
            // Check if the source file exists
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Create the destination file if it does not exist
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                // Read from the source file and write to the destination file
                sourceStream.CopyTo(destinationStream);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred: " + ex.Message);
        }
    }
}


//2
using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = "largefile.txt";
        string destinationPathBuffered = "destination_buffered.txt";
        string destinationPathUnbuffered = "destination_unbuffered.txt";

        const int bufferSize = 4096; // 4 KB

        // Measure time for buffered copy
        Stopwatch stopwatch = Stopwatch.StartNew();
        try
        {
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationPathBuffered, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedStream = new BufferedStream(destinationStream, bufferSize))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedStream.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Buffered copy time: {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred during buffered copy: " + ex.Message);
        }

        // Measure time for unbuffered copy
        stopwatch.Restart();
        try
        {
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationPathUnbuffered, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Unbuffered copy time: {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred during unbuffered copy: " + ex.Message);
        }
    }
}


//3
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = ReadFromConsole();

        Console.WriteLine("Enter your age:");
        string age = ReadFromConsole();

        Console.WriteLine("Enter your favorite programming language:");
        string favoriteLanguage = ReadFromConsole();

        string filePath = "userInfo.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Programming Language: " + favoriteLanguage);
            }

            Console.WriteLine("Information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static string ReadFromConsole()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        {
            return reader.ReadLine();
        }
    }
}


//4
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

[Serializable]
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static string filePath = "employees.json";
    
    static void SerializeEmployees(List<Employee> employees)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Employees saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving employees: {ex.Message}");
        }
    }

    static List<Employee> DeserializeEmployees()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No saved employees found.");
                return new List<Employee>();
            }
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(jsonString) ?? new List<Employee>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading employees: {ex.Message}");
            return new List<Employee>();
        }
    }

    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 60000 },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 55000 }
        };
        
        SerializeEmployees(employees);

        List<Employee> loadedEmployees = DeserializeEmployees();
        
        Console.WriteLine("\nDeserialized Employees:");
        foreach (var emp in loadedEmployees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
    }
}


//5
using System;
using System.IO;
using System.Linq;

class Program
{
    static byte[] ConvertImageToByteArray(string imagePath)
    {
        try
        {
            return File.ReadAllBytes(imagePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return Array.Empty<byte>();
        }
    }

    static void WriteByteArrayToImage(byte[] byteArray, string outputPath)
    {
        try
        {
            File.WriteAllBytes(outputPath, byteArray);
            Console.WriteLine("Image successfully written to file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error writing file: {ex.Message}");
        }
    }

    static bool CompareFiles(string filePath1, string filePath2)
    {
        try
        {
            byte[] file1 = File.ReadAllBytes(filePath1);
            byte[] file2 = File.ReadAllBytes(filePath2);
            return file1.SequenceEqual(file2);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error comparing files: {ex.Message}");
            return false;
        }
    }

    static void Main()
    {
        string inputImagePath = "input.jpg";
        string outputImagePath = "output.jpg";

        byte[] imageBytes = ConvertImageToByteArray(inputImagePath);
        if (imageBytes.Length > 0)
        {
            WriteByteArrayToImage(imageBytes, outputImagePath);
            
            bool isIdentical = CompareFiles(inputImagePath, outputImagePath);
            Console.WriteLine(isIdentical ? "The files are identical." : "The files are not identical.");
        }
    }
}


//6
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        // Specify the encoding to handle character encoding issues
        Encoding encoding = Encoding.UTF8;

        // Open the input and output files using BufferedStream for efficiency
        using (var inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
        using (var bufferedReader = new BufferedStream(inputStream))
        using (var reader = new StreamReader(bufferedReader, encoding))
        using (var outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
        using (var bufferedWriter = new BufferedStream(outputStream))
        using (var writer = new StreamWriter(bufferedWriter, encoding))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Convert the line to lowercase and write to the output file
                writer.WriteLine(line.ToLower());
            }
        }
    }
}


//7
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "students.bin";

        // Store student details
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fileStream))
        {
            // Example student details
            int rollNumber = 101;
            string name = "Alice";
            float gpa = 3.75f;

            // Write data to the binary file
            writer.Write(rollNumber);
            writer.Write(name);
            writer.Write(gpa);
        }

        // Retrieve student details
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fileStream))
        {
            // Read data from the binary file
            int rollNumber = reader.ReadInt32();
            string name = reader.ReadString();
            float gpa = reader.ReadSingle();

            // Display the retrieved details
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("GPA: " + gpa);
        }
    }
}


//8
using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create pipe streams
        using (var pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (var pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
        {
            // Create threads for writing and reading
            var writerThread = new Thread(() => WriteData(pipeServer));
            var readerThread = new Thread(() => ReadData(pipeClient));

            // Start threads
            writerThread.Start();
            readerThread.Start();

            // Wait for threads to complete
            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteData(AnonymousPipeServerStream pipeServer)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipeServer))
            {
                writer.AutoFlush = true;
                for (int i = 0; i < 10; i++)
                {
                    string message = "Message " + i;
                    Console.WriteLine("Writing: " + message);
                    writer.WriteLine(message);
                    Thread.Sleep(500); // Simulate work
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException in WriteData: " + ex.Message);
        }
    }

    static void ReadData(AnonymousPipeClientStream pipeClient)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipeClient))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Reading: " + message);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException in ReadData: " + ex.Message);
        }
    }
}


//9
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "largefile.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Check if the line contains the word "error" (case insensitive)
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
}

//10
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";

        try
        {
            // Dictionary to store word counts
            Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into words
                    string[] words = line.Split(new[] { ' ', '\t', ',', '.', ';', ':', '-', '_', '/', '\\', '!', '?', '(', ')', '[', ']', '{', '}', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        // Update word count in the dictionary
                        if (wordCounts.ContainsKey(word))
                        {
                            wordCounts[word]++;
                        }
                        else
                        {
                            wordCounts[word] = 1;
                        }
                    }
                }
            }

            // Sort the words based on frequency and display the top 5
            var topWords = wordCounts.OrderByDescending(kvp => kvp.Value).Take(5);
            Console.WriteLine("Top 5 most frequently occurring words:");
            foreach (var kvp in topWords)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
}
