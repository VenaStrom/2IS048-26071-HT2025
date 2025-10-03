using System.Text.RegularExpressions;
using static System.Console;

internal class Uppgift8
{
  public static void Run()
  {
    WriteLine("=== Uppgift 8 ===");

    Write("Provide 4 integers (e.g. '1 2 3 4'): ");
    string response = ReadLine() ?? "";

    if (response == "" || new Regex(@"\D").Match(response.Replace(" ", "")).Length != 0)
    {
      WriteLine("Bad input");
      return;
    }

    int[] numbers = [.. new Regex(@"\s*").Replace(response, " ").Split(" ").Where(s => s != "").Select(s => Convert.ToInt32(s))];

    if (numbers.Length != 4)
    {
      WriteLine("Wrong amount of numbers");
      return;
    }

    WriteLine("Your numbers are: " + string.Join(", ", numbers));
  }
}