internal class Program
{
  static void Main(string[] args)
  {
      Square(4);
  }
  
  public static void Diagonal(int n)
  {
      for (int i = 0; i < n; i++)
      {
          for (int j = 0; j < n; j++)
          {
              if (i == j || i + j == (n - 1))
              {
                  Console.Write("* ");
              }
              else
              {
                  Console.Write("  ");
              }
          }
          Console.WriteLine();
      }
  }
}
