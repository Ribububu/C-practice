using System;

class Circle
{
    // Declaring a constant variable PI and initializing it with 3.14
    public const double PI = 3.14;

    // Method to calculate the area of a circle: Area = π * r²
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    // Method to calculate the perimeter (circumference): Perimeter = 2 * π * r
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}




class Program
{
    static void Main(string[] args)
    {
        // ---- Part 1: Attempting to modify PI (causes compilation error) ----
        // Uncomment the following line to observe the compilation error:
        // Circle.PI = 3.14159;

        /*
         * COMPILATION ERROR EXPLANATION:
         * 
         * Error: CS0131 - The left-hand side of an assignment must be a variable, 
         *        property or indexer.
         * (or) CS0191 - A readonly field cannot be assigned to 
         *        (except in a constructor or a variable initializer).
         * 
         * Reason:
         * The keyword `const` makes a variable a compile-time constant. Its value 
         * is fixed at compilation and stored directly in the assembly metadata. 
         * The C# compiler replaces every usage of `PI` with the literal value 3.14 
         * at compile time, so there is no variable to assign a new value to.
         * 
         * Additionally, `const` fields are implicitly `static`, so they belong to 
         * the class itself (accessed as `Circle.PI`), not to an instance. Since 
         * constants cannot be changed after compilation, any attempt to assign 
         * a new value to them produces a compile-time error, preventing the 
         * program from building at all.
         * 
         * If we needed a value that could be changed (but only via a constructor 
         * or initializer), we would use the `readonly` keyword instead. However, 
         * `readonly` values can still be changed at runtime inside constructors.
         */

        // ---- Part 2: Testing the Circle class ----
        Circle myCircle = new Circle();

        double radius = 5.0;

        double area = myCircle.CalculateArea(radius);
        double perimeter = myCircle.CalculatePerimeter(radius);

        Console.WriteLine($"Radius of the circle: {radius}");
        Console.WriteLine($"Value of PI (constant): {Circle.PI}");
        Console.WriteLine($"Area of the circle: {area}");
        Console.WriteLine($"Perimeter (circumference) of the circle: {perimeter}");
    }
}