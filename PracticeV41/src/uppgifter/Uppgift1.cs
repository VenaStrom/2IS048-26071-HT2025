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


      // Regex based input validation
      Regex numberPairRegex = new(@"^\d*(?:[.,]\d*)? \d*(?:[.,]\d*)?$");
      if (numberPairRegex.Match(response.Trim()).Length == 0)
      {
        WriteLine("Only provide numbers please (nn or n.n or n,n). ");

        if (i == 2) WriteLine("Continuing with default value");
        else Write("Try again...");
        continue;
      }

      double[] numbersProvided = [.. response.Trim().Split(" ").Select(Convert.ToDouble)];

      if (numbersProvided.Length != 2)
      {
        WriteLine("You provided {0} numbers, not 2. ", numbersProvided.Length);

        if (i == 2) WriteLine("Continuing with default value");
        else Write("Try again...");
        continue;
      }
      else
      {
        number1 = numbersProvided[0];
        number2 = numbersProvided[1];
        break;
      }
    }

    WriteLine("\nYou chose: {0}", string.Join(" and ", [number1, number2])); // Casts doubles to strings implicitly
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