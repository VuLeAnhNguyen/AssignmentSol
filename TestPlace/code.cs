//Scenario
//A delivery company needs a program to calculate shipping costs for different orders. Its pricing policies change depending on the service selected by the customer.
//Requirements
//1. Each shipment must have an ID, weight, and delivery distance.
//2. The company must support at least three different shipping-pricing policies.
//3. The user must be able to select a pricing policy when the program runs.
//4. The same processing routine must calculate costs for all shipments, regardless of which policy is selected.
//5. Adding another pricing policy must not require rewriting that processing routine.
//6. Process at least five sample shipments and display each shipment's shipping cost and the combined total.
//7. Handle invalid shipment data and an empty shipment collection.

public class ShipmentData
{
    public int Id { get; set; }
    public float Weight { get; set; }
    public float Distance { get; set; }

    public ShipmentData(int id, float weight, float distance)
    {
        Id = id;
        Weight = weight;
        Distance = distance;
    }
}
public delegate decimal Policy(ShipmentData shipment);
class Program
{
    static void Main()
    {
        ShipmentData s1 = new ShipmentData(001, 5, 2);
        ShipmentData s2 = new ShipmentData(002, 10, 5);
        ShipmentData s3 = new ShipmentData(003, 13, 12);
        ShipmentData s4 = new ShipmentData(004, 6, 50);
        ShipmentData s5 = new ShipmentData(005, 1, 120);
        ShipmentData[] ss = { s1,s2,s3,s4,s5 };

        if (ss.Length == 0) 
        {
            Console.WriteLine("Zero shipment data");
            return; 
        }


        static decimal Express(ShipmentData shipment)
        {
            decimal cost = (decimal)(shipment.Weight * shipment.Distance) * 2m;
            return cost;
        }
        static decimal Standard(ShipmentData shipment)
        {
            decimal cost = (decimal)(shipment.Weight * shipment.Distance) * 1m;
            return cost;
        }
        static decimal Economy(ShipmentData shipment)
        {
            decimal cost = (decimal)(shipment.Weight * shipment.Distance) * 0.8m;
            return cost;
        }
        static decimal Selftaken(ShipmentData shipment)
        {
            return 0;
        }

        Console.WriteLine("Express, Standard, Economy, Self taking");
        Console.WriteLine("   1         2        3          4");
        Console.Write("Enter: ");
        int choose;
        while (!int.TryParse(Console.ReadLine(), out choose) || (choose >4 || choose <1))
        {
            Console.Write("Only accept 1 | 2 | 3 | 4 , try again: ");
        }
        decimal total=0;
        Policy p = new Policy(Standard);

        switch (choose)
        {
            case 1:
                p = new Policy(Express);
                break;
            case 2:
                p = new Policy(Standard);
                break;
            case 3:
                p = new Policy(Economy);
                break;
            case 4:
                p = new Policy(Selftaken);
                break; 
        }
        Console.WriteLine("ID\tWeight\tDistance\tCost");
        foreach (var item in ss)
        {
            Console.WriteLine($"({item.Id})\t{item.Weight:N1}\t{item.Distance:N1}\t\t{p(item):C0}");
            total += p(item);
        }
        Console.WriteLine($"\t\t\t\t{total:C0} - Total");
    }

}