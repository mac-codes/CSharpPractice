
string? readResult; // Declare a variable to hold the user's input
string roleName = ""; // Initialize a variable to an empty string
bool validEntry = true; // Initialize a variable to false to track if input is valid


do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine(); // Read the user's input
    if (readResult != null)
    {
        roleName = readResult.Trim(); // Store the non-null value as string
    }

    if (roleName.ToLower() == "adiministrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The role name \"{roleName}\" is invalid. Please try again.");
    }
} while (validEntry == false);

Console.WriteLine($"Your role: {roleName} is valid.");
