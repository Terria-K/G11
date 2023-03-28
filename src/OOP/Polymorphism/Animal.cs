using System;

class Animal 
{
    public virtual void MakeSound() 
    {
        Console.WriteLine("An animal make a sound");
    }
}

class Dog : Animal 
{
    // TODO Override the MakeSound method
    // TODO Make a dog sound
}

class Cat : Animal 
{
    // TODO Override the MakeSound method
    // TODO Make a cat sound
}