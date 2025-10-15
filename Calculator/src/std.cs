
static class StringExtension
{
  public static int? FindCharIndex(this string haystack, char needle)
  {
    char[] letters = haystack.ToCharArray();

    for (int i = 0; i < letters.Length; i++)
    {
      if (letters[i] == needle) return i;
    }

    return null;
  }
  public static int? FindLastCharIndex(this string haystack, char needle)
  {
    char[] letters = haystack.ToCharArray();

    for (int i = letters.Length - 1; i > 0; i--)
    {
      if (letters[i] == needle) return i;
    }

    return null;
  }

  public static string Slice(this string s, int? start = null, int? end = null)
  {
    start ??= 0;
    end ??= s.Length;

    int length = Math.Abs(end.Value - start.Value);
    char[] letters = new char[length];
    int letterIndexPointer = 0;

    for (int i = start.Value; i < end.Value; i++)
    {
      letters[letterIndexPointer] = s[i];
      letterIndexPointer++;
    }

    return new string(letters);
  }

  public static string CustomTrim(this string s)
  {
    if (s.Length == 0) return "";

    // Find how many spaces are at the front
    int startPad = 0;
    for (int i = 0; i < s.Length; i++)
    {
      if (s[i] == ' ')
      {
        startPad++;
      }
      else
      {
        break;
      }
    }

    // Find how many spaces are at the back
    int endPad = 0;
    for (int i = s.Length - 1; i > 0; i--)
    {
      if (s[i] == ' ')
      {
        endPad++;
      }
      else
      {
        break;
      }
    }

    return s.Slice(startPad, s.Length - endPad);
  }
}
