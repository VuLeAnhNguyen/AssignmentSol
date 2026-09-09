/*
2. Write a C# Sharp program to display certain values of the function x = y2 
+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).
*/
internal class B2
{
    public static void Main()
    {
        int y = -5;
        while (y>=-5 && y<=5)
        {
            Console.WriteLine($"x = {Math.Pow(y,2)+2*y+1}");
            y++;
        }
    }
}