using static System.Console;

internal class Uppgift1
{
  public static void Run()
  {
    WriteLine("=== Uppgift 1 ===");

    Write("What's your name?: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Hello World");
      return;
    }
    else
    {
      WriteLine("Hello {0}", response.Trim());
    }
  }
}