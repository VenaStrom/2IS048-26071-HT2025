using static System.Console;

static class StdUnitTest
{
  public static bool Run()
  {
    WriteLine("\n[Running unit tests...]");
    bool[] tests = [
      Test_FindCharIndex(),
      Test_FindLastCharIndex(),
      Test_Slice(),
      Test_CustomTrim(),
    ];

    return tests.Any(e => e == true);
  }

  static bool Test_FindCharIndex()
  {
    string name = "string.FindCharIndex()";

    string hay = "I always dreamed about being stranded on a desert island until it actually happened.";
    char needle = 'm';
    int expected = 13;

    int? response = hay.FindCharIndex(needle);

    if (response == null)
    {
      WriteLine($"❌ {name} failed, didn't find the index.");
      return false;
    }

    if (response != expected)
    {
      WriteLine($"❌ {name} failed, expected {expected}, got {response}.");
      return false;
    }

    WriteLine($"✅ {name}");
    return true;
  }

  static bool Test_FindLastCharIndex()
  {
    string name = "string.FindLastCharIndex()";

    string hay = "I always dreamed about being stranded on a desert island until it actually happened.";
    char needle = 'y';
    int expected = 73;

    int? response = hay.FindLastCharIndex(needle);

    if (response == null)
    {
      WriteLine($"❌ {name} failed, didn't find the index.");
      return false;
    }

    if (response != expected)
    {
      WriteLine($"❌ {name} failed, expected {expected}, got {response}.");
      return false;
    }

    WriteLine($"✅ {name}");
    return true;
  }

  static bool Test_Slice()
  {
    string name = "string.Slice()";

    string sentence = "I always dreamed about being stranded on a desert island until it actually happened.";
    char separator = ' ';

    int expectedWordCount = 14;

    string[] words = sentence.CustomSplit(separator);

    if (words.Length == 0)
    {
      WriteLine($"❌ {name} failed, received array of 0 length.");
      return false;
    }

    if (words.Length != expectedWordCount)
    {
      WriteLine($"❌ {name} failed, expected {expectedWordCount}, got {words.Length}.");
      return false;
    }

    WriteLine($"✅ {name}");
    return true;
  }

  static bool Test_CustomTrim()
  {
    string name = "string.CustomTrim()";

    string input = " cool.email@example.com  ";
    int expectedLength = 22;

    string trimmed = input.CustomTrim();

    if (trimmed.Length == 0)
    {
      WriteLine($"❌ {name} failed, received trimmed output of 0 length.");
      return false;
    }

    if (trimmed.Length != expectedLength)
    {
      WriteLine($"❌ {name} failed, expected {expectedLength}, got {trimmed.Length} length.");
      return false;
    }

    WriteLine($"✅ {name}");
    return true;
  }
}