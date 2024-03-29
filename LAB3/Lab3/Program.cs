using System;

class Employee
{
    private string name;
    private decimal salary;
    protected decimal bonus;

    public string Name => name;
    public decimal Salary { get => salary; set => salary = value; }

    public Employee(string name, decimal salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public virtual void SetBonus(decimal bonus)
    {
        this.bonus = bonus;
    }

    public decimal ToPay() => salary + bonus;
}

class SalesPerson : Employee
{
    private int percent;

    public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
    {
        this.percent = percent;
    }

    public override void SetBonus(decimal bonus)
    {
        base.SetBonus(percent > 200 ? bonus * 3 : percent > 100 ? bonus * 2 : bonus);
    }
}

class Manager : Employee
{
    private int quantity;

    public Manager(string name, decimal salary, int quantity) : base(name, salary)
    {
        this.quantity = quantity;
    }

    public override void SetBonus(decimal bonus)
    {
        base.SetBonus(quantity > 150 ? bonus + 1000 : quantity > 100 ? bonus + 500 : bonus);
    }
}

class Company
{
    public static decimal GetTotalToPay(Employee[] employees)
    {
        decimal totalToPay = 0;
        foreach (Employee emp in employees)
            totalToPay += emp.ToPay();
        return totalToPay;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new SalesPerson("John", 2000, 150),
            new Manager("Alice", 2500, 120)
        };

        foreach (Employee emp in employees)
            emp.SetBonus(500);

        decimal totalToPay = Company.GetTotalToPay(employees);
        Console.WriteLine("Total to pay: " + totalToPay);
    }
}




















/*using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; }
    public bool IsAvailable { get; set; }

    public Book(string title)
    {
        Title = title;
        IsAvailable = true;
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book SearchBook(string title)
    {
        return books.Find(book => book.Title == title && book.IsAvailable);
    }

    public void BorrowBook(Book book)
    {
        book.IsAvailable = false;
    }

    public void ReturnBook(Book book)
    {
        book.IsAvailable = true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Book book1 = new Book("Book1");
        Book book2 = new Book("Book2");
        library.AddBook(book1);
        library.AddBook(book2);

        Book borrowedBook = library.SearchBook("Book1");
        if (borrowedBook != null)
        {
            library.BorrowBook(borrowedBook);
            Console.WriteLine("Book1 has been borrowed.");
        }
        else
        {
            Console.WriteLine("Book1 is not available.");
        }

        Book returnedBook = library.SearchBook("Book1");
        if (returnedBook != null)
        {
            library.ReturnBook(returnedBook);
            Console.WriteLine("Book1 has been returned.");
        }
    }
}*/





















/*using System;

class Rectangle
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }

    public bool IsSquare()
    {
        return Width == Height;
    }
}

class ArrayRectangles
{
    private Rectangle[] rectangleArray;

    public ArrayRectangles(int n)
    {
        rectangleArray = new Rectangle[n];
    }

    public ArrayRectangles(params Rectangle[] rectangles)
    {
        rectangleArray = rectangles;
    }

    public bool AddRectangle(Rectangle rectangle)
    {
        for (int i = 0; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] == null)
            {
                rectangleArray[i] = rectangle;
                return true;
            }
        }
        return false;
    }

    public int? NumberMaxArea()
    {
        if (rectangleArray.Length == 0)
            return null;

        int maxIndex = 0;
        double maxArea = rectangleArray[0].Area();

        for (int i = 1; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] != null && rectangleArray[i].Area() > maxArea)
            {
                maxArea = rectangleArray[i].Area();
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    public int? NumberMinPerimeter()
    {
        if (rectangleArray.Length == 0)
            return null;

        int minIndex = 0;
        double minPerimeter = rectangleArray[0].Perimeter();

        for (int i = 1; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] != null && rectangleArray[i].Perimeter() < minPerimeter)
            {
                minPerimeter = rectangleArray[i].Perimeter();
                minIndex = i;
            }
        }
        return minIndex;
    }

    public int NumberSquare()
    {
        int squareCount = 0;
        foreach (var rectangle in rectangleArray)
        {
            if (rectangle != null && rectangle.IsSquare())
                squareCount++;
        }
        return squareCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        ArrayRectangles arrayRectangles = new ArrayRectangles(5); // Creating an array of length 5

        Rectangle rect1 = new Rectangle(3, 4);
        Rectangle rect2 = new Rectangle(5, 5);
        Rectangle rect3 = new Rectangle(2, 2);

        arrayRectangles.AddRectangle(rect1);
        arrayRectangles.AddRectangle(rect2);
        arrayRectangles.AddRectangle(rect3);

        Console.WriteLine("Number of squares: " + arrayRectangles.NumberSquare()); // Output: 1
    }
}


*/










/*class Program { 
public class Rectangle
{
    private double sideA; // Side A of the rectangle
    private double sideB; // Side B of the rectangle
    public Rectangle(double a, double b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentOutOfRangeException("Sides of a rectangle must be positive values.");
        }
        sideA = a;
        sideB = b;
    }
    public Rectangle(double a) : this(a, 5) { } // Delegate to constructor with two parameters
    public Rectangle() : this(4, 3) { } // Delegate to constructor with two parameters
    public double GetSideA() => sideA;
    public double GetSideB() => sideB;
    public double Area() => sideA * sideB;
    public double Perimeter() => 2 * (sideA + sideB);
    public bool IsSquare() => sideA == sideB;
    public void ReplaceSides()
    {
        double temp = sideA;
        sideA = sideB;
        sideB = temp;
    }
}

static void Main(string[] args)
{
    // Create rectangles using different constructors
    Rectangle rect1 = new Rectangle(6, 8); // Explicit values
    Rectangle rect2 = new Rectangle(10); // Default sideB (5)
    Rectangle rect3 = new Rectangle(); // Default sides (4, 3)

    // Print details for each rectangle
    Console.WriteLine("Rectangle 1:");
    Console.WriteLine("  Side A: {0}", rect1.GetSideA());
    Console.WriteLine("  Side B: {0}", rect1.GetSideB());
    Console.WriteLine("  Area: {0}", rect1.Area());
    Console.WriteLine("  Perimeter: {0}", rect1.Perimeter());
    Console.WriteLine("  Is Square: {0}", rect1.IsSquare());
    Console.WriteLine();

    rect1.ReplaceSides();
    Console.WriteLine("Rectangle 1 after side swap:");
    Console.WriteLine("  Side A: {0}", rect1.GetSideA());
    Console.WriteLine("  Side B: {0}", rect1.GetSideB());
}
}
*/