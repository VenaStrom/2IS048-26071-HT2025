using System.Text.RegularExpressions;
using static System.Console;

internal class Uppgift2
{
  readonly static double defaultInput = 2; // Days

  public static void Run()
  {
    WriteLine("=== Uppgift 2 ===");

    Write("Ange ett antal dagar: ");
    string response = (ReadLine() ?? defaultInput.ToString()).Trim();

    if (response == "")
    {
      WriteLine("Ogiltig inmatning. Avbryter...");
      return;
    }

    WriteLine("Du valde {0} dagar (standard: {1}).", response, defaultInput);

    double days = Convert.ToDouble(response);

    double seconds = days * 24 * 60 * 60;

    WriteLine($"{days} days is {seconds} seconds");
  }
}