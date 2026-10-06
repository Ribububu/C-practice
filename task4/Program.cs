using System;

class Program
{
    static void Main()
    {
        // Create an integer array containing 5 favorite numbers
        int[] numbers = { 7, 3, 9, 1, 5 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        // Print each element using a for loop
        Console.WriteLine("Numbers in descending order:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of a specific number
        int numberToFind = 5;
        int position = Array.IndexOf(numbers, numberToFind);

        // Print the position of the number
        Console.WriteLine($"Position of {numberToFind}: {position}");
    }
}