using static System.Console;

internal class Uppgift2
{
  readonly static double defaultInput = 2; // Days

  public static void Run()
  {
    WriteLine("=== Uppgift 2 ===");

    Write("Name a number of day (default: {0}): ", defaultInput);
    string response = (ReadLine() ?? defaultInput.ToString()).Trim();

    if (response == "") response = defaultInput.ToString();

    WriteLine("You chose {0} days.", response);

    double days = Convert.ToDouble(response);

    double seconds = days * 24 * 60 * 60;

    WriteLine($"{days} days is {seconds} seconds");
  }
}