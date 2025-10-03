using static System.Console;

internal class Uppgift3
{
  public static void Run()
  {
    WriteLine("=== Uppgift 3 ===");

    Write("Provide a string: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input.");
      return;
    }

    bool aStart = response.StartsWith('a') || response.StartsWith('A');
    bool zEnd = response.EndsWith('z') || response.EndsWith('Z');

    if (aStart && zEnd)
    {
      WriteLine("A to Z");
    }
    else if (aStart)
    {
      WriteLine("Input starts with A");
    }
    else if (zEnd)
    {
      WriteLine("Zebra");
    }
    else
    {
      WriteLine($"{response}, for it was written.");
    }
  }
}