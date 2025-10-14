using static System.Console;

class Calculator
{
  static void Main(string[] args)
  {
    string line = "";

    Draw(line);

    while (true)
    {
      string input = ReadKey().Key.ToString();

      if (input == "D1")
      {
        line += "1";
      }

      Draw(line, input);
    }
  }

  static void Draw(string line, string pressed = "")
  {
    Clear();
    WriteLine(pressed);

    string D01 = DrawButton(pressed, "D1", "1");
    string D02 = DrawButton(pressed, "D2", "2");
    string D03 = DrawButton(pressed, "D3", "3");
    string D04 = DrawButton(pressed, "D4", "4");
    string D05 = DrawButton(pressed, "D5", "5");
    string D06 = DrawButton(pressed, "D6", "6");
    string D07 = DrawButton(pressed, "D7", "7");
    string D08 = DrawButton(pressed, "D8", "8");
    string D09 = DrawButton(pressed, "D9", "9");
    string D00 = DrawButton(pressed, "D0", "0");
    string dot = DrawButton(pressed, "OemPeriod", ".");
    string sub = DrawButton(pressed, "Subtract", "-");
    string add = DrawButton(pressed, "Add", "+");
    string mul = DrawButton(pressed, "Multiply", "×");
    string div = DrawButton(pressed, "Divide", "÷");
    string eql = DrawButton(pressed, "Enter", "=");
    string pi_ = DrawButton(pressed, "P", "π");
    string del = pressed == "Backspace" ? $"#[<-]" : "# <- ";

    int colWidth = 22;
    string formattedLineWithSet_1 = line.PadRight(colWidth, ' ')[..colWidth];
    string formattedLineWithSet_2 = "".PadRight(colWidth, ' ');
    string formattedLineWithSet_3 = "".PadRight(colWidth, ' ');
    string formattedLineWithSet_4 = "".PadRight(colWidth, ' ');

    if (line.Length > colWidth)
    {
      formattedLineWithSet_2 = line.PadRight(colWidth * 2, ' ').Substring(colWidth, colWidth);
    }
    if (line.Length > colWidth * 2)
    {
      formattedLineWithSet_3 = line.PadRight(colWidth * 3, ' ').Substring(colWidth * 2, colWidth);
    }
    if (line.Length > colWidth * 3)
    {
      formattedLineWithSet_4 = line.PadRight(colWidth * 4, ' ').Substring(colWidth * 3, colWidth);
    }

    // Lines that wrap get a '<' else ' '
    formattedLineWithSet_1 += line.Length > colWidth ? " <" : "  ";
    formattedLineWithSet_2 += line.Length > colWidth * 2 ? " <" : "  ";
    formattedLineWithSet_3 += line.Length > colWidth * 3 ? " <" : "  ";
    formattedLineWithSet_4 += line.Length > colWidth * 4 ? " |" : "  ";
    string stop = line.Length > colWidth * 4 ? "[STOP]" : "      ";

    string vis = $"""
      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    #############################
    ##                         ##
    ## {formattedLineWithSet_1}##
    ## {formattedLineWithSet_2}##
    ## {formattedLineWithSet_3}##
    ## {formattedLineWithSet_4}##
    ##         {stop}          ##
    #############################
    ##{del}# ( ## ) #▌mod▐{pi_}##
    #############################
    ##{D07}{D08}{D09}{div}# √ ###
    #############################
    ##{D04}{D05}{D06}{mul}# x²###
    #############################
    ##{D01}{D02}{D03}{sub}#   ###
    ######################{eql}##
    ##{D00}{dot}# % #{add}#   ###
    #############################
    #############################
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
    """.Replace("#", "█");

    WriteLine(vis);
  }

  static string DrawButton(string pressed, string target, string label)
  {
    return pressed == target ? $"#[{label}]#" : $"# {label} #";
  }
}
