class Program
{
    static void Main()
    {
        int[] array = [4, 1, 123, 9, 12, 34, -1,-9999999,9123123];

        int? FindLargest(int[] array)
        {
            if (array.Length > 0)
            {
                int largest = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > largest)
                        largest = array[i];
                }
                return largest;
            }
            else
                return null;
        }
        Console.WriteLine(FindLargest(array));
    }
}

