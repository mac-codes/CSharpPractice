// Create a new random object to generate random numbers
Random random = new Random();

// Generate a random number between 0-11 to represent the days until expiration
int daysUntilExpiration = random.Next(12);

// initialize the dicount percentage to 0, which will be updated based on days until expiration 
int discountPercentage = 0;


// check the days until expiration and set the discount percentage accordingly.
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20; // set 20% discount if user renews
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
// check if there is any discount to be applied, and display appropiate message
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}