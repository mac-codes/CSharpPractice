// Declare an array to store fraudulent order IDs
string[] fraudulentOrderIDs = new string[3];

// Assign values to the elements of the array
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// Attempted to assign a value to fraudulentOrderIDs[3], but this will cause an "Index out of range" error, 
// as the array was declared with a size of 3, and arrays are zero-indexed.

// Print the values of the first three fraudulent order IDs.
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign the value of the first element in the array.
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// print the numbers of the fraud orders to process
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.")