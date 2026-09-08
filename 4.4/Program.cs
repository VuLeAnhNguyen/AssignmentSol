/* 
4. Write a C# Sharp program that takes the radius of a sphere as input and 
    Volume. V = 4/3*π*r3 
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---Input---");
        Console.Write("Radius (m): "); double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Sphere surface: "+(Math.Pow(radius,2)*Math.PI*4) );
        Console.WriteLine("Sphere volume: "+(4d/3d)*Math.PI*Math.Pow(radius,3) );
    }
}