using static System.Console;

internal class Uppgift5
{
  public static void Run()
  {
    WriteLine("=== Uppgift 5 ===");

    Write("Write an integer: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input.");
      return;
    }

    int parsedInteger = Convert.ToInt32(response);

    WriteLine("Dividing by 5 and finding the rest...");
    int rest = parsedInteger % 5;

    WriteLine("Rest={0}", rest);
  }
}