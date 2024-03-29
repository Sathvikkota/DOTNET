using System;
class Program
{
    public static int[,] InsertDiagonals(int[,] matrix)
    {
        int n = matrix.GetLength(0); // Get the matrix dimension (assuming square)
        int[,] result = new int[n, n]; // Create a new matrix to store the result

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < i) // Elements to the left of the diagonal
                {
                    result[i, j] = 0;
                }
                else if (j > i) // Elements to the right of the diagonal
                {
                    result[i, j] = 1;
                }
                else // Main diagonal (copy original element)
                {
                    result[i, j] = matrix[i, j];
                }
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[,] matrix = { { 2, 4, 3, 3 }, { 5, 7, 8, 5 }, { 2, 4, 3, 3 }, { 5, 7, 8, 5 } };
        int[,] modifiedMatrix = InsertDiagonals(matrix);

        // Print the original and modified matrices
        Console.WriteLine("Original matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nModified matrix:");
        for (int i = 0; i < modifiedMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < modifiedMatrix.GetLength(1); j++)
            {
                Console.Write(modifiedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}






















/*using System;
class Program{
    static int CalculateDistance(int[] nums){
        int maxValue = nums[0];int firstIndex = 0;int lastIndex = 0;
        for (int i = 1; i < nums.Length; i++){
            if (nums[i] > maxValue){
                maxValue = nums[i];firstIndex = i;
            }else if (nums[i] == maxValue){
                lastIndex = i;
            }}int distance = Math.Abs(lastIndex - firstIndex);
        return distance;
    }static void Main(string[] args){
        Console.WriteLine("Enter integers separated by spaces:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int[] nums = Array.ConvertAll(inputArray, int.Parse);
        Console.WriteLine("Result: " + CalculateDistance(nums));
    }
}*/
























/*using System;
class Program{
    public int[] Swap(int[] nums){
        for (int i = 0; i < nums.Length / 2; i++){
            if (nums[i] % 2 == 0 && nums[nums.Length - 1 - i] % 2 == 0){
                int temp = nums[i];
                nums[i] = nums[nums.Length - 1 - i];
                nums[nums.Length - 1 - i] = temp;
            }
        }return nums;
    }static void Main(string[] args){
        Console.WriteLine("Enter comma-separated integers (e.g., 10, 5, 3, 4): ");
        string userInput = Console.ReadLine();
        int[] nums = Array.ConvertAll(userInput.Split(','), int.Parse);
        Program swapper = new Program();
        int[] result = swapper.Swap(nums);
        Console.WriteLine("Swapped array: [{0}]", string.Join(", ", result));
    }
 }*/

























/*class Program{
    static int FibonacciSum(int n){
        int a = 0, b = 1, sum = 0;
        for (int i = 0; i < n; i++){
            sum += a;
            int temp = a + b;
            a = b;
            b = temp;
        }return sum;
    }
    static void Main(string[] args){
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result = {FibonacciSum(n)}");
    }
}*/




















/*using System;
class Program{
    static int CountOnesInBinary(int n){
        int count = 0;
        while (n > 0){
            if (n % 2 == 1)
            {
                count++;
            }
            n /= 2;
        }return count;
    }
    static void Main(string[] args){
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Result = {CountOnesInBinary(n)}");
    }
}
*/

/*using System;
class Program { 
    static int SumOfOddDigits(int n){
        int sum = 0;
        while (n > 0){
            int digit = n % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            n /= 10;
        }return sum;
    }
    static void Main(string[] args){
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result = {SumOfOddDigits(n)}");
    }
}
*/