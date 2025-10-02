using static System.Console;

namespace PracticeV41;

internal class Program
{
  private static void Main(string[] args)
  {
    if (args.Length > 0)
    {
      WriteLine("Why did you provide args? Your args:");
      WriteLine("  " + string.Join(", ", args));
    }

    WriteLine("=== 2IS048 26071 HT2025 ===\n");

    // Uppgift1.RunMVP();
    Uppgift1.Run();

    // Wait 200 ms and close due to JSON-RPC disconnect issues
    Thread.Sleep(200);
    WriteLine("\nClosing...");
    Environment.Exit(0);
  }
}