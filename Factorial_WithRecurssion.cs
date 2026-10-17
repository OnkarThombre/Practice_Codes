static void Main(string[] args)
{
    int number = 6;
    Console.WriteLine($"Factorial of {number} :- {Factorial(number)}"); 
}

static int Factorial(int n)
{
  
    if(n ==0 || n == 1)
    {
        return 1;
    }

    return n * Factorial(n-1);
}
