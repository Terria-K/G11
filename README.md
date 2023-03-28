# Workflow


## Plan
+ [About Programming](#about-programming)
+ [About C#](#about-c)
+ [Hello World](#hello-world)
+ [Variables and Data Type](#variables-and-data-type)
+ + [Inferred Type](#inferred-type)
+ [Operators](#operators)
+ [Input/Output operation](#inputoutput-operation)
+ [Conditional Statements](#conditional-statements)
+ [Switches](#switches)
+ [For and While loops](#for-and-while-loops)
+ [Switch](#switches)
+ [Arrays](#arrays)
+ [Methods](#methods)
+ [Object Oriented-Programming](#object-oriented-programming)
+ + [Classes and Objects](#classes-and-objects)
+ + [Inheritance](#inheritance)
+ + [Encapsulation](#encapsulation)
+ + + [Access Modifiers](#access-modifiers)
+ + + [Getters and Setters](#getters-and-setters)
+ + [Polymorphism](#polymorphism)
+ + + [Interfaces](#inheritance)

## About Programming
**What is programming?**

Programming is the process of performing a particular computation for telling a computer to perform a task in order to solve a problem. It involves using a programming language to create instructions that a computer can understand and execute.

Programming can be used to create a wide range of applications, from a simple command-line utilities to a complex web applications and video games. It is an essential skill in industries, including technology, finance, healthcare, and entertainment. 

Learning to program requires a combination of technical skills and problem-solving ability. Programmers must be able to break down complex problems into smaller, manageable pieces and develop algorithms, and software design principles, as well as familiarity with programming languages and development tools.


## About C#
C# (C-Sharp) is a programming language developed by Microsoft in 2000 by Anders Hejlsberg. It is now running on the .NET Runtime. C# is used to create a number of different programs and application including: desktop app with WinForms, web app with Blazor, mobile app with Xamarin, and video games with Unity or MonoGame.

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
```

For example
```csharp
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

### Inferred Type
Inferred type or implicit type is a type that determined the type of a value at compile-time based on the expression used to initialize it. For instance, the `var` keyword is used to declare variables with inferred types. 

For example, instead of explicitly declaring variable type, we can use the `var` instead:
```csharp
var greeting = "Hello World";
```
It's equivalent into this code:
```csharp
string greeting = "Hello World";
```
Inferred type can make the code shorter and easier to read, however, it's important to use them carefully, as they can also make the code harder to understand. It's worth noting that while `var` can be used to declare local variables, it cannot be used for method parameters, return types or class fields. In those cases, the type must be explicitly specified.

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

If-Else statements helps you to compare a value and execute a specific block. Logical and Comparison operators can be used for conditions. 
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
Loops can execute a block of code repeatedly. Loops are usually handled with the condition to be able to stop the execution when the condition is reached to prevent a slight logical errors such as infinite loops. Loops are handy because it saves you a lot of time to write code, and make code more readable. There are two ways to declare a loop, one that uses a `while` loop, and the other uses a `for` loop. These two has a syntax differences, but they are technically the same. While `while` loops has only 1 statement and accepts only a condition, `for` loops has three statements and can define a value, a range condition on when the loop will going to stop, and increment the value that the for loop defined after the execution.

```csharp
int i;
while (i < 5) 
{
    i++;
    Console.WriteLine(i);
}
```
There is also a `do` statement for `while` loop which will be executed before the condition and the loop started.
```csharp
int i;
do 
{
    Console.WriteLine(i);
    i++;
}
while (i < 5);
```

```csharp
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine(i);
}

```

## Arrays
Array is a data structure which can store a collection of elements of a same type, which can be accessed by an index. In C#, the indexing starts in zero, which means you always start counting at zero instead of one.

To create an array, you need to specify the type with a square brackets indicating it's an array of this type, followed by the name and values enclosed with a bracket.
```csharp
int[] numbers = { 1, 2, 3, 4, 5, 6 }; 
```
To access an element of an array, you use the index of the element in square brackets after the name of the array.
```csharp
int element = numbers[2]; // 3
```
To assign the value of a third element, you can also change the value of an element with square bracket after the name of an array.
```csharp
numbers[2] = 5;
Console.WriteLine(numbers[2]) // 5
```

To loop an array in `for` loop, you specify the length of an array to the range.
```csharp
for (int i = 0; i < numbers.Length; i++) 
{
    int element = numbers[i];
    Console.WriteLine(element);
}
```

## Methods
A method or a function is a block of code that contains a series of statements and is designed to perform a specific task. Think of it as a reusable code, you can call it multiple times in your code, and pass a parameters if a method accepts a specific parameters.

To declare a method, you use the following syntax:
```csharp
access_modifier return_type method_name(parameter_list) 
{
    // Method Body
}
```
+ Access Modifier: is a visibility of a method. Common access modifier include `public`, `private`, `protected`, and `internal`. We will get back to this later.
+ Return Type: is a data type that the returns to. It's more like an output to the method after and it is likely to appear at the end of statement. If the method does not need to return any value, the return type must use `void`.
+ Method Name: is a name of a method.
+ Parameter List: is a list of inputs to the method. Parameters are separated by commas and are formed with `type name`. If a method does not take any parameters, leave it empty.
+ Method Body: contains the statements that are executed when the method is called.


```csharp
int Add(int x, int y) 
{
    return x + y;
}
```

To call a method, use the following syntax:
```csharp
float m = Add(2, 4);
```
The following result is 6.

The methods can be overloaded with an another type. Depending on the type, the method will be called with a correct type from a parameters.
```csharp
int Add(int x, int y) 
{
    return x + y;
}

float Add(float x, float y) 
{
    return x + y;
}
```
```csharp
int x = Add(2, 1);
float y = Add(4.5f, 2.5f);
```

# Object-Oriented Programming
Object-Oriented Programming (OOP) is a programming paradigm that emphasizes the use of objects, which are instances of a classes, to represent and manipulate data. C# is a strongly-typed object-oriented language that supports many of the key features of OOP. 

## Classes and Objects
What are classes and objects? Classes and objects are the two main aspects of Object-Oriented programming. An objectis an instance of a class, and it contains both data and behaviour. 

To create a class, use the `class` keyword to define the class followed by the name you decide. Optionally, you can put a access modifier before the `class`.

```csharp
class MyClass 
{
    // members
}
```

You can also declare a field inside of a class which are a variables that is part of a class itself, methods which can be called inside and outside of a class, and properties, we will get back to this later. 

```csharp
class Point 
{
    public int x;
    public int y;

    int AddTogether() 
    {
        return x + y;
    }
}
```

To create an object, you use the `new` keyword and call the constructor of the class.
```csharp
Point point = new Point();
```
This creates a new instance of a `Point` class and assigns it to the variable named `point`.

To change how constructor is defined inside of a class, you just write the constructor inside of a class like how you define a method but without the return type, the name must matched the name of the class. For example:
```csharp
class Point 
{
    public int x;
    public int y;
    Point(int x, int y) 
    {
        this.x = x;
        this.y = y;
    } 
    // ...
}
```
The `this` keyword refers to the current instance of this class. It's optional to put it before accessing the variable. It can be used to prevent name collision from a parameter.


## Encapsulation
Encapsulation is the process of hiding the implementation details of a class from the outside world. 

### Access Modifiers

Encapsulation is achieved through the use of access modifiers, such as `public`, `private`, `protected`, and `internal`, which controls the visibility of members of a class.

+ `public`: Public members are accessible from outside of the class, and inside of the class.
+ `private`: Private members are only accessible inside of the class, but not the other way around.
+ `protected`: Protected members are only accessible inside of the class, and a class extending this class, we will get to that later.
+ `internal`: Internal members are only accessible only in one project.

For example:
```csharp
public class Person 
{
    private string name;
    private int Age;

    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;
    }
}
```
This class is accessible everywhere in the code, it has one field that is `private`.
If you tried to access the `name` variable, you will get an error, saying that it's inaccessible to the outside of this class.
```csharp
Person person = new Person("John", 15);
person.name = "Kowalski"; // Error
```
But what if we still need to change the value of a name while still keeping it as `private`?

### Getters and Setters
Getters and Setters are methods used in object-oriented programming to access and modify the values of private class fields from outside of a class.

Getters are method that allows access to the value of a private field and Setters are method that allows to modify the value of a private field from outside of a class.
```csharp
public class Person 
{
    private string name;
    private int Age;

    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;
    }

    public string GetName() 
    {
        return name;
    }

    public void SetName(string value) 
    {
        name = value;
    }

    public string GetAge() 
    {
        return age;
    }
}
```
```csharp
Person person = new Person("John", 15);
person.SetName("Kowalski"); // Error
```
Getters and Setters are useful because they provide a controlled way to access and modify the state of an object. By making fields private, we can ensure that they can only be access or modified through the appropriate methods, which can help prevent bugs and maintain the integrity of the object's state. For instance, you can have a customized way of accessing the value or modifying the value, such as validation.

## Inheritance
Inheritance is the process of extending an existing class by creating a new one. Inheritance is achieved using the `:` symbol.

```csharp
public class Student : Person 
{
    private int id;

    public int GetID() 
    {
        return id;
    }

    public void SetID(int id) 
    {
        this.id = id;
    }
}
```
In this example, the `Student` class extends from the `Person` class, which means that it has access to all the `public` and `protected` members of the `Person` class. 

```csharp
Student student = new Student();
student.SetID(2014241);
student.SetName("Mikey");
```

## Polymorphism
Polymorphism is the ability of objects to take multiple forms. It is related to inheritance, however it doesn't mean it's always inheriting, but it rather may be implementing. Polymorphism can be achieved through the use of `virtual` and `abstract` methods, as well as interfaces. Virtual methods can be overriden by derived classes, while abstract methods must be implemented by derived classes.
```csharp
class Animal 
{
    public virtual void MakeSound() 
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) {}

    public void Bite() 
    {
        Console.WriteLine("Bite!");
    }

    public override void MakeSound() 
    {
        Console.WriteLine("The dog barks!");
    }
} 

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) {}

    public void Claws() 
    {
        Console.WriteLine("Cat shows their claws");
    }

    public override void MakeSound() 
    {
        Console.WriteLine("The cat meows!");
    }
}
```
If we declare and use the objects with these classes, we get a different output from a different class, even if they are derived from the same class.

```csharp
Dog dog = new Dog();
Cat cat = new Cat();
dog.MakeSound();
cat.MakeSound();

TakeAnimal(cat);

void TakeAnimal(Animal animal) 
{
    // Take an animal
}
```

We see that the `TakeAnimal()` method accepts only an `Animal` type as a parameter, but we can still pass a variable that is a type of `Cat`. That is because `Cat` is derived from a class `Animal`, that is why we can use it as an input of this method.

### Interfaces
Interfaces is a blueprint for a set of methods that a class can implement. Interfaces are declared using `interface`, followed by the name and a set of method. Methods inside of an `interface` should be empty, although the default implementation is still allowed.
```csharp
interface IShape 
{
    float GetArea();
}
```
To implement an interface, a class must provide implementations for all the methods. For example, here is a class that implements the `IShape` interface.
```csharp
using System;

class Circle : IShape 
{
    private float radius;
    public Circle(float radius) 
    {
        this.radius = radius;
    }

    public float GetArea() 
    {
        return Math.PI * radius * radius;
    }
}
```
```csharp
IShape shape = new Circle(5);
float area = shape.GetArea();
Console.WriteLine("Area: " + area); // Output: Area: 78.5398163397448
```
Like inheritance, implementation can also be used with Polymorphism which you can also passed the class that implements an interface into the method that accepts the interface that the class implements to.