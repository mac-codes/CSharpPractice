// Initialize variables to store initial health of hero and monster.
int hero = 10;
int monster = 10;

// Create a random object to generate random numbers
Random dice = new Random();

// start a loop that continues until either the hero or the monster has 0 or less health 
do
{
    // The monster attcks the hero - generate random roll between 1 and 10
    int roll = dice.Next(1, 11);
    monster -= roll; // reduce health by the roll value
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    // if the monsters health drops to 0 or below, skip the heo attack and go to next iteration
    if (monster <= 0) continue;

    // The hero attacks the monster - generate a random roll between 1 and 10
    roll = dice.Next(1, 11);
    hero -= roll; // reduce health by the roll value
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

// after the loop ends, determine the winner based on the remaining health
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");