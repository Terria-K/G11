using System;

class Program 
{
    static void Main(string[] args) 
    {
        int x = Add(5, 5);
        Console.WriteLine(x);

        x = Substract(4, 2);
        Console.WriteLine(x);

        // TODO make a slope function
        // TODO store all of this into a function
    }

    static int Add(int x, int y) 
    {
        return x + y;
    }

    static int Substract(int x, int y) 
    {
        return x - y;
    }
}