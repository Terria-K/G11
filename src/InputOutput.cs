using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = "";
        name = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Enter your age: ");
        int age = 30;
        age =  int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Your Name: " + name);
        Console.WriteLine("Your Age: " + age);

        // TODO Create a simple calculator using input and operators
    }
}