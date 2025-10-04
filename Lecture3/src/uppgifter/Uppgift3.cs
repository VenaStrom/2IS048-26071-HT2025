using System.Text.RegularExpressions;
using static System.Console;

internal class Uppgift3
{
  public static void Run()
  {
    WriteLine("=== Uppgift 3 ===");

    Write("Provide two integers: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input");
      return;
    }

    int[] inputSplit = [.. new Regex(@",|\s+").Split(response).Where(s => s != "" && int.TryParse(s, out _)).Select(s => { int.TryParse(s, out int num); return num; })];

    WriteLine("Your inputs: [{0}]", string.Join(", ", inputSplit));

    if (inputSplit.Length != 2)
    {
      WriteLine("Only provide 2 numbers");
      return;
    }

    if (inputSplit[0] == inputSplit[1])
    {
      WriteLine("The integers are equal, {0} = {1}", inputSplit[0], inputSplit[1]);
    }
    else if (inputSplit.Any(n => n == 0))
    {
      WriteLine("At least one integer is zero");
    }
    else
    {
      WriteLine("Sum of the provided integers: {0}", inputSplit.Sum());
    }
  }
}