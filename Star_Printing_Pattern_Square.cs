static void Main(string[] args)
{
    //Console.WriteLine("Hello, World!");
    Square(4);
}

public static void Square(int n)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j ++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
