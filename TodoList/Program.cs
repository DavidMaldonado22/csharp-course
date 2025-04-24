using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

//var userInput = Console.ReadLine();

//bool isParsingSuccessful = int.TryParse(userInput, out int number);

//if (isParsingSuccessful)
//{
//    Console.WriteLine("Parsing worked, number is " + number);
//}
//else
//{
//    Console.WriteLine("Parsing was not successful");
//}

bool isParsingSuccessful;

do
{

    Console.WriteLine("Enter a number:");
    var userInput = Console.ReadLine();

    isParsingSuccessful = int.TryParse(userInput, out int number);

    if (isParsingSuccessful)
    {
        Console.WriteLine("Parsing worked, number is " + number);
    }
    else
    {
        Console.WriteLine("Parsing was not successful");
    }

} while (!isParsingSuccessful);

Console.ReadKey();