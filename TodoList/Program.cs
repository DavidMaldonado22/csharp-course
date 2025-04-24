using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] numbers = new[] {10, -8, 2, 12, -17};

int nonPositiveCount;

List<int> onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);

foreach (int number in onlyPositive)
{
    Console.WriteLine(number);
}

Console.WriteLine("Count of non positive " + nonPositiveCount);

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    List<int> result = new List<int>();
    countOfNonPositive = 0;

    foreach(int number in numbers)
    {

        if (number > 0) {
            result.Add(number);
        }
        else
        {
            countOfNonPositive = countOfNonPositive + 1;
        }
    }
    return result;
}

Console.ReadKey();