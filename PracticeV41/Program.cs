using static System.Console;

internal class Program
{
  private static void Main(string[] args)
  {
    if (args.Length > 0)
    {
      WriteLine("Why did you provide args? Your args:");
      WriteLine("  " + string.Join(", ", args));
    }

    WriteLine("2IS048 26071 HT2025");

    Uppgift1();


    // Wait 200 ms and close due to JSON-RPC disconnect issues
    Thread.Sleep(200);
    WriteLine("Closing...");
    Environment.Exit(0);
  }

  private static void Uppgift1()
  {
    WriteLine("=== Uppgift 1 ===");
  }
}