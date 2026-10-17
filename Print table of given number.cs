//Print table of given number 
static void Main(string[] args) 
{
    Console.WriteLine("Enter no. to print table :- ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Table of No:- {num}");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num} * {i} = {num * i}");
    }
    
}
