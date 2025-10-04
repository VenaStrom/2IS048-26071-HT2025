using static System.Console;

internal class Uppgift11
{
  public static void Run()
  {
    WriteLine("=== Uppgift 11 ===");

    Write("Provide a string: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input");
      return;
    }

    WriteLine("Your input, but reversed!:");
    char[] letters = response.Trim().ToCharArray();
    for (int i = letters.Length - 1; i > -1; i--)
    {
      Write(letters[i]);
    }

    Write("\n"); // Padding
  }
}