using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

//int userNumber;

//do
//{
//    Console.WriteLine("Enter a number larger than 10:");
//    var userInput =  Console.ReadLine();

//    if(userInput == "stop")
//    {
//        break;
//    }
//    bool isParseableToInt = userInput.All(char.IsDigit);
//    if(!isParseableToInt)
//    {
//        userNumber = 0;
//        continue;
//    }

//    userNumber = int.Parse(userInput);
//} while (userNumber <= 5);


for(int i = 0; i < 4; ++i)
{
    for(int j = 0; j < 3; ++j)
    {

        for(int k = 0; k < 5; ++k)
        {
            Console.WriteLine($"is is {i}, j is {j}, k is {k}");
        }
    }
}


Console.WriteLine("The loop is finished");
Console.ReadKey();