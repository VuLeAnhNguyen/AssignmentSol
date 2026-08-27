internal class Program3
{
    enum CurrencyType
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng");
        Console.WriteLine("Bảng  tỷ giá");
        Console.WriteLine($"{CurrencyType.USD}");
        Console.WriteLine($"{CurrencyType.EUR}");
        Console.WriteLine($"{CurrencyType.JPY}");
        Console.WriteLine($"{CurrencyType.GBP}");
        Console.WriteLine("---Input---");
        decimal tienViet = 0;
        Console.Write("Nhập số tiền VNĐ: ");
        tienViet = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("---Output---");
        Console.WriteLine($"Phí dịch vụ (0,5%): {tienViet * 0.005m}");
        Console.WriteLine($"Số tiền VNĐ tính đổi: {tienViet*0.995m}");
        Console.WriteLine($"Số tiền ");

    }
}