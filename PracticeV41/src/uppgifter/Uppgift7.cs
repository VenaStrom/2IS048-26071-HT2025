using System.Text.RegularExpressions;
using static System.Console;

internal class Uppgift7
{
  public static void Run()
  {
    WriteLine("=== Uppgift 7 ===");

    Write("Provide an integer: ");
    string response1 = ReadLine() ?? "";
    Write("Provide another integer: ");
    string response2 = ReadLine() ?? "";

    Regex nonIntRegex = new(@"\D");
    if (
      response1 == "" || response2 == ""
      || nonIntRegex.Match(response1).Length != 0
      || nonIntRegex.Match(response2).Length != 0
      )
    {
      WriteLine("Bad input");
      return;
    }

    int parsed1 = Convert.ToInt32(response1);
    int parsed2 = Convert.ToInt32(response2);

    if (parsed1 > parsed2)
    {
      WriteLine("{0} is larger", parsed1);
    }
    else if (parsed1 < parsed2)
    {
      WriteLine("{0} is larger", parsed2);
    }
    else if (parsed1 == parsed2)
    {
      WriteLine("{0} and {1} are equal", parsed1, parsed2);
    }
    else
    {
      WriteLine("What happened???");
    }
  }
}