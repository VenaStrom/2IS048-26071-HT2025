using static System.Console;

internal class Uppgift4
{
  public static void Run()
  {
    WriteLine("=== Uppgift 4 ===");

    Write("Provide string 1: ");
    string string1 = ReadLine() ?? "";
    Write("Provide string 2: ");
    string string2 = ReadLine() ?? "";

    const string joiner = " - ";

    WriteLine("\n+ string concat method");
    WriteLine("  " + string1 + joiner + string2);

    WriteLine("Template string method");
    WriteLine($"  {string1}{joiner}{string2}");

    WriteLine("Array join method");
    WriteLine("  " + string.Join(joiner, [string1, string2]));
  }
}