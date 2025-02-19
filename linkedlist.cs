//1
using System;

public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public char Grade { get; set; }
    public Student Next { get; set; }
}

public class StudentLinkedList
{
    private Student head;

    // Add a new student record at the beginning
    public void AddAtBeginning(int rollNumber, string name, int age, char grade)
    {
        Student newStudent = new Student
        {
            RollNumber = rollNumber,
            Name = name,
            Age = age,
            Grade = grade,
            Next = head
        };
        head = newStudent;
    }

    // Add a new student record at the end
    public void AddAtEnd(int rollNumber, string name, int age, char grade)
    {
        Student newStudent = new Student
        {
            RollNumber = rollNumber,
            Name = name,
            Age = age,
            Grade = grade
        };

        if (head == null)
        {
            head = newStudent;
            return;
        }

        Student current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newStudent;
    }

    // Add a new student record at a specific position
    public void AddAtPosition(int position, int rollNumber, string name, int age, char grade)
    {
        Student newStudent = new Student
        {
            RollNumber = rollNumber,
            Name = name,
            Age = age,
            Grade = grade
        };

        if (position == 0)
        {
            newStudent.Next = head;
            head = newStudent;
            return;
        }

        Student current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current == null)
                throw new ArgumentOutOfRangeException("Position is out of bounds of the list.");
            current = current.Next;
        }

        newStudent.Next = current.Next;
        current.Next = newStudent;
    }

    // Delete a student record by Roll Number
    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null) return;

        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            return;
        }

        Student current = head;
        while (current.Next != null && current.Next.RollNumber != rollNumber)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // Search for a student record by Roll Number
    public Student SearchByRollNumber(int rollNumber)
    {
        Student current = head;
        while (current != null)
        {
            if (current.RollNumber == rollNumber)
                return current;
            current = current.Next;
        }
        return null;
    }

    // Display all student records
    public void DisplayAll()
    {
        Student current = head;
        while (current != null)
        {
            Console.WriteLine($"Roll Number: {current.RollNumber}, Name: {current.Name}, Age: {current.Age}, Grade: {current.Grade}");
            current = current.Next;
        }
    }

    // Update a student's grade based on their Roll Number
    public void UpdateGrade(int rollNumber, char newGrade)
    {
        Student student = SearchByRollNumber(rollNumber);
        if (student != null)
        {
            student.Grade = newGrade;
        }
    }
}

public class Program
{
    public static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        // Add some students
        list.AddAtBeginning(1, "Sanskriti", 20, 'A');
        list.AddAtEnd(2, "Rahul", 21, 'B');
        list.AddAtPosition(1, 3, "Shivang", 22, 'C');

        // Display all students
        list.DisplayAll();

        // Update a student's grade
        list.UpdateGrade(2, 'A');

        // Delete a student by roll number
        list.DeleteByRollNumber(1);

        // Display all students again
        list.DisplayAll();
    }
}


//2
using System;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int YearOfRelease { get; set; }
    public double Rating { get; set; }
    public Movie Next { get; set; }
    public Movie Prev { get; set; }
}

public class MovieLinkedList
{
    private Movie head;
    private Movie tail;

    // Add a movie record at the beginning
    public void AddAtBeginning(string title, string director, int yearOfRelease, double rating)
    {
        Movie newMovie = new Movie
        {
            Title = title,
            Director = director,
            YearOfRelease = yearOfRelease,
            Rating = rating,
            Next = head
        };

        if (head != null)
        {
            head.Prev = newMovie;
        }
        head = newMovie;
        if (tail == null)
        {
            tail = head;
        }
    }

    // Add a movie record at the end
    public void AddAtEnd(string title, string director, int yearOfRelease, double rating)
    {
        Movie newMovie = new Movie
        {
            Title = title,
            Director = director,
            YearOfRelease = yearOfRelease,
            Rating = rating
        };

        if (tail == null)
        {
            head = tail = newMovie;
            return;
        }

        tail.Next = newMovie;
        newMovie.Prev = tail;
        tail = newMovie;
    }

    // Add a movie record at a specific position
    public void AddAtPosition(int position, string title, string director, int yearOfRelease, double rating)
    {
        Movie newMovie = new Movie
        {
            Title = title,
            Director = director,
            YearOfRelease = yearOfRelease,
            Rating = rating
        };

        if (position == 0)
        {
            AddAtBeginning(title, director, yearOfRelease, rating);
            return;
        }

        Movie current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current == null)
                throw new ArgumentOutOfRangeException("Position is out of bounds of the list.");
            current = current.Next;
        }

        newMovie.Next = current.Next;
        newMovie.Prev = current;

        if (current.Next != null)
        {
            current.Next.Prev = newMovie;
        }

        current.Next = newMovie;

        if (newMovie.Next == null)
        {
            tail = newMovie;
        }
    }

    // Remove a movie record by Movie Title
    public void RemoveByTitle(string title)
    {
        if (head == null) return;

        Movie current = head;
        while (current != null && current.Title != title)
        {
            current = current.Next;
        }

        if (current == null) return;

        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
        else
        {
            head = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }
        else
        {
            tail = current.Prev;
        }
    }

    // Search for a movie record by Director or Rating
    public Movie SearchByDirectorOrRating(string director, double rating)
    {
        Movie current = head;
        while (current != null)
        {
            if (current.Director == director || current.Rating == rating)
                return current;
            current = current.Next;
        }
        return null;
    }

    // Display all movie records in forward order
    public void DisplayAllForward()
    {
        Movie current = head;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
            current = current.Next;
        }
    }

    // Display all movie records in reverse order
    public void DisplayAllReverse()
    {
        Movie current = tail;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
            current = current.Prev;
        }
    }

    // Update a movie's rating 
    public void UpdateRating(string title, double newRating)
    {
        Movie movie = SearchByTitle(title);
        if (movie != null)
        {
            movie.Rating = newRating;
        }
    }

    // Search for a movie by title
    private Movie SearchByTitle(string title)
    {
        Movie current = head;
        while (current != null)
        {
            if (current.Title == title)
                return current;
            current = current.Next;
        }
        return null;
    }
}

public class Program
{
    public static void Main()
    {
        MovieLinkedList list = new MovieLinkedList();

        // Add some movies
        list.AddAtBeginning("Jab tak hai jaan", "Yash chopra", 2012, 8.8);
        list.AddAtEnd("3 idiots", "kabir khan", 2014, 8.7);
        list.AddAtPosition(1, "vivah", "suraj", 2005, 9.2);

        // Display all movies in forward order
        list.DisplayAllForward();

        // Display all movies in reverse order
        list.DisplayAllReverse();

        // Update a movie's rating
        list.UpdateRating("3 idiots", 9.0);

        // Remove a movie by title
        list.RemoveByTitle("Jab tak hai jaan");

        // Display all movies again in forward order
        list.DisplayAllForward();
    }
}


//3
using System;

public class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public Task Next { get; set; }
}

public class TaskScheduler
{
    private Task head;
    private Task current;

    // Add a task at the beginning
    public void AddAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task
        {
            TaskId = taskId,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate,
            Next = head
        };

        if (head == null)
        {
            head = newTask;
            newTask.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            head = newTask;
            newTask.Next = head;
        }
    }

    // Add a task at the end
    public void AddAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task
        {
            TaskId = taskId,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate
        };

        if (head == null)
        {
            head = newTask;
            newTask.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
    }

    // Add a task at a specific position
    public void AddAtPosition(int position, int taskId, string taskName, int priority, DateTime dueDate)
    {
        if (position == 0)
        {
            AddAtBeginning(taskId, taskName, priority, dueDate);
            return;
        }

        Task newTask = new Task
        {
            TaskId = taskId,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate
        };

        Task current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current.Next == head)
                throw new ArgumentOutOfRangeException("Position is out of bounds of the list.");
            current = current.Next;
        }

        newTask.Next = current.Next;
        current.Next = newTask;
    }

    // Remove a task by Task ID
    public void RemoveByTaskId(int taskId)
    {
        if (head == null) return;

        if (head.TaskId == taskId && head.Next == head)
        {
            head = null;
            return;
        }

        Task current = head;
        Task prev = null;
        do
        {
            if (current.TaskId == taskId)
            {
                if (prev != null)
                {
                    prev.Next = current.Next;
                }
                else
                {
                    Task temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }
                    head = current.Next;
                    temp.Next = head;
                }
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);
    }

    // View the current task and move to the next task
    public void ViewCurrentAndMoveNext()
    {
        if (current == null)
        {
            current = head;
        }

        if (current != null)
        {
            Console.WriteLine($"Task ID: {current.TaskId}, Task Name: {current.TaskName}, Priority: {current.Priority}, Due Date: {current.DueDate}");
            current = current.Next;
        }
    }

    // Display all tasks in the list starting from the head node
    public void DisplayAllTasks()
    {
        if (head == null) return;

        Task temp = head;
        do
        {
            Console.WriteLine($"Task ID: {temp.TaskId}, Task Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    // Search for a task by Priority
    public Task SearchByPriority(int priority)
    {
        if (head == null) return null;

        Task temp = head;
        do
        {
            if (temp.Priority == priority)
                return temp;
            temp = temp.Next;
        } while (temp != head);

        return null;
    }
}

public class Program
{
    public static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        // Add some tasks
        scheduler.AddAtBeginning(1, "Task A", 1, DateTime.Now.AddDays(1));
        scheduler.AddAtEnd(2, "Task B", 2, DateTime.Now.AddDays(2));
        scheduler.AddAtPosition(1, 3, "Task C", 3, DateTime.Now.AddDays(3));

        // Display all tasks
        scheduler.DisplayAllTasks();

        // View the current task and move to the next task
        scheduler.ViewCurrentAndMoveNext();

        // Remove a task by Task ID
        scheduler.RemoveByTaskId(1);

        // Display all tasks again
        scheduler.DisplayAllTasks();

        // Search for a task by priority
        Task task = scheduler.SearchByPriority(2);
        if (task != null)
        {
            Console.WriteLine($"Found Task: ID: {task.TaskId}, Name: {task.TaskName}, Priority: {task.Priority}, Due Date: {task.DueDate}");
        }
    }
}


//4
using System;

public class Item
{
    public string ItemName { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Item Next { get; set; }
}

public class InventoryLinkedList
{
    private Item head;

    // Add an item at the beginning
    public void AddAtBeginning(string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item
        {
            ItemName = itemName,
            ItemID = itemID,
            Quantity = quantity,
            Price = price,
            Next = head
        };
        head = newItem;
    }

    // Add an item at the end
    public void AddAtEnd(string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item
        {
            ItemName = itemName,
            ItemID = itemID,
            Quantity = quantity,
            Price = price
        };

        if (head == null)
        {
            head = newItem;
            return;
        }

        Item current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newItem;
    }

    // Add an item at a specific position
    public void AddAtPosition(int position, string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item
        {
            ItemName = itemName,
            ItemID = itemID,
            Quantity = quantity,
            Price = price
        };

        if (position == 0)
        {
            newItem.Next = head;
            head = newItem;
            return;
        }

        Item current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current == null)
                throw new ArgumentOutOfRangeException("Position is out of bounds of the list.");
            current = current.Next;
        }

        newItem.Next = current.Next;
        current.Next = newItem;
    }

    // Remove an item based on Item ID
    public void RemoveByItemID(int itemID)
    {
        if (head == null) return;

        if (head.ItemID == itemID)
        {
            head = head.Next;
            return;
        }

        Item current = head;
        while (current.Next != null && current.Next.ItemID != itemID)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // Update the quantity of an item by Item ID
    public void UpdateQuantity(int itemID, int newQuantity)
    {
        Item item = SearchByItemID(itemID);
        if (item != null)
        {
            item.Quantity = newQuantity;
        }
    }

    // Search for an item based on Item ID or Item Name
    public Item SearchByItemID(int itemID)
    {
        Item current = head;
        while (current != null)
        {
            if (current.ItemID == itemID)
                return current;
            current = current.Next;
        }
        return null;
    }

    public Item SearchByItemName(string itemName)
    {
        Item current = head;
        while (current != null)
        {
            if (current.ItemName == itemName)
                return current;
            current = current.Next;
        }
        return null;
    }

    // Calculate and display the total value of inventory
    public void DisplayTotalValue()
    {
        double totalValue = 0;
        Item current = head;
        while (current != null)
        {
            totalValue += current.Price * current.Quantity;
            current = current.Next;
        }
        Console.WriteLine($"Total Inventory Value: {totalValue}");
    }

    // Sort the inventory based on Item Name
    public void SortByName(bool ascending = true)
    {
        if (head == null) return;

        Item sorted = null;

        while (head != null)
        {
            Item current = head;
            head = head.Next;
            if (sorted == null || (ascending ? string.Compare(current.ItemName, sorted.ItemName) < 0 : string.Compare(current.ItemName, sorted.ItemName) > 0))
            {
                current.Next = sorted;
                sorted = current;
            }
            else
            {
                Item temp = sorted;
                while (temp.Next != null && (ascending ? string.Compare(current.ItemName, temp.Next.ItemName) >= 0 : string.Compare(current.ItemName, temp.Next.ItemName) <= 0))
                {
                    temp = temp.Next;
                }
                current.Next = temp.Next;
                temp.Next = current;
            }
        }
        head = sorted;
    }

    // Sort the inventory based on Price
    public void SortByPrice(bool ascending = true)
    {
        if (head == null) return;

        Item sorted = null;

        while (head != null)
        {
            Item current = head;
            head = head.Next;
            if (sorted == null || (ascending ? current.Price < sorted.Price : current.Price > sorted.Price))
            {
                current.Next = sorted;
                sorted = current;
            }
            else
            {
                Item temp = sorted;
                while (temp.Next != null && (ascending ? current.Price >= temp.Next.Price : current.Price <= temp.Next.Price))
                {
                    temp = temp.Next;
                }
                current.Next = temp.Next;
                temp.Next = current;
            }
        }
        head = sorted;
    }

    // Display all items in the list
    public void DisplayAll()
    {
        Item current = head;
        while (current != null)
        {
            Console.WriteLine($"Item Name: {current.ItemName}, Item ID: {current.ItemID}, Quantity: {current.Quantity}, Price: {current.Price}");
            current = current.Next;
        }
    }
}

public class Program
{
    public static void Main()
    {
        InventoryLinkedList inventory = new InventoryLinkedList();

        // Add some items
        inventory.AddAtBeginning("Item A", 1, 10, 15.5);
        inventory.AddAtEnd("Item B", 2, 5, 25.0);
        inventory.AddAtPosition(1, "Item C", 3, 8, 20.0);

        // Display all items
        inventory.DisplayAll();

        // Update the quantity of an item
        inventory.UpdateQuantity(2, 12);

        // Remove an item by Item ID
        inventory.RemoveByItemID(1);

        // Display total value of inventory
        inventory.DisplayTotalValue();

        // Sort by name and display all items
        inventory.SortByName(true);
        inventory.DisplayAll();

        // Sort by price and display all items
        inventory.SortByPrice(false);
        inventory.DisplayAll();
    }
}



//5
using System;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public Book Next;
    public Book Prev;

    public Book(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class Library
{
    private Book head;
    private Book tail;
    private int count = 0;

    public void AddBookAtBeginning(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        count++;
    }

    public void AddBookAtEnd(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (tail == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        count++;
    }

    public void AddBookAtPosition(string title, string author, string genre, int bookID, bool isAvailable, int position)
    {
        if (position < 1 || position > count + 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        if (position == 1)
        {
            AddBookAtBeginning(title, author, genre, bookID, isAvailable);
            return;
        }
        if (position == count + 1)
        {
            AddBookAtEnd(title, author, genre, bookID, isAvailable);
            return;
        }
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        Book temp = head;
        for (int i = 1; i < position - 1; i++)
        {
            temp = temp.Next;
        }
        newBook.Next = temp.Next;
        newBook.Prev = temp;
        temp.Next.Prev = newBook;
        temp.Next = newBook;
        count++;
    }

    public void RemoveBook(int bookID)
    {
        Book temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (temp.Prev != null)
        {
            temp.Prev.Next = temp.Next;
        }
        else
        {
            head = temp.Next;
        }
        if (temp.Next != null)
        {
            temp.Next.Prev = temp.Prev;
        }
        else
        {
            tail = temp.Prev;
        }
        count--;
    }

    public void SearchBook(string query)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.Title.Contains(query, StringComparison.OrdinalIgnoreCase) || temp.Author.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Found Book - Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Book ID: {temp.BookID}, Available: {temp.IsAvailable}");
            }
            temp = temp.Next;
        }
    }

    public void UpdateAvailability(int bookID, bool newStatus)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = newStatus;
                Console.WriteLine("Availability updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void DisplayForward()
    {
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Book ID: {temp.BookID}, Available: {temp.IsAvailable}");
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        Book temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Book ID: {temp.BookID}, Available: {temp.IsAvailable}");
            temp = temp.Prev;
        }
    }

    public int CountBooks()
    {
        return count;
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddBookAtEnd("C# Programming", "Sanskriti gupta", "Education", 101, true);
        library.AddBookAtBeginning("Data Structures", "Shivang bansal", "Education", 102, true);
        library.AddBookAtPosition("Algorithms", "Rahul kumar", "Computer Science", 103, true, 2);
        
        Console.WriteLine("All Books (Forward):");
        library.DisplayForward();
        
        Console.WriteLine("\nSearching for 'Data Structures':");
        library.SearchBook("Data Structures");
        
        Console.WriteLine("\nUpdating Availability of Book ID 101 to False:");
        library.UpdateAvailability(101, false);
        
        Console.WriteLine("\nRemoving Book ID 103:");
        library.RemoveBook(103);
        
        Console.WriteLine("\nAll Books after deletion (Reverse):");
        library.DisplayReverse();

        Console.WriteLine($"\nTotal Books: {library.CountBooks()}");
    }
}



//6

using System;

class Process
{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public Process Next;

    public Process(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private Process head = null;
    private Process tail = null;

    public void AddProcess(int processID, int burstTime, int priority)
    {
        Process newProcess = new Process(processID, burstTime, priority);
        if (head == null)
        {
            head = newProcess;
            tail = newProcess;
            newProcess.Next = head;
        }
        else
        {
            tail.Next = newProcess;
            newProcess.Next = head;
            tail = newProcess;
        }
    }

    public void RemoveProcess(int processID)
    {
        if (head == null)
        {
            Console.WriteLine("No processes to remove.");
            return;
        }

        Process temp = head, prev = null;
        do
        {
            if (temp.ProcessID == processID)
            {
                if (temp == head && temp == tail)
                {
                    head = tail = null;
                }
                else if (temp == head)
                {
                    head = head.Next;
                    tail.Next = head;
                }
                else if (temp == tail)
                {
                    tail = prev;
                    tail.Next = head;
                }
                else
                {
                    prev.Next = temp.Next;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void SimulateRoundRobin(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes available for scheduling.");
            return;
        }

        int totalWaitingTime = 0, totalTurnAroundTime = 0, processCount = 0;
        Process temp = head;

        Console.WriteLine("Simulating Round Robin Scheduling:");
        while (head != null)
        {
            Process current = temp;
            if (current.BurstTime > 0)
            {
                int executionTime = Math.Min(timeQuantum, current.BurstTime);
                current.BurstTime -= executionTime;
                totalTurnAroundTime += executionTime;

                if (current.BurstTime == 0)
                {
                    RemoveProcess(current.ProcessID);
                    totalWaitingTime += totalTurnAroundTime;
                    processCount++;
                }
            }
            temp = temp.Next;
        }

        Console.WriteLine($"Average Waiting Time: {totalWaitingTime / (double)processCount}");
        Console.WriteLine($"Average Turnaround Time: {totalTurnAroundTime / (double)processCount}");
    }

    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes available.");
            return;
        }

        Process temp = head;
        Console.WriteLine("Processes in the queue:");
        do
        {
            Console.WriteLine($"Process ID: {temp.ProcessID}, Burst Time: {temp.BurstTime}, Priority: {temp.Priority}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();
        
        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);
        
        Console.WriteLine("Initial Process Queue:");
        scheduler.DisplayProcesses();

        int timeQuantum = 3;
        scheduler.SimulateRoundRobin(timeQuantum);
    }
}



//7
using System;
using System.Collections.Generic;

class User
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> Friends;
    public User Next;

    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        Friends = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private User head;

    public void AddUser(int userID, string name, int age)
    {
        User newUser = new User(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            User temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
    }

    public void AddFriendConnection(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null && user1 != user2 && !user1.Friends.Contains(userID2))
        {
            user1.Friends.Add(userID2);
            user2.Friends.Add(userID1);
        }
    }

    public void RemoveFriendConnection(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null)
        {
            user1.Friends.Remove(userID2);
            user2.Friends.Remove(userID1);
        }
    }

    public void FindMutualFriends(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null)
        {
            HashSet<int> mutualFriends = new HashSet<int>(user1.Friends);
            mutualFriends.IntersectWith(user2.Friends);
            Console.WriteLine("Mutual Friends:");
            foreach (int friendID in mutualFriends)
            {
                Console.WriteLine(friendID);
            }
        }
    }

    public void DisplayFriends(int userID)
    {
        User user = FindUserByID(userID);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.Name}:");
            foreach (int friendID in user.Friends)
            {
                Console.WriteLine(friendID);
            }
        }
    }

    public User FindUserByID(int userID)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void SearchUser(string query)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || temp.UserID.ToString() == query)
            {
                Console.WriteLine($"User Found - ID: {temp.UserID}, Name: {temp.Name}, Age: {temp.Age}");
            }
            temp = temp.Next;
        }
    }

    public void CountFriends(int userID)
    {
        User user = FindUserByID(userID);
        if (user != null)
        {
            Console.WriteLine($"{user.Name} has {user.Friends.Count} friends.");
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();
        
        sm.AddUser(1, "Sanskriti", 25);
        sm.AddUser(2, "Rahul", 30);
        sm.AddUser(3, "Ruchita", 27);
        sm.AddUser(4, "Swapnil", 29);
        
        sm.AddFriendConnection(1, 2);
        sm.AddFriendConnection(1, 3);
        sm.AddFriendConnection(2, 4);
        sm.AddFriendConnection(3, 4);
        
        Console.WriteLine("Displaying Friends of Alice:");
        sm.DisplayFriends(1);
        
        Console.WriteLine("Finding Mutual Friends between Alice and Bob:");
        sm.FindMutualFriends(1, 2);
        
        Console.WriteLine("Counting Friends of Charlie:");
        sm.CountFriends(3);
        
        Console.WriteLine("Searching for User: Bob");
        sm.SearchUser("Bob");
    }
}


//8
using System;

class TextNode
{
    public string Content;
    public TextNode Prev;
    public TextNode Next;

    public TextNode(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextNode current;
    private int maxHistory;
    private int historyCount;

    public TextEditor(int maxHistorySize = 10)
    {
        maxHistory = maxHistorySize;
        historyCount = 0;
    }

    public void AddState(string content)
    {
        TextNode newNode = new TextNode(content);
        
        if (current != null)
        {
            newNode.Prev = current;
            current.Next = newNode;
        }
        current = newNode;
        
        if (historyCount < maxHistory)
        {
            historyCount++;
        }
        else
        {
            RemoveOldestState();
        }
    }

    private void RemoveOldestState()
    {
        TextNode temp = current;
        while (temp.Prev != null)
        {
            temp = temp.Prev;
        }
        
        if (temp.Next != null)
        {
            temp.Next.Prev = null;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("Current Text: " + current.Content);
        }
        else
        {
            Console.WriteLine("No text available.");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        
        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");
        
        editor.DisplayCurrentState();
        
        editor.Undo();
        editor.DisplayCurrentState();
        
        editor.Redo();
        editor.DisplayCurrentState();
    }
}



//9

using System;

// Class representing a ticket
class Ticket {
    public int TicketID; // Unique ticket identifier
    public string CustomerName; // Name of the customer
    public string MovieName; // Name of the movie
    public string SeatNumber; // Seat number assigned
    public string BookingTime; // Time of booking
    public Ticket Next; // Pointer to the next ticket (for circular linked list)
}

// Class for managing the ticket reservation system
class TicketReservation {
    private Ticket last; // Points to the last ticket in the circular linked list

    public TicketReservation() {
        last = null; // Initialize last as null
    }

    // Method to add a new ticket to the system
    public void AddTicket(int id, string customer, string movie, string seat, string time) {
        Ticket newTicket = new Ticket { TicketID = id, CustomerName = customer, MovieName = movie, SeatNumber = seat, BookingTime = time, Next = null };
        if (last == null) {
            last = newTicket;
            last.Next = last; // Circular reference
        } else {
            newTicket.Next = last.Next;
            last.Next = newTicket;
            last = newTicket;
        }
        Console.WriteLine("Ticket booked successfully!");
    }

    // Method to remove a ticket by ID
    public void RemoveTicket(int id) {
        if (last == null) {
            Console.WriteLine("No tickets to remove.");
            return;
        }

        Ticket current = last.Next, prev = last;
        do {
            if (current.TicketID == id) {
                if (current == last && current.Next == last) {
                    last = null; // Only one ticket in the list
                } else {
                    prev.Next = current.Next;
                    if (current == last) {
                        last = prev; // Update last if needed
                    }
                }
                Console.WriteLine("Ticket removed successfully!");
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != last.Next);

        Console.WriteLine("Ticket ID not found.");
    }

    // Method to display all tickets in the system
    public void DisplayTickets() {
        if (last == null) {
            Console.WriteLine("No tickets booked.");
            return;
        }
        Ticket current = last.Next;
        do {
            Console.WriteLine($"Ticket ID: {current.TicketID} | Customer: {current.CustomerName} | Movie: {current.MovieName} | Seat: {current.SeatNumber} | Time: {current.BookingTime}");
            current = current.Next;
        } while (current != last.Next);
    }

    // Method to search for a ticket by customer name or movie name
    public void SearchTicket(string query) {
        if (last == null) {
            Console.WriteLine("No tickets to search.");
            return;
        }
        Ticket current = last.Next;
        bool found = false;
        do {
            if (current.CustomerName == query || current.MovieName == query) {
                Console.WriteLine($"Ticket Found - ID: {current.TicketID} | Customer: {current.CustomerName} | Movie: {current.MovieName} | Seat: {current.SeatNumber} | Time: {current.BookingTime}");
                found = true;
            }
            current = current.Next;
        } while (current != last.Next);

        if (!found) Console.WriteLine("No matching ticket found.");
    }

    // Method to count the total number of booked tickets
    public int CountTickets() {
        if (last == null) return 0;
        int count = 0;
        Ticket current = last.Next;
        do {
            count++;
            current = current.Next;
        } while (current != last.Next);
        return count;
    }
}

class Program {
    static void Main() {
        TicketReservation system = new TicketReservation();
        system.AddTicket(1, "Sanskriti", "Vivah", "A12", "18:00");
        system.AddTicket(2, "Rahul", "Murder", "B10", "20:00");
        system.DisplayTickets();
        Console.WriteLine($"Total Tickets: {system.CountTickets()}");
        system.SearchTicket("Sanskriti");
        system.RemoveTicket(1);
        system.DisplayTickets();
    }
}

