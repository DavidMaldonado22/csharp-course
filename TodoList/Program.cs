Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string UserChoice = Console.ReadLine();

bool isUserInputAbc = UserChoice == "ABC";
bool isUserInputNotAbc = UserChoice != "ABC";
bool isUserInputNotAbc2 = !(UserChoice == "ABC");

var number = 10;

var isLargerThan5 = number > 5;
var isSmallerThan10 = number < 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;

var is10Modulo3EqualTo1 = 10 % 3 == 1;
var isEven = 10 % 2 == 0;

Console.ReadKey(); 