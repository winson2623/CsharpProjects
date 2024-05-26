/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);


string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);


string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


int value = (int)1.5m; // casting truncates
Console.WriteLine(value);
int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
*/

/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
double total = 0;
string message = "";

foreach (string value in values)
{
    if (double.TryParse(value, out double numResult))
    {
        total += numResult;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;


// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32(value1) / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");