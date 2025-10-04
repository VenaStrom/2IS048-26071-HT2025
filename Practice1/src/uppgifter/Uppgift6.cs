using static System.Console;

internal class Uppgift6
{
  public static void Run()
  {
    WriteLine("=== Uppgift 6 ===");

    Write("Provide a whole number: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad response");
      return;
    }

    int parsedInteger = Convert.ToInt32(response);

    // Is odd or even
    if (parsedInteger % 2 == 0)
    {
      WriteLine("Jämnt");
    }
    else
    {
      WriteLine("Udda");
    }
  }
}