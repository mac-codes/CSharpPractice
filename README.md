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

## ForEach
the `foreach` loop is used to iterator over elements in an array or any collection that implements `IEnumeral` interface.. it simplifies the process of accessing each element without expilicitly using an index.

```csharp
foreach (var item in collection)
{
    // Code to be executed for each item in the collection
}