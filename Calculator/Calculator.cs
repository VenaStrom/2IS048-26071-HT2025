using static System.Console;
using static StringExtension;


class Calculator
{
  static void Main()
  {
    bool passed = StdUnitTest.Run();
    if (!passed)
    {
      WriteLine("Some tests failed!");
      Environment.Exit(1);
    }

    string line = "";

    ConsoleKey[] allowedKeys = [
      ConsoleKey.D1,
      ConsoleKey.D2,
      ConsoleKey.D3,
      ConsoleKey.D4,
      ConsoleKey.D5,
      ConsoleKey.D6,
      ConsoleKey.D7,
      ConsoleKey.D8,
      ConsoleKey.D9,
      ConsoleKey.D0,
      ConsoleKey.Add,
      ConsoleKey.Subtract,
      ConsoleKey.Multiply,
      ConsoleKey.Divide,
      ConsoleKey.Enter,
      ConsoleKey.Backspace,
      ConsoleKey.Spacebar,
    ];

    while (true)
    {
      Clear();
      WriteLine("[CALCULATOR]\n");
      WriteLine(line + "_");
      SetCursorPosition(line.Length, CursorTop - 1);

      ConsoleKeyInfo keyInfo = ReadKey();

      if (!allowedKeys.Contains(keyInfo.Key)) continue;

      switch (keyInfo.Key)
      {
        case ConsoleKey.Backspace:
          if (line.Length == 0) break;
          if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
          {
            // Remove til next space what control is held
            int? spaceIndex = line.FindLastCharIndex(' ');
            if (spaceIndex == null) line = "";
            line = line.Slice(0, spaceIndex);
          }
          else
          {
            // Remove last character
            line = line[..(line.Length - 1)];
          }
          break;

        case ConsoleKey.Enter:
          double? result = ParseEq(line);
          if (result != null)
          {
            line = result.Value.ToString();
          }
          else
          {
            WriteLine("Failed to evaluate");
            Thread.Sleep(500);
          }
          break;

        default:
          line += keyInfo.KeyChar;
          break;
      }

      // Thread.Sleep(100);
    }
  }

  static double? ParseEq(string eq)
  {
    string trimmedEq = eq.RemoveWhitespace();

    if (trimmedEq == "") return null;

    // Split into parts via operator

    string[] parts = trimmedEq.CustomSplit('/');

    WriteLine("\n\n parts: " + parts.Length);
    WriteLine($"[{string.Join(", ", parts)}]");

    return null;
  }

  // static void Draw(string line, string pressed = "")
  // {
  //   Clear();
  //   WriteLine(pressed);

  //   string D01 = DrawButton(pressed, "D1", "1");
  //   string D02 = DrawButton(pressed, "D2", "2");
  //   string D03 = DrawButton(pressed, "D3", "3");
  //   string D04 = DrawButton(pressed, "D4", "4");
  //   string D05 = DrawButton(pressed, "D5", "5");
  //   string D06 = DrawButton(pressed, "D6", "6");
  //   string D07 = DrawButton(pressed, "D7", "7");
  //   string D08 = DrawButton(pressed, "D8", "8");
  //   string D09 = DrawButton(pressed, "D9", "9");
  //   string D00 = DrawButton(pressed, "D0", "0");
  //   string dot = DrawButton(pressed, "OemPeriod", ".");
  //   string sub = DrawButton(pressed, "Subtract", "-");
  //   string add = DrawButton(pressed, "Add", "+");
  //   string mul = DrawButton(pressed, "Multiply", "×");
  //   string div = DrawButton(pressed, "Divide", "÷");
  //   string eql = DrawButton(pressed, "Enter", "=");
  //   string pi_ = DrawButton(pressed, "P", "π");
  //   string del = pressed == "Backspace" ? $"#[<-]" : "# <- ";

  //   int colWidth = 22;
  //   string formattedLineWithSet_1 = line.PadRight(colWidth, ' ')[..colWidth];
  //   string formattedLineWithSet_2 = "".PadRight(colWidth, ' ');
  //   string formattedLineWithSet_3 = "".PadRight(colWidth, ' ');
  //   string formattedLineWithSet_4 = "".PadRight(colWidth, ' ');

  //   if (line.Length > colWidth)
  //   {
  //     formattedLineWithSet_2 = line.PadRight(colWidth * 2, ' ').Substring(colWidth, colWidth);
  //   }
  //   if (line.Length > colWidth * 2)
  //   {
  //     formattedLineWithSet_3 = line.PadRight(colWidth * 3, ' ').Substring(colWidth * 2, colWidth);
  //   }
  //   if (line.Length > colWidth * 3)
  //   {
  //     formattedLineWithSet_4 = line.PadRight(colWidth * 4, ' ').Substring(colWidth * 3, colWidth);
  //   }

  //   // Lines that wrap get a '<' else ' '
  //   formattedLineWithSet_1 += line.Length > colWidth ? " <" : "  ";
  //   formattedLineWithSet_2 += line.Length > colWidth * 2 ? " <" : "  ";
  //   formattedLineWithSet_3 += line.Length > colWidth * 3 ? " <" : "  ";
  //   formattedLineWithSet_4 += line.Length > colWidth * 4 ? " |" : "  ";
  //   string stop = line.Length > colWidth * 4 ? "[STOP]" : "      ";

  //   string vis = $"""
  //     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
  //   #############################
  //   ##                         ##
  //   ## {formattedLineWithSet_1}##
  //   ## {formattedLineWithSet_2}##
  //   ## {formattedLineWithSet_3}##
  //   ## {formattedLineWithSet_4}##
  //   ##         {stop}          ##
  //   #############################
  //   ##{del}# ( ## ) #▌mod▐{pi_}##
  //   #############################
  //   ##{D07}{D08}{D09}{div}# √ ###
  //   #############################
  //   ##{D04}{D05}{D06}{mul}# x²###
  //   #############################
  //   ##{D01}{D02}{D03}{sub}#   ###
  //   ######################{eql}##
  //   ##{D00}{dot}# % #{add}#   ###
  //   #############################
  //   #############################
  //     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
  //   """.Replace("#", "█");

  //   WriteLine(vis);
  // }

  // static string DrawButton(string pressed, string target, string label)
  // {
  //   return pressed == target ? $"#[{label}]#" : $"# {label} #";
  // }
}
