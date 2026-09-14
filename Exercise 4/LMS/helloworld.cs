namespace Exercise__4
{
    internal class helloworld
    {
        static void Mainj()
        {
            int a = 0;
            for (int l = 1; l <= 4; l++)
            {
                for (int s = 1; s <= 4 - l; s++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= l; c++)
                {
                    a++;
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }


            
        }
    }
}
