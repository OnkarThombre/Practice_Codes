static void Main(string[] args) 
{
    int num = 27;
    bool isPrime = true;
    for (int i = 2; i <= (num / 2); i++) 
    {
        if (num % i == 0)
        {
            //Console.WriteLine($"{num} is not a prime number");
            isPrime = false;
            break;
        }
        //else
        //{
        //    Console.WriteLine($"{num} is a prime number");
        //}
    }

    if (isPrime) 
    {
        Console.WriteLine($"{num} is  prime number");
    }
    else
    {
        Console.WriteLine($"{num} is not a prime number");
    }
}
