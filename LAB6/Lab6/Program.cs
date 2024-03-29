using System;

public static class DateTimeExtensions
{
    public static int DaysBetween(this DateTime startDate, DateTime endDate)
    {
        return (int)(endDate - startDate).TotalDays;
    }

    public static bool IsWeekend(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DateTime startDate = new DateTime(2024, 3, 1);
        DateTime endDate = new DateTime(2024, 3, 10);

        int daysBetween = startDate.DaysBetween(endDate);
        Console.WriteLine("Days between {0} and {1}: {2}", startDate, endDate, daysBetween);

        DateTime someDate = new DateTime(2024, 3, 5);
        Console.WriteLine("Is {0} a weekend? {1}", someDate, someDate.IsWeekend());
    }
}





























/*using System;
using System.Collections.Generic;
using System.Linq;

public static class MyExtension
{
    public static int SummaDigit(this int number) => number.ToString().Sum(c => c - '0');

    public static uint SummaWithReverse(this uint number) => number + ReverseDigits(number);

    private static uint ReverseDigits(uint number) => uint.Parse(string.Concat(number.ToString().Reverse()));

    public static int CountNotLetter(this string str) => str.Count(c => !char.IsLetter(c));

    public static bool IsDayOff(this DayOfWeek day) => day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;

    public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers) => numbers.Where(n => n > 0 && n % 2 == 0);
}

class Program
{
    static void Main(string[] args)
    {
        // Example 1
        int number1 = 1274;
        Console.WriteLine("Sum of digits of {0}: {1}", number1, number1.SummaDigit());

        // Example 2
        uint number2 = 132;
        Console.WriteLine("Sum of {0} with its reverse: {1}", number2, number2.SummaWithReverse());

    }
}
*/