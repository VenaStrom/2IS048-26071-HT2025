using static System.Console;

internal class Uppgift16
{
  public static void Run()
  {
    WriteLine("=== Uppgift 16 ===");

    int[] array1 = [1, 2, 3];
    int[] array2 = [12, 13, 14, 0, 0, 0];

    WriteLine("These arrays will be combined: ");
    WriteLine(" [{0}]", string.Join(", ", array1));
    WriteLine(" [{0}]", string.Join(", ", array2));

    Write("Which index should they be joined at?: ");
    string response = ReadLine() ?? "";

    if (response == "" || !int.TryParse(response, out int joinIndex))
    {
      WriteLine("Bad input");
      return;
    }

    if (joinIndex > array2.Length - array1.Length || joinIndex < 0)
    {
      WriteLine("Index out of bounds.");
      return;
    }

    for (int i = 0; i < array1.Length; i++)
    {
      array2[i + joinIndex] = array1[i];
    }

    WriteLine("Resulting array: [{0}]", string.Join(", ", array2));
  }
}