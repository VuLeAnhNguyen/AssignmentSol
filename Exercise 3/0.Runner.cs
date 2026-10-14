/*using Exercise_3;
class Runner
{
    static void Main()
    {
        //Bai1.Run();
        //Bai2.Run();
        //Bai3.Run();
        //Bai4.Run();
        Bai5.Run();
    }
}*/
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] m = new int[] { 3, 2, 6 };
        int[] d = m;
        d[1] = 9;
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine("  {0}", m[i]);
        }
        Console.WriteLine();
        foreach (int s in m)
        {
            Console.WriteLine(" {0}", s);
        }
    }
}