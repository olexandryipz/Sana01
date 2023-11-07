using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення d: ");
        double d = Convert.ToDouble(Console.ReadLine());

        double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2)) / (Math.Pow(b, 2));
        double y = (5 * (a + b) * (c - d)) / ((1.0) / (2) * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
        double z = (((Math.Pow(x, 2) - 2 * x) / (x * x)) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
        double r = ((1.0) / (2) * a + (3.0) / (4) * b - (7.0) / (5)) / (3 * c + 1) + (1) / (a - c);

        Console.WriteLine("Значення x: " + x);
        Console.WriteLine("Значення y: " + y);
        Console.WriteLine("Значення z: " + z);
        Console.WriteLine("Значення r: " + r);
    }
}