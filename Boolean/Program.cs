/*
Random coin = new();
int headsOrTails = coin.Next(0,2);
Console.WriteLine($"{(headsOrTails == 1 ? "heads" : "tails")}");
*/

string permission = "Admin";
int level = 53;
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Admin super user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}

if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges");
    }
}

if (!permission.Contains("Admin") && !permission.Contains("Manager"))
{
   Console.WriteLine("You do not have sufficient privileges"); 
}

