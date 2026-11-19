class Program_z
{
    public static void RadixSort(int[] array)
    {
        //assuming array is alway right
        Queue<int>[] digitContainer = new Queue<int>[10];
        for (int i = 0; i < 10; i++)
        {
            digitContainer[i] = new Queue<int>();
        }
        int placeLevel = 1;
        int maxStep = 1;
        while (placeLevel <= maxStep)
        {
            foreach (var item in array)
            {
                if (placeLevel == 1)
                {
                    int countDigit = item.ToString().Length;
                    if (countDigit > maxStep)
                    {
                        maxStep = countDigit;
                    }
                }

                int digit = (int)(item % Math.Pow(10, placeLevel) / Math.Pow(10, placeLevel-1));
                digitContainer[digit].Enqueue(item);
            }

            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                while (digitContainer[i].Count >0)
                {
                    array[temp] = digitContainer[i].Dequeue();
                    temp++;
                }
            }
            placeLevel++;

        }
    }
    static void Main()
    {
        int[] array = { 242, 110, 2337, 36, 4, 21230, 117, 0 };
        RadixSort(array);
        foreach (var item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
}