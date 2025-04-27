using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello!");

List<string> toDos = new List<string>();

string userChoice;
do
{
    Console.WriteLine("What do you whant to do?");

    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    userChoice = Console.ReadLine();
    userChoice.ToUpper();


    switch (userChoice)
    {
        case "S":
            break;
        case "A":
            string toDo = validateToDo();
            bool isTodoAlreadyExist = checkIfATodoExist(toDo);
            AddAToDo(isTodoAlreadyExist, toDo);
            break;
        case "R":
            break;
        case "E":
            break;
        default:
            Console.WriteLine("Invalid option, please, select a valid");
            break;
    }

} while (userChoice != "E");

string validateToDo()
{
    Console.WriteLine("Enter a TODO description: ");
    string toDo = Console.ReadLine();

    while (toDo.Length <= 0)
    {
        Console.WriteLine("Invalid description. The lengh of description can´t be 0. Please Enther a valid description.");
        Console.WriteLine("Enter a TODO description again: ");
        toDo = Console.ReadLine();
    }
    return toDo;
}
bool checkIfATodoExist(string toDoReceived)
{
    if (toDos.Count > 0)
    {
        foreach (string toDo in toDos)
        {
            if (toDo == toDoReceived)
            {
                Console.WriteLine("Already a TODO with same name exist!");
                return true;
            }
           
        }
    }
    return false;
}
void AddAToDo(bool isTodoAlreadyExist, string toDo)
{
    if(isTodoAlreadyExist)
    {
        Console.WriteLine("Nothing to be added");
    }
    else
    {
        toDos.Add(toDo);
    }
}

Console.ReadKey();