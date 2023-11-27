using System;

// Step 1: Declare the generic delegate
delegate T Operation<T>(T a, T b);

class Program
{
    // Step 2: Implement static methods for generic arithmetic operations
    static T Add<T>(T a, T b)
    {
        return (dynamic)a + b;
    }

    static T Subtract<T>(T a, T b)
    {
        return (dynamic)a - b;
    }

    static T Multiply<T>(T a, T b)
    {
        return (dynamic)a * b;
    }

    static T Divide<T>(T a, T b)
    {
        if (b.Equals(0))
        {
            Console.WriteLine("Cannot divide by zero.");
            return default(T);
        }
        return (dynamic)a / b;
    }

    static void Main(string[] args)
    {
        // Step 3: Create instances of the generic delegate for each method with appropriate type arguments
        Operation<int> addDelegate = new Operation<int>(Add);
        Operation<int> subtractDelegate = new Operation<int>(Subtract);
        Operation<int> multiplyDelegate = new Operation<int>(Multiply);
        Operation<int> divideDelegate = new Operation<int>(Divide);

        // Step 4: Ask the user to input two values of the same data type
        Console.Write("Enter the first value: ");
        int value1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second value: ");
        int value2 = Convert.ToInt32(Console.ReadLine());

        // Step 5: Prompt the user to choose an operation
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        // Step 6: Based on the user's choice, call the corresponding method through the generic delegate and display the result
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        int result = 0;

        switch (choice)
        {
            case 1:
                result = addDelegate(value1, value2);
                Console.WriteLine($"Result of Addition: {result}");
                break;
            case 2:
                result = subtractDelegate(value1, value2);
                Console.WriteLine($"Result of Subtraction: {result}");
                break;
            case 3:
                result = multiplyDelegate(value1, value2);
                Console.WriteLine($"Result of Multiplication: {result}");
                break;
            case 4:
                result = divideDelegate(value1, value2);
                Console.WriteLine($"Result of Division: {result}");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
