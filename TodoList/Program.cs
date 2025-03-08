using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if(userChoice == "S")
{
    PrintSelectionOption("See all TODOs");
}
else if(userChoice == "A")
{
    PrintSelectionOption("Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectionOption("Remove a TODO");
}
else if (userChoice == "E")
{
    PrintSelectionOption("Exit");
}

void PrintSelectionOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

Console.ReadKey();