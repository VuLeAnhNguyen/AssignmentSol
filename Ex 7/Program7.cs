internal class Program7
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 7: Lập Kế Hoạch Chi Phí Nhiên Liệu & Chia Sẻ Chuyến Đi (Car-pooling)");
        Console.WriteLine("---Input---");
        Console.Write("Quãng đường (Km): "); double distance = double.Parse(Console.ReadLine());
        Console.Write("Mức tiêu hao (lít/100km): "); double fuelConsumptionRate = double.Parse(Console.ReadLine());
        Console.Write("Giá xăng (VNĐ/lít): "); decimal fuelPrice = decimal.Parse(Console.ReadLine());
        Console.Write("Số người đi: "); int passengerCount = int.Parse(Console.ReadLine());
        //
        double fuelConsumption = (distance / 100) * fuelConsumptionRate;
        decimal fuelCost = (decimal)fuelConsumption * fuelPrice;
        decimal costPerPassenger = fuelCost / (decimal)passengerCount;
        //
        Console.WriteLine("---Output---");
        Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {fuelConsumption} Lít");
        Console.WriteLine($"Tổng chi phí xăng dầu: {fuelCost} VNĐ");
        Console.WriteLine($"Chi phí mỗi người ({passengerCount}):  {Math.Ceiling(costPerPassenger)} VNĐ");
    }
}