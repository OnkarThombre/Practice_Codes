using System.Numerics;

namespace Collection_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeOperation();
        }

        public static void SomeOperation()
        {
            List<int> list = new List<int> { 50, 47, 30, 80, 10, 4, 90 };
        
            int largest = list.Max();
        
            int smallest = list.Min();
        
            //list.Sort(); list.Reverse();
        
            int min = int.MaxValue;
        
            foreach (var ele in list)
            {
                if (ele < min)
                {
                    min = ele;
                }
            }
        
            int max = int.MinValue;
        
            foreach(var ele in list)
            {
                if(ele > max)
                {
                    max = ele;
                }
            }
        
            Console.WriteLine($"Minimum element is :- {min}");
            Console.WriteLine($"Minimum element is :- {max}");
        }
        
    }
}


