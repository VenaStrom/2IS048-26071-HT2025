using static System.Console;

internal class Uppgift13
{
  public static void Run()
  {
    WriteLine("=== Uppgift 13 ===");

    int[] initialArray = [1, 2, 3];

    WriteLine("Heres a cool array: [{0}]", string.Join(", ", initialArray));
    Write("Provide a number to append to it: ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input");
      return;
    }

    if (!int.TryParse(response, out int providedNumber))
    {
      WriteLine("You did not provide a whole number.");
      return;
    }

    WriteLine("Your number is {0}", providedNumber);

    int[] newArray = [.. initialArray, providedNumber];

    WriteLine("The updated array is [{0}]", string.Join(", ", newArray));


    // Using lists is also an option
    List<int> initialList = [1, 2, 3];
    initialList.Add(providedNumber);
    WriteLine("Using List type instead [{0}]", string.Join(", ", initialList));
  }
}