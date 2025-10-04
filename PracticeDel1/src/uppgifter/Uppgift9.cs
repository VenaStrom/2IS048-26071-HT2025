using static System.Console;

internal class Uppgift9
{
  public static void Run()
  {
    WriteLine("=== Uppgift 9 ===");

    int[] inputArray = [10, 44, 67, 3, 38];

    WriteLine("Input array: [{0}]", string.Join(", ", inputArray));

    List<int> oddIndices = [];

    for (int i = 0; i < inputArray.Length; i++)
    {
      if (i % 2 != 0)
      {
        oddIndices.Add(i);
      }
    }

    WriteLine("Value of the odd indices:");
    foreach (var index in oddIndices)
    {
      WriteLine("  {0}", inputArray[index]);
    }


    // Quick approach hihi
    int[] oddValues = [.. inputArray.Where((v, i) => i % 2 != 0)];
  }
}