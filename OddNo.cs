static void Main(string[] args)
{
    Console.WriteLine("Odd Numbers:-");

    int n = 0; //initialization

    while (n <= 100) //condition
    {
        if (n % 2 != 0) { 

            Console.WriteLine($"{n}, ");
            n++;//update 
        }
    }
}
