// define and array of order IDs
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// Loop through each order ID in the array
foreach (string orderID in orderIDs)
{
    // check if the current order ID starts with the letter "B"
    if (orderID.StartsWith("B"))
    {
        // if the condition is true, print the order ID
        Console.WriteLine(orderID);
    }
}

// The code will print all the order IDs that start with the letter "B".