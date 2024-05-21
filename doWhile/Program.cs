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

//exercise 1
/*
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
*/

//exercise 2

bool validName = false;
Console.WriteLine("Please enter your role (Administrator, Manager, or User)");
string[] correctNames = {"Administrator", "Manager", "User"};

do
{
    string? readLine = Console.ReadLine();
    if (readLine == null)
    {
        Console.WriteLine("INVALID. Please enter your role (Administrator, Manager, or User)");
        continue; // Add continue to skip the rest of the loop and prompt again
    }

    readLine = readLine.Trim();
    
    bool isValidRole = false;
    foreach (string role in correctNames)
    {
        if (string.Equals(readLine, role, StringComparison.OrdinalIgnoreCase))
        {
            isValidRole = true;
            break;
        }
    }

    if (isValidRole)
    {
        Console.WriteLine($"Your input value {readLine} has been accepted.");
        validName = true;
    }
    else
    {
        Console.WriteLine("INVALID. Please enter your role (Administrator, Manager, or User)");
    }

} while (!validName);

//exercise 3
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for(int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    
    string mySentence = "";

    while(periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");
        
        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/