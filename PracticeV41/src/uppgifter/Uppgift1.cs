using System.Text.RegularExpressions;
using System.Xml.Serialization;
using static System.Console;

internal class Uppgift1
{
  readonly static string defaultInput = "10 20";

  public static void Run()
  {
    WriteLine("=== Uppgift 1 ===");

    double number1 = Convert.ToDouble(defaultInput.Split(" ")[0]);
    double number2 = Convert.ToDouble(defaultInput.Split(" ")[1]);

    // Give user 3 attempt to input numbers
    for (int i = 0; i < 3; i++)
    {
      Write("Provide two numbers (default: {0}):", defaultInput);

      string response = ReadLine() ?? defaultInput;
      if (response == "") response = defaultInput;

      GeneratedRegexAttribute nonDigitRegex = new(@"[^\d\.\,\s]", RegexOptions.IgnorePatternWhitespace);

      // Type check
      if (nonDigitRegex.Match(response))
      {
        WriteLine("Only provide numbers please");

        if (i == 2) WriteLine("Continuing with default value");
        else WriteLine("Try again...");
        continue;
      }

      double[] numbersProvided = [.. response.Split(" ").Select(Convert.ToDouble)];

      if (numbersProvided.Length != 2)
      {
        WriteLine("You provided {0} numbers, not 2", numbersProvided.Length);

        if (i == 2) WriteLine("Continuing with default value");
        else WriteLine("Try again...");
        continue;
      }
      else
      {
        number1 = numbersProvided[0];
        number2 = numbersProvided[1];
        break;
      }
    }

    WriteLine("You chose: {0}", string.Join(" and ", [number1, number2])); // Casts doubles to strings implicitly
    WriteLine("Calculating...");

    double sum = number1 + number2;
    WriteLine($"Sum: {sum}");

    double diff = number1 - number2;
    WriteLine($"Diff: {diff}");

    double product = number1 * number2;
    WriteLine($"Product: {product}");

    double quotient = number1 / number2;
    WriteLine($"Quotient: {quotient}");
  }

  public static void RunMVP()
  {
    int input1 = 10;
    int input2 = 20;
    WriteLine("input1 = {0}\ninput2 = {1}\n", input1, input2);

    int summa = input1 + input2;
    WriteLine("Summa: {0}", summa);

    int differens = input1 - input2;
    WriteLine("Differens: {0}", differens);

    int produkt = input1 * input2;
    WriteLine("Produkt: {0}", produkt);

    double kvot = input1 / input2;
    WriteLine("Kvot: {0}", kvot);
  }
}