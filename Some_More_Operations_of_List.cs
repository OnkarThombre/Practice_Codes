List<int> list = new List<int> { 50, -47, 30, 87, -1,8,7,5, -42, 90,99 , -745 };

Console.WriteLine("Even numbers of list :- ");
foreach(var ele in list)
{
    if(ele % 2 == 0)
    {
        Console.WriteLine(ele);
    }
}

Console.WriteLine("-- -- -- -- -- -- -- ");
var result = list.Where(n => n % 2 == 0);
Console.WriteLine(string.Join(", " , result));

Console.WriteLine("-- -- -- -- -- -- -- ");
int sum = 0;
foreach(var ele in list)
{
    sum += ele;
}
Console.WriteLine($"Sum = {sum}");

Console.WriteLine("-- -- Greater than 10 list  -- -- -- ");
List<int> newlist = new List<int>();
foreach (var ele in list)
{
    if (ele > 10)
    {
        newlist.Add(ele);
    }
}

Console.WriteLine(string.Join(", ", newlist));

Console.WriteLine("-----gtten------");
var gtten = list.Where(n => n > 10);
Console.WriteLine(string.Join(", ", gtten));

Console.WriteLine("--Remove allnegative no. from list--");

foreach(var ele in list.ToList()) // by adding toList we are iterating on the Snapshot of list 
{
    //if(ele < 0) // if we do this without adding .ToList() then we will get InvalidModificationException: Collection was modified; enumeration operation may not execute.
    //{
    //    list.Remove(ele);//InvalidModificationException: Collection was modified; enumeration operation may not execute.
    //}

    if (ele < 0)
    {
        list.Remove(ele);
    }
}
Console.WriteLine(string.Join(", ", list));
