namespace Collection_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AnyMethod();
        }

        public static void AnyMethod()
        {
            List<int> list = new List<int>();
            list.Add(80);
            list.Add(20);
            list.Add(10);
            list.Add(500);
            list.Add(35);

            Console.WriteLine("List Elements:");
            Console.WriteLine(list[2]); //30

            Console.WriteLine("Print by foreach loop");
            foreach(var ele in list)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("Print by string.join");
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine("----------------------");
            list.Insert(2,35);

            Console.WriteLine("Print by string.join");
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine("----------------------");

            list.Remove(35);
            Console.WriteLine("Removed element");
            Console.WriteLine(string.Join(", ", list));

            list.RemoveAt(4);//if index given is out of bound then we will receive an exception indexOutOfBoundException

            Console.WriteLine("Removed element at index");
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine("----------------------");
            Console.WriteLine(list.Count + " <- Count :: Capacity -> "+ list.Capacity);

            //list.RemoveAll(); // remove elements that matches the specific condition

            bool ans = list.Contains(35);
            Console.WriteLine($"list.Contains() :- {ans}");

            int[] arr = list.ToArray();

            Console.WriteLine("ToArray method "+string.Join(", ", arr));
            Console.WriteLine("----------------------");

            int index = list.IndexOf(30);
            Console.WriteLine(index);

            list.Sort();
            Console.WriteLine("Sort");
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine("----------------------");

            list.Reverse();
            Console.WriteLine("Reverse");
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine("----------------------");
            
            list.Clear();
            Console.WriteLine("Clear");
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine("----------------------");
        }
    }
}
