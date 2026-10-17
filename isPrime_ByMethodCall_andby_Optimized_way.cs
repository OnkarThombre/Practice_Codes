static void Main(string[] args)
{
    //int start = Console.ReadLine() != null ? Convert.ToInt32(Console.ReadLine()) : 0;
    Console.WriteLine("Enter starting index :- ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter ending index :- ");
    int end = int.Parse(Console.ReadLine());

    Console.WriteLine("Prime numbers are:- ");
    isPrimeMethod(start, end);
}

//range of isprime
static void isPrimeMethod(int n, int e) 
{
    int num = n, end = e;

    while (num <= end)
    {
        bool isPrime = true;
        if(num <= 1)
        {
            isPrime = false;
            
        }
        for (int i = 2; i <= (num / 2); i++)
        {
            if (num % i == 0) 
            {
                 isPrime = false;
                 break;
            }
        }
        
        if (isPrime)
        {
            Console.WriteLine(num);
        }
        //Console.WriteLine();
        num++;
    }

    //while (num <= end)
    //{
    //    Main_isPrime(new string[] { num.ToString() });
    //    num++;
    //}
}
