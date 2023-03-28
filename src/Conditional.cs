using System;

class Program 
{
    static void Main(string[] args) 
    {
        int x = 10;
        if (x > 5) 
        {
            Console.WriteLine("X is greater than 5");
        }
        else 
        {
            Console.WriteLine("X is less than 5");
        }

        bool lessThan = x < 5;
        if (lessThan) 
        {
            Console.WriteLine("X is less than 5");
        }
        else 
        {
            Console.WriteLine("X is greater than 5");
        }

        //TODO Grading system
    }
}