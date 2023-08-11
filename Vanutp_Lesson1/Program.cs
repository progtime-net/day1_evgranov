using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Привет, как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}");

        Console.WriteLine("Введите ваш возраст");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Ваш возраст через 10 лет: {age + 10}");
    }
}