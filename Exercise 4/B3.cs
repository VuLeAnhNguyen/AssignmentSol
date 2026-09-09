/* 
 3. Write a C# Sharp program that takes distance and time (hours, minutes, 
seconds) as input and displays speed in kilometers per hour (km/h) and 
miles per hour (miles/h).
*/
internal class B3
{
    public static void Main()
    {
        Console.Write("Distance (Km): "); double distance = double.Parse(Console.ReadLine());
        Console.Write("Time (hh:mm:ss): "); TimeSpan time = TimeSpan.Parse(Console.ReadLine());
        double speedKm = distance / (double)time.TotalHours;
        double speedM = distance*1000d / (double)time.TotalHours;
        Console.WriteLine("Km/h = " + speedKm);
        Console.WriteLine("M/h = " + speedM);


    }
}