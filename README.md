# Code Basics
The primary job of the compiler is to convert code into an executable format that the computer can understand.

## Variables
* `STRING`: for words, phrases, or any alphanumeric data for presentation (not data)
* `CHAR`: for a single alphanumeric character
* `INT`: for a whole number
* `DECIMAL`: for a number with a fractional component (one number has to be a decimal for a decimal output)
* `BOOL`: for a true/false value

To declare a variable, first select a data type and then give it a name. Example: `int number = 7;`

To retrieve a variable, you just have to call the variable name.

* `VAR`: This keyword tells the compiler to infer the data type of the variable based on the value it is initialized to. Use data types when possible.
### Variable Name Rules
* variable names can contain alphanumeric characters and the underscore character
    * `#`, `-`, `$` ,and other special characters not allowed
* Must begin with an alphanumeric letter or an underscore
* Must NOT be a C# keyword
* Names are case sensitive `string myValue` and `string MyVaule` are different things.
* use **camelCase** 

## Literal Strings
Use character escape sequences when you need to insert a special character into a  literal string, such as:

* TAB: `\t`
* NEW LINE: `\n`
* DOUBLE QUOTES: `\"`
* BACKSLASH: `\\`
* UNICODE: `\u` (may not print correctly depending on the application)
The `@` directive creates a verbatim string literal that keeps all whitespace formatting and backslash characters in the string.

## Math Operations
* `+`: addition
* `-`: subtraction
* `*`: multiplication
* `/`: division (use decimal assignment variable when dividing)
* `%`: remainder of division
## Order of Operations
Remember the acronym PEMDAS:

* Parentheses (whatever is inside is performed first)
* Exponents
* Multiplication and Division
* Addition and Subtraction
Note: There is no exponent operator. Use `System.Math.Pow` for exponents.

## Compound Assignment Operators
* `+=`: increment
* `-=`: decrement
* `*=`: multiplication
* `++`: increment by 1
* `--`: decrement by 1
## Calling Methods
To call methods:

* Start by typing the class name, e.g., `Console`
* Add the member access operator: `.`
* Add the method name, e.g., `WriteLine`
* Add the method invocation operator: `()`
* Specify the argument that is passed to the method
## Execution Environment
* When using the terminal in Visual Studio Code:

* Click on the `.csproj` file
* Run your code there
## State Definition
As your code executes line by line, values are stored in variables. At any moment during execution, the current state of the application is the collection of all values stored in memory.

## Stateless/Static Methods
Stateless/Static methods are implemented so that they can work without referencing or changing any values already stored in memory.

## Stateful Methods
Stateful methods are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed.

## The NEW Operator
The `NEW` operator requests an area big enough in the computer to store a random object. It creates that new object in memory and then returns the memory address so it can be stored in the new object.

## Parameter vs. Argument
Often times, the terms 'parameter' and 'argument' are used interchangeably. However, 'parameter' refers to the variable that's being used inside the method. An 'argument' is the value that's passed when the method is called.

## Void Method
Void methods do not return a value when finished.

## Overloaded Method
An overloaded method is defined with multiple method signatures.

## Array Basics
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
## If
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

## If Else
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

## For
The `for` loop is used for iterative execution of code. It allows you to specify an initialization, a condition, and an iterator, and repeatedly execute a block of code until the condition becomes false.
```csharp
for (initialization; condition; iterator)
{
    // Code to be executed in each iteration
}
```
* The `for` loop provides a more controlled and structured way to iterate over a range of values or perform a specific number of iterations.
* The `initialization` step is executed only once at the beginning to initialize loop variables.
* The `condition` is evaluated before each iteration, and if it is true, the code block is executed. If it is false, the loop terminates.
* The `iterator` is executed after each iteration and is responsible for updating the loop variables.
* You can use the loop variables inside the code block to control the iteration or perform specific operations.
## ForEach
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

## Code Blocks
A code block is one or more C# statements that define an execution path. the statements outside of the code block affect when, if, and how often that block of code is executed at run time. 
* **Scope**: when you define a varibale inside of a code block, its visibility is local to that code block and inaccesible outside of the code block
* To make a variable visible inside and outside of a code block, you must define the variable outside of the code block.
* Do not forget to initialize any variables whose value is set in a code block, such as an `if` statement.

## Code Readability
When implimenting an `if` statement that includes a single-statement code block:
* Never use single-line form
* If you realize you have only one line of code listed within the code blocks of an **if-elseif-else** statement, you can remove the curly braces of the code block and white space. 
* Only remove the curly braces of a code block when it makes the code more readable. It's always acceptable to include curly braces.
* Only remove the line feed if it makes the code more readable. Microsoft suggests that your code will be more readable when each statement is placed on its own code line.
 
