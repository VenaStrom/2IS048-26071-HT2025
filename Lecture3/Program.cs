using static System.Console;

internal class Program
{
  private static void Main(string[] args)
  {
    WriteLine("=== 2IS048 26071 HT2025 - Lecture 3 (F3) ===\n");

    // Uppgift1.Run();
    Uppgift2.Run();
    // Uppgift3.Run();


    // Wait 200 ms before closing due to JSON-RPC disconnect issues
    Thread.Sleep(200);
    WriteLine("\nClosing...");
    Environment.Exit(0);
  }
}