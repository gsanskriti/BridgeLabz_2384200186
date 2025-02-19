//1
using System;
using System.Collections.Generic;
// Abstract class representing a warehouse item
public abstract class WarehouseItem
{
public int Id { get; set; }
public string Name { get; set; }
public int Quantity { get; set; }
public abstract void DisplayInfo();
}
// Class representing Electronics
public class Electronics : WarehouseItem
{
public string Brand { get; set; }
public string Model { get; set; }
public override void DisplayInfo()
{

Console.WriteLine($&quot;Electronics - ID: {Id}, Name:
{Name}, Brand: {Brand}, Model: {Model}, Quantity:
{Quantity}&quot;);
}
}
// Class representing Groceries
public class Groceries : WarehouseItem
{
public DateTime ExpiryDate { get; set; }
public override void DisplayInfo()
{
Console.WriteLine($&quot;Groceries - ID: {Id}, Name:
{Name}, Expiry Date: {ExpiryDate.ToShortDateString()},
Quantity: {Quantity}&quot;);
}
}
// Class representing Furniture
public class Furniture : WarehouseItem
{
public string Material { get; set; }
public override void DisplayInfo()
{
Console.WriteLine($&quot;Furniture - ID: {Id}, Name:
{Name}, Material: {Material}, Quantity: {Quantity}&quot;);
}
}
// Generic class for storage of warehouse items
public class Storage&lt;T&gt; where T : WarehouseItem
{
private List&lt;T&gt; items = new List&lt;T&gt;();
public void AddItem(T item)

{
items.Add(item);
}
public void DisplayAllItems()
{
foreach (var item in items)
{
item.DisplayInfo();
}
}
}
// Main program to test the warehouse management system
class Program
{
static void Main(string[] args)
{
// Create storage for Electronics
Storage&lt;Electronics&gt; electronicsStorage = new
Storage&lt;Electronics&gt;();
electronicsStorage.AddItem(new Electronics { Id =
1, Name = &quot;Laptop&quot;, Brand = &quot;BrandA&quot;, Model = &quot;ModelX&quot;,
Quantity = 10 });
electronicsStorage.AddItem(new Electronics { Id =
2, Name = &quot;Smartphone&quot;, Brand = &quot;BrandB&quot;, Model =
&quot;ModelY&quot;, Quantity = 20 });
// Create storage for Groceries
Storage&lt;Groceries&gt; groceriesStorage = new
Storage&lt;Groceries&gt;();
groceriesStorage.AddItem(new Groceries { Id = 3,
Name = &quot;Milk&quot;, ExpiryDate = DateTime.Now.AddDays(7),
Quantity = 50 });
groceriesStorage.AddItem(new Groceries { Id = 4,
Name = &quot;Bread&quot;, ExpiryDate = DateTime.Now.AddDays(3),
Quantity = 30 });

// Create storage for Furniture
Storage&lt;Furniture&gt; furnitureStorage = new
Storage&lt;Furniture&gt;();
furnitureStorage.AddItem(new Furniture { Id = 5,
Name = &quot;Chair&quot;, Material = &quot;Wood&quot;, Quantity = 15 });
furnitureStorage.AddItem(new Furniture { Id = 6,
Name = &quot;Table&quot;, Material = &quot;Metal&quot;, Quantity = 5 });
// Display all items
Console.WriteLine(&quot;Electronics Storage:&quot;);
electronicsStorage.DisplayAllItems();
Console.WriteLine(&quot;\nGroceries Storage:&quot;);
groceriesStorage.DisplayAllItems();
Console.WriteLine(&quot;\nFurniture Storage:&quot;);
furnitureStorage.DisplayAllItems();
}
}


//2
using System;

using System.Collections.Generic;
// Define an abstract class for Product
public abstract class Product
{
public string Name { get; set; }
public double Price { get; set; }
public abstract void DisplayInfo();
}
// Define a class for BookCategory
public class BookCategory : Product
{
public string Author { get; set; }
public string ISBN { get; set; }
public override void DisplayInfo()
{
Console.WriteLine($&quot;Book - Name: {Name}, Author:
{Author}, ISBN: {ISBN}, Price: {Price:C}&quot;);
}
}
// Define a class for ClothingCategory
public class ClothingCategory : Product
{
public string Size { get; set; }
public string Material { get; set; }
public override void DisplayInfo()
{
Console.WriteLine($&quot;Clothing - Name: {Name},
Size: {Size}, Material: {Material}, Price: {Price:C}&quot;);
}
}

// Define a generic class for Product Catalog
public class ProductCatalog&lt;T&gt; where T : Product
{
private List&lt;T&gt; products = new List&lt;T&gt;();
public void AddProduct(T product)
{
products.Add(product);
}
public void DisplayAllProducts()
{
foreach (var product in products)
{
product.DisplayInfo();
}
}
// Generic method to apply discount
public void ApplyDiscount&lt;U&gt;(U product, double
percentage) where U : Product
{
product.Price -= product.Price * (percentage /
100);
}
}
// Main program to test the online marketplace
class Program
{
static void Main(string[] args)
{
// Create a product catalog for books
ProductCatalog&lt;BookCategory&gt; bookCatalog = new
ProductCatalog&lt;BookCategory&gt;();
var book1 = new BookCategory { Name = &quot;C#
Programming&quot;, Author = &quot;John Doe&quot;, ISBN = &quot;1234567890&quot;,

Price = 29.99 };
var book2 = new BookCategory { Name = &quot;Learning
Python&quot;, Author = &quot;Jane Smith&quot;, ISBN = &quot;0987654321&quot;,
Price = 39.99 };
bookCatalog.AddProduct(book1);
bookCatalog.AddProduct(book2);
// Create a product catalog for clothing
ProductCatalog&lt;ClothingCategory&gt; clothingCatalog
= new ProductCatalog&lt;ClothingCategory&gt;();
var clothing1 = new ClothingCategory { Name = &quot;T-
Shirt&quot;, Size = &quot;M&quot;, Material = &quot;Cotton&quot;, Price = 19.99 };
var clothing2 = new ClothingCategory { Name =
&quot;Jeans&quot;, Size = &quot;L&quot;, Material = &quot;Denim&quot;, Price = 49.99 };
clothingCatalog.AddProduct(clothing1);
clothingCatalog.AddProduct(clothing2);
// Display all products in the book catalog
Console.WriteLine(&quot;Book Catalog:&quot;);
bookCatalog.DisplayAllProducts();
// Apply a discount to the first book
bookCatalog.ApplyDiscount(book1, 10); // 10%
discount
Console.WriteLine(&quot;\nAfter applying discount:&quot;);
bookCatalog.DisplayAllProducts();
// Display all products in the clothing catalog
Console.WriteLine(&quot;\nClothing Catalog:&quot;);
clothingCatalog.DisplayAllProducts();
// Apply a discount to the first clothing item
clothingCatalog.ApplyDiscount(clothing1, 15); //
15% discount
Console.WriteLine(&quot;\nAfter applying discount:&quot;);
clothingCatalog.DisplayAllProducts();
}

}


//3
using System;
using System.Collections.Generic;
// Abstract class representing a course type
public abstract class CourseType
{
public string CourseName { get; set; }
public int Credits { get; set; }
public abstract void DisplayCourseInfo();
}
// Class representing an ExamCourse
public class ExamCourse : CourseType
{
public int ExamDuration { get; set; } // Duration in
minutes
public override void DisplayCourseInfo()
{

Console.WriteLine($&quot;Exam Course - Name:
{CourseName}, Credits: {Credits}, Exam Duration:
{ExamDuration} minutes&quot;);
}
}
// Class representing an AssignmentCourse
public class AssignmentCourse : CourseType
{
public int NumberOfAssignments { get; set; }
public override void DisplayCourseInfo()
{
Console.WriteLine($&quot;Assignment Course - Name:
{CourseName}, Credits: {Credits}, Number of Assignments:
{NumberOfAssignments}&quot;);
}
}
// Generic class for Course management
public class Course&lt;T&gt; where T : CourseType
{
private List&lt;T&gt; courses = new List&lt;T&gt;();
public void AddCourse(T course)
{
courses.Add(course);
}
public void DisplayAllCourses()
{
foreach (var course in courses)
{
course.DisplayCourseInfo();
}
}
}

// Main program to test the university course management
system
class Program
{
static void Main(string[] args)
{
// Create a course management system for
ExamCourses
Course&lt;ExamCourse&gt; examCourseCatalog = new
Course&lt;ExamCourse&gt;();
var examCourse1 = new ExamCourse { CourseName =
&quot;Calculus&quot;, Credits = 3, ExamDuration = 120 };
var examCourse2 = new ExamCourse { CourseName =
&quot;Physics&quot;, Credits = 4, ExamDuration = 90 };
examCourseCatalog.AddCourse(examCourse1);
examCourseCatalog.AddCourse(examCourse2);
// Create a course management system for
AssignmentCourses
Course&lt;AssignmentCourse&gt; assignmentCourseCatalog
= new Course&lt;AssignmentCourse&gt;();
var assignmentCourse1 = new AssignmentCourse {
CourseName = &quot;Data Structures&quot;, Credits = 3,
NumberOfAssignments = 5 };
var assignmentCourse2 = new AssignmentCourse {
CourseName = &quot;Web Development&quot;, Credits = 4,
NumberOfAssignments = 3 };
assignmentCourseCatalog.AddCourse(assignmentCourse1);
assignmentCourseCatalog.AddCourse(assignmentCourse2);
// Display all courses in the ExamCourse catalog
Console.WriteLine(&quot;Exam Course Catalog:&quot;);
examCourseCatalog.DisplayAllCourses();
// Display all courses in the AssignmentCourse
catalog

Console.WriteLine(&quot;\nAssignment Course
Catalog:&quot;);
assignmentCourseCatalog.DisplayAllCourses();
}
}



//4
using System;
namespace MealPlanGenerator
{
// Define the IMealPlan interface
public interface IMealPlan
{
string GetDescription();
int GetCalories();
}
// Subtypes of IMealPlan
public class VegetarianMeal : IMealPlan
{
public string GetDescription() =&gt; &quot;Vegetarian
Meal&quot;;

public int GetCalories() =&gt; 500;
}
public class VeganMeal : IMealPlan
{
public string GetDescription() =&gt; &quot;Vegan Meal&quot;;
public int GetCalories() =&gt; 450;
}
public class KetoMeal : IMealPlan
{
public string GetDescription() =&gt; &quot;Keto Meal&quot;;
public int GetCalories() =&gt; 600;
}
public class HighProteinMeal : IMealPlan
{
public string GetDescription() =&gt; &quot;High-Protein
Meal&quot;;
public int GetCalories() =&gt; 700;
}
// Generic class Meal&lt;T&gt;
public class Meal&lt;T&gt; where T : IMealPlan, new()
{
public T MealPlan { get; set; }
public Meal()
{
MealPlan = new T();
}
public void DisplayMeal()
{
Console.WriteLine($&quot;Meal:
{MealPlan.GetDescription()}, Calories:
{MealPlan.GetCalories()}&quot;);

}
// Generic method to validate and generate meal
plans
public static Meal&lt;T&gt; GenerateMeal()
{
// Perform validation if needed
return new Meal&lt;T&gt;();
}
}
class Program
{
static void Main(string[] args)
{
// Example usage
var vegetarianMeal =
Meal&lt;VegetarianMeal&gt;.GenerateMeal();
vegetarianMeal.DisplayMeal();
var ketoMeal = Meal&lt;KetoMeal&gt;.GenerateMeal();
ketoMeal.DisplayMeal();
}
}
}


//5
using System;
using System.Collections.Generic;
// Define the abstract class JobRole
public abstract class JobRole
{
public string CandidateName { get; set; }
public abstract string GetRoleDescription();
}
// Define specific job roles
public class SoftwareEngineer : JobRole
{
public override string GetRoleDescription() =&gt;
&quot;Software Engineer&quot;;
}
public class DataScientist : JobRole
{
public override string GetRoleDescription() =&gt; &quot;Data
Scientist&quot;;
}
// Generic class Resume&lt;T&gt;
public class Resume&lt;T&gt; where T : JobRole, new()
{
public T JobRole { get; set; }
public Resume(T jobRole)
{
JobRole = jobRole;
}

public void DisplayResume()
{
Console.WriteLine($&quot;Candidate:
{JobRole.CandidateName}, Role:
{JobRole.GetRoleDescription()}&quot;);
}
// Generic method to process resumes
public static List&lt;Resume&lt;T&gt;&gt;
ProcessResumes(List&lt;Resume&lt;T&gt;&gt; resumes)
{
// Processing logic
return resumes;
}
}
class Program
{
static void Main(string[] args)
{
// Example usage
var softwareEngineerResume = new
Resume&lt;SoftwareEngineer&gt;(new SoftwareEngineer {
CandidateName = &quot;Alice&quot; });
var dataScientistResume = new
Resume&lt;DataScientist&gt;(new DataScientist { CandidateName =
&quot;Bob&quot; });
var resumes = new List&lt;Resume&lt;JobRole&gt;&gt;
{
softwareEngineerResume,
dataScientistResume
};
foreach (var resume in resumes)
{

resume.DisplayResume();
}
// Process resumes (example of the generic
method)
var processedResumes =
Resume&lt;JobRole&gt;.ProcessResumes(resumes);
// Display processed resumes
foreach (var processedResume in processedResumes)
{
processedResume.DisplayResume();
}
}
}