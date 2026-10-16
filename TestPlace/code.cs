using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        list.AddRange(new[] { 1, 2, 3, 4, 5, 6 });

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        list.Insert(2, 10);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.Remove(10);
    }
}