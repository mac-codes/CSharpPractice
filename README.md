# C# Basics
The primary job of the compiler is to convert code into an executable format that the computer can understand.

`dotnet new console` makes a basic C# application in VS code.
## The Compiler
The primary job of the compiler is to convert code into an executable format that the computer can understand.

## Object Oriented Programming
The four basic principles of OOP are:
 * *Abstraction*: Modeling the relevent attributes and interactions of entities as classes to define an abstract representation of a system.
 * *Encapsulation*: Hiding  the internal state and functionallity of an object and only allowing access through a public set of functions
* *Inheritance*: Ability to create new abstractions based on existing abstractions.
* *Polymorphism*: Ability to implement inherited properties or methods in different way across multiple abstractions
## Classes
A class is a blueprint or template that defines the structure and behavior of objects. it encapsulates both the attributes (properties) and the behavio (methods) that objects of that class with possess. Classses provide a consistent way to create objects with a ccommon set of attributes and behaviors
```csharp
// class: car
public class Car
{
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}
// class: motorcycle
public class Motorcycle
{
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}
```
### Objects
An object is a concrete instance created from a class, embodying the attributes and behaviors defined by that class. Objects are the **building blocks** of OOP, representing real world entities, or data structures withing the program.
```csharp
car myCar = new Car();
Motorcycle MyMoto = new Motorcycle();
```
### Properties
Also known as `*attributes*` or `*fields*`, are data memebers of a class that store information about the objects state. Each object created from a class has its own set of property values. Properties define the characteristics that distinguish one objects from another.
```csharp
// Class: Vehicle
public class Vehicle
{
    // Properties
    public string Type { get; set; }   // Car, Motorcycle, etc.
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}
```
### Methods
Methods are `*functions*` defined within a class that enables objects to perform actions of exhibit behaviors. They represent the operations that objects of the class can carry out. Meethods encapsulate the logic associated with an objects behavior and allow controlled access to the objects internal state.
```csharp
public class Car
{
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }
}
```
## Variables
To declare a variable, first select a data type and then give it a name. Example: `int number = 7;`

### Variable Data Types and Nullable Types:
* `STRING`: for words, phrases, or any alphanumeric data for presentation (not data)
* `CHAR`: for a single alphanumeric character
* `INT`: for a whole number
* `DECIMAL`: for a number with a fractional component (one number has to be a decimal for a decimal output)
* `BOOL`: for a true/false value
* `VAR`: This keyword tells the compiler to infer the data type of the variable based on the value it is initialized to. Use data types when possible.
* `NULLABLE TYPES`: Used when you need to reprsent a value that is regular or special value. add a **?** symbol after the data type. best to use when reading user entered values.
```csharp
int? nullableNumber = null;
```

To retrieve a variable, you just have to call the variable name.

## Expessions and Operators
An expression is any combination of values, variables, operators, and function calls that can be evaluated to produce a single value. Expressions are fundemental to performing calculations, making decisions, manipulating data, and communicating with computers through user input and output.

### Operators
Operators are symbols or keywords used to perform operations on one or more operands (variables, values, expressions)
* **Math Operations**: `+`, `-`,`*`,`.`,`%`
* **Compound Assignment Operators**: `+=`,`-+`,`*=`,`++`,`--`
* **Comparison Operators**: `<=`, `>=`, `<`, `>`
### Operator Procedence and Associativity
Operator precedence defines the order in which operators are evaluated when an expression contains multiple operators. Some operators have *higher* precedence than others, and they are evaluated first.

* `Assocativity` determines the order in which operators of the same precedence are evaluated. Operators can be left- associative (evaluated from left) or right-associative.
* You can use *Parenthesis* to control the order of evaluation.
```csharp
int result = 10 + 5 * 2
```
1. Evaluate `5 * 2` which is `10`
2. add `10` to `10` which is `20`
```csharp
int result = (10 + 5) * 2
```
1. Evaluate `10 + 5` which is `15`
2. multiply `15` to `2` which is `30`

## Order of Operations
Remember the acronym PEMDAS:

* Parentheses (whatever is inside is performed first)
* Exponents
* Multiplication and Division
* Addition and Subtraction
Note: There is no exponent operator. Use `System.Math.Pow` for exponents.

## Literal Strings & Escape sequences
Use character escape sequences when you need to insert a special character into a  literal string, such as:

* TAB: `\t`
* NEW LINE: `\n`
* DOUBLE QUOTES: `\"`
* BACKSLASH: `\\`
* UNICODE: `\u` (may not print correctly depending on the application)
The `@` directive creates a verbatim string literal that keeps all whitespace formatting and backslash characters in the string.

## Execution Environment
When using the terminal in Visual Studio Code:

* Click on the `.csproj` file
* Run your code there

## State Definition
As your code executes line by line, values are stored in variables. At any moment during execution, the current state of the application is the collection of all values stored in memory.

### Variable Name Rules
* variable names can contain alphanumeric characters and the underscore character
    * `#`, `-`, `$` ,and other special characters not allowed
* Must begin with an alphanumeric letter or an underscore
* Must NOT be a C# keyword
* Names are case sensitive `string myValue` and `string MyVaule` are different things.
* use **camelCase** for variable names.

## Evaluating Expressions  (BOOLEAN)
* There are many different types of expressions that evaluate to either `true` or `false`.
* Evaluate equality using the `==` operator.
* Evaluate inequality using `!=` operator
* strings may have different case. or leading/trailing spaces. use the `ToLower()`, `ToUpper()` and `Trim` helper methods to improve the likelyhood that they are equal. 
* Use comparison operators.
* If a method returns a **Bool*, it can be used as a boolean expression

### Logical Negation
Logical negation is a fundemental  concept in programming that involves inverting the truth value of a boolean expression. in other words it changes `true` to `false` and the other way around.

#### `!` (NOT) Operator
the `!` (not) operator is used to perform logical negation on a boolean expression. it evaluated the expression and returns the opposite boolean value.
```csharp
bool isTrue = true;
bool isFalse = false;

bool negatedTrue = !isTrue; // Evaluates to false
bool negatedFalse = !isFalse; // Evaluates to true
```
### De Morgan's Laws
#### De Morgan's Laws for  *AND* Operator:
1. Negation of an ***AND*** is the same as the ***OR*** of negations:
    `!(A && B)` is equivelant to `!A || !B`.
#### De Morgan's Laws for  *OR* Operator:
2. Negation of an ***OR*** is the same as the ***AND*** negations:
    `!(A || B)` is equivelant to `!A && !B`.

### Condional Operator
use the conditional operator when you need to return a value thats based on a binary condition. Your code with return the first option when the condition evaluates to true, and the second option when the coditon is true. 
```csharp
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
```
## Functions and Methods

# Functions
Functions and methods are essential components of C# programming, allowing you to break down complex tasks into smaller, reusable units of code.

## Function Basics
In C#, a function is a block of code that performs a specific taks and can be called from other parts of the program. Functions are defined using the following syntax:
```csharp
returnType functionName(parameters)
{
    // Code to be executed
    // Optionally, return a value of returnType
}
```
* **returnType**: The data type of the value that the function returns. Use `void` if the function does not return any value
* **functionName**: The name of the function, which is used to call it from other parts of the code.
* **parameters**: The input values that the function can recieve. These are optional and can be one or more, seperated by commas.

## Calling Functions
To call a function simply use its name followed by parentheses and any required arguments:
```csharp
returnType result = functionName(arg1, arg2, ...);
```
* **returnType**: If the function returns a value, you can store it in a variable of the corresponding data type.
* **arg1, arg2,...**: The actual values passed as arguments to the function.

### Example:
```csharp
int Add(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}
```

## Overloaded Method
An overloaded method is defined with multiple method signatures.

# Methods
in C#, methods are functions that belong to a class or object. They define the behavior of objects and allow you to perform actions related to the class.

## Method Basics
Methods are defined inside a class and can access class-level variables and properties. The syntax for defining a method is similar to that of a function.
```csharp
accessModifier returnType methodName(parameters)
{
    // Code to be executed
    // Optionally, return a value of returnType
}
```
* **accessModifer**: Specifies the visibility or accessability of the method (e.g., **public**, **Private**, **Protected**).
* **returnType**: The data type of the value that the method returns. Use `void` if the method does not return any value.
* **methodName**: The name of the method, which is used to call it on objects of the class.
* **parameters**: The input values that the method can recieve. These are optional and can be one or more seperated by commas.

## Stateless/Static Methods
Stateless/Static methods are implemented so that they can work without referencing or changing any values already stored in memory.

## Stateful Methods
Stateful methods are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed.

## Void Method
Void methods do not return a value when finished.

## Calling Methods
To call a method, you need an instance of the class (an object) on which the method will be invoked:
```csharp
className obj = new className();
returnType result = ibj.methodName(arg1, arg2, ...);
```
* **className**: The name of the class that defines the method.
* **obj**: an instance of the class (object) on which the method will be called.

To call methods:
* Start by typing the class name, e.g., `Console`
* Add the member access operator: `.`
* Add the method name, e.g., `WriteLine`
* Add the method invocation operator: `()`
* Specify the argument that is passed to the method
### Example:
```csharp
public class Calculator
{
    public int Add(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }
}
```

## The NEW Operator
The `NEW` operator requests an area big enough in the computer to store a random object. It creates that new object in memory and then returns the memory address so it can be stored in the new object.

## Parameter vs. Argument
Often times, the terms 'parameter' and 'argument' are used interchangeably. However, 'parameter' refers to the variable that's being used inside the method. An 'argument' is the value that's passed when the method is called.

# Array Basics
an array is a sequence of individual data elements accessible through a single variable name. use name of the array to access the array elements 

### Array variable Declaration
> datatype[] variablename = new datatype[size]; 

### Accessing Array Elements
You can access individual elements of an array using square brackets and the index position.
> int firstElement = numbers[0];
> numbers[0] = 42

### Array Length
> in length = numbers.Length
Arrays are a powerful tool for storing and manipulating collections of data in a structured manner. They are widely used in programming to handle lists, matrices, and more.
# Statements
## If Statement
The `if` statement allows you to specify a condition and execute a block of code only if the condition evaluates to true.

```csharp
if (condition)
{
    // Code to be executed if the condition is true
}
```
* The condition is a boolean expression that determines whether the code block should be executed.
* If the condition evaluates to true, the code block is executed; otherwise, it is skipped.
* You can use comparison operators (e.g., `==`, `!=`, `<`, `>`) and logical operators (e.g., `&&`, `||`) to build complex conditions.
* It's important to ensure that the condition inside the `if` statement evaluates to a boolean value (`true` or `false`).

## If Else Satement
The `if-else` statement is an extension of the `if` statement that allows you to specify an alternative block of code to execute when the condition is false.
``` csharp
if (condition)
{
    // Code to be executed if the condition is true
}
else
{
    // Code to be executed if the condition is false
}
```
* The `else` block is optional and provides an alternative code path when the condition in the if statement evaluates to false.
* If the condition is true, the code block inside the `if` statement is executed; otherwise, the code block inside the `else` statement is executed.
* You can nest multiple `if-else` statements to handle more complex conditions and alternative scenarios.

# Loops
## For Loops
> **THREE PARTS THAT CONTROL HOW IT IMPLEMENTS ITERATIONS**

**purpose**: The for loop is a programming construct used for repetitive execution of a block of code. it allows you to perform a series of action over a range of values or a specific number of times.
```csharp
for (initialization; condition; iterator)
{
    // Code to be executed in each iteration
}
```
    * **Initialization**: This step is executed only once at the beginning. it invovles setting up the initial values of variables  that will control the loops behavior.
    * **Condition**: The condition is evaluated before each iteration. if it evaluates to true, the code block within the loop is executed. If its false, the loop terminstes and program control moves to the next statement after the loop.
    * **Iterator**: After each iteration, the iterator step is executed. It's responsible for updating the loop variables, typically incrementing or decrementing them.
* **Controlled Iteration**: The for loop provides a controlled a structured way to iterate. it helps you avoid writing repetitive code and makes it easier to manage and understand the flow of you program.
* *Usage Examples*:
    * Iterating over a range of numbers:
    ```csharp
    for ((init)int i = 1;(cond) i <= 10;(iter) 1++)
    {
        /Code to be executed with i ranging from 1 to 10
    }
    ```
    * Iterating over an array or collection:
    ```csharp
    for (int i = 0; i < array.length; i++)
    {
        Code to be executed for each element of the array
    }
    ```
#### TIPS
*  Ensure your initialization, condition, and iterator are correctly set to avoid infinite loops or premature termination.
* use loop variables (e.g., `i` in examples above) to control iteration or perform specific operations within the loop.

## ForEach Loop
```csharp
foreach (var item in collection)
{
    // Code to be executed for each item in the collection
}
```
* The `foreach` loop iterates over each element in the collection and executes the specified code block for each item.
* It automatically handles the iteration process, eliminating the need for an explicit index or managing the loop control variables.
* The `var` keyword is used to implicitly type the loop variable `item`, allowing it to adapt to the type of elements in the collection.
* You can perform any desired operations on each element within the loop block.
## Nested Loop
* The practice of using one loop inside another loop. for each iteration of the outer loop, the inner loops goes through its full cycle.
```csharp
for (outerInitialization; outerCondition; outerIteration)
{
    // Code or operations to be executed before the inner loop

    for (innerInitialization; innerCondition; innerIteration)
    {
        // Code or operations to be executed inside the inner loop
    }

    // Code or operations to be executed after the inner loop
}
```
* `outerInitialization`: This is where you set the initial value of the variable used in the outer loop.
*  `outerCondition`: The outer loop will continue running as long as this condition is true. 
    * if the condition is false before the outerloop is executed, the loop will be skipped entirely.
* `outerIteration`: After each iteration of the outer loop this part is executed, typically used to update the value of the variable used in the outerloop
*  `innerInitialization`: Inside the outer loop, this is where you set the initial value of the variable used in the inner loop.
* `innerCondition`: the inner loop will continue running as long as this condition is true. if the condition evaluated to false, the inner loop will be skipped.
* `innerIteration`: After each iteration of the inner loop,, this part is executed, typically used to update the variable used in the inner loop.

>The flow of execution is such that the outer loop runs once, then the inner loop runs its full cycle. After that, the outer loop continues with its next iteration, and the inner loop runs again, and so on. This pattern repeats until the outer loop's condition becomes false, at which point the entire nested loop structure terminates.

# Iteration
```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```
## For Iteration
* The `for` iteration statement allows you to iterate through a block of code a specific number of times.
* the `for` iteration statement allows you to control every aspect of the iteration mechanics by altering the three conditions inside the parenthesis: The **initializer**, **condition**, and **iterator**.
* It's common to use the `for` statment when you need to control how you want to iterate through each item in the array.
* If the code block had only one line of code, you can eliminate the curly braces and white space if you wish.
### Six parts of a For statement

1. The `for` keyword.
2. A set of `parenthesis` that defines the conditions of for iteration. The parentheses contain **three distinct parts**, separated by the end of statement operator, a semi-colon.
3. INITIALIZER:The **first part** defines and initializes the iterator variable. In this example: `int i = 0`.
4. CONDITION: The **second part** defines the completion condition. In this example: `i < 10`. In other words, the runtime will continue to iterate over the code in the code block below the for statement while `i` is less than `10`. When `i` becomes equal to `10`, the runtime stops executing the for statement's code block. 
5. ITERATOR: The **third part** defines the action to take after each iteration. In this case, after each iteration, `i++` will increment the value of `i` by 1.
6. BODY: **Finally**, the code block. The code block contains the code that will be executed for each iteration. Notice that the value of `i` is referenced inside of the code block.

## While Loops
While loops allows a block of code to be executed repeatedly as long as a specific condition remains true. 
```csharp
while (condition)
{
    // Code to be executed as long as the condition is true
    // The code here will be repeated in each iteration of the loop
}

```
* While loops are particularly useful when you want to repeat an operation an unknown number of times until a certain condition is met. Sice the loop continues to execute as long as the condition is true, you need to ensure that conditions will eventually become false. otherwise its an **indefinite loop**
## Do-While Loops
The `do-while` and `while` statements are yet another iteration statement that allows you to iterate through a code block and thereby change the flow of execution of the code. 
```csharp
do
{
    // Code block to be executed repeatedly.
} while (condition);
```
* The flow of execution starts inside of the curly brace. The code executes at least one time, then the **Boolean** expression next to the `while` keyword is executed. if the **Bool** expression return true, the code is executed again
* the code block of a `do-while` loop while execute at least once. it could iterate a large number of times, and it is inlikley we know ahead of time how many iterations there will be.
* The **continue** key word will transfer control to the end of the code block and the while loop will evaluate.
## Scope
* Scope defines the visibility and accessibility of variables and code blocks in a program.
* variables declared within a code block are typically only accessible within that block.
* Variables declared outside of the block have broader visibility
### Local Scope
* variables declared *within a code block* have local scope
* They are accessible only within that block and its nested blocks.
### Global Scope
* Variables declared outside of any code block have a global scope.
* They are accessible anywhere in the program.
### Variable Visibility
* The visibility of a variable depends on its scope
* Local variables prioritize their own blocks scope.
### Using Statements
* The `using` statement can apply to an entire code file.
* its an exception to the local scope rule.
### Variable Initialization
* Variables set within a code blovk should be initialized within that block
*initializing variables ensures valid values a present before usage.
### Controlling Scope
* Defining variables outside of specific blocks increases their scope
* Scope control is cruicial for managing variables visibiliy and lifetime
### Scope Hierarchy
* Nested blocks inherit variables from their containing blocks
* Outer blocks can't access variables from their nested blocks
### Initialization
* initialize variables before using them to avoid potential errors
* Uninitialized variables can lead to unexpected behavior due to scope. 
### Best Practices
* Keep variable scope as narrow as possible for better code organization
* Limit global scope to avoid inintended side effects


## Code Blocks
A code block is one or more C# statements that define an execution path. the statements outside of the code block affect when, if, and how often that block of code is executed at run time. 

### Difference between *DO* and *WHILE*
* `for`: executes it body while a specified Boolean expression evaluates to true.
* `foreach`: enumerates the elements of a collection and executes its body for each elements of the collection.
* `do-while`: conditionally  executes its body one or more times.
* `while`: conditionally executes its body zero or more times.

## Code Readability
When implimenting an `if` statement that includes a single-statement code block:
* Always use meaningful variable and function names
* properly indent code
* Break down complex operations into smaller well names functions or methods.
* Never use single-line form
* If you realize you have only one line of code listed within the code blocks of an **if-elseif-else** statement, you can remove the curly braces of the code block and white space. 
* Only remove the curly braces of a code block when it makes the code more readable. It's always acceptable to include curly braces.
* Only remove the line feed if it makes the code more readable. Microsoft suggests that your code will be more readable when each statement is placed on its own code line.
 
## Switch Statements
Switch statements provide an efficient way to handle multiple conditions based on the value of a single variable.

Best used when:
* You have a single value that you want to match against many possible values.
* For any given match, you need to execute a couple of lines of code at most.
```csharp
switch (input)
{
    case "hello":
        Console.WriteLine("You entered `hello`");
        break;
    case "world":
        Console.WriteLine("You entered `world");
        break;
    case var when (input.Length > 5):
}
```
* The `switch` statements checks the value of the variable against different cases and executes the code block associated with the matching case.
    * a single switch section can have multiple case labels.
* Each case should end in a `break` statement to exit the switch block. Without `break`, the execution with "fall through" to the next case.
* The `default` case is optional and is executed when none of the cases match the variable. 
* It's good practice to use a `default` case to handle unexpected or edge cases.
* Case patterns are boolean expressions that evaluate to either true or false.
* The `break` keyword tells the runtime to stop evaluating and prevents execution of other cases in the switch construct.

# Basic HTML
Hypertext Markup Language is the foundation of web development. It structures content on the web.
### Head
The `<head>` section of an HTML document contains meta-information and resources that aren't directly displayed in the browser window. meant to provide data about the documents and intructions to browsers and search engines
#### Meta Tags
Meta Tags within the `<head>` section provide metadata about the HTML document. this metadata includes information life the character encoding, author, description, and keywords.
#### Linking external resourcs
in the `<head>` section, you can link external resources such as CSS files and scripts. Enhancing presentation and functionality of the web page. the `<link>` tag is used to CSS and `<script>` tag is used for scripts.
### Metadata
metadata in the context of HTML refers to data that provides information about the document itself. Including details like authors name, creation data, and character encoding. important for SEO and accesibility.
### title
The `<title>` element, placed within the `<head>` section, is used to define the title of the HTML document. Displayed on the top of the browser window or tab when the webpage is loaded. utilized in search enginesas the main title.
### Semantic HTML
these elements go beyond basic formatting and provide context to both the browser and developers.
1. `<header>`: introdcutory content of a webpage or a section. it often includes the logo, site title and navigation.
2. `<nav>`: defines a section of navigation links. placing your navigation menu itesm within a nav element helps readers identify and differentiate navigation. and the search engine recognized these links as important site structures.
3. `<main>`: Encapsulates the primary content of the webpage. usually the central area the holds the most important content. 
4. `<article>`: used to mark a standalone piece of content that can be used to distrubute and reused independently.
5. `<section>`: represents a thematic grouping of content. Help organize the content into logical blocks. You can also you the `<article>` element.
6. `<footer>`: Typically contains info about the author, copyright, contact info, and links to related pages.
7. `<aside>`: Used to mark content that is tangentially related to the main content. It can include sidebars, advertisements, or  other content that supports the primarty content.
### Accesibility and SEO Benfits
* **Accessibility**: Screen readers and other assitstive technologies rely on semantic elements to provide accurate and meaningful information to users with disaplities By using these elements correctly, you improve the overall accessibility of the website.
* **SEO**: Search engines use semantic elements to better understand the structure and hierarchy of the content. Properly structured content can improve the websites search engine ranking and visibility.
* **Maintainability**: Semantic HTML enhances readability and maintainabillity of the code. using elements to convety meaning makes it easier for other developers to understand the purpose of different sections.

# Basic CSS
###
