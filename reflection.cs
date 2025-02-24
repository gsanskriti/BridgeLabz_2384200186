//1
using System;
using System.Reflection;

class SampleClass
{
    public int number;
    public string text;

    public SampleClass() { }
    public SampleClass(int num) { }

    public void Display() => Console.WriteLine("Display method.");
}

class Program
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);

        if (type != null)
        {
            Console.WriteLine("\nMethods:");
            foreach (var method in type.GetMethods())
                Console.WriteLine(method.Name);

            Console.WriteLine("\nFields:");
            foreach (var field in type.GetFields())
                Console.WriteLine(field.Name);

            Console.WriteLine("\nConstructors:");
            foreach (var constructor in type.GetConstructors())
                Console.WriteLine(constructor.ToString());
        }
        else
        {
            Console.WriteLine("Class not found!");
        }
    }
}


//2
using System;
using System.Reflection;

class Person
{
    private int age = 25;
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        FieldInfo field = typeof(Person).GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(person, 30);
        Console.WriteLine("Modified Age: " + field.GetValue(person));
    }
}


//3
using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        MethodInfo method = typeof(Calculator).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        
        int result = (int)method.Invoke(calc, new object[] { 5, 6 });
        Console.WriteLine("Multiplication Result: " + result);
    }
}


//4
using System;

class Student
{
    public Student() { Console.WriteLine("Student object created!"); }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);
    }
}

//5
using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.Write("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        MathOperations obj = new MathOperations();
        MethodInfo method = typeof(MathOperations).GetMethod(methodName);

        if (method != null)
        {
            object result = method.Invoke(obj, new object[] { 10, 5 });
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found!");
        }
    }
}


//6
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name) => Name = name;
}

[Author("John Doe")]
class SampleClass { }

class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);
        var attr = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        Console.WriteLine("Author: " + attr.Name);
    }
}


//7
using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class Program
{
    static void Main()
    {
        Type type = typeof(Configuration);
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        field.SetValue(null, "NEW_KEY");
        Console.WriteLine("Updated API_KEY: " + field.GetValue(null));
    }
}


//advanced level
//1
using System;
using System.Collections.Generic;
using System.Reflection;

class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var prop in properties)
        {
            FieldInfo field = type.GetField(prop.Key);
            if (field != null) field.SetValue(obj, prop.Value);
        }
        return obj;
    }

    static void Main()
    {
        Dictionary<string, object> data = new() { { "Name", "Alice" }, { "Age", 30 } };
        Person person = ToObject<Person>(data);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}


//2
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

class Person
{
    public string Name = "Alice";
    public int Age = 30;
}

class Program
{
    static string ToJson(object obj)
    {
        var jsonDict = new Dictionary<string, object>();
        foreach (var field in obj.GetType().GetFields())
        {
            jsonDict[field.Name] = field.GetValue(obj);
        }
        return JsonSerializer.Serialize(jsonDict);
    }

    static void Main()
    {
        Person person = new Person();
        Console.WriteLine(ToJson(person));
    }
}


//3
using System;
using System.Reflection;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello() => Console.WriteLine("Hello, World!");
}

class LoggingProxy<T> : DispatchProxy
{
    private T _instance;
    public static T Create(T instance)
    {
        var proxy = Create<T, LoggingProxy<T>>();
        (proxy as LoggingProxy<T>)._instance = instance;
        return proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"Executing {targetMethod.Name}...");
        return targetMethod.Invoke(_instance, args);
    }
}

class Program
{
    static void Main()
    {
        IGreeting proxy = LoggingProxy<IGreeting>.Create(new Greeting());
        proxy.SayHello();
    }
}


//4
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Constructor)]
class InjectAttribute : Attribute { }

class Service { public void Serve() => Console.WriteLine("Service Running"); }

class Client
{
    private readonly Service _service;
    
    [Inject]
    public Client(Service service) => _service = service;

    public void Run() => _service.Serve();
}

class Program
{
    static void Main()
    {
        Type type = typeof(Client);
        ConstructorInfo ctor = type.GetConstructors()[0];
        object instance = ctor.Invoke(new object[] { new Service() });

        ((Client)instance).Run();
    }
}


//5
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

class SampleMethods
{
    public void FastMethod() 
    {
        Thread.Sleep(100);  // Simulate work
        Console.WriteLine("FastMethod executed.");
    }

    public void SlowMethod()
    {
        Thread.Sleep(500);  // Simulate work
        Console.WriteLine("SlowMethod executed.");
    }
}

class Program
{
    static void MeasureExecutionTime(object instance, string methodName)
    {
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine($"Method '{methodName}' not found.");
            return;
        }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start(); // Start time tracking

        method.Invoke(instance, null);  // Call the method dynamically

        stopwatch.Stop(); // Stop time tracking
        Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms\n");
    }

    static void Main()
    {
        SampleMethods obj = new SampleMethods();

        MeasureExecutionTime(obj, "FastMethod");
        MeasureExecutionTime(obj, "SlowMethod");
    }
}
