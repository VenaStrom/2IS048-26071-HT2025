using static System.Console;

class Calculator
{
  static void Main(string[] args)
  {

    Draw();

    while (true)
    {
      string input = ReadKey().Key.ToString();

      Draw(input);
    }
  }

  static void Draw(string pressed = "")
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
    string dot = pressed == "OemPeriod" ? "#[.]#" : "# . #";

    string vis = $"""
      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    #############################
    ##                         ##
    ##                         ##
    ##                         ##
    ##                         ##
    ##                         ##
    ##                         ##
    #############################
    ### <- # ( ## ) #▌mod▐# π ###
    #############################
    ##{D07}{D08}{D09}# ÷ ## √ ###
    #############################
    ##{D04}{D05}{D06}# × ## x²###
    #############################
    ##{D01}{D02}{D03}# - ##   ###
    ####################### = ###
    ##{D00}{dot}# % ## + ##   ###
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
