/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/


/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 

char[] openSymbols = { '[', '{', '(' };
int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

/*
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/


string message = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";


//extract message in SPAN
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingSpanPosition = message.IndexOf("<span>");
int closingSpanPosition = message.IndexOf("</span>");

openingSpanPosition += openSpan.Length;
int quantity = closingSpanPosition - openingSpanPosition;

//extract message in DIV
const string openDiv = "<div>";
const string closeDiv = "</div>";

int openingDivPosition = message.IndexOf("<div>");
int closingDivPosition = message.IndexOf("</div>");

openingDivPosition += openDiv.Length;
int output = closingDivPosition - openingDivPosition;

//replace trade & reg
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
message = message.Replace(tradeSymbol, regSymbol);

//output
Console.WriteLine(message.Substring(openingSpanPosition,quantity));
Console.WriteLine(message.Substring(openingDivPosition,output));

