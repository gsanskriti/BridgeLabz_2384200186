//1
using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.MakeSound();  // Output: Dog barks.
    }
}


//2
using System;

class LegacyAPI
{
    [Obsolete("OldFeature() is obsolete. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old feature.");
    }

    public void NewFeature()
    {
        Console.WriteLine("This is the new feature.");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();  // Generates a warning
        api.NewFeature();
    }
}


//3
using System;
using System.Collections;

class Program
{
    #pragma warning disable CS8600, CS8602 // Suppressing specific warnings
    static void Main()
    {
        ArrayList list = new ArrayList(); // No generics used
        list.Add(10);
        list.Add("Hello");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    #pragma warning restore CS8600, CS8602 // Restoring warnings
}


//4
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo(1, "Alice")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

class Program
{
    static void Main()
    {
        MethodInfo methodInfo = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute attr = (TaskInfoAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(TaskInfoAttribute));

        if (attr != null)
        {
            Console.WriteLine($"Task Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
        }
    }
}


//5
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class BugTracker
{
    [BugReport("Null reference issue fixed.")]
    [BugReport("Performance optimization applied.")]
    public void FixBug()
    {
        Console.WriteLine("Bug fixed.");
    }
}

class Program
{
    static void Main()
    {
        MethodInfo methodInfo = typeof(BugTracker).GetMethod("FixBug");
        object[] attributes = methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute attr in attributes)
        {
            Console.WriteLine($"Bug Report: {attr.Description}");
        }
    }
}


//Practice Problems for Custom Attributes in C#
//1
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class TaskHandler
{
    [ImportantMethod("CRITICAL")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }

    [ImportantMethod]
    public void SaveData()
    {
        Console.WriteLine("Saving data...");
    }
}

class Program
{
    static void Main()
    {
        MethodInfo[] methods = typeof(TaskHandler).GetMethods();

        foreach (var method in methods)
        {
            var attr = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));
            if (attr != null)
            {
                Console.WriteLine($"{method.Name} - Importance Level: {attr.Level}");
            }
        }
    }
}


//2
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Implement Login", "Alice", "HIGH")]
    [Todo("Optimize database", "Bob")]
    public void FeatureA() { }

    [Todo("Write unit tests", "Charlie", "LOW")]
    public void FeatureB() { }
}

class Program
{
    static void Main()
    {
        MethodInfo[] methods = typeof(Project).GetMethods();

        foreach (var method in methods)
        {
            var todos = (TodoAttribute[])method.GetCustomAttributes(typeof(TodoAttribute), false);
            foreach (var todo in todos)
            {
                Console.WriteLine($"Task: {todo.Task}, Assigned To: {todo.AssignedTo}, Priority: {todo.Priority}");
            }
        }
    }
}


//3
using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class PerformanceTester
{
    [LogExecutionTime]
    public void HeavyCalculation()
    {
        Stopwatch sw = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++) { } // Simulated work
        sw.Stop();
        Console.WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}

class Program
{
    static void Main()
    {
        var obj = new PerformanceTester();
        MethodInfo method = typeof(PerformanceTester).GetMethod("HeavyCalculation");

        if (Attribute.IsDefined(method, typeof(LogExecutionTimeAttribute)))
        {
            obj.HeavyCalculation();
        }
    }
}


//4
using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }
    public MaxLengthAttribute(int length) => Length = length;
}

class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        if (username.Length > 10)
        {
            throw new ArgumentException("Username exceeds maximum length!");
        }
        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User user = new User("LongUsername123"); // Throws exception
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


//5
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }
    public RoleAllowedAttribute(string role) => Role = role;
}

class SecureActions
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted.");
    }
}

class Program
{
    static void ExecuteMethod(object obj, string methodName, string userRole)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        var attr = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

        if (attr != null && attr.Role == userRole)
        {
            method.Invoke(obj, null);
        }
        else
        {
            Console.WriteLine("Access Denied!");
        }
    }

    static void Main()
    {
        SecureActions actions = new SecureActions();
        ExecuteMethod(actions, "DeleteUser", "USER");  // Access Denied!
        ExecuteMethod(actions, "DeleteUser", "ADMIN"); // User deleted.
    }
}


//6
using System;
using System.Reflection;
using System.Text.Json;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; }
    public JsonFieldAttribute(string name) => Name = name;
}

class User
{
    [JsonField("user_name")]
    public string Username;

    public User(string username) => Username = username;
}

class Program
{
    static string SerializeToJson(object obj)
    {
        var jsonDict = new Dictionary<string, object>();
        foreach (var field in obj.GetType().GetFields())
        {
            var attr = (JsonFieldAttribute)Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));
            string key = attr != null ? attr.Name : field.Name;
            jsonDict[key] = field.GetValue(obj);
        }
        return JsonSerializer.Serialize(jsonDict);
    }

    static void Main()
    {
        User user = new User("Alice");
        Console.WriteLine(SerializeToJson(user)); // {"user_name":"Alice"}
    }
}


//7
using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class ExpensiveOperations
{
    private static Dictionary<int, int> cache = new();

    [CacheResult]
    public int ComputeSquare(int number)
    {
        if (cache.ContainsKey(number))
        {
            Console.WriteLine("Returning cached result...");
            return cache[number];
        }

        int result = number * number;
        cache[number] = result;
        Console.WriteLine("Computing result...");
        return result;
    }
}

class Program
{
    static void Main()
    {
        ExpensiveOperations ops = new ExpensiveOperations();
        Console.WriteLine(ops.ComputeSquare(5)); // Computing result...
        Console.WriteLine(ops.ComputeSquare(5)); // Returning cached result...
    }
}
