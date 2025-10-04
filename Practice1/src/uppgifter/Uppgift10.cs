using static System.Console;

internal class Uppgift10
{
  public static void Run()
  {
    WriteLine("=== Uppgift 10 ===");

    int[] inputArray = [10, 44, 67, 3, 38];

    WriteLine("The input array: [{0}]", string.Join(", ", inputArray));

    List<int> evenNumbers = [];

    foreach (var number in inputArray)
    {
      if (number % 2 == 0)
      {
        evenNumbers.Add(number);
      }
    }

    WriteLine("Even numbers in array are:");
    foreach (var even in evenNumbers)
    {
      WriteLine("  {0}", even);
    }
  }
}