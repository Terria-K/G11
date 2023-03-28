# Workflow


## Plan
+ About Programming
+ About C#
+ Hello World
+ Variables and Data Type
+ Operators
+ Input/Output operation
+ Conditional Statements
+ Switches
+ For/While loops
+ Switch
+ Arrays
+ Methods
+ Object Oriented-Programming
+ + Classes
+ + Inheritance
+ + Interfaces

## About Programming


## About C#
C# (C-Sharp) is a programming language developed by Microsoft that runs on .NET Runtime. C# is used to create a number of different programs and application including: desktop app with WinForms, web app with Blazor, mobile app with Xamarin, and video games with Unity or MonoGame.

It's a general purpose programming languages, and support multiple paradigms. It is known to have a strong relationship to Object Oriented Programming and is also known to be criticized as a copy of Java.

## Hello World
To create your first C# Program, you will need to have a .NET SDK installed on your machine and your preferred environment such as Visual Studio, Visual Studio Code, Rider, etc. Most environment have a C# installed already.

If you have it installed, you can now open your command line and type `dotnet new --console` to create your first console application. (If you are using an environment such as Visual Studio or Rider, you do not need to do this step as it can create a project for you).

**Your first Hello World program**

+ There is two ways to create your Hello World program in C#, one of which without the class, and one with the class. We are going to use with the class as this method also shows how C# syntax works.

```csharp
using System;

namespace HelloWorld;

class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Hello World!");
    }
}
```
+ The `namespace` is used to organize your code, and it is more like a container of the classes. The Program is contained in the `namespace` HelloWorld. The curly braces `{}` marks the beginning and the end of our code block. And `class` is a structure of a data, and it also contains with a method that brings a functionality of a program. Our default program entry point is always a `Main` static method.
+ We used `Console.WriteLine` to output Hello World which is under the `System` namespace. A `System` namespace is a part of a standard library of C# which contains a set of classes and methods to help provide your needs to build your application. 



## Variables and Data Type
Variables represent a storage locations. Every variable has a type determines what values can be stored in the variable. In C#, there are different types of variables, `int`, `float`, `char`, `string`, `bool` and ten more data types. (A total of 15 data types).

- `int` or integer stores numeric values without decimals, such as 100, 30.
- `float` or floating point stores numeric values with decimals point and a letter `f` at the end, such as 3.14f, 20f, 1.5f
- `char` or character stores a single character value, such as 'a' or 'b'. Char values are surrounded by a single quote;
- `string` stores multiple characters in a single text, such as "Hello World". String values are surrounded by a double quotes;
- `bool` or boolean stores conditional values, which is true or false.

To declare a variable, you must specify the type, followed by name and value. The equal sign is used to assign a values to the variable.

```csharp
type variableName = value;

// Example
int x = 42;
int y = 30;
Console.WriteLine(x + y); // 72
```

Another examples which includes all of the data types.
```csharp
int x = 2;
float y = 0.5f;
char c = 'c';
string h = "Hey World!";
bool b = true;
```

## Operators
Operators are used to perform operations on a variables and values. There are 4 types of operators.

### Arithmetic Operators
Arithmetic operators are used to perform a mathemetical operations. Which of it are addition, substraction, multiplication, division, modulos and increment, decrement operators. 

+ Addition: Adds one value from another.
+ Substraction: Substracts one value from another.
+ Multiply: Multiplies a value.
+ Division: Divide a value.
+ Modulos: Returns a remainder from a division.
+ Increment: Increases the variable value by 1.
+ Decrement: Decreases the variable value by 1.

```csharp
int add = 5 + 5; // 10
int sub = 10 - 5; // 5
int mul = 2 * 4; // 8
int div = 8 / 2; // 4
int mod = 6 % 4; // 2

// Increment Decrement
int x = 1;
int y = 1;
int inc = x++; // 2
int dec = y--; // 0
```

### Assignment Operators
Assignment operators are used to assign values to variables. It is a shorthand for assigning a values with arithmetic operators.

```csharp
int add = 10;
add += 5; // 15
add -= 5; // 10
add *= 5; // 50
add /= 5; // 10
add %= 5; // 0
```

### Comparison Operators
Comparison operators are used to compare two values, returning true or false value, This is frequently used when using a conditional statements. There are six comparison operators available. 

- Equal to (==)
- Not Equal (!=)
- Greater than (>)
- Less than (<)
- Greater than or equal to (>=)
- Less than or equal to (<=)

```csharp
int x = 10;
int y = 15;
Console.WriteLine(x > 5); // False
Console.WriteLine(x < 5); // True
```

### Logical Operators
Logical operators are used to determine the logic between variables and values. This can be mixed with comparison operators as it only accepts true or false value.

```csharp
bool tr = 5 < 10 && 5 == 5; // true
bool fl = 5 > 10 && 5 == 5; // false
int x = 5;
int y = 2;
bool x = x > y || x == y; // true
bool negate = !tr; // false
```

## Input/Output Operation
You have already learned about outputting "Hello World" using `Console.WriteLine()` method. Now we will provide an input then we output the result. 

To get the input, we will use the method called `Console.ReadLine()` and type any text in the input based on the prompt you want to give to the input, the common example to that is getting a name, and age.

```csharp
// Output the prompt you want to give in the user.
Console.WriteLine("Enter your name: ");
// Create a string variable, then the value should be the input of the user.
string name = Console.ReadLine();
// Print the result. 
Console.WriteLine("Name is: " + name);
```

## Conditional Statements
A conditional statement used to compare values and tell the program to execute the action depending on whether a condition is true or false.
It can be used in variety of ways for example, checking if the value is greater, less than or equal, or for validating an email and password.

If-Else statements helps you to compare a value and execute a specific block. 
+ If statement will check if the condition is true and execute the block beneath it, 
+ Else statement check if the previous If statement is false and execute the block beneath it.
+ Else-If Statement check if the previous If statement is false, check if the condition is true, and execute the block beneath it.
```csharp 
if (x > 0) 
{
    Console.WriteLine("x is greater than 0");
}
else if (x == 5) 
{
    Console.WriteLine("x is equal to 5");
}
else 
{
    Console.WriteLine("x is less than 0");
}
```

## Switches
If you want to just match a lot of values, there is an alternatives to if-else statements. Introducing the `switch` statement. Use `switch` statement to select one of the cases to be executed. The way how it works is the value of the expression is compared with the values of each `case`. If there is a match in the `case`, the associated code is executed. And `break` to stop the `switch` statement.

```csharp
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
```


## For and While Loops
```csharp
Console.WriteLine("Counting 1 to 10");
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine(i);
}
int i;
while (i < 5) 
{
    Console.WriteLine(i);
    i++;
}
```

## Arrays
```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 }; 
int[] fixedNumbers = new int[4] { 0, 1, 2, 3 };
Console.WriteLine(numbers[3]) // 4
```

## Methods
```csharp
float Slope(float x1, float x2, float y1, float y2) 
{
    var x = x2 - x1;
    var y = y2 - y1;
    return y / x;
}

int Add(int x, int y) 
{
    return x + y;
}

float Add(float x, float y) 
{
    return x + y;
}

void RunSlope() 
{
    var slope = Slope(2, 4.5f, 10, 20);
    Console.WriteLine(slope);
}
```

## Object Oriented Programming

### Declaring Class
```csharp
class Point 
{
    public int x;
    public int y;
}

var point = new Point();
point.x = 10;
point.y = 20;
```

## Access Modifiers
```csharp
class Point 
{
    private int x;
    private int y;

    public Point(int x, int y) 
    {
        this.x = x;
        this.y = y;
    }
}

var point = new Point();
point.x = 20; // ERROR
```

## Inheritance
```csharp
class Animal 
{
    public string Name;
    public int Age;

    public Animal(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    public void Eat() 
    {
        Console.WriteLine(Name + " ate some food");
    } 
}

class Dog : Animal 
{
    public Dog(string name, int age) : base(name, age) {}

    public void Bite() 
    {
        Console.WriteLine("Bite!");
    }
}

class Cat : Animal 
{
    public Cat(string name, int age) : base(name, age) {}

    public void Claws() 
    {
        Console.WriteLine("Cat shows their claws");
    }
}

var dog = new Dog("Puppy", 3);
var cat = new Cat("Kitty", 1);

dog.Bite();
cat.Claws();

dog.Eat();
cat.Eat();
```

## Interfaces
```csharp
public interface IJump 
{
    void Jump(float heights);
}

public interface IRun
{
    void Run(float speed);
}

public interface ISwim
{
    void Swim();
}

class Dog : Animal, ISwim, IRun
{
    public Dog(string name, int age) : base(name, age) {}

    public void Bite() 
    {
        Console.WriteLine("Bite!");
    }
    
    public void Run(float speed) 
    {
        Console.WriteLine(Name + " run as fast as " + speed + " m speed");
    }

    public void Swim() 
    {
        Console.WriteLine(Name + " Swim in the water");
    }
} 

class Cat : Animal, IRun, IJump
{
    public Cat(string name, int age) : base(name, age) {}

    public void Claws() 
    {
        Console.WriteLine("Cat shows their claws");
    }

    public void Run(float speed) 
    {
        Console.WriteLine(Name + " run as fast as " + speed + " m speed");
    }

    public void Jump(float heights) 
    {
        Console.WriteLine(Name + " Jumps as high as " + heights + "ft");
    }
}
```