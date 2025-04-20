using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<string> words = new List<string>();

Console.WriteLine("Count of elements is " + words.Count);

words.Add("hello");

Console.WriteLine("Count of elements is " + words.Count);

Console.ReadKey();