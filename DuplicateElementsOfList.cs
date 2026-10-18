using System.Numerics;

namespace Collection_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
              DuplicateElementsOfList();
        }
        public static void DuplicateElementsOfList()
        {
            List<int> list = new List<int> { 99, 30, -47, 30, 87, -1, 8, 7, 5, -42, 30, -1, 90, 99, -745 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
        
            HashSet<int> set = new HashSet<int>();//Unique elements of List
            foreach (var ele in list)
            {
                set.Add(ele);
            }
        
            Console.WriteLine(string.Join(", ", set));
            Console.WriteLine("-------------------");
            foreach (var ele in list)
            {
                //dict[ele] = dict.ContainsKey(ele) ? dict[ele] + 1 : 1;
                dict[ele] = dict.GetValueOrDefault(ele, 0) + 1;
            }
        
            Console.WriteLine("Duplicate elements of Dictionary :- ");
            foreach(KeyValuePair<int, int> items in dict)
            {
                if (dict[items.Key] > 1)
                {
                    Console.WriteLine(items.Key);
                    dict[items.Key] = 1;
                }
            }
        }
}
