using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ============================================================
        // PART 1: List<string> — Favorite Fruits
        // ============================================================

        // Create a List<string> with 3 favorite fruits
        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };

        Console.WriteLine("========== Initial Fruit List ==========");
        PrintFruits(fruits);

        // Add a new fruit to the list
        fruits.Add("Strawberry");
        Console.WriteLine("\n========== After Adding \"Strawberry\" ==========");
        PrintFruits(fruits);

        // Remove one fruit from the list
        fruits.Remove("Banana");                 // Remove by value
        // Alternative: fruits.RemoveAt(0);      // Remove by index
        Console.WriteLine("\n========== After Removing \"Banana\" ==========");
        PrintFruits(fruits);

        // Print all fruits using a foreach loop
        Console.WriteLine("\n========== Printing Fruits with foreach ==========");
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"- {fruit}");
        }

        // ============================================================
        // PART 2: Dictionary<int, string> — Fruit IDs → Fruit Names
        // ============================================================

        // Create a Dictionary where the key is an int (fruit ID) and the value is a string
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

        // Add a new entry to the dictionary
        fruitDictionary.Add(4, "Strawberry");
        // Alternatively: fruitDictionary[4] = "Strawberry";

        // Print all key-value pairs
        Console.WriteLine("\n========== Dictionary Contents (foreach KeyValuePair) ==========");
        foreach (KeyValuePair<int, string> entry in fruitDictionary)
        {
            Console.WriteLine($"ID: {entry.Key} → Fruit: {entry.Value}");
        }

        // Print using keys only (alternative approach)
        Console.WriteLine("\n========== Dictionary Contents (foreach Keys) ==========");
        foreach (int key in fruitDictionary.Keys)
        {
            Console.WriteLine($"ID: {key} → Fruit: {fruitDictionary[key]}");
        }

        // ============================================================
        // BONUS: Useful Dictionary & List operations
        // ============================================================
        Console.WriteLine("\n========== Bonus: Lookup & Contains ==========");

        // Look up a value by key (with TryGetValue for safety)
        if (fruitDictionary.TryGetValue(2, out string foundFruit))
        {
            Console.WriteLine($"Fruit with ID 2 is: {foundFruit}");
        }

        // Check if a key exists
        Console.WriteLine($"Contains key 5? {fruitDictionary.ContainsKey(5)}");

        // Check if a value exists
        Console.WriteLine($"Contains value \"Apple\"? {fruitDictionary.ContainsValue("Apple")}");

        // List count
        Console.WriteLine($"Number of fruits in list: {fruits.Count}");
        Console.WriteLine($"Number of entries in dictionary: {fruitDictionary.Count}");
    }

    // Helper method: print list items with index
    static void PrintFruits(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"[{i}] {list[i]}");
        }
    }
}