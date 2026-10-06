using System;

class Program
{
    static void Main(string[] args)
    {
        // ---- Part 1: Create a DateTime for your birthdate ----
        // Format: new DateTime(year, month, day)  OR  (year, month, day, hour, minute, second)
        DateTime birthDate = new DateTime(2000, 5, 15);  // Replace with your actual birthdate
        // Example with time: new DateTime(2000, 5, 15, 8, 30, 0);

        // ---- Part 2: Create a DateTime for the current date and time ----
        DateTime currentDate = DateTime.Now;   // Local time
        // Alternative: DateTime.UtcNow;        // Coordinated Universal Time

        // ---- Part 3: Calculate age using TimeSpan ----
        TimeSpan ageSpan = currentDate - birthDate;

        // Convert the total days to years (approximate, since a year is not exactly 365.25 days)
        // A more precise age calculation accounts for whether the birthday has occurred this year.
        int ageInYears = currentDate.Year - birthDate.Year;
        if (currentDate < birthDate.AddYears(ageInYears))
        {
            ageInYears--;  // Birthday hasn't occurred yet this year
        }

        // ---- Part 4: Print birthdate, current date, and age ----
        Console.WriteLine("========== Date Information ==========");
        Console.WriteLine($"Birthdate        : {birthDate:dddd, MMMM dd, yyyy}");
        Console.WriteLine($"Current Date/Time: {currentDate:dddd, MMMM dd, yyyy hh:mm:ss tt}");
        Console.WriteLine();
        Console.WriteLine("========== Age Breakdown (via TimeSpan) ==========");
        Console.WriteLine($"Total Days since birth   : {ageSpan.TotalDays:N0} days");
        Console.WriteLine($"Total Hours since birth  : {ageSpan.TotalHours:N0} hours");
        Console.WriteLine($"Total Minutes since birth: {ageSpan.TotalMinutes:N0} minutes");
        Console.WriteLine();
        Console.WriteLine($"Full age as TimeSpan     : {ageSpan.Days} days, " +
                          $"{ageSpan.Hours} hours, {ageSpan.Minutes} minutes (component view)");
        Console.WriteLine($"Age in years (precise)   : {ageInYears} years");
        Console.WriteLine($"Age in years (approx.)   : {ageSpan.TotalDays / 365.25:F2} years");

        // ---- Part 5: Add 10 days to birthdate and print the result ----
        DateTime birthdatePlus10 = birthDate.AddDays(10);

        Console.WriteLine();
        Console.WriteLine("========== Birthdate + 10 Days ==========");
        Console.WriteLine($"Original birthdate  : {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"After adding 10 days: {birthdatePlus10:yyyy-MM-dd}");
        Console.WriteLine($"(also shown as      : {birthdatePlus10:dddd, MMMM dd, yyyy})");
    }
}