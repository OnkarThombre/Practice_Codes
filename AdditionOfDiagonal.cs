internal class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[, ] 
        {
            { 1, 7, 5, 8 ,7 },
            { 2, 3, 4, 5 ,5 },
            { 6, 7, 8, 9 ,2 },
            { 1, 2, 3, 4 ,1 },
            { 5, 6, 7, 8 ,3 }
        };
        Console.WriteLine(AdditionOfDiagonal(5, arr)); //36 
    }

    public static int AdditionOfDiagonal(int n, int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            { 
                if(i == j || (i + j) == (n-1))
                {
                    sum += arr[i, j];
                }
            }
        }
        return sum;
    }

public static int AdditionOfDiagonal_Consider_Centre_Element_As_Twice(int n, int[,] arr)
{
    int sum = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                sum += arr[i, j];
            }

            if (i + j == n - 1)
            {
                sum += arr[i, j];
            }
        }
    }

    return sum;
}

}


