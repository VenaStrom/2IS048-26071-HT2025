using static System.Console;

internal class Uppgift3
{
  public static void Run()
  {
    WriteLine("=== Uppgift 3 ===");

    string input = "Skriv ett program som byter ut alla små a:n (gemener) mot stora A:n (versaler) i en string. (a → A)";

    char[] inputSplit = input.ToCharArray();

    for (int i = 0; i < inputSplit.Length; i++)
    {
      if (inputSplit[i] == 'a')
      {
        inputSplit[i] = 'A';
      }
    }

    string recombined = string.Join("", inputSplit);

    WriteLine($"\"{recombined}\"");
  }
}