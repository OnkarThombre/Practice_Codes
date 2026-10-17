static void Main(string[] args) 
{
    int num = 2, end = 100;

    while (num <= end)
    {
        bool isPrime = true;
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
