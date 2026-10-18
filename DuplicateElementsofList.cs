
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>
        {
            99, 30, -47, 30, 87, -1, 8, 7, 5,
            -42, 30, -1, 90, 99, -745
        };

        Dictionary<int, int> dict = new Dictionary<int, int>();

        // Count the frequency of each element
        foreach (int num in list)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        Console.WriteLine("Duplicate elements:");

        // Print elements occurring more than once
        foreach (KeyValuePair<int, int> items in dict)
        {
            if (items.Value > 1)
            {
                Console.WriteLine(items.Key);
            }
        }
    }
}
