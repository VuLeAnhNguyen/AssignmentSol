using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    public static void BucketSort(ref double[] a, int k)
    {
        if (a.Length <= 1)
            return;
        double min = a.Min(), max = a.Max();
        if (min == max)
            return;

        List<double>[] bucket = new List<double>[k];
        for (int i = 0; i < k; i++)
            bucket[i] = new List<double>();

        //Phân phối từng bucket
        foreach (var x in a)
        {
            int index = (int)((x - min) / (max - min) * k);
            if (index == k)
                index--;
            bucket[index].Add(x);
        }
        List<double> R = new List<double>();
        foreach (var b in bucket)
        {
            b.Sort();
            foreach (var x in b)
                R.Add(x);
        }
        a = R.ToArray();
        return;
    }
    static void Main()
    {
        double[] arr = { 8.5, 6.2, 9.1, 4.5, 7.8, 5.3, 8.9, 3.2, 6.8, 9.5, 7.1, 4.8, 5.9 };
        BucketSort(ref arr, 10);
        foreach (var x in arr)
        {
            Console.Write(x + " ");
        }
    }
}

