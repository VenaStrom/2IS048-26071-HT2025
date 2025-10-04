using static System.Console;

internal class Uppgift14
{
  public static void Run()
  {
    WriteLine("=== Uppgift 14 ===");

    Write("Provide an array of numbers (e.g. 1, 3, 4): ");
    string response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input");
      return;
    }

    string[] splitInput = [.. response.Trim().Split(",").Select(s => s.Trim())];

    WriteLine("Your inputted array: [{0}]", string.Join(", ", splitInput));

    Write("Which index should be removed?: ");
    response = ReadLine() ?? "";

    if (response == "")
    {
      WriteLine("Bad input");
      return;
    }

    if (!int.TryParse(response, out int popIndex))
    {
      WriteLine("Bad input. Provide an integer.");
      return;
    }

    if (popIndex > splitInput.Length - 1 || popIndex < 0)
    {
      WriteLine("Index is out of range");
      return;
    }

    // Array method
    string?[] poppedArray = [.. splitInput];
    poppedArray[popIndex] = null;
    WriteLine("Array with nulled value at index {1}: [{0}]", string.Join(", ", poppedArray.Select(s => s ??= "null")), popIndex);

    // List method
    List<string> poppedList = [.. splitInput];
    poppedList.RemoveAt(popIndex);
    WriteLine("List with remove value at index {0}: [{1}]", popIndex, string.Join(", ", poppedList));
  }
}