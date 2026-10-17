static void Main(string[] args)
{
    int number = 6;
    Console.WriteLine($"Factorial of {number} :- {Factorial(number)}"); 
}

static int Factorial(int n)
{
    int num = n, fact = 1;
    if(num <= 1)
    {
        return 1;
    }
    else
    {
        for (int i = num; i > 0; i--)
        {
            fact = fact * i;
        }

        return fact;
    }
    
}
