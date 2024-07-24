using System;

class Program
{
    static void Main()
    {
        int fahrenheit = 94;
        decimal temperature = ((fahrenheit - 32) * 5m / 9);
        Console.WriteLine("The temperature is " + temperature + " degree celcius");  // Output: The temperature is 34.4444444444444 degree celcius

        int fahrenheit2 = 100;
        decimal temperature2 = ((fahrenheit2 - 32) * 5m / 9);
        Console.WriteLine("The temperature is " + temperature2 + " degree celcius");  // Output: The temperature is 37.7777777777778 degree celcius

        int fahrenheit3 = 80;
        decimal temperature3 = ((fahrenheit3 - 32) * 5m / 9);
        Console.WriteLine("The temperature is " + temperature3 + " degree celcius");  // Output: The temperature is 26.6666666666667 degree celcius

        int fahrenheit4 = 110;
        decimal temperature4 = ((fahrenheit4 - 32) * 5m / 9);
        Console.WriteLine("The temperature is " + temperature4 + " degree celcius");  // Output: The temperature is 43.3333333333333 degree celcius

        int fahrenheit5 = 94;
        decimal temperature5 = ((fahrenheit5 - 32m) * 5m / 9m);
        Console.WriteLine("The temperature is " + Math.Round(temperature5) + " degree celcius");  // Output: The temperature is 34 degree celcius

        int fahrenheit6 = 100;
        decimal temperature6 = ((fahrenheit6 - 32m) * 5m / 9m);
        Console.WriteLine("The temperature is " + Math.Round(temperature6) + " degree celcius");  // Output: The temperature is 38 degree celcius

        int fahrenheit7 = 80;
        decimal temperature7 = ((fahrenheit7 - 32m) * 5m / 9m);
        Console.WriteLine("The temperature is " + Math.Round(temperature7) + " degree celcius");  // Output: The temperature is 27 degree celcius

        int fahrenheit8 = 110;
        decimal temperature8 = ((fahrenheit8 - 32m) * 5m / 9m);
        Console.WriteLine("The temperature is " + Math.Round(temperature8) + " degree Celsius");  // Output: The temperature is 43 degree Celsius
    }
}