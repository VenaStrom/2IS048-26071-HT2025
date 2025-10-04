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

    // Uppgift1.Run();
    // Uppgift1.RunAlaVena();
    // Uppgift2.Run();
    // Uppgift3.Run();
    // Uppgift4.Run();
    // Uppgift5.Run();
    // Uppgift6.Run();
    // Uppgift7.Run();
    // Uppgift8.Run();
    // Uppgift9.Run();
    // Uppgift10.Run();
    // Uppgift11.Run();
    Uppgift12.Run();

    // Wait 200 ms before closing due to JSON-RPC disconnect issues
    Thread.Sleep(200);
    WriteLine("\nClosing...");
    Environment.Exit(0);
  }
}