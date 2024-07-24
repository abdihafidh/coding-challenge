using System;

class Program
{
    static void Main()
    {
        int value = 1;
        value = value + 1;
        Console.WriteLine("First Increment:" + value);  // Output: First Increment:2
        value += 1;
        Console.WriteLine("Second Increment:" + value);  // Output: Second Increment:3
        value++;
        Console.WriteLine("Third Increment :" + value);  // Output: Third Increment :4
        value = value - 1;
        Console.WriteLine("First Decrement:" + value);  // Output: First Decrement:3
        value -= 1;
        Console.WriteLine("Second Decrement:" + value);  // Output: Second Decrement:2
        value--;
        Console.WriteLine("Third Decrement:" + value);  // Output: Third Decrement:1

        value = value + 5;
        Console.WriteLine("Adding 5:" + value);  // Output: Adding 5:6
        value += 2;
        Console.WriteLine("Adding 2:" + value);  // Output: Adding 2:8
        value = value * 2;
        Console.WriteLine("Multiplying by 2:" + value);  // Output: Multiplying by 2:16
        value /= 2;
        Console.WriteLine("Dividing by 2:" + value);  // Output: Dividing by 2:8
        value -= 3;
        Console.WriteLine("Subtracting 3:" + value);  // Output: Subtracting 3:5
    }
}