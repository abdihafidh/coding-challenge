using System;

class Program
{
    static void Main()
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 101);
        int roll2 = dice.Next(1, 101);
        int roll3 = dice.Next(50, 101);
        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");

        int roll4 = dice.Next(1, 101);
        int roll5 = dice.Next(1, 101);
        int roll6 = dice.Next(50, 101);
        Console.WriteLine($"Fourth roll: {roll4}");
        Console.WriteLine($"Fifth roll: {roll5}");
        Console.WriteLine($"Sixth roll: {roll6}");

        int roll7 = dice.Next(1, 101);
        int roll8 = dice.Next(1, 101);
        int roll9 = dice.Next(50, 101);
        Console.WriteLine($"Seventh roll: {roll7}");
        Console.WriteLine($"Eighth roll: {roll8}");
        Console.WriteLine($"Ninth roll: {roll9}");

        int roll10 = dice.Next(1, 101);
        int roll11 = dice.Next(1, 101);
        int roll12 = dice.Next(50, 101);
        Console.WriteLine($"Tenth roll: {roll10}");
        Console.WriteLine($"Eleventh roll: {roll11}");
        Console.WriteLine($"Twelfth roll: {roll12}");
    }
}