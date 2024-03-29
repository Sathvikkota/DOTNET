using System;
public class Calculator{
    public static double PerformOperation(double a, double b, Func<double, double, double> operation){
        return operation(a, b);
    }
    static void Main(string[] args){
        Console.WriteLine("Welcome to the Calculator!");
        while (true){
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Square Root");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 6)
                break;
            double result = 0;
            switch (choice){
                case 1:
                    Console.Write("Enter first number: ");
                    double add1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double add2 = Convert.ToDouble(Console.ReadLine());
                    result = PerformOperation(add1, add2, (a, b) => a + b);
                    break;
                case 2:
                    Console.Write("Enter first number: ");
                    double sub1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double sub2 = Convert.ToDouble(Console.ReadLine());
                    result = PerformOperation(sub1, sub2, (a, b) => a - b);
                    break;
                case 3:
                    Console.Write("Enter first number: ");
                    double mul1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double mul2 = Convert.ToDouble(Console.ReadLine());
                    result = PerformOperation(mul1, mul2, (a, b) => a * b);
                    break;
                case 4:
                    Console.Write("Enter dividend: ");
                    double div1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter divisor: ");
                    double div2 = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        result = PerformOperation(div1, div2, (a, b) => a / b);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    break;
                case 5:
                    Console.Write("Enter a number: ");
                    double sqrt = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        result = PerformOperation(sqrt, 0, (a, b) => Math.Sqrt(a));
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}


































/*using System;
using System.Collections.Generic;
using System.Linq;

public class MaximumPermutation
{
    public static int FindMaximumPermutation(int n)
    {
        string strNum = n.ToString();
        List<string> permutations = GeneratePermutations(strNum);
        int maxPerm = permutations.Max(p => int.Parse(p));
        return maxPerm;
    }

    public static List<string> GeneratePermutations(string str)
    {
        List<string> result = new List<string>();
        if (str.Length == 1)
        {
            result.Add(str);
            return result;
        }

        for (int i = 0; i < str.Length; i++)
        {
            char currentChar = str[i];
            string remainingChars = str.Remove(i, 1);
            List<string> permutations = GeneratePermutations(remainingChars);

            foreach (string permutation in permutations)
            {
                result.Add(currentChar + permutation);
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a three-digit positive integer:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 100 || n > 999)
        {
            Console.WriteLine("Invalid input. Please enter a three-digit positive integer.");
        }
        else
        {
            int result = FindMaximumPermutation(n);
            Console.WriteLine($"Result: {result}");
        }
    }
}*/



/*using System;

public class NumberValueCalculator
{
    public static int CalculateValue(int n)
    {
        if (n > 0)
        {
            return n * n; // squared number
        }
        else if (n < 0)
        {
            return Math.Abs(n); // modulus of a number
        }
        else
        {
            return 0; // zero
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateValue(n);
        Console.WriteLine($"Result: {result}");
    }
}*/


/*using System;

public class SimpleCalculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");

        Console.Write("First number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum: {Add(num1, num2)}");
        Console.WriteLine($"Difference: {Subtract(num1, num2)}");
    }
}
*/