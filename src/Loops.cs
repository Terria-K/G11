using System;

class Program 
{
    static void Main(string[] args) 
    {
        for (int i = 0; i < 5; i++) 
        {
            Console.WriteLine(i);
        }

        int x = 0;
        while (x != 5) 
        {
            if (x % 2 == 0) 
            {
                Console.WriteLine("X is an even number: " + x);
            }
            else 
            {
                Console.WriteLine("X is an odd number: " + x);
            }

            x++;
        }

        // TODO Combine it with switch statements
    }
}