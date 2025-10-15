using static System.Console;
using static StringExtension;

static class StdUnitTest
{
  public static void Run()
  {
    WriteLine("\n[Running unit tests...]");

    Test_FindCharIndex();
  }

  static void Test_FindCharIndex()
  {
    string name = "string.FindCharIndex()";

    string hay = "I always dreamed about being stranded on a desert island until it actually happened.";
    char needle = 'm';
    int expected = 13;

    int? response = hay.FindCharIndex(needle);

    if (response == null)
    {
      WriteLine($"❌ {name} failed, didn't find the index.");
      return;
    }

    if (response != expected)
    {
      WriteLine($"❌ {name} failed, expected {0}, got {1}.", expected, response);
      return;
    }

    WriteLine($"✅ {name}");
  }
}