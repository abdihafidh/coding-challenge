using System;

class Program
{
    static void Main()
    {
        // Array Reverse and Sort
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("Original array:");
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }

        Console.WriteLine("Sorted....");
        Array.Sort(pallets);
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }

        Console.WriteLine("Reverse....");
        Array.Reverse(pallets);
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }

        // Add values to the array
        Array.Resize(ref pallets, pallets.Length + 2);
        pallets[pallets.Length - 2] = "A15";
        pallets[pallets.Length - 1] = "B16";

        Console.WriteLine("Array after adding values:");
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }

        // Array Clear
        Console.WriteLine("\nArray Clear:");
        string[] pallets2 = { "B14", "A11", "B12", "A13" };
        Console.WriteLine($"Before: {pallets2[0].ToLower()}");
        Array.Clear(pallets2, 0, 2);
        Console.WriteLine($"After: {(pallets2[0] != null ? pallets2[0].ToLower() : "null")}");
        Console.WriteLine($"Clearing 2... count: {pallets2.Length}");
        foreach (var pallet in pallets2)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}