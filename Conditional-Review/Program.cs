// Conditionals 

using System.Net.Security;

bool condition = true;

if (condition)
{
    Console.WriteLine("Creative");
}
else if(5 > 2)
{
    Console.WriteLine("Something else");
}
else
{
    Console.WriteLine("Whatever");
}

string hello = "Good Day!";

var response = Console.ReadLine().ToLower(); //Makes the user response not case sensitive

switch (response)
{
    case "Good Day!":
        Console.WriteLine("Hello There");
        break;

    case "Good Morning":
        Console.WriteLine("Nice Day Isnt it");
        break;

    default:
        Console.WriteLine("I dont understand");
        break;
}
if (response.Contains("Good")) 
{
    Console.WriteLine("It is pretty good isnt it");
}

Console.WriteLine("Please enter 1 or 2");

var userNumber = int.Parse(Console.ReadLine());


switch (userNumber)
{
    case 1:
      Console.WriteLine("One");
         break;
    case 2:
        Console.WriteLine("Two");
        break;
    default:
        Console.WriteLine("Please Enter a Number");
        break;
}

//What code am i going to need for the hw assignment for the user input?
// I Want my user to give me a string value
// Console.ReadLine(); want to store as a variable
// Ex
var userInput = Console.ReadLine();

// I want my user to give me a number value
// int.Parse(Console.ReadLine());
//ex
var number = int.Parse(Console.ReadLine());


//User Input
