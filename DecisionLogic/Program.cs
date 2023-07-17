// Create a new random object to simulate dice rolling
Random dice = new Random();

// Roll three dice and store the results in variables
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// set roll1, roll2, and roll3 to 6, this overrides the previously rolled values
roll1 = 6;
roll2 = 6;
roll3 = 6;

// calculate the total sum of the dice rolls
int total = roll1 + roll2 + roll3;

// print the dice roll and the total
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// check if any two dice rolls are the same (doubles) or all three are the same (triplets)
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!"); // print message for rolling 3x and add 6 to total
        total += 6;
    }
    else
    {
    Console.WriteLine("You rolled doubles! +2 bonus to total!"); // print message for 2x and add 2 to the total
    total += 2;
    }
}
// check the total to determine the prize won
if (total >= 16) 
{
    Console.WriteLine("You win a NEW CAR!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new LAPTOP!");
}
else if (total == 7)
{
    Console.WriteLine("Woah. You won a TRIP!");
}
else
{
    Console.WriteLine("You win a KITTEN!");
}