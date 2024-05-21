//hero and monster dice game
/*
Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int attackDamage = 0;

do
{
    attackDamage = random.Next(1, 11);
    heroHealth = heroHealth - attackDamage;
    Console.WriteLine($"Hero was hit by {attackDamage} points, his health remaining is {heroHealth}");

    if (heroHealth <= 0)continue;

    attackDamage = random.Next(1, 11);
    monsterHealth = monsterHealth - attackDamage;
    Console.WriteLine($"Monster was hit by {attackDamage} points, his health remaining is {monsterHealth}");
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
*/

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/


int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    string? readResult = Console.ReadLine();
    if (readResult == null)
    {
        Console.WriteLine("No input detected");
        continue;
    }

    validNumber = int.TryParse(readResult, out numericValue);

    if (validNumber)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            validNumber = true;
        }
        else
        {
            validNumber = false;
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"You entered a valid number {numericValue}");