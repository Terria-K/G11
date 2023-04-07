# Introduction to Programming
## What is programming? 
It is the process of preparing an instructional program for a device. It is attempting to get a computer to complete its specific task without making mistakes.

Computers are only smart because we program them to be, which means what information we feed to our computer, they are only smart on that information.

Computers only understand **machine code**. A machine code is a series of 1's and 0's or so called a binary, fed and interpreted by the computer. This is the only way computer can read instructions.

It would be entirely unpractical to convert every programming instructions you written into binary by hand, but it is possible to do it with programming languages and a compiler.

## Programming Languages
Programming languages serve as a middle-man for translating your instruction into **machine code**, and it is very useful for programmers. This is easy to learn for humans to learn than **machine code**.

There are many programming languagues that serves different purposes, languages such as **C#, Java, and Python** are a general purposes languages, **C, C++, and Rust** designed for systems programming.

Each language also have a **power** or **level**, basically how similar it is to machine code, or are closer to the hardware. The lower the level, the more similar to machine code.

+ Low-Level programming languages
+ + **Assembly, or C**

+ High-Level programming langugaes
+ + **Java, C# or Python**

Each language has other minor differences, explore to find one which you like since there are thousands of programming languages, but most of them can accomplish similar task.

## How do we write code?
You cannot simply type words into a text document, and expecte that the computer is able to carry out a specific task you've written.

To properly send instructions to the computer, we need **programming languages**. But we also cannot type in a certain language and expect the same thing.

We use a **compiler** for a certain languages such as **C++, Java, or C#**, or an IDE (Integrated Development Environments) which contains tools such as **compilers**, and auto-completion that you would need to writing a code, building, and running the program.

**Compilers**
Compilers are a program that compiled our written code into bytecode or a machine code. 
+ A byte code is similar to machine code except it is specific to other languages, such as **Java, or C#**. It convert our code into a intermediate language that would also be translated into machine code later at runtime.

**IDEs**
IDEs are like any other program on your computer except it's used for the facilitation of code. IDEs has a graphical interface that helps programmers to build, run, and debug the code by just pressing a single button.
+ Examples (NetBeans, IntelliJ, Visual Studio)

In addition to a place to write, IDE's also include
+ Built in **Error-checking** for when the code is incorrect.
+ **Auto-completion** for automatically completing the word without having to write it manually.
+ Project hierarchy that helps you manage and organize your code.

// Images of how IDE looks like

## Syntaxes
Each language has its own set of rules, set of syntax you must follow. You cannot simply just type anything in the code, convert it to machine code and expect the computer to understand it. You need **syntax**.

Learning a programming language can be similar to learning a real language.
+ All programming languages have a **set of rules** you must follow when writing code. In other words, it is called **syntax**.
+ Similar to **grammar** in real life languages.

**What is a syntax?**

It is a rules you must follow if you want your program to run correctly. Syntax for each programming language is **different** and **unique**. Breaking programming language's rules will result into an compilation **error**, preventing you to build or run the program.

Example of initializing a variables in 3 different languages:

**Java**
In **Java**, we must specify the type of a variable we are defining, and must add a semicolon at the end of a line.
```java
int x = 10;
```

**Python**
In **Python**, we just type the name and what value is stored to, it doesn't need to know what type it is.
```python
x = 10
```

**JavaScript**
In **JavaScript**, it is similar to python, except we need to put **let** keyword if the value subject to change, or **const** if the value will never change. The semicolons are optional in **JavaScript**.
```javascript
let x = 10
```

As you can see in the examples, **syntax matters** when learning when learning a new language. The goal of the program was the same, but all three languages shown took a different approaches.

If you forgot to put one semicolon, or misplace a character, the entire program will not run or compile and send you back a **syntax error**.

Another cool thing about IDEs is that it will let you know if and when there are **syntax errors** in your code. Usually with underlined in red and it won't let your program to build or run until the program has been fixed.

// Show some image examples of what we're talking about

## How do we get Information or an output from computers?
**Console**, programmers keep track of their progress by looking at the console. It is a text interface within the computer that programmers can use for a variety of purposes, whether to output something on the screen, or to make a user input.

// Picture of a console application

The main use of the **console** is to output text from the **program** using **code**.

```python
print("Hello World")
```

// Picture of Hello World in console application

Print function is used for viewing and interpreting the computer's output from a program. 

Example, computing 4+3 will print nothing to the console.
// Some blank output on a console application

Example, computing 4+3 then **printing** it will print 7 to the **console**.
// 7 printed on the console

The print statement will vary depending on the language.

Example Java code for outputting a text to a console. 
```java
class Program {
    public static void main(String[] args) {
        System.out.print("Hi");
        System.out.println("Hello World");
    } 
}
```

Another example but with a Python code.
```python
print("Hi")
print("Hello World\n")
```

The console is mainly a **Developer Tool**, not usually meant to be used and interacted by the end user except in a **very abstract cases**.

## What can computer can do?
### Math
The computer already knows how to do **simple arithmetic**. You will be able to print the result of any math operation using the `print()` function. May seem useless, but comes in handy **extremely often**.

The simple arithmetic are:
+ Addition: `+`
+ Substraction: `-`
+ Multiplication: `*`
+ Division: `/`

In addition to **simple arithmetic**, most programming languages included an additional math operator known as **modulus**. **Modulus** allows us to get the **remainder** of a divisional operation, represented with **%**.

Example, if we take **10 modulus 3 (or 10 % 3)**, the computers will give us the division remainder of these operation. The following output of the program will be **1**.

```python
print(10 % 3)
```

Output:
```
Console: 1
```

In this case where there **isn't a remainder**, the computer will simply give us **0**.


This is extremely useful when determining if a number is **even or odd**.
If a number modulo 2 is 0, the number is **even**.
If a number modulo 2 is 1, the number is **odd**.


### Strings
Strings are another way of representing a **text**.
+ "Hello World"
+ "A"
+ **Anything enclosed by a quotation marks**.

Example usage for that when the game is over.

```mermaid
graph LR
A["Game Over, 4 was your final score"]
```
We could make it as a string as a exact phrase and print it out on the console.

```python
print("Game Over, 4 was your final score")
```
Great, but there is a problem on this code. We are not actually printing the actual score, but just printing a number `4` on it. To fix this, we can print our integer variable called `score` by joining our string with a number.

```python
score = 4
print("Game Over, " + score + " was your final score")
```
We can print multiple text by adding them or joining them together in a print function. It is also known as **concatenation**.

```
Console: Game over, 4 was your final score
```

We can also combine the previous example with math operation.

```python
print("Game Over, " + (score + 4) + " was your final score")
```

```
Console: Game over, 8 was your final score
```
Difference between "4" and 4:
+ 4 in quotation marks ("4") is treated as a **String**
+ 4 without quotation marks (4) is treated as an **Integer**

```
4 != "4"
```

## Variables
A variables is something that can store **information**, can be **referenced** and **modified**.

Each variable has a **type, a name, and a stored value** inside.

Many types of variables, but we will be focusing on common **data type variables**, which is **Integers, Booleans, Floats, Strings and Chars**.

+ Integer (int) - is a primitive type, can store numeric values, but it cannot store decimal values. It can hold from -2,147,483,648 to 2,147,483,648 number.
```
1, 4, 10, 342
```
+ Float (float) - is a primitive, floating point data type, can store numeric values, and can also store decimal values.
```
1.5f, 2, 13.5f
```
+ Boolean (bool) - is a primitive type, can only store a value of either **true** or **false**.
```java
true, false
```
+ String - is an another way of representing a **text**. Useful for displaying text and storing **input information**. Is also useful for outputting information in a readable format for the user.
```java
"Hello World", "Hi!", "Text"
```
+ Char (char) - is a primitive type, it stands as a **Character**. Each holds **one** character, enclosed with a **single-quotation** marks.
```java
'a', 'b', '#', 'c'
```

**Why variables are so useful?**
Often times you are going to want to keep track of things such as user's **name** or **score**. By creating a variable, you can store this information in that variable and then **reference**, **add too**, or **modify it**.

```mermaid
graph LR
A[Name] --> B["Mikey"]
C[Score] --> D[10]
```
Other important uses for variables is taking input from the user. Making your program have **variability**. Manipulating variables is necessary for many tasks in programming.

## How do we manipulate variables?
Everytime we define or creates a variable, a variable and the value is stored in memory. The variable is always referencing the value it holds, so that we can easily access the value.

In this table, we have Name and Age variable defined in the memory. 

Name | Age
-----|-------
"Mike" | 18

If we defined something else like Location variable, the computer will store it in memory.

```java
String Location = "Bulacan"
```

Name | Age   | Location
-----|-------|----------
"Mike" | 18  | "Bulacan"

In some cases, you may put the variable **without any information inside of it**, or also called as a `null` values. The reason to do this is if you want **to store information in the variable later**.

If you ever tried to **reference** a variable without a value, it will result a **runtime error** or an **exception**, in this case a **NullPointerException**.

```java
String value = null;
```
We may also have a variable that point to a variable to access a value that the variable is pointing to.
```mermaid
graph LR
A[userName] --> B[name]
C[employeeName] --> B
```

This doesn't also create a space in memory because we are just referencing another variable which has a value that already been created.

name | userName | employeeName
-----|----------|-------------
"Mike" | |

### Modify variables

**Variables are mutable** by default in most languages, it means we can modify or change any value that the variable holds for instance, if we want to change the value of the `score`, we simply just change it with a equal sign operator.

```java
int score = 10;
score = 10 + 10;
```
or better yet:
```java
int score = 10;
score += 10;
```

There are other ways to modify these values. Integer, and Float variable can be modify with any arithmetic operators. (Add, Subtract, Multiply, Divide, Modulo). String variable can be added or concatenated. 

### Naming variables
There is **one big rule** when naming variables, they must be continous and only contains one word. In this case, we cannot have a spaces when naming a variable.

```mermaid
graph LR
A[int player score = 20] --> B[Bad]
C[int playerScore = 20] --> D[Good]
E[int player_score = 20] --> D
```

After the code has out of scope, the variables are deleted in memory. Unless if you run that code once again which the variable will lived once again.


# Conditional Statements
Depending on the certain conditions, we want our code to do different things.

### If statement

The most basic conditional statement is the If statement. (If something is True, otherwise do something else.)

```mermaid
graph TD
A[If something is True] --> B[Do This]
A --> C[Do another thing]
```

Most programming languages uses **parenthesis ()**, to cover the conditions in If statement which will be evaluated as boolean which is **true** or **false**.

If the statement is true, the code block that under it will be executed, **else** the another code block will be executed, or just do nothing (if there is no **else**).

```java
if (thingIsTrue) {
    /* Do this line of code */
} 
/* Then run any code under this */
```

Example with a given variables:
```java
if (score > 5) {
    System.out.println("Good job! Nice score!");
}
```

### Else-if Statement
The Else-if statement will only be evaluated if the preceding if (or if-else) statement was evaluated, but returned as false.

```mermaid
graph TD
A["If (firstIsTrue)"] --> B[DoThis]
A --> C["Else If (secondIsAlsoTrue)"] --> D[DoThis]
A --> E["Else If (thirdIsAlsoTrue)"] --> F[DoThis]
```

```java
if (score < 10) {
    /* Do This */
} else if (score < 20) {
    /* Do This */
} else if (score < 40) {
    /* Do This */
} 
/* Then run any code under this */
```

Check the initial statement, if it's true, we run that block of code, if it's false, we move on to any else if statements and evaluate the conditions. If any of them are true, run that block of code and move on.


### Else Statement
The else statement comes after if/if-else statement and **will always** carry out instructions, if all previous cases are not true.

```mermaid
graph TD
A["If (thisIsTrue)"] --> B[Do This]
A --> C
C[Else] --> D[Do This instead]
```

```java
if (score < 10) {
    System.out.println("Nice score!");
} else if (score < 20) {
    System.out.println("Great Job!");
} else {
    System.out.println("Gamer!");
}
```

### Switch Statement
An easily collapsible way to write many if-else statements. You input a variable, then determine which **cases** that variable could be.

Unlike if-else statement, **switch** statement cannot evalute a condition, only constant values.

```mermaid
graph TD
A["Switch (var)"] --> B["Case (a)"]
A --> C["Case (b)"]
A --> D["Case(c)"]
```

```java
switch (var) {
    case a: 
        /* Do something */ 
        break;
    case b: 
        /* Do something */ 
        break;
    case c: 
        /* Do something */ 
        break;
    default:
        /* Default */
}
```
Case statements start with a colon (:), each switch statements also includes a "default" case (Else statement).

// Overview

### Why conditional statements are useful?
+ It adds a variability to programming.
+ If a user does something, we want to be able to **adapt** accordingly.
+ Without it, the program would run the same way.

## Arrays
Variables are very good at storing **singular bits of information**, but they are unable to hold **more than one** piece of data.

```mermaid
graph LR
A[Name] --> B["Mike"]
```

An array is a **list** of **something**, it can be Integers, Strings, or even an array. 

+ All information in an array is related.

+ Like columns in Excel or Google Sheets

// an image of an excel grocery list

An array is very useful when programmers wants to store a lot of information that can be easily to search through.

Example, if we have a Facebook-like program with 100,000 users. Every time a person wants to create a new username, we want to check to see if the account name has already been taken.

// Image of usernames

The **single most important thing to note about arrays** is **how we reference each element inside of them**.

Numbers | 1 | 2 | 3 | 4 | 5 | 6
----------|---|---|---|---|---|---
Index | 0 | 1 | 2 | 3 | 4 | 5

To reference each element inside of them, we use index, a numbers **"place"** in the array.

The array indexing starts at 0, that means to access the first element in the array, we use index 0, because the first element is placed at index 0.

It is weird and confusing, but this is the one that you have to memorize and commit to memory. If you slip up and accidentally reference the 6th index in this array, it will result in an **OutOfBoundsException**.


### Creating an array
To create an array, you insert the elements you would like in the array **immediately**. Or you create an array with a specific size, but choose to **add elements later**.

When we create array, their sizes are **FINAL**. It cannot **increased** or **decreased** in size through conventional methods. This is what allows us to easily access their indexes.

When initializing an array, you must determine its type and they all have to be the same type. Which means you cannot mix and matches the type of the array. As example of mix and match:

Username|
-------|
Sean
Mike
10
Isaac
True
False

Which are not allowed in the array.

### Multi-dimensional Arrays
Putting an **array inside an array** is known as 2 dimensional array, or multi-dimensional array.

Index | Names | | | | |
------| -------|--|--|--|--|
0| Alex | Arnold | Ael | Ash | Ariel
1| Bob | Ben | Billy | Boan | Baly
2| Clint | Carry | Cal | Colton | Crab

To index 2D arrays, we use 2 numbers. **First number** is the row, **second number** is the column.

Index | 0 | 1 | 2 | 3 | 4 |
------| -------|--|--|--|--|
0| Alex | Arnold | Ael | Ash | Ariel
1| Bob | Ben | Billy | Boan | Baly
2| Clint | Carry | Cal | Colton | Crab

```mermaid
graph LR
A[0, 2] --> B[Clint]
C[1, 1] --> D[Ben]
```

You can have more dimension to an array, but 2 dimensional array is fairly enough for programming.

## Loops