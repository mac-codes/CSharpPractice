// Initialize a string array with 4 names
string[] names = { "Alex", "Eddie", "David", "Michael" };

// Use the Array.Length property to get the number of elements in the array,
// and set up the loop to iterate through the array in reverse order.
// We start with the last index (Length - 1) and go down to the first index (0).

// Loop through the array in reverse order.
for (int i = names.Length - 1; i >= 0; i--)
{
    // Print the name at the current index.
    Console.WriteLine(names[i]);
    
    // cannot  reassign the value of the name bc it is part of the foreach iterations inner implementation
    // if (name == "David") name == "Sammy"
}
