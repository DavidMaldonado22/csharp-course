Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

var number = 10;
var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6OrSmallerThan200 = number == 2 || number > 6 || number < 200;
var isEqualTo123OrEvenAndSmallerThan20 = number == 123 || (number % 2 == 0 && number < 20);

Console.ReadKey(); 