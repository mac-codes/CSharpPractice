/* The primary job of the compiler is to convert code into an executable format
 * that the computer can understand
 * 
 * Variables:
 * STRING: for wordsm phrases or any alphanumeric data for presentation not data
 * CHAR: for a single alphanumeric character
 * INT: for a whole number
 * DECIMAL: for a number with a fractional component *one num has to be a decimal
 *                                                      for a decimal output
 * BOOL: for a true/false value
 * 
 * to declare a variable, first select a data type and then give it a nume. 
 * ex: int number = 7;
 * to retrieve a varibable you just have to call the variable name.
 * 
 * VAR:
 * this keyword tells the compiler to infer the data type of the variable based
 * on the value it is initialized to.
 * use data types when possibnle.
 * 
 * LITERAL STRINGS:
 * use character escape sequences when you need to insert a special character
 * into a literal string, like:
 * TAB: \t
 * NEW LINE: \n
 * DOUBLE QUOTES: \"
 * BACKSLASH: \\
 * UNICODE: \u (may not print correctly depending of app)
 * the @ directive creates a verbatim string literal that keeps all whitespace
 * formatting and backshlash characters in string
 * 
 * MATH:
 * +: addition
 * -: subtraction
 * *: muiltiplication
 * division: / - use decimal assignment variable when dividing
 * %: remainder of division
 * 
 * ORDER OF OPERATIONS:
 * PEMDAS
 * Parentheses (whatever is inside is performed first.
 * Exponents
 * Multiplication and Division
 * Addition and Subtraction
 * *** there is no exponent operator. use System.Math.Pow for exponents.
 * 
 * COMPOUND ASSIGNMENT OPERATORS:
 * += (inccrement), -=(decrement), *=, ++, --
 * 
 * HOW TO CALL METHODS:
 * -start: type the class name ex: Console
 * -add the member access operator ex: .
 * -add the method name ex: WriteLine
 * -add the method invocation operator ex: ()
 * -finally specify the arument that is passed to the method.
 * 
 * when using the terminal in VS Code click on the csproj file and run 
 * your code there.
 * 
 * STATE DEFINTION: As your code executes line by line, values are stored in 
 * variables. At any moment during execution, the current state of the a
 * pplication is the collection of all values stored in memory.
 * STATELESS/STATIC METHODS: are implemented so that they can work without 
 * referencing 
 * or changing any values already stored in memory. 
 * STATEFUL: are built in such a way that they rely on values stored in memory 
 * by previous lines of code that have already been executed.
 * 
 * NEW operator: requests and area big enoough in the computer to store a random
 * object. creates that new object in the memory then returns the memory address
 * so it can be stores in the new object.
 * **Often times, the terms 'parameter' and 'argument' are used interchangeably.
 * However, 'parameter' refers to the variable that's being used inside the 
 * method. An 'argument' is the value that's passed when the method is called.
 * VOID METHOD: do not return a value when finished.
 * PARAMETER refers to the variable that's being used inside the method.
 * ARGUMENT is the value that's passed when the method is called.
 * OVERLOADED METHOD is defined with multiple method signatures. 
 */