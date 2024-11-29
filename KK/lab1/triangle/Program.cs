using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] sides = input.Split(' ');

        if (sides.Length != 3)
        {
            Console.WriteLine("Неизвествая ошибка");
            return;
        }

        double a, b, c;
        if (!double.TryParse(sides[0], out a) || !double.TryParse(sides[1], out b) || !double.TryParse(sides[2], out c))
        {
            Console.WriteLine("Неизвествая ошибка");
            return;
        }

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Треугольник равносторонний.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Треугольник равнобедренный.");
            }
            else
            {
                Console.WriteLine("Треугольник обычный.");
            }
        }
        else
        {
            Console.WriteLine("Не треугольник.");
        }
    }
}
