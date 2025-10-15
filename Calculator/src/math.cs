
static class CustomMath
{
  public static int Add(int a, int b)
  {
    return a + b;
  }
  public static double Add(int a, double b)
  {
    return Convert.ToDouble(a) + b;
  }
  public static double Add(double a, int b)
  {
    return a + Convert.ToDouble(b);
  }
  public static double Add(double a, double b)
  {
    return a + b;
  }
}