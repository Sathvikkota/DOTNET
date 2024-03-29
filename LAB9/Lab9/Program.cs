using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Sample list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ query to filter even numbers
        var evenNumbers = from number in numbers
                          where number % 2 == 0
                          select number;

        // Output the even numbers
        Console.WriteLine("Even Numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}



























/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<string> GetSortedOddIntegers(List<int> integerList)
    {
        List<string> oddStrings = integerList.Where(num => num % 2 != 0).Select(num => num.ToString()).ToList();
        oddStrings.Sort();
        return oddStrings;
    }

    static void Main(string[] args)
    {
        List<int> integerList = new List<int> { 3, 6, 8, 5, 10, 11, 2 };
        List<string> result = GetSortedOddIntegers(integerList);
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
*/


























/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<string> GetStringsEndingInDigit(List<string> stringList, int K)
    {
        List<string> result = stringList.Where(str => str.Length == K && char.IsDigit(str[K - 1])).ToList();
        result.Sort();
        return result;
    }

    static void Main(string[] args)
    {
        List<string> stringList = new List<string> { "ABC123", "DEF456", "GHI789", "JKL101", "MNO202" };
        int K = 6;
        List<string> result = GetStringsEndingInDigit(stringList, K);
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
*/




























/*using System;
using System.Collections.Generic;

class Program
{
    static List<string> GetFirstLastCharacters(List<string> stringList)
    {
        List<string> newSequence = new List<string>();
        foreach (string str in stringList)
        {
            string newString = str[0].ToString() + str[str.Length - 1];
            newSequence.Add(newString);
        }
        return newSequence;
    }

    static void Main(string[] args)
    {
        List<string> stringList = new List<string> { "hello", "world", "python", "code" };
        List<string> result = GetFirstLastCharacters(stringList);
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
*/























/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> GetSortedLengths(List<string> stringList)
    {
        List<int> lengths = stringList.Select(s => s.Length).ToList();
        lengths.Sort();
        return lengths;
    }

    static void Main(string[] args)
    {
        List<string> stringList = new List<string> { "apple", "banana", "car", "dog", "cat" };
        List<int> result = GetSortedLengths(stringList);
        foreach (int length in result)
        {
            Console.WriteLine(length);
        }
    }
}
*//*




























/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> GetSortedLengths(List<string> stringList)
    {
        List<int> lengths = stringList.Select(s => s.Length).ToList();
        lengths.Sort();
        return lengths;
    }

    static void Main(string[] args)
    {
        List<string> stringList = new List<string> { "apple", "banana", "car", "dog", "cat" };
        List<int> result = GetSortedLengths(stringList);
        foreach (int length in result)
        {
            Console.WriteLine(length);
        }
    }
}
*/

































/*using System;
using System.Collections.Generic;

class Program
{
    static List<string> GenerateStrings(List<string> stringList)
    {
        List<string> newSequence = new List<string>();
        foreach (string str in stringList)
        {
            if (str.Length > 1)
            {
                newSequence.Add('C' + str + 'C');
            }
        }
        return newSequence;
    }

    static void Main(string[] args)
    {
        List<string> stringList = new List<string> { "apple", "banana", "car", "dog", "cat", "C" };
        List<string> result = GenerateStrings(stringList);
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
*/