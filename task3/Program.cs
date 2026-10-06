using System;

class Program
{
    static void Main(string[] args)
    {
        // ---- Part 1: Declare and initialize variables of various types ----
        byte    byteValue    = 255;              // 8-bit unsigned integer (0 to 255)
        short   shortValue   = -32000;           // 16-bit signed integer
        int     intValue     = 2_000_000;        // 32-bit signed integer
        long    longValue    = 9_000_000_000L;   // 64-bit signed integer (note the L suffix)
        float   floatValue   = 3.14f;            // 32-bit floating-point (note the f suffix)
        double  doubleValue  = 3.14159265359;    // 64-bit floating-point
        decimal decimalValue = 19.99m;           // 128-bit high-precision decimal (note the m suffix)
        char    charValue    = 'A';              // Single 16-bit Unicode character
        bool    boolValue    = true;             // Boolean (true/false)

        // ---- Part 2: Convert integer 42 to a string ----
        int numberToConvert = 42;
        string numberAsString = numberToConvert.ToString();   // Using .ToString()

        // ---- Part 3: Convert string "3.14" to a double ----
        string piString = "3.14";
        double piAsDouble = Convert.ToDouble(piString);       // Using Convert.ToDouble()
        // Alternative: double piAsDouble = double.Parse(piString);
        // Safer alternative: double.TryParse(piString, out double piAsDouble);

        // ---- Part 4: Print all variables with labels ----
        Console.WriteLine("========== Data Types ==========");
        Console.WriteLine($"byte    value : {byteValue}       (Type: {byteValue.GetType()})");
        Console.WriteLine($"short   value : {shortValue}    (Type: {shortValue.GetType()})");
        Console.WriteLine($"int     value : {intValue}   (Type: {intValue.GetType()})");
        Console.WriteLine($"long    value : {longValue}  (Type: {longValue.GetType()})");
        Console.WriteLine($"float   value : {floatValue}        (Type: {floatValue.GetType()})");
        Console.WriteLine($"double  value : {doubleValue} (Type: {doubleValue.GetType()})");
        Console.WriteLine($"decimal value : {decimalValue}        (Type: {decimalValue.GetType()})");
        Console.WriteLine($"char    value : {charValue}          (Type: {charValue.GetType()})");
        Console.WriteLine($"bool    value : {boolValue}        (Type: {boolValue.GetType()})");

        Console.WriteLine("\n========== Type Conversions ==========");
        Console.WriteLine($"Converted 42 (int) to string     : \"{numberAsString}\"  (Type: {numberAsString.GetType()})");
        Console.WriteLine($"Converted \"3.14\" (string) to double: {piAsDouble}  (Type: {piAsDouble.GetType()})");
    }
}