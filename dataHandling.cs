//1
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "students.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}


//2
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";
        string[] employees = {
            "ID,Name,Department,Salary",
            "101,John,IT,60000",
            "102,Sara,HR,50000",
            "103,David,Finance,70000",
            "104,Emma,IT,65000",
            "105,Michael,Marketing,55000"
        };

        File.WriteAllLines(filePath, employees);
        Console.WriteLine("CSV file created successfully.");
    }
}


//3
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";
        
        if (File.Exists(filePath))
        {
            int count = File.ReadAllLines(filePath).Length - 1; // Exclude header
            Console.WriteLine($"Total Records: {count}");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}


//4
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "students.csv";

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath).Skip(1);
            
            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (int.Parse(data[3]) > 80)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}



//5
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";
        Console.Write("Enter Employee Name: ");
        string searchName = Console.ReadLine();

        var lines = File.ReadAllLines(filePath).Skip(1);
        foreach (var line in lines)
        {
            var data = line.Split(',');
            if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Department: {data[2]}, Salary: {data[3]}");
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}


//6
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";
        string[] lines = File.ReadAllLines(filePath);
        
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            if (data[2] == "IT")
            {
                data[3] = (int.Parse(data[3]) * 1.1).ToString();
                lines[i] = string.Join(",", data);
            }
        }

        File.WriteAllLines("updated_employees.csv", lines);
        Console.WriteLine("Salaries updated successfully.");
    }
}


//7
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";

        var sortedLines = File.ReadAllLines(filePath).Skip(1)
                             .OrderByDescending(line => int.Parse(line.Split(',')[3]))
                             .Take(5);

        foreach (var line in sortedLines)
        {
            Console.WriteLine(line);
        }
    }
}


//8
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "contacts.csv";
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";

        var lines = File.ReadAllLines(filePath).Skip(1);
        foreach (var line in lines)
        {
            var data = line.Split(',');
            if (!Regex.IsMatch(data[2], emailPattern) || !Regex.IsMatch(data[3], phonePattern))
            {
                Console.WriteLine($"Invalid data: {line}");
            }
        }
    }
}


//9
using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        string filePath = "students.csv";
        List<Student> students = new List<Student>();

        foreach (var line in File.ReadAllLines(filePath).Skip(1))
        {
            var data = line.Split(',');
            students.Add(new Student { ID = data[0], Name = data[1], Age = int.Parse(data[2]), Marks = int.Parse(data[3]) });
        }

        foreach (var student in students)
        {
            Console.WriteLine($"{student.ID} - {student.Name} - {student.Age} - {student.Marks}");
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
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        Dictionary<string, string[]> studentData = new Dictionary<string, string[]>();

        foreach (var line in File.ReadAllLines(file1).Skip(1))
        {
            var data = line.Split(',');
            studentData[data[0]] = new string[] { data[1], data[2] };
        }

        using (StreamWriter writer = new StreamWriter("merged_students.csv"))
        {
            writer.WriteLine("ID,Name,Age,Marks,Grade");
            foreach (var line in File.ReadAllLines(file2).Skip(1))
            {
                var data = line.Split(',');
                if (studentData.ContainsKey(data[0]))
                {
                    writer.WriteLine($"{data[0]},{studentData[data[0]][0]},{studentData[data[0]][1]},{data[1]},{data[2]}");
                }
            }
        }
        Console.WriteLine("Merged CSV file created.");
    }
}


//11
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "large_data.csv";
        int batchSize = 100;
        int count = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            reader.ReadLine(); // Skip header
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                count++;

                if (count % batchSize == 0)
                {
                    Console.WriteLine($"Processed {count} records...");
                    Console.ReadKey(); // Pause for manual processing
                }
            }
        }

        Console.WriteLine($"Total records processed: {count}");
    }
}


//12
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "students.csv";
        HashSet<string> uniqueIds = new HashSet<string>();
        List<string> duplicates = new List<string>();

        foreach (var line in File.ReadAllLines(filePath).Skip(1))
        {
            string id = line.Split(',')[0];
            if (!uniqueIds.Add(id))
                duplicates.Add(line);
        }

        Console.WriteLine("Duplicate Records:");
        duplicates.ForEach(Console.WriteLine);
    }
}


//13
using System;
using System.Data.SqlClient;
using System.IO;

class Program
{
    static void Main()
    {
        string connectionString = "your_connection_string";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (StreamWriter writer = new StreamWriter("employee_report.csv"))
        {
            conn.Open();
            writer.WriteLine("EmployeeID,Name,Department,Salary");

            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    writer.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                }
            }
        }

        Console.WriteLine("CSV report generated.");
    }
}


//14
//JSON to CSV
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("students.json");
        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);

        using (StreamWriter writer = new StreamWriter("students.csv"))
        {
            writer.WriteLine("ID,Name,Age,Marks");
            foreach (var student in students)
            {
                writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
            }
        }

        Console.WriteLine("JSON converted to CSV.");
    }
}

//CSV to JSON
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("students.csv");
        List<Student> students = new List<Student>();

        foreach (var line in lines.Skip(1))
        {
            var data = line.Split(',');
            students.Add(new Student { ID = data[0], Name = data[1], Age = int.Parse(data[2]), Marks = int.Parse(data[3]) });
        }

        File.WriteAllText("students.json", JsonConvert.SerializeObject(students, Formatting.Indented));
        Console.WriteLine("CSV converted to JSON.");
    }
}


//15
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static string Encrypt(string text, string key)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(16).Substring(0, 16));
        using (Aes aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.IV = keyBytes;
            using (ICryptoTransform encryptor = aes.CreateEncryptor())
            {
                byte[] input = Encoding.UTF8.GetBytes(text);
                byte[] encrypted = encryptor.TransformFinalBlock(input, 0, input.Length);
                return Convert.ToBase64String(encrypted);
            }
        }
    }

    static void Main()
    {
        string key = "my_secret_key123";
        string filePath = "employees.csv";
        string outputFile = "encrypted_employees.csv";

        var lines = File.ReadAllLines(filePath);
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            writer.WriteLine(lines[0]); // Write header
            foreach (var line in lines.Skip(1))
            {
                var data = line.Split(',');
                data[3] = Encrypt(data[3], key); // Encrypt salary
                writer.WriteLine(string.Join(",", data));
            }
        }

        Console.WriteLine("Data encrypted successfully.");
    }
}

