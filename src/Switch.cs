using System;

class Program 
{
    static void Main(string[] args) 
    {
        int x = 2;
        switch (x) 
        {
            case 0:
                Console.WriteLine("Value is Zero");
                break;
            case 1:
                Console.WriteLine("Value is One");
                break;
            case 2:
                Console.WriteLine("Value is Two");
                break;
            case 3:
                Console.WriteLine("Value is Three");
                break;
            default:
                Console.WriteLine("Fallback to default");
                break;
        }

        // Match with names
    }
}