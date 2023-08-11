using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Привет, как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}"); 
    }
}