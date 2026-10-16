internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Even numbers:-");

        int n = 100;
        for (int i = 0; i <= n; i++)
        {
            if(i%2 == 0)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
