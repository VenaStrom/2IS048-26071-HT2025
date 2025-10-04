using static System.Console;

internal class Uppgift15
{
  public static void Run()
  {
    WriteLine("=== Uppgift 15 ===");

    int[] array1 = [1, 2, 3];
    int[] array2 = [12, 14, 16];

    WriteLine("Arrays to be combined:");
    WriteLine(" 1. [{0}]", string.Join(", ", array1));
    WriteLine(" 2. [{0}]", string.Join(", ", array2));

    int combinedLength = array1.Length + array2.Length;

    WriteLine("New array length: {0} + {1} = {2}", array1.Length, array2.Length, combinedLength);

    int[] combinedArray = new int[combinedLength];

    for (int i = 0; i < array1.Length; i++)
    {
      combinedArray[i] = array1[i];
    }
    for (int i = 0; i < array2.Length; i++)
    {
      combinedArray[i + array1.Length] = array2[i];
    }

    WriteLine("Combined array: [{0}]", string.Join(", ", combinedArray));


    // Better method
    int[] combined = [.. array1, .. array2];
    WriteLine("Combined array using array deconstruction: [{0}]", string.Join(", ", combined));
  }
}