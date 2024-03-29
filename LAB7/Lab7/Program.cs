using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        Console.WriteLine("Numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Dictionary<string, string> countries = new Dictionary<string, string>();
        countries.Add("USA", "United States");
        countries.Add("CAN", "Canada");
        countries.Add("GBR", "United Kingdom");
        Console.WriteLine("\nCountries:");
        foreach (var kvp in countries)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}



























/*using System;
using System.Collections;
using System.Collections.Generic;

public class CustomArray<T> : IEnumerable<T>
{
    private T[] array;
    private int startIndex;

    public CustomArray(int length, int startIndex)
    {
        if (length <= 0)
            throw new ArgumentException("Length must be greater than zero.", nameof(length));

        this.startIndex = startIndex;
        array = new T[length];
    }

    public int Length => array.Length;
    public int FirstIndex => startIndex;
    public int LastIndex => startIndex + array.Length - 1;

    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return array[index - startIndex];
        }
        set
        {
            CheckIndex(index);
            array[index - startIndex] = value;
        }
    }

    public T[] ToStandardArray() => array;

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in array)
            yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private void CheckIndex(int index)
    {
        if (index < startIndex || index > LastIndex)
            throw new ArgumentOutOfRangeException(nameof(index), $"Index must be between {startIndex} and {LastIndex}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            CustomArray<char> charArray = new CustomArray<char>(20, 18);
            charArray[18] = 'A';
            charArray[19] = 'B';

            Console.WriteLine($"First index: {charArray.FirstIndex}, Last index: {charArray.LastIndex}, Array length: {charArray.Length}");
            Console.WriteLine("Array elements: " + string.Join(" ", charArray));

            CustomArray<Animal> animalArray = new CustomArray<Animal>(10, -5);
            animalArray[-5] = new Animal("Lion");
            animalArray[-4] = new Animal("Elephant");

            Console.WriteLine($"\nFirst index: {animalArray.FirstIndex}, Last index: {animalArray.LastIndex}, Array length: {animalArray.Length}");
            Console.WriteLine("Array elements:");
            foreach (Animal animal in animalArray)
                Console.WriteLine(animal.Name);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

public class Animal
{
    public string Name { get; set; }
    public Animal(string name) => Name = name;
}*/
