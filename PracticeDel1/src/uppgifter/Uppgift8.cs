using System.Text.RegularExpressions;
using static System.Console;

internal class Uppgift8
{
  public static void Run()
  {
    WriteLine("=== Uppgift 8 ===");

    Write("Provide 4 integers (e.g. '1 2 3 4'): ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input");
      return;
    }

    string[] splitInput = [.. new Regex(@"\s+").Replace(response, " ").Split(" ").Where(s => s != "")];

    if (!splitInput.All(s => int.TryParse(s, out _)))
    {
      WriteLine("Bad input, contains non-integers.");
      return;
    }


    int[] numbers = [.. splitInput.Select(s => Convert.ToInt32(s))];

    if (numbers.Length != 4)
    {
      WriteLine("Wrong amount of numbers");
      return;
    }

    WriteLine("Your numbers are: " + string.Join(", ", numbers));

    WriteLine("The smallest number (via int[].Min()) is {0}", numbers.Min());

    int smallest = numbers[0];

    // i starts at 1 since the smallest is initially set to the 0 index
    for (int i = 1; i < numbers.Length; i++)
    {
      // If current is smaller than smallest
      if (numbers[i] < smallest)
      {
        smallest = numbers[i];
      }
    }

    WriteLine("The smallest number is: {0}", smallest);
  }
}