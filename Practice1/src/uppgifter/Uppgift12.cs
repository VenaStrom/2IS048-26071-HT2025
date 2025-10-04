using static System.Console;

internal class Uppgift12
{
  public static void Run()
  {
    WriteLine("=== Uppgift 12 ===");

    Write("Provide a string: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input");
      return;
    }

    WriteLine("Your input but only every other letter:");
    char[] letters = response.Trim().ToCharArray();
    for (int i = 0; i < letters.Length; i += 2)
    {
      Write(letters[i]);
    }
  }
}