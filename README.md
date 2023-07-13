# Code Basics
The primary job of the compiler is to convert code into an executable format that the computer can understand.

## Variables
* `STRING`: for words, phrases, or any alphanumeric data for presentation (no data)
* `CHAR`: for a single alphanumeric character
* `INT`: for a whole number
* `DECIMAL`: for a number with a fractional component (one number has to be decimal for a decimal output)
* `BOOL`: for a true/false value

To declare a variable, first, select a data type and then give it a name. Example: `int number = 7;`

To retrieve a variable, you have to call the variable name.

* `VAR`: This keyword tells the compiler to infer the data type of the variable based on the value it is initialized to. Use data types when possible.
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
The `NEW` operator requests an area big enough in the computer to store a random object. It creates that new object in memory and then returns the memory address to store it in the new object.

## Parameter vs. Argument
The terms 'parameter' and 'argument' are often used interchangeably. However, 'parameter' refers to the variable that's being used inside the method. An 'argument' is the value that's passed when the method is called.

## Void Method
Void methods do not return a value when finished.

## Overloaded Method
An overloaded method is defined with multiple method signatures.

## Array Basics
an array is a sequence of individual data elements accessible through a single variable name. use name of the array to access the array elements 
### Array variable Declaration
> datatype[] variablename = new datatype[size]; 

## ForEach
