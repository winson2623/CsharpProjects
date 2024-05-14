/*
string firstName = "Bob";
//testing a change to message
//int widgetsSold = 7;
//Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/


/*
This code creates an reverses an array with the initial string
and loops through each character, finding all the letter "o"
in the array. Then prints the result to console.
*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o')
    {
         letterCount++; 
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");