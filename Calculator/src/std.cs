
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

  /// <summary>
  /// Return part of a string.
  /// 
  /// Start: inclusive. End: exclusive.
  /// </summary>
  /// <param name="s"></param>
  /// <param name="start">Inclusive index</param>
  /// <param name="end">Exclusive index</param>
  /// <returns></returns>
  public static string Slice(this string s, int? start = null, int? end = null)
  {
    start ??= 0;
    end ??= s.Length;

    if (start < 0 || end > s.Length)
    {
      throw new IndexOutOfRangeException();
    }

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

  public static string RemoveWhitespace(this string s)
  {
    char?[] letters = [.. s.ToCharArray()];

    int spaceCount = 0;
    for (int i = 0; i < letters.Length; i++)
    {
      if (letters[i] == ' ')
      {
        letters[i] = null;
        spaceCount++;
      }
    }

    if (spaceCount == 0) return s;

    char[] noWhitespaceLetters = new char[letters.Length - spaceCount];
    int newArrayIndex = 0;
    for (int i = 0; i < letters.Length; i++)
    {
      char? letter = letters[i];
      if (letter == null) continue;

      noWhitespaceLetters[newArrayIndex] = letter.Value;

      newArrayIndex++;
    }

    return new string(noWhitespaceLetters);
  }

  public static string[] CustomSplit(this string s, char separator)
  {
    if (s.Length == 0) return [];

    int separatorCount = 0;
    for (int i = 0; i < s.Length; i++) if (s[i] == separator) separatorCount++;

    if (separatorCount == 0) return [s];

    string[] substrings = new string[separatorCount + 1];
    int substringsIndex = 0;

    int lastSeparatorIndex = 0;
    for (int i = 0; i < s.Length; i++)
    {
      if (i == separator)
      {
        substrings[substringsIndex] = s.Slice(lastSeparatorIndex, i);
        substringsIndex++;
        lastSeparatorIndex = i + 1;
      }
    }

    return substrings;
  }
}