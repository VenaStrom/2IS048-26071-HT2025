using static System.Console;

internal class Uppgift2
{
  public static void Run()
  {
    WriteLine("=== Uppgift 2 ===");

    int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    for (int i = array.Length - 1; i > -1; i--)
    {
      WriteLine(array[i]);
    }
  }
}