using System;
using System.Collections.Generic;

public interface IBorrowable
{
    bool Borrow();
    bool Return();
}

public class Book
{
    public string Title { get; }
    public string Author { get; }
    public bool IsAvailable { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public bool Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            return true;
        }
        return false;
    }

    public bool Return()
    {
        if (!IsAvailable)
        {
            IsAvailable = true;
            return true;
        }
        return false;
    }
}

public class LibraryMember
{
    public string Name { get; }
    public List<Book> BorrowedBooks { get; }

    public LibraryMember(string name)
    {
        Name = name;
        BorrowedBooks = new List<Book>();
    }

    public bool BorrowBook(Book book)
    {
        if (book.Borrow())
        {
            BorrowedBooks.Add(book);
            return true;
        }
        Console.WriteLine("Sorry, the book is not available for borrowing.");
        return false;
    }

    public bool ReturnBook(Book book)
    {
        if (BorrowedBooks.Remove(book))
        {
            book.Return();
            return true;
        }
        Console.WriteLine("You have not borrowed this book.");
        return false;
    }
}

public class Library
{
    public List<Book> Books { get; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating books
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

        // Creating library
        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);

        // Creating library members
        LibraryMember member1 = new LibraryMember("Alice");
        LibraryMember member2 = new LibraryMember("Bob");

        // Alice borrows a book
        member1.BorrowBook(book1);
        Console.WriteLine("Alice's borrowed books: " + string.Join(", ", member1.BorrowedBooks));

        // Bob tries to borrow the same book
        member2.BorrowBook(book1);

        // Alice returns the book
        member1.ReturnBook(book1);
        Console.WriteLine("Alice's borrowed books after returning: " + string.Join(", ", member1.BorrowedBooks));
    }
}






















/*using System;
using System.Collections;
using System.Collections.Generic;

public interface IProlongable
{
    bool CanToProlong();
}

public abstract class Deposit : IComparable<Deposit>
{
    public double Amount { get; }
    public int Period { get; }

    protected Deposit(double amount, int period)
    {
        Amount = amount;
        Period = period;
    }

    public abstract double Income();

    public double TotalAmount() => Amount + Income();

    public int CompareTo(Deposit other) => TotalAmount().CompareTo(other.TotalAmount());
}

public class BaseDeposit : Deposit
{
    public BaseDeposit(double amount, int period) : base(amount, period) { }

    public override double Income() => Enumerable.Range(1, Period).Sum(i => Amount * 0.05 * Math.Pow(1.05, i - 1));
}

public class SpecialDeposit : Deposit, IProlongable
{
    public SpecialDeposit(double amount, int period) : base(amount, period) { }

    public bool CanToProlong() => Amount > 1000;

    public override double Income() => Enumerable.Range(1, Period).Sum(i => Amount * i / 100.0);
}

public class LongDeposit : Deposit, IProlongable
{
    public LongDeposit(double amount, int period) : base(amount, period) { }

    public bool CanToProlong() => Period <= 36;

    public override double Income() => Enumerable.Range(1, Period).Sum(i => i >= 7 ? Amount * 0.15 : 0);
}

public class Client : IEnumerable<Deposit>
{
    private readonly List<Deposit> deposits = new List<Deposit>();

    public bool AddDeposit(Deposit deposit)
    {
        if (deposits.Count < 10)
        {
            deposits.Add(deposit);
            return true;
        }
        return false;
    }

    public double TotalIncome() => deposits.Sum(d => d.Income());

    public double MaxIncome() => deposits.Max(d => d.Income());

    public double GetIncomeByNumber(int number) => number >= 1 && number <= deposits.Count ? deposits[number - 1].Income() : 0;

    public IEnumerator<Deposit> GetEnumerator() => deposits.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void SortDeposits() => deposits.Sort((d1, d2) => d2.CompareTo(d1));

    public int CountPossibleToProlongDeposit() => deposits.Count(d => d is IProlongable && ((IProlongable)d).CanToProlong());
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        // Adding deposits
        client.AddDeposit(new BaseDeposit(1000, 3));
        client.AddDeposit(new SpecialDeposit(1500, 3));
        client.AddDeposit(new LongDeposit(1000, 36));

        // Getting total income
        Console.WriteLine("Total Income: " + client.TotalIncome());

        // Getting maximum income
        Console.WriteLine("Max Income: " + client.MaxIncome());

        // Getting income by deposit number
        Console.WriteLine("Income from deposit 1: " + client.GetIncomeByNumber(1));
        Console.WriteLine("Income from deposit 2: " + client.GetIncomeByNumber(2));
        Console.WriteLine("Income from deposit 3: " + client.GetIncomeByNumber(3));

        // Sorting deposits
        client.SortDeposits();

        // Counting possible to prolong deposits
        Console.WriteLine("Possible to prolong deposits: " + client.CountPossibleToProlongDeposit());
    }
}*/





















/*using System;

public abstract class Deposit
{
    public double Amount { get; }
    public int Period { get; }

    public Deposit(double depositAmount, int depositPeriod)
    {
        Amount = depositAmount;
        Period = depositPeriod;
    }

    public abstract double Income();
}

public class BaseDeposit : Deposit
{
    public BaseDeposit(double amount, int period) : base(amount, period) { }

    public override double Income()
    {
        double income = 0;
        double currentAmount = Amount;

        for (int i = 0; i < Period; i++)
        {
            income += currentAmount * 0.05;
            currentAmount += income;
            income = Math.Round(income, 2);
        }

        return income;
    }
}

public class SpecialDeposit : Deposit
{
    public SpecialDeposit(double amount, int period) : base(amount, period) { }

    public override double Income()
    {
        double income = 0;
        double currentAmount = Amount;

        for (int i = 0; i < Period; i++)
        {
            income += currentAmount * (i + 1) / 100.0;
            currentAmount += income;
            income = Math.Round(income, 2);
        }

        return income;
    }
}

public class LongDeposit : Deposit
{
    public LongDeposit(double amount, int period) : base(amount, period) { }

    public override double Income()
    {
        double income = 0;
        double currentAmount = Amount;

        for (int i = 0; i < Period; i++)
        {
            if (i >= 6)
            {
                income += currentAmount * 0.15;
                currentAmount += income;
                income = Math.Round(income, 2);
            }
        }

        return income;
    }
}

public class Client
{
    private Deposit[] deposits;

    public Client()
    {
        deposits = new Deposit[10];
    }

    public bool AddDeposit(Deposit deposit)
    {
        for (int i = 0; i < deposits.Length; i++)
        {
            if (deposits[i] == null)
            {
                deposits[i] = deposit;
                return true;
            }
        }
        return false;
    }

    public double TotalIncome()
    {
        double totalIncome = 0;
        foreach (var deposit in deposits)
        {
            if (deposit != null)
                totalIncome += deposit.Income();
        }
        return totalIncome;
    }

    public double MaxIncome()
    {
        double maxIncome = 0;
        foreach (var deposit in deposits)
        {
            if (deposit != null && deposit.Income() > maxIncome)
                maxIncome = deposit.Income();
        }
        return maxIncome;
    }

    public double GetIncomeByNumber(int number)
    {
        if (number >= 1 && number <= deposits.Length)
        {
            if (deposits[number - 1] != null)
                return deposits[number - 1].Income();
        }
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        // Adding deposits
        client.AddDeposit(new BaseDeposit(1000, 3));
        client.AddDeposit(new SpecialDeposit(1000, 3));
        client.AddDeposit(new LongDeposit(1000, 12));

        // Getting total income
        Console.WriteLine("Total Income: " + client.TotalIncome());

        // Getting maximum income
        Console.WriteLine("Max Income: " + client.MaxIncome());

        // Getting income by deposit number
        Console.WriteLine("Income from deposit 1: " + client.GetIncomeByNumber(1));
        Console.WriteLine("Income from deposit 2: " + client.GetIncomeByNumber(2));
        Console.WriteLine("Income from deposit 3: " + client.GetIncomeByNumber(3));
    }
}
*/