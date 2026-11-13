class Program
{
    static void Main()
    {
        int l = 34;

        int[][] arbitraryArray = new int[l][];
        for (int i = 0; i < l; i++)
        {
            arbitraryArray[i] = new int[i + 1];
        }

        //

        for (int r = 0; r < l; r++)
        {
            for (int c = 0; c < arbitraryArray[r].Length; c++)
            {
                if ((c == 0) || (c == arbitraryArray[r].Length - 1))
                    arbitraryArray[r][c] = 1;
                else
                {
                    arbitraryArray[r][c] = arbitraryArray[r - 1][c] + arbitraryArray[r - 1][c - 1];
                }
                Console.Write(arbitraryArray[r][c] + " ");
            }
            Console.WriteLine();
        }

    }
}