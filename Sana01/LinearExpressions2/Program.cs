using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть значення m: ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            double y = 2.4 * (Math.Abs((x * x + b) / a)) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + Math.Pow(10, -2) * (x - b);

            Console.WriteLine("Значення z1: " + z1);
            Console.WriteLine("Значення z2: " + z2);
            Console.WriteLine("Значення y: " + y);
        }
    }