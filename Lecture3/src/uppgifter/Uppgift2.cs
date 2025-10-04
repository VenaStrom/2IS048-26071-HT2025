using System.Text.RegularExpressions;
using static System.Console;

internal class Uppgift2
{
  public static void Run()
  {
    WriteLine("=== Uppgift 2 ===");

    Write("Provide two addends which sums to 5: ");
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

    int sum = inputSplit.Sum();

    WriteLine("Sum: {0}", sum);

    if (sum == 5)
    {
      WriteLine("Yes");
    }
    else
    {
      WriteLine("Nope");
    }
  }
}