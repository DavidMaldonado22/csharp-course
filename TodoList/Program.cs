using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice.Length == 0)
{
    Console.WriteLine("Empty choice!");
    int number = 5;
    Console.WriteLine(number);
    var word = "ABC";
    var number2 = 10;
    if(word.Length > 0)
    {
        var number2 = 10;
        Console.WriteLine(number);
        Console.WriteLine(userChoice);
    }
    Console.WriteLine(number2);
}
else
{
    int number = 5;
    Console.WriteLine("Non-empty choice: " + userChoice);
    Console.WriteLine(number);
}
Console.WriteLine("Your choice is: " + userChoice);
Console.WriteLine(number);

Console.ReadKey(); 